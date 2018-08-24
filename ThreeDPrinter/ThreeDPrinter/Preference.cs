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

    public partial class Preference : Form
    {
        public Preference()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if ((this.ZCaliDist.Text != "") && (this.DelayAfterAction.Text != ""))
            {
                ShareMemory.Preference.ZCaliDist = int.Parse(ZCaliDist.Text);
                ShareMemory.Preference.DelayAfterAction = int.Parse(DelayAfterAction.Text);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Jabil\3D Printer\parameters_2.txt"))
                {
                    file.WriteLine(ShareMemory.Preference.ZCaliDist.ToString());
                    file.WriteLine(ShareMemory.Preference.DelayAfterAction.ToString());
                }

                ShareMemory.Preference.Checked = FileSaveCheckBox.Checked;
            }
        }

        private void Preference_Load(object sender, EventArgs e)
        {
            ZCaliDist.Text = ShareMemory.Preference.ZCaliDist.ToString();
            DelayAfterAction.Text = ShareMemory.Preference.DelayAfterAction.ToString();
            FileSaveCheckBox.Checked = ShareMemory.Preference.Checked;
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
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

        private void ZCaliDist_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnlyNumber(sender, e);
        }

        private void DelayAfterAction_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnlyNumber(sender, e);
        }

    }
}
