namespace ThreeDPrinter
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.JOGTimer = new System.Windows.Forms.Timer(this.components);
            this.PrintTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.JogUp_button = new System.Windows.Forms.Button();
            this.JogDown_button = new System.Windows.Forms.Button();
            this.AutoManual_button = new System.Windows.Forms.Button();
            this.Home_button = new System.Windows.Forms.Button();
            this.ZCalibration_button = new System.Windows.Forms.Button();
            this.AutoPrintStart_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Preference_button = new System.Windows.Forms.Button();
            this.Link_button = new System.Windows.Forms.Button();
            this.AutoConnectArduino_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.PlatformMotorControl_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Exposure_textBox = new System.Windows.Forms.TextBox();
            this.LayerHeight_textBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BaseExposure_textBox = new System.Windows.Forms.TextBox();
            this.BaseLayerNumber_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RSpinDelayTime_textBox = new System.Windows.Forms.TextBox();
            this.ZUpDelayTime_textBox = new System.Windows.Forms.TextBox();
            this.Misc_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.ImageScale_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ZMotorUpRPM_textBox = new System.Windows.Forms.TextBox();
            this.ZMotorDownRPM_textBox = new System.Windows.Forms.TextBox();
            this.RMotorUpRPM_textBox = new System.Windows.Forms.TextBox();
            this.RMotorDownRPM_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ThreeDModelProject_groupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.OpenFile_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.EstimatedTimeTitle_label = new System.Windows.Forms.Label();
            this.FileNameTitle_label = new System.Windows.Forms.Label();
            this.FileName_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.EstimatedTime_textBox = new System.Windows.Forms.TextBox();
            this.ReadSVG_progressBar = new System.Windows.Forms.ProgressBar();
            this.MainSVG_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.SVGYDirPos_textBox = new System.Windows.Forms.TextBox();
            this.SVGYDirStep_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.SVGXDirPos_textBox = new System.Windows.Forms.TextBox();
            this.SVGXDirStep_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.SVGZoomScale_textBox = new System.Windows.Forms.TextBox();
            this.SVGZoomStep_textBox = new System.Windows.Forms.TextBox();
            this.MainSVG_panel = new System.Windows.Forms.Panel();
            this.MainSVG_pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.ZoomIn_button = new System.Windows.Forms.Button();
            this.GoDown_button = new System.Windows.Forms.Button();
            this.GoLeft_button = new System.Windows.Forms.Button();
            this.GoRight_button = new System.Windows.Forms.Button();
            this.ZoomOut_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LayerNo_label = new System.Windows.Forms.Label();
            this.GoUp_button = new System.Windows.Forms.Button();
            this.SVGEachLayer_vScrollBar = new System.Windows.Forms.VScrollBar();
            this.WaitParseTimer = new System.Windows.Forms.Timer(this.components);
            this.DongleTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.PlatformMotorControl_groupBox.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.Misc_groupBox.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.ThreeDModelProject_groupBox.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.MainSVG_tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.MainSVG_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSVG_pictureBox)).BeginInit();
            this.tableLayoutPanel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // JOGTimer
            // 
            this.JOGTimer.Interval = 10;
            this.JOGTimer.Tick += new System.EventHandler(this.JOGTimer_Tick);
            // 
            // PrintTimer
            // 
            this.PrintTimer.Tick += new System.EventHandler(this.PrintTimer_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.Exit_button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Exit_button
            // 
            this.Exit_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.exit;
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_button.Location = new System.Drawing.Point(1231, 4);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(131, 70);
            this.Exit_button.TabIndex = 0;
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.JogUp_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.JogDown_button, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.AutoManual_button, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Home_button, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ZCalibration_button, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.AutoPrintStart_button, 0, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1231, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(131, 683);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // JogUp_button
            // 
            this.JogUp_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.up11;
            this.JogUp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JogUp_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JogUp_button.Enabled = false;
            this.JogUp_button.Location = new System.Drawing.Point(3, 3);
            this.JogUp_button.Name = "JogUp_button";
            this.JogUp_button.Size = new System.Drawing.Size(125, 62);
            this.JogUp_button.TabIndex = 1;
            this.JogUp_button.UseVisualStyleBackColor = true;
            this.JogUp_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogUp_button_MouseDown);
            this.JogUp_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogUp_button_MouseUp);
            // 
            // JogDown_button
            // 
            this.JogDown_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.down11;
            this.JogDown_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JogDown_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JogDown_button.Enabled = false;
            this.JogDown_button.Location = new System.Drawing.Point(3, 71);
            this.JogDown_button.Name = "JogDown_button";
            this.JogDown_button.Size = new System.Drawing.Size(125, 62);
            this.JogDown_button.TabIndex = 2;
            this.JogDown_button.UseVisualStyleBackColor = true;
            this.JogDown_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JogDown_button_MouseDown);
            this.JogDown_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.JogDown_button_MouseUp);
            // 
            // AutoManual_button
            // 
            this.AutoManual_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.A;
            this.AutoManual_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutoManual_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoManual_button.Location = new System.Drawing.Point(3, 139);
            this.AutoManual_button.Name = "AutoManual_button";
            this.tableLayoutPanel2.SetRowSpan(this.AutoManual_button, 2);
            this.AutoManual_button.Size = new System.Drawing.Size(125, 130);
            this.AutoManual_button.TabIndex = 0;
            this.AutoManual_button.UseVisualStyleBackColor = true;
            this.AutoManual_button.Click += new System.EventHandler(this.AutoManual_button_Click);
            // 
            // Home_button
            // 
            this.Home_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.home5;
            this.Home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Home_button.Location = new System.Drawing.Point(3, 275);
            this.Home_button.Name = "Home_button";
            this.Home_button.Size = new System.Drawing.Size(125, 62);
            this.Home_button.TabIndex = 3;
            this.Home_button.UseVisualStyleBackColor = true;
            this.Home_button.Click += new System.EventHandler(this.Home_button_Click);
            // 
            // ZCalibration_button
            // 
            this.ZCalibration_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.ZCali;
            this.ZCalibration_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ZCalibration_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZCalibration_button.Location = new System.Drawing.Point(3, 343);
            this.ZCalibration_button.Name = "ZCalibration_button";
            this.ZCalibration_button.Size = new System.Drawing.Size(125, 62);
            this.ZCalibration_button.TabIndex = 4;
            this.ZCalibration_button.Text = "                       Z axis\r\n                     Cali.";
            this.ZCalibration_button.UseVisualStyleBackColor = true;
            this.ZCalibration_button.Click += new System.EventHandler(this.ZCalibration_button_Click);
            // 
            // AutoPrintStart_button
            // 
            this.AutoPrintStart_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.play1;
            this.AutoPrintStart_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutoPrintStart_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoPrintStart_button.Enabled = false;
            this.AutoPrintStart_button.Location = new System.Drawing.Point(3, 547);
            this.AutoPrintStart_button.Name = "AutoPrintStart_button";
            this.tableLayoutPanel2.SetRowSpan(this.AutoPrintStart_button, 2);
            this.AutoPrintStart_button.Size = new System.Drawing.Size(125, 133);
            this.AutoPrintStart_button.TabIndex = 5;
            this.AutoPrintStart_button.UseVisualStyleBackColor = true;
            this.AutoPrintStart_button.Click += new System.EventHandler(this.AutoPrintStart_button_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 10;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.Preference_button, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.Link_button, 8, 0);
            this.tableLayoutPanel3.Controls.Add(this.AutoConnectArduino_button, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1220, 70);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Preference_button
            // 
            this.Preference_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.Preference1;
            this.Preference_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Preference_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preference_button.Location = new System.Drawing.Point(1101, 3);
            this.Preference_button.Name = "Preference_button";
            this.Preference_button.Size = new System.Drawing.Size(116, 64);
            this.Preference_button.TabIndex = 0;
            this.Preference_button.UseVisualStyleBackColor = true;
            this.Preference_button.Click += new System.EventHandler(this.Preference_button_Click);
            // 
            // Link_button
            // 
            this.Link_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.linking;
            this.Link_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Link_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Link_button.Location = new System.Drawing.Point(979, 3);
            this.Link_button.Name = "Link_button";
            this.Link_button.Size = new System.Drawing.Size(116, 64);
            this.Link_button.TabIndex = 1;
            this.Link_button.UseVisualStyleBackColor = true;
            this.Link_button.Click += new System.EventHandler(this.Link_button_Click);
            // 
            // AutoConnectArduino_button
            // 
            this.AutoConnectArduino_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.auto_arduino;
            this.AutoConnectArduino_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AutoConnectArduino_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoConnectArduino_button.Location = new System.Drawing.Point(857, 3);
            this.AutoConnectArduino_button.Name = "AutoConnectArduino_button";
            this.AutoConnectArduino_button.Size = new System.Drawing.Size(116, 64);
            this.AutoConnectArduino_button.TabIndex = 3;
            this.AutoConnectArduino_button.UseVisualStyleBackColor = true;
            this.AutoConnectArduino_button.Visible = false;
            this.AutoConnectArduino_button.Click += new System.EventHandler(this.AutoConnectArduino_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel3.SetColumnSpan(this.panel1, 2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 64);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Location = new System.Drawing.Point(369, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 81);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1220, 683);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.PlatformMotorControl_groupBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Misc_groupBox, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(360, 677);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // PlatformMotorControl_groupBox
            // 
            this.PlatformMotorControl_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PlatformMotorControl_groupBox.Controls.Add(this.tableLayoutPanel6);
            this.PlatformMotorControl_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlatformMotorControl_groupBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatformMotorControl_groupBox.Location = new System.Drawing.Point(4, 4);
            this.PlatformMotorControl_groupBox.Name = "PlatformMotorControl_groupBox";
            this.PlatformMotorControl_groupBox.Size = new System.Drawing.Size(352, 331);
            this.PlatformMotorControl_groupBox.TabIndex = 0;
            this.PlatformMotorControl_groupBox.TabStop = false;
            this.PlatformMotorControl_groupBox.Text = "Platform Motor Control";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Controls.Add(this.Exposure_textBox, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.LayerHeight_textBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.BaseExposure_textBox, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.BaseLayerNumber_textBox, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.RSpinDelayTime_textBox, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.ZUpDelayTime_textBox, 1, 4);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(346, 292);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // Exposure_textBox
            // 
            this.Exposure_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exposure_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exposure_textBox.Location = new System.Drawing.Point(211, 49);
            this.Exposure_textBox.Name = "Exposure_textBox";
            this.Exposure_textBox.Size = new System.Drawing.Size(129, 27);
            this.Exposure_textBox.TabIndex = 1;
            this.Exposure_textBox.Text = "1000";
            this.Exposure_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.Exposure_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // LayerHeight_textBox
            // 
            this.LayerHeight_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LayerHeight_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayerHeight_textBox.Location = new System.Drawing.Point(211, 8);
            this.LayerHeight_textBox.Name = "LayerHeight_textBox";
            this.LayerHeight_textBox.Size = new System.Drawing.Size(129, 27);
            this.LayerHeight_textBox.TabIndex = 0;
            this.LayerHeight_textBox.Text = "100";
            this.LayerHeight_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.LayerHeight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(6, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 38);
            this.label14.TabIndex = 1;
            this.label14.Text = "Base Exposure (ms):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 38);
            this.label13.TabIndex = 1;
            this.label13.Text = "Base Layer Number:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 38);
            this.label8.TabIndex = 0;
            this.label8.Text = "Layer Height (um):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 38);
            this.label9.TabIndex = 1;
            this.label9.Text = "Exposure (ms):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseExposure_textBox
            // 
            this.BaseExposure_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseExposure_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseExposure_textBox.Location = new System.Drawing.Point(211, 131);
            this.BaseExposure_textBox.Name = "BaseExposure_textBox";
            this.BaseExposure_textBox.Size = new System.Drawing.Size(129, 27);
            this.BaseExposure_textBox.TabIndex = 3;
            this.BaseExposure_textBox.Text = "2000";
            this.BaseExposure_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.BaseExposure_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // BaseLayerNumber_textBox
            // 
            this.BaseLayerNumber_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseLayerNumber_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLayerNumber_textBox.Location = new System.Drawing.Point(211, 90);
            this.BaseLayerNumber_textBox.Name = "BaseLayerNumber_textBox";
            this.BaseLayerNumber_textBox.Size = new System.Drawing.Size(129, 27);
            this.BaseLayerNumber_textBox.TabIndex = 2;
            this.BaseLayerNumber_textBox.Text = "3";
            this.BaseLayerNumber_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.BaseLayerNumber_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(6, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 38);
            this.label12.TabIndex = 6;
            this.label12.Text = "R Spin Delay Time(ms):";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(6, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 38);
            this.label7.TabIndex = 5;
            this.label7.Text = "Z Up Delay Time(ms):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RSpinDelayTime_textBox
            // 
            this.RSpinDelayTime_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RSpinDelayTime_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSpinDelayTime_textBox.Location = new System.Drawing.Point(211, 213);
            this.RSpinDelayTime_textBox.Name = "RSpinDelayTime_textBox";
            this.RSpinDelayTime_textBox.Size = new System.Drawing.Size(129, 27);
            this.RSpinDelayTime_textBox.TabIndex = 5;
            this.RSpinDelayTime_textBox.Text = "0";
            this.RSpinDelayTime_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.RSpinDelayTime_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // ZUpDelayTime_textBox
            // 
            this.ZUpDelayTime_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZUpDelayTime_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZUpDelayTime_textBox.Location = new System.Drawing.Point(211, 172);
            this.ZUpDelayTime_textBox.Name = "ZUpDelayTime_textBox";
            this.ZUpDelayTime_textBox.Size = new System.Drawing.Size(129, 27);
            this.ZUpDelayTime_textBox.TabIndex = 4;
            this.ZUpDelayTime_textBox.Text = "0";
            this.ZUpDelayTime_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.ZUpDelayTime_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // Misc_groupBox
            // 
            this.Misc_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Misc_groupBox.Controls.Add(this.tableLayoutPanel7);
            this.Misc_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Misc_groupBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Misc_groupBox.Location = new System.Drawing.Point(4, 342);
            this.Misc_groupBox.Name = "Misc_groupBox";
            this.Misc_groupBox.Size = new System.Drawing.Size(352, 331);
            this.Misc_groupBox.TabIndex = 1;
            this.Misc_groupBox.TabStop = false;
            this.Misc_groupBox.Text = "Misc";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.Controls.Add(this.ImageScale_textBox, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.ZMotorUpRPM_textBox, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.ZMotorDownRPM_textBox, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.RMotorUpRPM_textBox, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.RMotorDownRPM_textBox, 1, 4);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 7;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(346, 292);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // ImageScale_textBox
            // 
            this.ImageScale_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageScale_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageScale_textBox.Location = new System.Drawing.Point(211, 8);
            this.ImageScale_textBox.Name = "ImageScale_textBox";
            this.ImageScale_textBox.Size = new System.Drawing.Size(129, 27);
            this.ImageScale_textBox.TabIndex = 0;
            this.ImageScale_textBox.Text = "1.5";
            this.ImageScale_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.ImageScale_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_double_KeyPress);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 38);
            this.label10.TabIndex = 1;
            this.label10.Text = "Image Scale:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(6, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(196, 38);
            this.label15.TabIndex = 1;
            this.label15.Text = "Z Motor UP RPM:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(6, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 38);
            this.label16.TabIndex = 1;
            this.label16.Text = "Z Motor Down RPM:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(6, 126);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 38);
            this.label17.TabIndex = 1;
            this.label17.Text = "R Motor UP RPM:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(6, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 38);
            this.label11.TabIndex = 1;
            this.label11.Text = "R Motor Down RPM:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ZMotorUpRPM_textBox
            // 
            this.ZMotorUpRPM_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZMotorUpRPM_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZMotorUpRPM_textBox.Location = new System.Drawing.Point(211, 49);
            this.ZMotorUpRPM_textBox.Name = "ZMotorUpRPM_textBox";
            this.ZMotorUpRPM_textBox.Size = new System.Drawing.Size(129, 27);
            this.ZMotorUpRPM_textBox.TabIndex = 1;
            this.ZMotorUpRPM_textBox.Text = "60";
            this.ZMotorUpRPM_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.ZMotorUpRPM_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // ZMotorDownRPM_textBox
            // 
            this.ZMotorDownRPM_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZMotorDownRPM_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZMotorDownRPM_textBox.Location = new System.Drawing.Point(211, 90);
            this.ZMotorDownRPM_textBox.Name = "ZMotorDownRPM_textBox";
            this.ZMotorDownRPM_textBox.Size = new System.Drawing.Size(129, 27);
            this.ZMotorDownRPM_textBox.TabIndex = 2;
            this.ZMotorDownRPM_textBox.Text = "60";
            this.ZMotorDownRPM_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.ZMotorDownRPM_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // RMotorUpRPM_textBox
            // 
            this.RMotorUpRPM_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RMotorUpRPM_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMotorUpRPM_textBox.Location = new System.Drawing.Point(211, 131);
            this.RMotorUpRPM_textBox.Name = "RMotorUpRPM_textBox";
            this.RMotorUpRPM_textBox.Size = new System.Drawing.Size(129, 27);
            this.RMotorUpRPM_textBox.TabIndex = 3;
            this.RMotorUpRPM_textBox.Text = "40";
            this.RMotorUpRPM_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.RMotorUpRPM_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // RMotorDownRPM_textBox
            // 
            this.RMotorDownRPM_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RMotorDownRPM_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMotorDownRPM_textBox.Location = new System.Drawing.Point(211, 172);
            this.RMotorDownRPM_textBox.Name = "RMotorDownRPM_textBox";
            this.RMotorDownRPM_textBox.Size = new System.Drawing.Size(129, 27);
            this.RMotorDownRPM_textBox.TabIndex = 4;
            this.RMotorDownRPM_textBox.Text = "40";
            this.RMotorDownRPM_textBox.TextChanged += new System.EventHandler(this.SaveParameters_TextChanged);
            this.RMotorDownRPM_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.ThreeDModelProject_groupBox, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.MainSVG_tableLayoutPanel, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(369, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(848, 677);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // ThreeDModelProject_groupBox
            // 
            this.ThreeDModelProject_groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ThreeDModelProject_groupBox.Controls.Add(this.tableLayoutPanel10);
            this.ThreeDModelProject_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeDModelProject_groupBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeDModelProject_groupBox.Location = new System.Drawing.Point(4, 577);
            this.ThreeDModelProject_groupBox.Name = "ThreeDModelProject_groupBox";
            this.ThreeDModelProject_groupBox.Size = new System.Drawing.Size(840, 96);
            this.ThreeDModelProject_groupBox.TabIndex = 0;
            this.ThreeDModelProject_groupBox.TabStop = false;
            this.ThreeDModelProject_groupBox.Text = "3D Model Project";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.OpenFile_button, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(834, 64);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // OpenFile_button
            // 
            this.OpenFile_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.OpenFile_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.folder_open;
            this.OpenFile_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenFile_button.Location = new System.Drawing.Point(670, 3);
            this.OpenFile_button.Name = "OpenFile_button";
            this.OpenFile_button.Size = new System.Drawing.Size(161, 58);
            this.OpenFile_button.TabIndex = 0;
            this.OpenFile_button.UseVisualStyleBackColor = true;
            this.OpenFile_button.Click += new System.EventHandler(this.OpenFile_button_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 2;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel17.Controls.Add(this.EstimatedTimeTitle_label, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.FileNameTitle_label, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.FileName_textBox, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel9, 1, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(661, 58);
            this.tableLayoutPanel17.TabIndex = 9;
            // 
            // EstimatedTimeTitle_label
            // 
            this.EstimatedTimeTitle_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EstimatedTimeTitle_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedTimeTitle_label.Location = new System.Drawing.Point(3, 29);
            this.EstimatedTimeTitle_label.Name = "EstimatedTimeTitle_label";
            this.EstimatedTimeTitle_label.Size = new System.Drawing.Size(192, 29);
            this.EstimatedTimeTitle_label.TabIndex = 10;
            this.EstimatedTimeTitle_label.Text = "Estimated Time:";
            this.EstimatedTimeTitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileNameTitle_label
            // 
            this.FileNameTitle_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNameTitle_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileNameTitle_label.Location = new System.Drawing.Point(3, 0);
            this.FileNameTitle_label.Name = "FileNameTitle_label";
            this.FileNameTitle_label.Size = new System.Drawing.Size(192, 29);
            this.FileNameTitle_label.TabIndex = 9;
            this.FileNameTitle_label.Text = "File Name:";
            this.FileNameTitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileName_textBox
            // 
            this.FileName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FileName_textBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName_textBox.Location = new System.Drawing.Point(201, 3);
            this.FileName_textBox.Name = "FileName_textBox";
            this.FileName_textBox.ReadOnly = true;
            this.FileName_textBox.Size = new System.Drawing.Size(457, 26);
            this.FileName_textBox.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.EstimatedTime_textBox, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.ReadSVG_progressBar, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(201, 32);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(457, 23);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // EstimatedTime_textBox
            // 
            this.EstimatedTime_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EstimatedTime_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EstimatedTime_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EstimatedTime_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.EstimatedTime_textBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedTime_textBox.Location = new System.Drawing.Point(3, 3);
            this.EstimatedTime_textBox.Name = "EstimatedTime_textBox";
            this.EstimatedTime_textBox.Size = new System.Drawing.Size(222, 24);
            this.EstimatedTime_textBox.TabIndex = 0;
            this.EstimatedTime_textBox.Text = "00:00:00";
            // 
            // ReadSVG_progressBar
            // 
            this.ReadSVG_progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadSVG_progressBar.Location = new System.Drawing.Point(231, 3);
            this.ReadSVG_progressBar.Maximum = 1000;
            this.ReadSVG_progressBar.Name = "ReadSVG_progressBar";
            this.ReadSVG_progressBar.Size = new System.Drawing.Size(223, 17);
            this.ReadSVG_progressBar.Step = 1;
            this.ReadSVG_progressBar.TabIndex = 13;
            this.ReadSVG_progressBar.Value = 10;
            this.ReadSVG_progressBar.Visible = false;
            // 
            // MainSVG_tableLayoutPanel
            // 
            this.MainSVG_tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MainSVG_tableLayoutPanel.ColumnCount = 4;
            this.MainSVG_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainSVG_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 774F));
            this.MainSVG_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainSVG_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainSVG_tableLayoutPanel.Controls.Add(this.tableLayoutPanel11, 1, 0);
            this.MainSVG_tableLayoutPanel.Controls.Add(this.MainSVG_panel, 1, 1);
            this.MainSVG_tableLayoutPanel.Controls.Add(this.tableLayoutPanel16, 1, 2);
            this.MainSVG_tableLayoutPanel.Controls.Add(this.SVGEachLayer_vScrollBar, 2, 1);
            this.MainSVG_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSVG_tableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.MainSVG_tableLayoutPanel.Name = "MainSVG_tableLayoutPanel";
            this.MainSVG_tableLayoutPanel.RowCount = 3;
            this.MainSVG_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainSVG_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 438F));
            this.MainSVG_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainSVG_tableLayoutPanel.Size = new System.Drawing.Size(840, 566);
            this.MainSVG_tableLayoutPanel.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 7;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel11.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel11.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel14, 4, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel13, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel15, 6, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(26, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(768, 70);
            this.tableLayoutPanel11.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(548, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 70);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zoom In/Out";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 70);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vertical\r\n(Y-dir)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 70);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horizontal\r\n(X-dir)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.SVGYDirPos_textBox, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.SVGYDirStep_textBox, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(439, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(103, 64);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // SVGYDirPos_textBox
            // 
            this.SVGYDirPos_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SVGYDirPos_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SVGYDirPos_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SVGYDirPos_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVGYDirPos_textBox.ForeColor = System.Drawing.Color.Blue;
            this.SVGYDirPos_textBox.Location = new System.Drawing.Point(4, 37);
            this.SVGYDirPos_textBox.Name = "SVGYDirPos_textBox";
            this.SVGYDirPos_textBox.ReadOnly = true;
            this.SVGYDirPos_textBox.Size = new System.Drawing.Size(95, 20);
            this.SVGYDirPos_textBox.TabIndex = 2;
            this.SVGYDirPos_textBox.Text = "0";
            this.SVGYDirPos_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SVGYDirStep_textBox
            // 
            this.SVGYDirStep_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SVGYDirStep_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SVGYDirStep_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVGYDirStep_textBox.Location = new System.Drawing.Point(4, 4);
            this.SVGYDirStep_textBox.Name = "SVGYDirStep_textBox";
            this.SVGYDirStep_textBox.ReadOnly = true;
            this.SVGYDirStep_textBox.Size = new System.Drawing.Size(95, 27);
            this.SVGYDirStep_textBox.TabIndex = 0;
            this.SVGYDirStep_textBox.Text = "50";
            this.SVGYDirStep_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SVGYDirStep_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(103, 64);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel13.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.SVGXDirPos_textBox, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.SVGXDirStep_textBox, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(221, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(103, 64);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // SVGXDirPos_textBox
            // 
            this.SVGXDirPos_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SVGXDirPos_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SVGXDirPos_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SVGXDirPos_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVGXDirPos_textBox.ForeColor = System.Drawing.Color.Blue;
            this.SVGXDirPos_textBox.Location = new System.Drawing.Point(4, 37);
            this.SVGXDirPos_textBox.Name = "SVGXDirPos_textBox";
            this.SVGXDirPos_textBox.ReadOnly = true;
            this.SVGXDirPos_textBox.Size = new System.Drawing.Size(95, 20);
            this.SVGXDirPos_textBox.TabIndex = 1;
            this.SVGXDirPos_textBox.Text = "0";
            this.SVGXDirPos_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SVGXDirStep_textBox
            // 
            this.SVGXDirStep_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SVGXDirStep_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SVGXDirStep_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVGXDirStep_textBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SVGXDirStep_textBox.Location = new System.Drawing.Point(4, 4);
            this.SVGXDirStep_textBox.Name = "SVGXDirStep_textBox";
            this.SVGXDirStep_textBox.ReadOnly = true;
            this.SVGXDirStep_textBox.Size = new System.Drawing.Size(95, 27);
            this.SVGXDirStep_textBox.TabIndex = 0;
            this.SVGXDirStep_textBox.Text = "50";
            this.SVGXDirStep_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SVGXDirStep_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.SVGZoomScale_textBox, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.SVGZoomStep_textBox, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(657, 3);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(108, 64);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // SVGZoomScale_textBox
            // 
            this.SVGZoomScale_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SVGZoomScale_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SVGZoomScale_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SVGZoomScale_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SVGZoomScale_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVGZoomScale_textBox.ForeColor = System.Drawing.Color.Blue;
            this.SVGZoomScale_textBox.Location = new System.Drawing.Point(4, 37);
            this.SVGZoomScale_textBox.Name = "SVGZoomScale_textBox";
            this.SVGZoomScale_textBox.ReadOnly = true;
            this.SVGZoomScale_textBox.Size = new System.Drawing.Size(100, 20);
            this.SVGZoomScale_textBox.TabIndex = 2;
            this.SVGZoomScale_textBox.Text = "0";
            this.SVGZoomScale_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SVGZoomStep_textBox
            // 
            this.SVGZoomStep_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SVGZoomStep_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SVGZoomStep_textBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVGZoomStep_textBox.Location = new System.Drawing.Point(4, 4);
            this.SVGZoomStep_textBox.Name = "SVGZoomStep_textBox";
            this.SVGZoomStep_textBox.ReadOnly = true;
            this.SVGZoomStep_textBox.Size = new System.Drawing.Size(100, 27);
            this.SVGZoomStep_textBox.TabIndex = 0;
            this.SVGZoomStep_textBox.Text = "1";
            this.SVGZoomStep_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SVGZoomStep_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_textBox_int_KeyPress);
            // 
            // MainSVG_panel
            // 
            this.MainSVG_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainSVG_panel.BackColor = System.Drawing.Color.Black;
            this.MainSVG_panel.Controls.Add(this.MainSVG_pictureBox);
            this.MainSVG_panel.Location = new System.Drawing.Point(26, 79);
            this.MainSVG_panel.Name = "MainSVG_panel";
            this.MainSVG_panel.Size = new System.Drawing.Size(768, 432);
            this.MainSVG_panel.TabIndex = 8;
            this.MainSVG_panel.MouseHover += new System.EventHandler(this.MainSVG_panel_MouseHover);
            // 
            // MainSVG_pictureBox
            // 
            this.MainSVG_pictureBox.BackColor = System.Drawing.Color.Black;
            this.MainSVG_pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainSVG_pictureBox.Location = new System.Drawing.Point(195, 163);
            this.MainSVG_pictureBox.Name = "MainSVG_pictureBox";
            this.MainSVG_pictureBox.Size = new System.Drawing.Size(100, 50);
            this.MainSVG_pictureBox.TabIndex = 0;
            this.MainSVG_pictureBox.TabStop = false;
            this.MainSVG_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainSVG_pictureBox_MouseDown);
            this.MainSVG_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainSVG_pictureBox_MouseMove);
            this.MainSVG_pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainSVG_pictureBox_MouseUp);
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 8;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel16.Controls.Add(this.ZoomIn_button, 4, 0);
            this.tableLayoutPanel16.Controls.Add(this.GoDown_button, 3, 0);
            this.tableLayoutPanel16.Controls.Add(this.GoLeft_button, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.GoRight_button, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.ZoomOut_button, 5, 0);
            this.tableLayoutPanel16.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel16.Controls.Add(this.LayerNo_label, 7, 0);
            this.tableLayoutPanel16.Controls.Add(this.GoUp_button, 2, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(26, 517);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(768, 46);
            this.tableLayoutPanel16.TabIndex = 9;
            // 
            // ZoomIn_button
            // 
            this.ZoomIn_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.zoom_svg_in;
            this.ZoomIn_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ZoomIn_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomIn_button.Enabled = false;
            this.ZoomIn_button.Location = new System.Drawing.Point(387, 3);
            this.ZoomIn_button.Name = "ZoomIn_button";
            this.ZoomIn_button.Size = new System.Drawing.Size(90, 40);
            this.ZoomIn_button.TabIndex = 4;
            this.ZoomIn_button.UseVisualStyleBackColor = true;
            this.ZoomIn_button.Click += new System.EventHandler(this.ZoomIn_button_Click);
            // 
            // GoDown_button
            // 
            this.GoDown_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.bottom_256;
            this.GoDown_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoDown_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoDown_button.Enabled = false;
            this.GoDown_button.Location = new System.Drawing.Point(291, 3);
            this.GoDown_button.Name = "GoDown_button";
            this.GoDown_button.Size = new System.Drawing.Size(90, 40);
            this.GoDown_button.TabIndex = 1;
            this.GoDown_button.UseVisualStyleBackColor = true;
            this.GoDown_button.Click += new System.EventHandler(this.GoDown_button_Click);
            // 
            // GoLeft_button
            // 
            this.GoLeft_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.left_256;
            this.GoLeft_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoLeft_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoLeft_button.Enabled = false;
            this.GoLeft_button.Location = new System.Drawing.Point(3, 3);
            this.GoLeft_button.Name = "GoLeft_button";
            this.GoLeft_button.Size = new System.Drawing.Size(90, 40);
            this.GoLeft_button.TabIndex = 2;
            this.GoLeft_button.UseVisualStyleBackColor = true;
            this.GoLeft_button.Click += new System.EventHandler(this.GoLeft_button_Click);
            // 
            // GoRight_button
            // 
            this.GoRight_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.right_256;
            this.GoRight_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoRight_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.GoRight_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoRight_button.Enabled = false;
            this.GoRight_button.Location = new System.Drawing.Point(99, 3);
            this.GoRight_button.Name = "GoRight_button";
            this.GoRight_button.Size = new System.Drawing.Size(90, 40);
            this.GoRight_button.TabIndex = 3;
            this.GoRight_button.UseVisualStyleBackColor = true;
            this.GoRight_button.Click += new System.EventHandler(this.GoRight_button_Click);
            // 
            // ZoomOut_button
            // 
            this.ZoomOut_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.zoom_svg_out;
            this.ZoomOut_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ZoomOut_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomOut_button.Enabled = false;
            this.ZoomOut_button.Location = new System.Drawing.Point(483, 3);
            this.ZoomOut_button.Name = "ZoomOut_button";
            this.ZoomOut_button.Size = new System.Drawing.Size(90, 40);
            this.ZoomOut_button.TabIndex = 5;
            this.ZoomOut_button.UseVisualStyleBackColor = true;
            this.ZoomOut_button.Click += new System.EventHandler(this.ZoomOut_button_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(579, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 46);
            this.label6.TabIndex = 6;
            this.label6.Text = "Layer No. :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LayerNo_label
            // 
            this.LayerNo_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LayerNo_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayerNo_label.ForeColor = System.Drawing.Color.Blue;
            this.LayerNo_label.Location = new System.Drawing.Point(694, 0);
            this.LayerNo_label.Name = "LayerNo_label";
            this.LayerNo_label.Size = new System.Drawing.Size(71, 46);
            this.LayerNo_label.TabIndex = 7;
            this.LayerNo_label.Text = "0";
            this.LayerNo_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GoUp_button
            // 
            this.GoUp_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.top_256;
            this.GoUp_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoUp_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoUp_button.Enabled = false;
            this.GoUp_button.Location = new System.Drawing.Point(195, 3);
            this.GoUp_button.Name = "GoUp_button";
            this.GoUp_button.Size = new System.Drawing.Size(90, 40);
            this.GoUp_button.TabIndex = 0;
            this.GoUp_button.UseVisualStyleBackColor = true;
            this.GoUp_button.Click += new System.EventHandler(this.GoUp_button_Click);
            // 
            // SVGEachLayer_vScrollBar
            // 
            this.SVGEachLayer_vScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SVGEachLayer_vScrollBar.Enabled = false;
            this.SVGEachLayer_vScrollBar.LargeChange = 1;
            this.SVGEachLayer_vScrollBar.Location = new System.Drawing.Point(797, 76);
            this.SVGEachLayer_vScrollBar.Name = "SVGEachLayer_vScrollBar";
            this.SVGEachLayer_vScrollBar.Size = new System.Drawing.Size(20, 438);
            this.SVGEachLayer_vScrollBar.TabIndex = 10;
            this.SVGEachLayer_vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SVGEachLayer_vScrollBar_Scroll);
            // 
            // WaitParseTimer
            // 
            this.WaitParseTimer.Tick += new System.EventHandler(this.WaitParseTimer_Tick);
            // 
            // DongleTimer
            // 
            this.DongleTimer.Interval = 1000;
            this.DongleTimer.Tick += new System.EventHandler(this.DongleTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D Printer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.PlatformMotorControl_groupBox.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.Misc_groupBox.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.ThreeDModelProject_groupBox.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.MainSVG_tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.MainSVG_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSVG_pictureBox)).EndInit();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Timer JOGTimer;
        private System.Windows.Forms.Timer PrintTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button JogUp_button;
        private System.Windows.Forms.Button JogDown_button;
        private System.Windows.Forms.Button AutoManual_button;
        private System.Windows.Forms.Button Home_button;
        private System.Windows.Forms.Button ZCalibration_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Preference_button;
        private System.Windows.Forms.Button Link_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox PlatformMotorControl_groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox Misc_groupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button AutoPrintStart_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.GroupBox ThreeDModelProject_groupBox;
        private System.Windows.Forms.TableLayoutPanel MainSVG_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TextBox SVGYDirPos_textBox;
        private System.Windows.Forms.TextBox SVGYDirStep_textBox;
        private System.Windows.Forms.TextBox SVGXDirPos_textBox;
        private System.Windows.Forms.TextBox SVGZoomScale_textBox;
        private System.Windows.Forms.TextBox SVGZoomStep_textBox;
        private System.Windows.Forms.Panel MainSVG_panel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button OpenFile_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label FileNameTitle_label;
        private System.Windows.Forms.TextBox EstimatedTime_textBox;
        private System.Windows.Forms.Label EstimatedTimeTitle_label;
        private System.Windows.Forms.TextBox FileName_textBox;
        private System.Windows.Forms.Button GoUp_button;
        private System.Windows.Forms.Button GoDown_button;
        private System.Windows.Forms.Button GoLeft_button;
        private System.Windows.Forms.Button GoRight_button;
        private System.Windows.Forms.Button ZoomIn_button;
        private System.Windows.Forms.Button ZoomOut_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LayerNo_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SVGXDirStep_textBox;
        private System.Windows.Forms.TextBox Exposure_textBox;
        private System.Windows.Forms.TextBox LayerHeight_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ImageScale_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BaseLayerNumber_textBox;
        private System.Windows.Forms.TextBox BaseExposure_textBox;
        private System.Windows.Forms.TextBox ZMotorUpRPM_textBox;
        private System.Windows.Forms.TextBox ZMotorDownRPM_textBox;
        private System.Windows.Forms.TextBox RMotorUpRPM_textBox;
        private System.Windows.Forms.TextBox RMotorDownRPM_textBox;
        private System.Windows.Forms.VScrollBar SVGEachLayer_vScrollBar;
        private System.Windows.Forms.PictureBox MainSVG_pictureBox;
        private System.Windows.Forms.Button AutoConnectArduino_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ProgressBar ReadSVG_progressBar;
        private System.Windows.Forms.TextBox ZUpDelayTime_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RSpinDelayTime_textBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer WaitParseTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer DongleTimer;
    }
}

