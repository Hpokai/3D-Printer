using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Management;
using csSPC;

namespace ThreeDPrinter
{

    public partial class Form1 : Form
    {
        int LayerCount = 0;
        int TotalLayerNum = 0;

        bool isAutoMode = true;
        bool isLoadingPara = false;

        string SafeFileName = string.Empty;

        Svg.SvgDocument svgDocument;
        SysHook hook;
        CPrintTransData myPrintTransData = null;

        Link LinkDlg = null;
        HomeDlg HomeDialog = null;
        Preference PreferenceDlg = null;
        ZCaliProcessDlg1 ZCaliDlg1 = null;
        ZCaliProcessDlg2 ZCaliDlg2 = null;

        List<TextBox> text_list = null;
        List<bool> isEnabled = null;
        List<Button> button_list = null;

        //csSPC.CsSPC cs_spc = null;

        double original_svg_height = 0.0, original_svg_width = 0.0;

        public Form1()
        {
            InitializeComponent();

            #region Dongle
            /* DONGLE start 
             * 1. ref cSPC.dll
             * 2. ref csSPC.dll
             * 3. declair CsSPC();
             * 4. run check key timer
             * 5. check IsKeyError(), if return true, there is NO dongle, then close this software
             */
            //this.cs_spc = new CsSPC();
            //this.cs_spc.test(2, 4);
            this.DongleTimer.Interval = 1000;
            this.DongleTimer.Start();
            #endregion

            this.text_list = new List<TextBox>();
            this.isEnabled = new List<bool>();
            this.button_list = new List<Button>();
            this.ObjectList();

            ShareMemory.initial();

            this.ReadParameters();
            this.SVGZoomStep_textBox.Text = this.ImageScale_textBox.Text;
            this.SVGDisplaySettings();
            this.FileClear();

            this.LinkDlg = new Link();
            this.HomeDialog = new HomeDlg();
            this.PreferenceDlg = new Preference();
            this.ZCaliDlg1 = new ZCaliProcessDlg1();
            this.ZCaliDlg2 = new ZCaliProcessDlg2();

            this.hook = new SysHook();

            this.MainSVG_pictureBox.Parent = this.MainSVG_panel;
            this.MainSVG_pictureBox.Location = new Point(0, 0);

            //thread start
            this.threadRoutine = new ThreadRoutineRW();
            this.runRoutineThread = new Thread(threadRoutine.Run);
            this.runRoutineThread.Name = "Thread: Routine RW!";
            this.runRoutineThread.Priority = ThreadPriority.AboveNormal;
            this.runRoutineThread.IsBackground = true;
            this.runRoutineThread.Start();

            this.threadFile = new ThreadFileRW();
            this.runFileThread = new Thread(threadFile.Run);
            this.runFileThread.Name = "Thread: File RW!";
            this.runFileThread.Priority = ThreadPriority.BelowNormal;
            this.runFileThread.IsBackground = true;
            this.runFileThread.Start();

            // connect first
            /*-  
            this.Link_button_Click(this, new EventArgs());
            if (false == ShareMemory.isConnected) this.Exit_button_Click(this, new EventArgs());
            -*/
        }

        private void ObjectList()
        {
            TextBox[] text =  {this.LayerHeight_textBox,this.Exposure_textBox,this.BaseLayerNumber_textBox,this.BaseExposure_textBox,
                               this.ZUpDelayTime_textBox,this.RSpinDelayTime_textBox, this.ImageScale_textBox, this.ZMotorUpRPM_textBox,
                               this.ZMotorDownRPM_textBox, this.RMotorUpRPM_textBox,this.RMotorDownRPM_textBox};
            this.text_list.AddRange(text);

            Button[] button =  {this.Link_button, this.Preference_button,this.Exit_button,
                                this.JogUp_button,this.JogDown_button,this.AutoManual_button,this.Home_button,this.ZCalibration_button,this.AutoPrintStart_button,
                                this.OpenFile_button, this.GoLeft_button,this.GoRight_button,this.GoUp_button, this.GoDown_button};//,this.ZoomIn_button,this.ZoomOut_button};
            this.button_list.AddRange(button);
        }

        private void SVGDisplaySettings()
        {
            this.myPrintTransData = new CPrintTransData(2.5);

            this.myPrintTransData.screenWidth = Screen.PrimaryScreen.Bounds.Width;
            this.myPrintTransData.screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.myPrintTransData.TransformSize();

            this.MainSVG_panel.Size = new Size(this.myPrintTransData.panelWidth, this.myPrintTransData.panelHeight);
        }

