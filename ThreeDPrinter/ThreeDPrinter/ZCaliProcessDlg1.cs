using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreeDPrinter
{
    public partial class ZCaliProcessDlg1 : Form
    {
        public ZCaliProcessDlg1()
        {
            InitializeComponent();
        }

        private void ZCaliOKBtn1_Click(object sender, EventArgs e)
        {
            if (this.ZCalicheckBox1.Checked)
            {
                this.ZCalicheckBox1.Enabled = false;
                this.ZCaliOKBtn1.Enabled = false;

                ShareMemory.LinkSerialPort.DiscardInBuffer();
                ShareMemory.LinkSerialPort.ReadTimeout = 10;
                ShareMemory.LinkSerialPort.Write("2;"+ShareMemory.Preference.ZCaliDist.ToString()+";"+ShareMemory.Preference.DelayAfterAction.ToString()+";");
                this.isStartMotion = true;
                this.ZCali_progressBar.Visible = true;

                this.ZMotion_timer.Interval = 100;
                this.ZMotion_timer.Start();
            }

        }

        private bool isStartMotion = false;
        private void ZMotion_timer_Tick(object sender, EventArgs e)
        {
            if (true == this.isStartMotion)
            {
                if (false == ShareMemory.isDebug)
                {
                    if (21 == ShareMemory.ReturnPollingSignal())
                    {
                        this.ZCali_progressBar.Value = this.ZCali_progressBar.Maximum;
                        this.isStartMotion = false;
                    }
                    else
                    {
                        // this.msgLabel.Text = "Z軸移動中，請稍後...";
                        this.ZCali_progressBar.PerformStep();
                    }
                }
                else
                {
                    this.ZCali_progressBar.Value = this.ZCali_progressBar.Maximum;
                    this.isStartMotion = false;
                }
            }
            else
            {
                this.ZMotion_timer.Stop();
                ShareMemory.LinkSerialPort.ReadTimeout = 2000;
                System.Threading.Thread.Sleep(1000);
                this.DialogResult = DialogResult.OK;
                this.ZCali_progressBar.Visible = false;

                this.Close();
            }
        }

        private void ZCaliProcessDlg1_Load(object sender, EventArgs e)
        {
            this.ZCalicheckBox1.Enabled = true;
            this.ZCaliOKBtn1.Enabled = true;
            this.isStartMotion = false;

            this.ZCalicheckBox1.Checked = false;
            this.ZCali_progressBar.Value = 0;

            this.ZCaliLabel.Text = ShareMemory.Preference.ZCaliDist.ToString();
            this.DelayAfterActionLabel.Text = ShareMemory.Preference.DelayAfterAction.ToString();
        }



    }
}
