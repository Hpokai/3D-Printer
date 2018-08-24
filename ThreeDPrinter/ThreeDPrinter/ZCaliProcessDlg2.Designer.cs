namespace ThreeDPrinter
{
    partial class ZCaliProcessDlg2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZCaliOKBtn2 = new System.Windows.Forms.Button();
            this.ZCalicheckBox2 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZCaliOKBtn2
            // 
            this.ZCaliOKBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ZCaliOKBtn2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZCaliOKBtn2.Location = new System.Drawing.Point(411, 47);
            this.ZCaliOKBtn2.Margin = new System.Windows.Forms.Padding(5);
            this.ZCaliOKBtn2.Name = "ZCaliOKBtn2";
            this.ZCaliOKBtn2.Size = new System.Drawing.Size(86, 50);
            this.ZCaliOKBtn2.TabIndex = 1;
            this.ZCaliOKBtn2.Text = "OK";
            this.ZCaliOKBtn2.UseVisualStyleBackColor = true;
            this.ZCaliOKBtn2.Click += new System.EventHandler(this.ZCaliOKBtn2_Click);
            // 
            // ZCalicheckBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ZCalicheckBox2, 2);
            this.ZCalicheckBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZCalicheckBox2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ZCalicheckBox2.Location = new System.Drawing.Point(5, 5);
            this.ZCalicheckBox2.Margin = new System.Windows.Forms.Padding(5);
            this.ZCalicheckBox2.Name = "ZCalicheckBox2";
            this.ZCalicheckBox2.Size = new System.Drawing.Size(396, 134);
            this.ZCalicheckBox2.TabIndex = 0;
            this.ZCalicheckBox2.Text = "請確認成型平台是否與槽底貼平；\r\n請確認成型平台調整螺絲是否鎖緊。";
            this.ZCalicheckBox2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ZCaliOKBtn2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ZCalicheckBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 144);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ZCaliProcessDlg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 144);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ZCaliProcessDlg2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Z Calibration Process";
            this.Load += new System.EventHandler(this.ZCaliProcessDlg2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ZCaliOKBtn2;
        private System.Windows.Forms.CheckBox ZCalicheckBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}