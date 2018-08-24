using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using CypressLibrary;
using Ddp343xLibrary;

namespace ThreeDPrinter
{

    public partial class Link : Form
    {

        internal Color BackUpColor;
        internal Color BackUpStatusColor;

        Ddp343x mDdp343x;
        CypressSpi mCypressSpi;
        CypressI2c mCypressI2c;
        CypressGpio mCypressGpio;


        public Link()
        {
            InitializeComponent();

            mCypressI2c = new CypressI2c();
            mCypressSpi = new CypressSpi();
            mCypressGpio = new CypressGpio();
            mDdp343x = new Ddp343x(mCypressI2c, mCypressSpi, mCypressGpio);
        }

        private void Link_Load(object sender, EventArgs e)
        {
            this.COMPortRefresh();
            ShiedON_button.Enabled = false;
            ShiedOFF_button.Enabled = false;

            if (true == ShareMemory.isConnected)
            {
                LinkIndicator.BackColor = Color.FromArgb(255, 255, 0);
                LinkIndicatorStatus.Text = " ON ";
                LinkIndicatorStatus.ForeColor = Color.FromArgb(0, 0, 255);

                this.ShiedSwitch_checkBox.Enabled = true;
            }
            else
            {
                this.ShiedSwitch_checkBox.Enabled = false;
                this.UVOn_checkBox.Enabled = false;
                this.UVOff_checkBox.Enabled = false;
            }

            this.PowerOn_checkBox.CheckedChanged -= new System.EventHandler(this.PowerOn_checkBox_CheckedChanged);
            this.PowerOff_checkBox.CheckedChanged -= new System.EventHandler(this.PowerOff_checkBox_CheckedChanged);
            this.UVOn_checkBox.CheckedChanged -= new System.EventHandler(this.UVOn_checkBox_CheckedChanged);
            this.UVOn_checkBox.CheckedChanged -= new System.EventHandler(this.UVOff_checkBox_CheckedChanged);

            this.PowerOn_checkBox.CheckState = CheckState.Unchecked;
            this.PowerOff_checkBox.CheckState = CheckState.Checked;
            this.UVOn_checkBox.CheckState = CheckState.Unchecked;
            this.UVOff_checkBox.CheckState = CheckState.Checked;

            this.PowerOn_checkBox.CheckedChanged += new System.EventHandler(this.PowerOn_checkBox_CheckedChanged);
            this.PowerOff_checkBox.CheckedChanged += new System.EventHandler(this.PowerOff_checkBox_CheckedChanged);
            this.UVOn_checkBox.CheckedChanged += new System.EventHandler(this.UVOn_checkBox_CheckedChanged);
            this.UVOff_checkBox.CheckedChanged += new System.EventHandler(this.UVOff_checkBox_CheckedChanged);

            this.cbSerialPorts.SelectedIndex = this.cbSerialPorts.Items.Count - 1;
            this.cbBaud.SelectedIndex = 3;
        }

        public void LinkCloseExe()
        {
            try
            {
                if (ShareMemory.LinkSerialPort != null && ShareMemory.LinkSerialPort.IsOpen)
                {
                    SendLedOffMessageToArduino();
                    ShareMemory.LinkSerialPort.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Close() error: " + e.Message);
            }
        }

        private void LinkOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ShareMemory.LinkSerialPort = new SerialPort(cbSerialPorts.SelectedItem.ToString(),
                                                    int.Parse(cbBaud.Text.ToString()), Parity.None, 8, StopBits.One);

                ShareMemory.LinkSerialPort.ReadTimeout = int.Parse(TimeoutVal.Text);
                // Open serial port
                ShareMemory.LinkSerialPort.Open();
                ShareMemory.LinkSerialPort.DiscardOutBuffer();
                ShareMemory.LinkSerialPort.DiscardInBuffer();

                ShareMemory.LinkSerialPort.Write("0;");
                System.Threading.Thread.Sleep(50);

                switch (int.Parse(ShareMemory.LinkSerialPort.ReadLine()))
                {
                    case 0:
                        LinkIndicator.BackColor = Color.FromArgb(255, 255, 0);
                        LinkIndicatorStatus.Text = " ON ";
                        LinkIndicatorStatus.ForeColor = Color.FromArgb(0, 0, 255);

                        this.ShiedSwitch_checkBox.Enabled = true;
                        ShareMemory.isConnected = true;
                        break;
                    default:
                        MessageBox.Show("Connect Error!");
                        ShareMemory.LinkSerialPort.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open() error: " + ex.Message);
                ShareMemory.LinkSerialPort.Close();
            }
        }