        private void CalculateEstimatedTime()
        {
            int base_layer_num = int.Parse(this.BaseLayerNumber_textBox.Text);
            int base_exposure_time = int.Parse(this.BaseExposure_textBox.Text);
            int exposure_time = int.Parse(this.Exposure_textBox.Text);
            int z_up_delay_time = int.Parse(this.ZUpDelayTime_textBox.Text);
            int r_spin_delay_time = int.Parse(this.RSpinDelayTime_textBox.Text);

            int print_time = (base_layer_num * base_exposure_time + (this.TotalLayerNum - base_layer_num) * exposure_time +
                              this.TotalLayerNum * (z_up_delay_time + r_spin_delay_time)) / 1000;

            this.EstimatedTime_textBox.Text = (print_time / 3600).ToString("#00") + ":" +
                                              ((print_time % 3600) / 60).ToString("#00") + ":" +
                                              ((print_time % 3600) % 60).ToString("#00");
        }

        // auto print------------------------------------------------------------------------------------------------------------------
        private ThreadRoutineRW threadRoutine;
        private ThreadFileRW threadFile;
        private Thread runRoutineThread,runFileThread;
        private void InitAutoEnv()
        {
            this.LayerCount = 0;

            this.hook.Hook_Start();

            Cursor.Hide();
            ShareMemory.isPrintProcessInterrupt = false;
            ShareMemory.LinkSerialPort.Write(this.SendMessageArr());
            this.myPrintTransData.panelX = int.Parse(this.SVGXDirPos_textBox.Text);
            this.myPrintTransData.panelY = int.Parse(this.SVGYDirPos_textBox.Text);
            this.myPrintTransData.ChangeLocation();
        }

        public String SendMessageArr()
        {
            StringBuilder argument = new StringBuilder("4;");

            argument.Append(this.RMotorDownRPM_textBox.Text + ";");
            argument.Append(ShareMemory.Preference.ZCaliDist.ToString() + ";");
            argument.Append(this.RMotorUpRPM_textBox.Text + ";");
            argument.Append(this.BaseLayerNumber_textBox.Text + ";");
            argument.Append(this.BaseExposure_textBox.Text + ";");
            argument.Append(this.ZMotorUpRPM_textBox.Text + ";");
            argument.Append("0;");
            argument.Append(this.LayerHeight_textBox.Text + ";");
            argument.Append(this.ZMotorDownRPM_textBox.Text + ";");
            argument.Append(this.Exposure_textBox.Text + ";");
            argument.Append(ShareMemory.Preference.DelayAfterAction.ToString() + ";");
            argument.Append("0;");
            argument.Append(this.ZUpDelayTime_textBox.Text + ";");
            argument.Append(this.RSpinDelayTime_textBox.Text + ";");

            return argument.ToString();
        }

        private void SetSVGImage(string selectedPath)
        {
            svg.SVGParser.MaximumSize = new Size(1920, 1080);

            svgDocument = svg.SVGParser.GetSvgDocument(selectedPath);

            svgDocument.Width = (int)svgDocument.Width;
            svgDocument.Height = (int)svgDocument.Height;
            svgDocument.ViewBox = new SvgViewBox(0, 0, svgDocument.Width, svgDocument.Height);
            svgDocument.AspectRatio = new SvgAspectRatio(SvgPreserveAspectRatio.xMaxYMin);

            this.MainSVG_pictureBox.Size = new System.Drawing.Size((int)svgDocument.Width.Value, (int)svgDocument.Height.Value);
            MainSVG_pictureBox.Image = svg.SVGParser.GetBitmapFromSVG(selectedPath);
        }

        private void DrawSVGImage(string selectedPath, double product)
        {
            //int zoom_step = int.Parse(this.SVGZoomScale_textBox.Text);
            this.svgDocument = svg.SVGParser.GetSvgDocument(selectedPath);
            svgDocument.ViewBox = new SvgViewBox(0, 0, this.svgDocument.Width, this.svgDocument.Height);
            svgDocument.AspectRatio = new SvgAspectRatio(SvgPreserveAspectRatio.xMaxYMin);
            //this.svgDocument.Width = Convert.ToInt32(product * (this.svgDocument.Width + zoom_step));
            //this.svgDocument.Height = Convert.ToInt32(product * (this.svgDocument.Height + zoom_step));
            //this.MainSVG_pictureBox.Size = new System.Drawing.Size((int)svgDocument.Width.Value, (int)svgDocument.Height.Value);
            //MainSVG_pictureBox.Image = svgDocument.Draw();

            double zoom_step = 0.0;
            double.TryParse(this.SVGZoomStep_textBox.Text, out zoom_step);
            if (0 >= zoom_step) zoom_step = 1;

            //this.MainSVG_pictureBox.Size = new System.Drawing.Size(Convert.ToInt32(this.original_svg_width * zoom_step), Convert.ToInt32(this.original_svg_height * zoom_step));

            this.svgDocument.Width = Convert.ToInt32(product * this.original_svg_width * zoom_step);
            this.svgDocument.Height = Convert.ToInt32(product * this.original_svg_height * zoom_step);

            this.MainSVG_pictureBox.Size = new System.Drawing.Size((int)svgDocument.Width.Value, (int)svgDocument.Height.Value);

            this.MainSVG_pictureBox.Image = svgDocument.Draw();

        }

        private void DrawSVGImage(string selectedPath, double product, int x, int y)
        {
            this.MainSVG_pictureBox.Location = new Point(x, y);
            this.DrawSVGImage(selectedPath, product);
        }

