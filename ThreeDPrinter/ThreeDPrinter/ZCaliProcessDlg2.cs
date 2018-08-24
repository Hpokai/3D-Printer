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
    public partial class ZCaliProcessDlg2 : Form
    {
        public ZCaliProcessDlg2()
        {
            InitializeComponent();
        }

        private void ZCaliOKBtn2_Click(object sender, EventArgs e)
        {
            if (ZCalicheckBox2.Checked)
            {
                ShareMemory.LinkSerialPort.Write("f");
                this.DialogResult = DialogResult.OK;
            }

        }

        private void ZCaliProcessDlg2_Load(object sender, EventArgs e)
        {
            this.ZCalicheckBox2.Checked = false;
        }
    }
}
