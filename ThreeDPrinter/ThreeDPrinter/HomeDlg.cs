using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreeDPrinter
{
    public partial class HomeDlg : Form
    {
        private bool isHoming = false;

        public HomeDlg()
        {
            InitializeComponent();
        }

        private void HomeDlg_Load(object sender, EventArgs e)
        {
            this.isHoming = true;
            this.msgLabel.Text = "Homing";
            this.Homing_progressBar.Value = 0;

            ShareMemory.LinkSerialPort.DiscardInBuffer();
            ShareMemory.LinkSerialPort.ReadTimeout = 10;
            ShareMemory.LinkSerialPort.Write("3;");
            
            this.HomeTimer.Interval = 100;
            this.HomeTimer.Start();
        }

        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            if (false == ShareMemory.isDebug)
            {
                if (this.isHoming)
                {
                    if (31 == ShareMemory.ReturnPollingSignal())
                    {
                        this.isHoming = false;
                        this.msgLabel.Text = "Home completed";
                        this.Homing_progressBar.Value = this.Homing_progressBar.Maximum;
                        ShareMemory.isHome = true;
                    }
                    else
                    {
                        this.Homing_progressBar.PerformStep();
                    }
                }
                else
                {
                    this.Exit_button.PerformClick();
                }
            }
            else
            {
                this.isHoming = false;
                ShareMemory.isHome = true;
                this.Exit_button.PerformClick();
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.HomeTimer.Stop();
            System.Threading.Thread.Sleep(1000);
            ShareMemory.LinkSerialPort.ReadTimeout = 2000;
            ShareMemory.LinkSerialPort.Write("0");

            this.Close();
        }
    }
}