        private void SendLedOffMessageToArduino()
        {
            ShareMemory.LinkSerialPort.Write("1;0");
            System.Threading.Thread.Sleep(10);
            ShareMemory.LinkSerialPort.Write("999;");
            System.Threading.Thread.Sleep(10);
        }

        private void COMRefresh_Click(object sender, EventArgs e)
        {
            this.COMPortRefresh();
        }

        private void COMPortRefresh()
        {
            string[] serialPorts = SerialPort.GetPortNames();

            if (LinkIndicatorStatus.Text != " ON ")
            {
                // Fill in Combobox with serial port names
                cbSerialPorts.DataSource = serialPorts;

                BackUpColor = LinkIndicator.BackColor;
                BackUpStatusColor = LinkIndicatorStatus.ForeColor;
                LinkIndicatorStatus.Text = " OFF ";
            }
        }

        private void Link_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ShiedSwitch_checkBox.Checked = false;

            this.UVOff_checkBox.Checked = true;
            System.Threading.Thread.Sleep(50);
            this.PowerOff_checkBox.Checked = true;
            System.Threading.Thread.Sleep(50);
        }

        private void ShiedSwitch_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.ShiedSwitch_checkBox.Checked)
            {
                ShareMemory.LinkSerialPort.Write("1;");
                ShiedON_button.Enabled = true;
                ShiedOFF_button.Enabled = true;
            }
            else
            {
                ShiedON_button.Enabled = false;
                ShiedOFF_button.Enabled = false;
                ShareMemory.LinkSerialPort.Write("c");
            }
        }

        private void ShiedON_button_Click(object sender, EventArgs e)
        {
            ShareMemory.LinkSerialPort.Write("a");
        }

        private void ShiedOFF_button_Click(object sender, EventArgs e)
        {
            ShareMemory.LinkSerialPort.Write("b");
        }

        private void LinkClose_Click(object sender, EventArgs e)
        {
            if (true == ShareMemory.LinkSerialPort.IsOpen)
            {
                byte[] bytestosend = { 0xff };
                ShareMemory.LinkSerialPort.Write(bytestosend, 0, bytestosend.Length);

                ShareMemory.LinkSerialPort.Close();

                LinkIndicator.BackColor = Color.MidnightBlue;
                LinkIndicatorStatus.Text = " OFF ";
                LinkIndicatorStatus.ForeColor = Color.Crimson;
                ShareMemory.isConnected = false;
            }
        }

        public int SetProjectorPowerOn()
        {
            bool ProjectorEnable = true;
            int ret;
            mDdp343x.ClearLog();

            ret = mCypressGpio.Open();
            if (ret < 0) return ret;

            ret = mDdp343x.SetProjectorOnOff(ProjectorEnable);
            if (ret < 0) return ret;

            ret = mCypressGpio.Close();
            if (ret < 0) return ret;

            //Waiting for power on ready
            bool ledEnableR, ledEnableG, ledEnableB;
            ret = mCypressI2c.Open();
            ret = mDdp343x.GetLedOnOff(out ledEnableR, out ledEnableG, out ledEnableB);
            ret = mCypressI2c.Close();

            return ret;
        }
        private void ProjectorPowerOn()
        {
            bool ProjectorEnable = true;
            int ret;
            mDdp343x.ClearLog();

            ret = mCypressGpio.Open();
            if (ret < 0)
            {
                MessageBox.Show("GPIO Communication FAIL!!!");
                return;
            }

            ret = mDdp343x.SetProjectorOnOff(ProjectorEnable);
            if (ret < 0) { return; }

            ret = mCypressGpio.Close();
            if (ret < 0)
            {
                MessageBox.Show("GPIO Communication FAIL!!!");
                return;
            }

            //Waiting for power on ready
            bool ledEnableR, ledEnableG, ledEnableB;
            ret = mCypressI2c.Open();
            ret = mDdp343x.GetLedOnOff(out ledEnableR, out ledEnableG, out ledEnableB);
            ret = mCypressI2c.Close();
            MessageBox.Show("System is ready !");
        }
        private void PowerOn_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.PowerOn_checkBox.Checked)
            {
                if (0 > this.SetProjectorPowerOn())
                {
                    this.PowerOn_checkBox.CheckState = CheckState.Unchecked;
                    MessageBox.Show("GPIO Communication FAIL!!!");
                }
                else
                {
                    this.PowerOff_checkBox.CheckState = CheckState.Unchecked;
                    this.UVOn_checkBox.Enabled = true;
                    this.UVOff_checkBox.Enabled = true;
                    MessageBox.Show("System is ready !");
                }
            }
        }

        public int SetProjectorPowerOff()
        {
            bool ProjectorEnable = false;
            int ret;
            mDdp343x.ClearLog();

            ret = mCypressGpio.Open();
            if (ret < 0) return ret;

            ret = mDdp343x.SetProjectorOnOff(ProjectorEnable);
            if (ret < 0) return ret;

            ret = mCypressGpio.Close();

            return ret;
        }
        private void ProjectorPowerOff()
        {
            bool ProjectorEnable = false;
            int ret;
            mDdp343x.ClearLog();

            ret = mCypressGpio.Open();
            if (ret < 0)
            {
                MessageBox.Show("GPIO Communication FAIL!!!");
                return;
            }

            ret = mDdp343x.SetProjectorOnOff(ProjectorEnable);
            if (ret < 0) { return; }

            ret = mCypressGpio.Close();
            if (ret < 0)
            {
                MessageBox.Show("GPIO Communication FAIL!!!");
                return;
            }
        }
        private void PowerOff_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.PowerOff_checkBox.Checked)
            {
                if (0 > this.SetProjectorPowerOff())
                {
                    this.PowerOff_checkBox.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.PowerOn_checkBox.CheckState = CheckState.Unchecked;
                    this.UVOn_checkBox.Enabled = false;
                    this.UVOff_checkBox.Enabled = false;
                }
            }
        }

        public int SetUVLedOnOff(bool isLedEnable)
        {
            bool ledEnableG = isLedEnable;
            int ret;
            mDdp343x.ClearLog();

            ret = mCypressI2c.Open();
            if (ret < 0) return ret;

            ret = mDdp343x.SetLedOnOff(false, ledEnableG, false);
            if (ret < 0) return ret;

            ret = mCypressI2c.Close();
            return ret;
        }
        private void UVLedOnOff(bool isLedEnable)
        {
            bool ledEnableG = isLedEnable;
            int ret;
            mDdp343x.ClearLog();

            ret = mCypressI2c.Open();
            if (ret < 0)
            {
                MessageBox.Show("I2C Communication FAIL!!!");
            }

            ret = mDdp343x.SetLedOnOff(false, ledEnableG, false);
            if (ret < 0) { return; }

            ret = mCypressI2c.Close();
            if (ret < 0)
            {
                MessageBox.Show("I2C Communication FAIL!!!");
                return;
            }
        }
        private void UVOn_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.UVOn_checkBox.Checked)
            {
                if (0 > this.SetUVLedOnOff(true))
                {
                    this.UVOn_checkBox.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.UVOff_checkBox.CheckState = CheckState.Unchecked;
                }
            }
        }
        private void UVOff_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (true == this.UVOff_checkBox.Checked)
            {
                if (0 > this.SetUVLedOnOff(false))
                {
                    this.UVOff_checkBox.CheckState = CheckState.Unchecked;
                }
                else
                {
                    this.UVOn_checkBox.CheckState = CheckState.Unchecked;
                }
            }
        }

        private void TimeoutVal_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