        // Auto Print Process
        public enum PROCESS
        {
            None, ProjectorPWON, ProjectorPWOFF, ProjectorLEDON, ProjectorLEDOFF, MotorUp,
            WaitSolidification, WaitPosition, NextSVG, Initialize, waitFinishHandshake, Finish
        }
        private PROCESS process_state = PROCESS.None;
        private void PrintTimer_Tick(object sender, EventArgs e)
        {
            if (false == ShareMemory.isDebug)
            {
                if (true == ShareMemory.isPrintProcessInterrupt)
                {
                    this.LayerCount = this.TotalLayerNum + 1;
                    this.process_state = PROCESS.NextSVG;
                    ShareMemory.isPrintProcessInterrupt = false;
                }
            }

            switch (this.process_state)
            {
                case PROCESS.None:
                    break;
                case PROCESS.ProjectorPWON:
                    if (0 > this.LinkDlg.SetProjectorPowerOn())
                    {
                        // Error: Projector power on fail.
                    }
                    else
                    {
                        this.process_state = PROCESS.NextSVG;
                    }

                    this.MainSVG_panel.Parent = this;
                    this.MainSVG_panel.Dock = DockStyle.Fill;
                    this.MainSVG_panel.BringToFront();
                    this.MainSVG_panel.Refresh();
                    this.process_state = PROCESS.NextSVG;

                    break;
                case PROCESS.ProjectorPWOFF:
                    if (0 > this.LinkDlg.SetProjectorPowerOff())
                    {
                        // Error: Projector power off fail.
                        this.process_state = PROCESS.Finish;
                    }
                    else
                    {
                    }
                    ShareMemory.LinkSerialPort.Write("h");
                    this.process_state = PROCESS.waitFinishHandshake;
                    break;
                case PROCESS.ProjectorLEDON:
                    // send led on
                    this.LinkDlg.SetUVLedOnOff(true);

                    if (this.LayerCount >= int.Parse(this.BaseLayerNumber_textBox.Text))
                    {
                        // wait timer = exposure time
                        ShareMemory.Exposure = int.Parse(this.Exposure_textBox.Text);
                        ShareMemory.isCountExposure = true;
                    }
                    else
                    {
                        // wait timer = base exposure time
                        ShareMemory.BaseExposure = int.Parse(this.BaseExposure_textBox.Text);
                        ShareMemory.isCountBaseExposure = true;
                    }

                    this.process_state = PROCESS.WaitSolidification;
                    break;
                case PROCESS.ProjectorLEDOFF:
                    // send led off
                    this.LinkDlg.SetUVLedOnOff(false);
                    System.Threading.Thread.Sleep(50);
                    this.process_state = PROCESS.MotorUp;

                    break;
                case PROCESS.MotorUp:
                    //ShareMemory.LinkSerialPort.DiscardInBuffer();
                    ShareMemory.LinkSerialPort.Write("g");
                    this.process_state = PROCESS.WaitPosition;
                    break;
                case PROCESS.WaitSolidification:
                    if (true == ShareMemory.isTimeUp)
                    {
                        ShareMemory.isTimeUp = false;
                        this.process_state = PROCESS.ProjectorLEDOFF;
                    }
                    break;
                case PROCESS.WaitPosition:
                    if (41 == ShareMemory.ReturnPollingSignal())
                    {
                        this.LayerCount++;
                        this.process_state = PROCESS.NextSVG;
                    }
                    break;
                case PROCESS.Initialize:
                    ShareMemory.LinkSerialPort.ReadTimeout = 10;
                    //ShareMemory.LinkSerialPort.Write("a");
                    this.InitAutoEnv();
                    this.process_state = PROCESS.ProjectorPWON;
                    break;
                case PROCESS.NextSVG:
                    if (this.LayerCount < this.TotalLayerNum)
                    {
                        this.DrawSVGImage(this.dir_files_path+@"\PriningLayer_" + this.LayerCount.ToString("0000000") + ".svg", this.myPrintTransData.transProduct,
                                          this.myPrintTransData.screenX, this.myPrintTransData.screenY);
                        this.Refresh();
                        this.process_state = PROCESS.ProjectorLEDON;
                    }
                    else
                    {
                        this.process_state = PROCESS.ProjectorPWOFF;
                    }
                    break;
                case PROCESS.waitFinishHandshake:
                    if (129 == ShareMemory.ReturnPollingSignal())
                    {
                        this.process_state = PROCESS.Finish;
                    }
                    break;
                case PROCESS.Finish:
                    ShareMemory.LinkSerialPort.ReadTimeout = 2000;
                    //-- return to main HMI
                    this.hook.Hook_Clear();
                    Cursor.Show();
                    this.MainSVG_panel.Parent = this.MainSVG_tableLayoutPanel;
                    this.MainSVG_panel.Anchor = AnchorStyles.None;
                    this.DrawSVGImage(this.dir_files_path+@"\PriningLayer_0000000.svg", 1, this.myPrintTransData.panelX, this.myPrintTransData.panelY);
                    this.Refresh();

                    this.SVGEachLayer_vScrollBar.Value = 0;
                    this.LayerNo_label.Text = this.SVGEachLayer_vScrollBar.Value.ToString();

                    if (false == ShareMemory.isDebug)
                    {
                        this.TASK_WaitToHome();
                    }
                    this.PrintTimer.Stop();
                    break;
                default:
                    break;
            }
            //Console.Write(this.process_state.ToString()+"\n");
        }
        private void TASK_WaitToHome()
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(2000);
                this.Home_button_Click(this, null);
            });
        }

        #region Main Form Closing
        string dir_files_path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Jabil\3D Printer\files";
        private void FileClear()
        {
            if (true == Directory.Exists(this.dir_files_path))
            {
                string[] files = Directory.GetFiles(this.dir_files_path);
                string[] dirs = Directory.GetDirectories(this.dir_files_path);
                foreach (string file in files)
                {
                    System.IO.File.SetAttributes(file, FileAttributes.Normal);
                    System.IO.File.Delete(file);
                }
                foreach (string dir in dirs)
                {
                    Directory.Delete(dir);
                }
            }
            else
            {
                Directory.CreateDirectory(this.dir_files_path);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FileClear();
        }
        #endregion

        #region Read / Write File
        private void SaveParameters_TextChanged(object sender, EventArgs e)
        {
            if (false == this.isLoadingPara)
            {
                if (((TextBox)sender).Name == this.ImageScale_textBox.Name)
                {
                    this.SVGZoomStep_textBox.Text = this.ImageScale_textBox.Text;
                    this.ZoomSVG(+1);
                }

                //Create file security and apply rules to it
                System.Security.AccessControl.FileSecurity oFileSecurity = new System.Security.AccessControl.FileSecurity();
                oFileSecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule("Administrators", System.Security.AccessControl.FileSystemRights.FullControl, System.Security.AccessControl.AccessControlType.Allow));
                System.IO.File.SetAccessControl(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Jabil\3D Printer\parameters_1.txt", oFileSecurity);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+@"\Jabil\3D Printer\parameters_1.txt"))
                {
                    foreach (TextBox textbox in text_list)
                    {
                        if ("" == textbox.Text)
                        {
                            file.WriteLine("0");
                        }
                        else
                        {
                            file.WriteLine(textbox.Text);
                        }
                    }
                }
            }
            if ("" != this.FileName_textBox.Text)
            {
                this.CalculateEstimatedTime();
                this.CalculateTotalLayerHeight(false);
            }
        }

        private void ReadParameters()
        {
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Jabil\3D Printer\parameters_1.txt";
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Jabil\3D Printer\parameters_2.txt";

            if (false == File.Exists(path1))
            {
                using (File.Create(path1)) { }
            }
            if (false == File.Exists(path2))
            {
                using (File.Create(path2)) { }
            }

            this.isLoadingPara = true;
            using (System.IO.StreamReader file = new System.IO.StreamReader(path1))
            {
                foreach (TextBox textbox in text_list)
                {
                    textbox.Text = file.ReadLine();
                    if ("" == textbox.Text) textbox.Text = "0";
                }
            }

            using (System.IO.StreamReader file = new System.IO.StreamReader(path2))
            {
                string temp = string.Empty;
                temp = file.ReadLine();
                if ("" == temp || null == temp) temp = "0";
                ShareMemory.Preference.ZCaliDist = int.Parse(temp);
                temp = file.ReadLine();
                if ("" == temp || null == temp) temp = "0";
                ShareMemory.Preference.DelayAfterAction = int.Parse(temp);
            }

            this.isLoadingPara = false;
        }

        private double DoubleTryParse(string text)
        {
            double d_value = 0.00;
            double.TryParse(text, out d_value);
            return d_value;
        }

        private int IntTryParse(string text)
        {
            int i_value = 0;
            int.TryParse(text, out i_value);
            return i_value;
        }
        #endregion

        private int ParseSVGList(List<string> list_str)
        {
            CRecord xml_section = new CRecord();
            CRecord svg_section = new CRecord();

            List<CRecord> layers = new List<CRecord>();

            // find xml & svg
            for (int i = 0; i < list_str.Count; i++)
            {
                if (true == xml_section.IsFound(list_str[i].IndexOf("<?xml")))
                {
                    xml_section.start_line = i;
                    xml_section.start_index = xml_section.result_index;

                    i = list_str.Count;
                }
            }
            for (int i = xml_section.start_line; i < list_str.Count; i++)
            {
                if (true == xml_section.IsFound(list_str[i].IndexOf("<svg")))
                {
                    xml_section.end_line = i - 1;
                    xml_section.end_index = list_str[i - 1].Length - 1;

                    svg_section.start_line = i;
                    svg_section.start_index = svg_section.result_index;

                    i = list_str.Count;
                }
            }
            for (int i = svg_section.start_line; i < list_str.Count; i++)
            {
                if (true == svg_section.IsFound(list_str[i].IndexOf(">")))
                {
                    svg_section.end_line = i;
                    svg_section.end_index = svg_section.result_index;

                    i = list_str.Count;
                }
            }

            for (int i = xml_section.start_line; i <= xml_section.end_line; i++)
            {
                xml_section.contain.Append(list_str[i]);
            }
            for (int i = svg_section.start_line; i <= svg_section.end_line; i++)
            {
                svg_section.contain.Append(list_str[i]);
            }

            // find layers
            bool isFindLayerStart = true;
            CRecord temp_record = null;
            for (int i = svg_section.end_line + 1; i < list_str.Count; i++)
            {
                if (true == isFindLayerStart)
                {
                    if (true == svg_section.IsFound(list_str[i].IndexOf("<g")))
                    {
                        temp_record = new CRecord();
                        temp_record.start_line = i + 1;
                        temp_record.start_index = 0;

                        isFindLayerStart = false;
                    }
                }
                else
                {
                    if (true == svg_section.IsFound(list_str[i].IndexOf("</g>")))
                    {
                        temp_record.end_line = i - 1;
                        temp_record.end_index = list_str[i - 1].Length - 1;

                        layers.Add(temp_record);
                        temp_record = null;
                        isFindLayerStart = true;
                    }
                }
            }

            for (int j = 0; j < layers.Count; j++)
            {
                layers[j].contain.AppendLine(xml_section.contain.ToString());
                layers[j].contain.AppendLine(svg_section.contain.ToString());
                for (int i = layers[j].start_line; i <= layers[j].end_line; i++)
                {
                    layers[j].contain.AppendLine(list_str[i]);
                }
                layers[j].contain.AppendLine("</svg>");
            }

            int index = 0;
            foreach (var item in layers)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(this.dir_files_path + @"\PriningLayer_" + (index++).ToString("0000000") + ".svg"))
                {
                    file.Write(item.contain.ToString());
                }
            }

            return layers.Count;
        }
      
        // progress bar
        delegate void MyInvoke(int select);
        void UpdateForm(int select)
        {
            switch (select)
            {
                case 1:
                    this.ReadSVG_progressBar.Value = 0;
                    this.ReadSVG_progressBar.Visible = true;
                    break;
                case 2:
                    if (99 > this.ReadSVG_progressBar.Value)
                    {
                        this.ReadSVG_progressBar.PerformStep();
                    }
                    break;
                case 3:
                    this.ReadSVG_progressBar.Value = this.ReadSVG_progressBar.Maximum;
                    break;
                case 4:
                    this.ReadSVG_progressBar.Visible = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// New layout of main form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainSVG_panel_MouseHover(object sender, EventArgs e)
        {
            this.SVGEachLayer_vScrollBar.Focus();
        }

        private void SVGEachLayer_vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            //this.MainPageFigureDraw();
            this.DrawSVGImage(this.dir_files_path+@"\PriningLayer_" + this.SVGEachLayer_vScrollBar.Value.ToString("0000000") + ".svg", 1);
            this.LayerNo_label.Text = this.SVGEachLayer_vScrollBar.Value.ToString();
        }

        #region Buttons
        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            ShareMemory.isShutDown = true;
            if (ShareMemory.isConnected)
            {
                byte[] bytestosend = { 0xff };
                try
                {
                    ShareMemory.LinkSerialPort.Write(bytestosend, 0, bytestosend.Length);
                    System.Threading.Thread.Sleep(10);
                    ShareMemory.LinkSerialPort.Write("999;");
                    System.Threading.Thread.Sleep(10);
                }
                catch (Exception) { }


                LinkDlg.LinkCloseExe();
            }
            this.Close();
            Environment.Exit(Environment.ExitCode);
        }

        private void AutoManual_button_Click(object sender, EventArgs e)
        {
            if (ShareMemory.isConnected)
            {
                switch (this.isAutoMode)
                {
                    case true:
                        this.AutoManual_button.BackgroundImage = Properties.Resources.M;
                        this.isAutoMode = false;
                        this.JogUp_button.Enabled = true;
                        this.JogDown_button.Enabled = true;
                        this.Home_button.Enabled = false;
                        this.ZCalibration_button.Enabled = false;
                        this.AutoPrintStart_button.Enabled = false;
                        ShareMemory.LinkSerialPort.Write("8;");
                        this.JOGTimer.Start();
                        ShareMemory.isHome = false;
                        break;
                    case false:
                        this.AutoManual_button.BackgroundImage = Properties.Resources.A;
                        this.isAutoMode = true;
                        this.JogUp_button.Enabled = false;
                        this.JogDown_button.Enabled = false;
                        this.Home_button.Enabled = true;
                        this.ZCalibration_button.Enabled = true;
                        if ((string.Empty != this.FileName_textBox.Text) && (true == ShareMemory.isConnected))
                        {
                            this.AutoPrintStart_button.Enabled = true;
                        }
                        ShareMemory.LinkSerialPort.Write("s");
                        this.JOGTimer.Stop();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("請先連線！", "Warning", MessageBoxButtons.OK);
            }
        }

        private void AutoPrintStart_button_Click(object sender, EventArgs e)
        {
            // thread start
            this.process_state = PROCESS.Initialize;

            this.PrintTimer.Interval = 100;
            this.PrintTimer.Start();
        }
        #endregion

        #region ShowDialog
        private void Home_button_Click(object sender, EventArgs e)
        {
            if (ShareMemory.isConnected)
            {
                if (this.isAutoMode)
                {
                    this.HomeDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("請改為自動!", "Warning", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("請先連線!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void ZCalibration_button_Click(object sender, EventArgs e)
        {
            if (true == ShareMemory.isHome)
            {
                if (this.ZCaliDlg1.ShowDialog() == DialogResult.OK)
                {
                    if (ZCaliDlg2.ShowDialog() == DialogResult.OK)
                    {
                        ShareMemory.isHome = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Home firstly!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void Preference_button_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.PreferenceDlg.ShowDialog()) { }
        }

        private void Link_button_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.DialogResult.Cancel == this.LinkDlg.ShowDialog())
            {
                if ((string.Empty != this.FileName_textBox.Text) && (true == ShareMemory.isConnected))
                {
                    this.AutoPrintStart_button.Enabled = true;
                }
            }
        }

        private void OpenFile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "SVG Files|*.svg";
            openFileDialog1.Title = "Select a SVG File";

            // StringBuilder lines = new StringBuilder();
            List<string> str_lines = new List<string>() { };

            if (System.Windows.Forms.DialogResult.OK == openFileDialog1.ShowDialog())
            {
                this.ReadSVG_progressBar.Visible = true;
                this.ReadSVG_progressBar.Value = 100;
                this.ReadSVG_progressBar.Refresh();

                this.FileClear();

                using (System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName))
                {
                    while (file.Peek() >= 0)
                    {
                        // lines.AppendLine(file.ReadLine());
                        str_lines.Add(file.ReadLine());
                    }
                }

                // this.TotalLayerNum = this.ParseSVG(lines);
                // this.TotalLayerNum = this.ParseSVGList(str_lines);

                this.SetButtonState(false); // not recover
                this.runFileThread.Priority = ThreadPriority.Highest;

                ShareMemory.lines = str_lines;
                ShareMemory.isCompletedParse = false;
                ShareMemory.isStartParse = true;
                this.WaitParseTimer.Start();

                this.SafeFileName = openFileDialog1.SafeFileName;
            }
        }
        #endregion

        private void SetButtonState(bool isRecover)
        {
            if (false == isRecover)
            {
                this.isEnabled.Clear();

                for (int i = 0; i < this.button_list.Count(); i++)
                {
                    this.isEnabled.Add(this.button_list[i].Enabled);
                    this.button_list[i].Enabled = false;
                }
            }
            else
            {
                for (int i = 0; i < this.button_list.Count(); i++)
                {
                    this.button_list[i].Enabled = this.isEnabled[i];
                }
            }
        }

        private void WaitParseTimer_Tick(object sender, EventArgs e)
        {
            if (true == ShareMemory.isCompletedParse)
            {
                this.runFileThread.Priority = ThreadPriority.BelowNormal;
                this.WaitParseTimer.Stop();
                ShareMemory.isCompletedParse = false;

                this.TotalLayerNum = ShareMemory.TotalLayerNum;
                this.SVGEachLayer_vScrollBar.Maximum = this.TotalLayerNum - 1;
                this.SVGEachLayer_vScrollBar.Enabled = true;
                this.SVGEachLayer_vScrollBar.Value = 0;
                this.LayerNo_label.Text = this.SVGEachLayer_vScrollBar.Value.ToString();
                
                this.FileName_textBox.Text = this.SafeFileName;

                this.SetSVGImage(this.dir_files_path+@"\PriningLayer_0000000.svg");
                this.MainSVG_pictureBox.Location = new Point(0, 0);
                this.original_svg_width = Convert.ToDouble(this.svgDocument.Width);
                this.original_svg_height = Convert.ToDouble(this.svgDocument.Height);
                this.ZoomSVG(+1);
                
                this.SetButtonState(true); // recover

                this.SVGZoomScale_textBox.Text = "0";
                this.SVGXDirPos_textBox.Text = "0";
                this.SVGYDirPos_textBox.Text = "0";
                //this.ZoomIn_button.Enabled = true;
                //this.ZoomOut_button.Enabled = true;
                this.GoUp_button.Enabled = true;
                this.GoDown_button.Enabled = true;
                this.GoLeft_button.Enabled = true;
                this.GoRight_button.Enabled = true;

                if (ShareMemory.isConnected)
                {
                    this.AutoPrintStart_button.Enabled = true;
                }

                this.CalculateEstimatedTime();
                this.CalculateTotalLayerHeight(true);

                this.ReadSVG_progressBar.Value = this.ReadSVG_progressBar.Maximum;
                System.Threading.Thread.Sleep(500);
                this.ReadSVG_progressBar.Visible = false;
            }
            else
            {
                if (950 > this.ReadSVG_progressBar.Value)
                {
                    this.ReadSVG_progressBar.PerformStep();
                }
            }
        }

        private void CalculateTotalLayerHeight(bool isShow)
        {
            int total_layer_height = this.TotalLayerNum * int.Parse(this.LayerHeight_textBox.Text);
            if (total_layer_height > ShareMemory.Preference.ZCaliDist   )
            {
                MessageBox.Show("Total layer height = " + total_layer_height.ToString() + ".\nIt is higher than Z-axis height!", "Warning", MessageBoxButtons.OK);
            }
            else
            {
                if (true == isShow) MessageBox.Show("SVG File is ready!");
            }
        }

        #region Move or Zoom SVG
        private void ZoomIn_button_Click(object sender, EventArgs e)
        {
            this.ZoomSVG(+1);
        }

        private void ZoomOut_button_Click(object sender, EventArgs e)
        {
            int zoom_step = int.Parse(this.SVGZoomStep_textBox.Text);
            if ((0 < (this.svgDocument.Width - zoom_step)) && (0 < (this.svgDocument.Height - zoom_step)))
            {
                this.ZoomSVG(-1);
            }
            else
            {
                MessageBox.Show("Width or Height will be ZERO!", "Warning");
            }
        }

        private void ZoomSVG(int weight)    // weight must be +1 or -1
        {
            if ("" != this.FileName_textBox.Text)
            {
                double zoom_step = 0.0;
                double.TryParse(this.SVGZoomStep_textBox.Text, out zoom_step);
                if (0 >= zoom_step) zoom_step = 1;

                this.MainSVG_pictureBox.Size = new System.Drawing.Size(Convert.ToInt32(this.original_svg_width * zoom_step), Convert.ToInt32(this.original_svg_height * zoom_step));

                this.svgDocument.Width = Convert.ToInt32(this.original_svg_width * zoom_step);
                this.svgDocument.Height = Convert.ToInt32(this.original_svg_height * zoom_step);

                this.MainSVG_pictureBox.Image = svgDocument.Draw();

                //this.SVGZoomScale_textBox.Text = (int.Parse(this.SVGZoomScale_textBox.Text) + weight * zoom_step).ToString();
            }
        }

        private void GoUp_button_Click(object sender, EventArgs e)
        {
            this.MainSVG_pictureBox.Location = new Point(
                this.MainSVG_pictureBox.Location.X,
                this.MainSVG_pictureBox.Location.Y - int.Parse(this.SVGYDirStep_textBox.Text));

            this.SVGYDirPos_textBox.Text = (int.Parse(this.SVGYDirPos_textBox.Text) - int.Parse(this.SVGYDirStep_textBox.Text)).ToString();
        }

        private void GoDown_button_Click(object sender, EventArgs e)
        {
            this.MainSVG_pictureBox.Location = new Point(
                this.MainSVG_pictureBox.Location.X,
                this.MainSVG_pictureBox.Location.Y + int.Parse(this.SVGYDirStep_textBox.Text));

            this.SVGYDirPos_textBox.Text = (int.Parse(this.SVGYDirPos_textBox.Text) + int.Parse(this.SVGYDirStep_textBox.Text)).ToString();
        }

        private void GoLeft_button_Click(object sender, EventArgs e)
        {
            this.MainSVG_pictureBox.Location = new Point(
                this.MainSVG_pictureBox.Location.X - int.Parse(this.SVGXDirStep_textBox.Text),
                this.MainSVG_pictureBox.Location.Y);

            this.SVGXDirPos_textBox.Text = (int.Parse(this.SVGXDirPos_textBox.Text) - int.Parse(this.SVGXDirStep_textBox.Text)).ToString();
        }

        private void GoRight_button_Click(object sender, EventArgs e)
        {
            this.MainSVG_pictureBox.Location = new Point(
                this.MainSVG_pictureBox.Location.X + int.Parse(this.SVGXDirStep_textBox.Text),
                this.MainSVG_pictureBox.Location.Y);

            this.SVGXDirPos_textBox.Text = (int.Parse(this.SVGXDirPos_textBox.Text) + int.Parse(this.SVGXDirStep_textBox.Text)).ToString();
        }
        #endregion

        #region Jog for Manual
        int JOGType = 0;
        private void JOGTimer_Tick(object sender, EventArgs e)
        {
            if (ShareMemory.isConnected)
            {
                switch (JOGType)
                {
                    case 1:   //Down
                        ShareMemory.LinkSerialPort.Write("q");
                        break;
                    case 2:  //Up
                        ShareMemory.LinkSerialPort.Write("r");
                        break;
                    default:
                        break;
                }
            }
        }

        private void JogUp_button_MouseDown(object sender, MouseEventArgs e)
        {
            if (ShareMemory.isConnected)
            {
                JOGType = 2;
            }
            else
            {
                MessageBox.Show("請重新連線！", "Warning", MessageBoxButtons.OK);
            }
        }

        private void JogUp_button_MouseUp(object sender, MouseEventArgs e)
        {
            if (ShareMemory.isConnected)
            {
                JOGType = 0;
            }
        }

        private void JogDown_button_MouseDown(object sender, MouseEventArgs e)
        {
            if (ShareMemory.isConnected)
            {
                JOGType = 1;
            }
            else
            {
                MessageBox.Show("請重新連線！", "Warning", MessageBoxButtons.OK);
            }
        }

        private void JogDown_button_MouseUp(object sender, MouseEventArgs e)
        {
            if (ShareMemory.isConnected)
            {
                JOGType = 0;
            }
        }
        #endregion

        #region Auto Connect To Arduino
        private string AutodetectArduinoPort(string port_name)
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    //if (desc.Contains("Arduino")) 
                    if (desc.Contains(port_name))
                    {
                        MessageBox.Show(port_name);
                        return deviceId;
                    }
                }
            }
            catch {/* Do Nothing */}

            return null;
        }

        private void AutoConnectArduino_button_Click(object sender, EventArgs e)
        {
            try
            {
                ShareMemory.LinkSerialPort = new SerialPort(this.AutodetectArduinoPort("Arduino"), 9600, Parity.None, 8, StopBits.One);

                ShareMemory.LinkSerialPort.ReadTimeout = 2000;
                // Open serial port
                ShareMemory.LinkSerialPort.Open();
                ShareMemory.LinkSerialPort.Write("0;");

                switch (int.Parse(ShareMemory.LinkSerialPort.ReadLine()))
                {
                    case 0:
                        ShareMemory.isConnected = true;
                        this.AutoConnectArduino_button.BackColor = Color.Yellow;
                        break;
                    default:
                        ShareMemory.LinkSerialPort.Close();
                        MessageBox.Show("Connect Error!");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open() error: " + ex.Message);
            }
        }
        #endregion

        #region Drag & Drop PictureBox
        int control_old_x = 0, control_old_y = 0;
        int cursor_old_x = 0, cursor_old_y = 0;
        bool isPictrueBoxMoveNow = false;
        private void MainSVG_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (false == this.isPictrueBoxMoveNow)   // assume non-move state
            {
                this.control_old_x = ((PictureBox)sender).Left;     // Control object original X
                this.control_old_y = ((PictureBox)sender).Top;      // Control object original Y
                this.cursor_old_x = Cursor.Position.X;              // Cursor original X
                this.cursor_old_y = Cursor.Position.Y;              // Cursor original Y

                this.isPictrueBoxMoveNow = true;
            }
        }
        private void MainSVG_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (true == this.isPictrueBoxMoveNow)
            {
                int cursor_x = Cursor.Position.X;   // temp cursor X
                int cursor_y = Cursor.Position.Y;   // temp cursor Y
                // new object pos = old object pos + cursor move distance
                ((PictureBox)sender).Left = this.control_old_x + (cursor_x - cursor_old_x);     // new object X
                ((PictureBox)sender).Top = this.control_old_y + (cursor_y - cursor_old_y);      // new object Y
                this.SVGXDirPos_textBox.Text = ((PictureBox)sender).Left.ToString();
                this.SVGYDirPos_textBox.Text = ((PictureBox)sender).Top.ToString();
            }
        }
        private void MainSVG_pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.isPictrueBoxMoveNow = false;
        }
        #endregion

        #region KeyPress
        private void MainForm_textBox_int_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 使用 Char.IsDigit 方法 : 指示指定的 Unicode 字元是否分類為十進位數字。
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9

            // Char.IsControl 方法 : 指示指定的 Unicode 字元是否分類為控制字元。
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MainForm_textBox_double_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 使用 Char.IsDigit 方法 : 指示指定的 Unicode 字元是否分類為十進位數字。
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9

            // Char.IsControl 方法 : 指示指定的 Unicode 字元是否分類為控制字元。
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (e.KeyChar == (Char)46))
            {
                if ((e.KeyChar == (Char)46) && (-1 != ((TextBox)sender).Text.IndexOf(".")))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region security dongle
        private void DongleTimer_Tick(object sender, EventArgs e)
        {
            //bool ret = this.cs_spc.IsKeyError();
            //this.textBox1.Text = System.DateTime.Now.ToString() + " ->" + ret.ToString();

            //if (true==ret)
            //{
            //    this.DongleTimer.Stop();
            //    MessageBox.Show("No Accessable right!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Exit_button.PerformClick();
            //}
        }
        #endregion

    }

    public class CRecord
    {
        public CRecord()
        {
            this.start_line = -1;
            this.end_line = -1;
            this.start_index = -1;
            this.end_index = -1;

            this.contain = new StringBuilder();
        }

        public int start_line { set; get; }
        public int end_line { set; get; }
        public int start_index { set; get; }
        public int end_index { set; get; }
        public int result_index { private set; get; }

        public StringBuilder contain { set; get; }

        public bool IsFound(int result)
        {
            bool ret = false;
            if (result != -1)
            {
                ret = true;
            }
            return ret;
        }
    }

}
