namespace ThreeDPrinter
{
    partial class Link
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
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.LinkOpen = new System.Windows.Forms.Button();
            this.LinkClose = new System.Windows.Forms.Button();
            this.LinkIndicator = new System.Windows.Forms.Panel();
            this.LinkIndicatorStatus = new System.Windows.Forms.Label();
            this.ShiedON_button = new System.Windows.Forms.Button();
            this.ShiedOFF_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeoutVal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.COMRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UVOn_checkBox = new System.Windows.Forms.CheckBox();
            this.UVOff_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PowerOn_checkBox = new System.Windows.Forms.CheckBox();
            this.PowerOff_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ShiedSwitch_checkBox = new System.Windows.Forms.CheckBox();
            this.LinkIndicator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerialPorts.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(3, 4);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(225, 30);
            this.cbSerialPorts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baud(Hz):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbBaud
            // 
            this.cbBaud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaud.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200"});
            this.cbBaud.Location = new System.Drawing.Point(147, 4);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(139, 30);
            this.cbBaud.TabIndex = 0;
            this.cbBaud.Tag = "0";
            // 
            // LinkOpen
            // 
            this.LinkOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinkOpen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkOpen.Location = new System.Drawing.Point(3, 3);
            this.LinkOpen.Name = "LinkOpen";
            this.LinkOpen.Size = new System.Drawing.Size(138, 77);
            this.LinkOpen.TabIndex = 0;
            this.LinkOpen.Text = "Open";
            this.LinkOpen.UseVisualStyleBackColor = true;
            this.LinkOpen.Click += new System.EventHandler(this.LinkOpen_Click);
            // 
            // LinkClose
            // 
            this.LinkClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinkClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkClose.Location = new System.Drawing.Point(147, 3);
            this.LinkClose.Name = "LinkClose";
            this.LinkClose.Size = new System.Drawing.Size(139, 77);
            this.LinkClose.TabIndex = 1;
            this.LinkClose.Text = "Close";
            this.LinkClose.UseVisualStyleBackColor = true;
            this.LinkClose.Click += new System.EventHandler(this.LinkClose_Click);
            // 
            // LinkIndicator
            // 
            this.LinkIndicator.BackColor = System.Drawing.Color.MidnightBlue;
            this.LinkIndicator.Controls.Add(this.LinkIndicatorStatus);
            this.LinkIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinkIndicator.Location = new System.Drawing.Point(304, 3);
            this.LinkIndicator.Name = "LinkIndicator";
            this.LinkIndicator.Size = new System.Drawing.Size(95, 221);
            this.LinkIndicator.TabIndex = 6;
            // 
            // LinkIndicatorStatus
            // 
            this.LinkIndicatorStatus.AutoSize = true;
            this.LinkIndicatorStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkIndicatorStatus.ForeColor = System.Drawing.Color.Crimson;
            this.LinkIndicatorStatus.Location = new System.Drawing.Point(28, 101);
            this.LinkIndicatorStatus.Name = "LinkIndicatorStatus";
            this.LinkIndicatorStatus.Size = new System.Drawing.Size(39, 19);
            this.LinkIndicatorStatus.TabIndex = 0;
            this.LinkIndicatorStatus.Text = "OFF";
            // 
            // ShiedON_button
            // 
            this.ShiedON_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiedON_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiedON_button.Location = new System.Drawing.Point(3, 78);
            this.ShiedON_button.Name = "ShiedON_button";
            this.ShiedON_button.Size = new System.Drawing.Size(140, 69);
            this.ShiedON_button.TabIndex = 1;
            this.ShiedON_button.Text = "Shied ON";
            this.ShiedON_button.UseVisualStyleBackColor = true;
            this.ShiedON_button.Click += new System.EventHandler(this.ShiedON_button_Click);
            // 
            // ShiedOFF_button
            // 
            this.ShiedOFF_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiedOFF_button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiedOFF_button.Location = new System.Drawing.Point(3, 153);
            this.ShiedOFF_button.Name = "ShiedOFF_button";
            this.ShiedOFF_button.Size = new System.Drawing.Size(140, 71);
            this.ShiedOFF_button.TabIndex = 2;
            this.ShiedOFF_button.Text = "Shied OFF";
            this.ShiedOFF_button.UseVisualStyleBackColor = true;
            this.ShiedOFF_button.Click += new System.EventHandler(this.ShiedOFF_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 259);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer Connection";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.LinkIndicator, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(402, 227);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(295, 221);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.LinkOpen, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.LinkClose, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(289, 83);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.TimeoutVal, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(289, 38);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // TimeoutVal
            // 
            this.TimeoutVal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeoutVal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeoutVal.Location = new System.Drawing.Point(147, 4);
            this.TimeoutVal.Name = "TimeoutVal";
            this.TimeoutVal.Size = new System.Drawing.Size(139, 29);
            this.TimeoutVal.TabIndex = 0;
            this.TimeoutVal.Text = "2000";
            this.TimeoutVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeoutVal_KeyPress);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Timeout(ms):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.cbBaud, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(289, 38);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Controls.Add(this.cbSerialPorts, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.COMRefresh, 1, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(289, 38);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // COMRefresh
            // 
            this.COMRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COMRefresh.Image = global::ThreeDPrinter.Properties.Resources.refresh;
            this.COMRefresh.Location = new System.Drawing.Point(234, 3);
            this.COMRefresh.Name = "COMRefresh";
            this.COMRefresh.Size = new System.Drawing.Size(52, 32);
            this.COMRefresh.TabIndex = 0;
            this.COMRefresh.UseVisualStyleBackColor = true;
            this.COMRefresh.Click += new System.EventHandler(this.COMRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 174);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projector Connection";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(560, 142);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(283, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 136);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UV On/Off";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UVOn_checkBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UVOff_checkBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 104);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // UVOn_checkBox
            // 
            this.UVOn_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UVOn_checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UVOn_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UVOn_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UVOn_checkBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UVOn_checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.UVOn_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UVOn_checkBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.UVOn_checkBox.ForeColor = System.Drawing.Color.Red;
            this.UVOn_checkBox.Location = new System.Drawing.Point(3, 3);
            this.UVOn_checkBox.Name = "UVOn_checkBox";
            this.UVOn_checkBox.Size = new System.Drawing.Size(128, 98);
            this.UVOn_checkBox.TabIndex = 0;
            this.UVOn_checkBox.Text = "ON";
            this.UVOn_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UVOn_checkBox.UseVisualStyleBackColor = false;
            this.UVOn_checkBox.CheckedChanged += new System.EventHandler(this.UVOn_checkBox_CheckedChanged);
            // 
            // UVOff_checkBox
            // 
            this.UVOff_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.UVOff_checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UVOff_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UVOff_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UVOff_checkBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UVOff_checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.UVOff_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UVOff_checkBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.UVOff_checkBox.ForeColor = System.Drawing.Color.Red;
            this.UVOff_checkBox.Location = new System.Drawing.Point(137, 3);
            this.UVOff_checkBox.Name = "UVOff_checkBox";
            this.UVOff_checkBox.Size = new System.Drawing.Size(128, 98);
            this.UVOff_checkBox.TabIndex = 1;
            this.UVOff_checkBox.Text = "OFF";
            this.UVOff_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UVOff_checkBox.UseVisualStyleBackColor = false;
            this.UVOff_checkBox.CheckedChanged += new System.EventHandler(this.UVOff_checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 136);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Projector On/Off";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PowerOn_checkBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PowerOff_checkBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PowerOn_checkBox
            // 
            this.PowerOn_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PowerOn_checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PowerOn_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PowerOn_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PowerOn_checkBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PowerOn_checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.PowerOn_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerOn_checkBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.PowerOn_checkBox.ForeColor = System.Drawing.Color.Red;
            this.PowerOn_checkBox.Location = new System.Drawing.Point(3, 3);
            this.PowerOn_checkBox.Name = "PowerOn_checkBox";
            this.PowerOn_checkBox.Size = new System.Drawing.Size(128, 98);
            this.PowerOn_checkBox.TabIndex = 0;
            this.PowerOn_checkBox.Text = "ON";
            this.PowerOn_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PowerOn_checkBox.UseVisualStyleBackColor = false;
            this.PowerOn_checkBox.CheckedChanged += new System.EventHandler(this.PowerOn_checkBox_CheckedChanged);
            // 
            // PowerOff_checkBox
            // 
            this.PowerOff_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.PowerOff_checkBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PowerOff_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PowerOff_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PowerOff_checkBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PowerOff_checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.PowerOff_checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerOff_checkBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.PowerOff_checkBox.ForeColor = System.Drawing.Color.Red;
            this.PowerOff_checkBox.Location = new System.Drawing.Point(137, 3);
            this.PowerOff_checkBox.Name = "PowerOff_checkBox";
            this.PowerOff_checkBox.Size = new System.Drawing.Size(128, 98);
            this.PowerOff_checkBox.TabIndex = 1;
            this.PowerOff_checkBox.Text = "OFF";
            this.PowerOff_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PowerOff_checkBox.UseVisualStyleBackColor = false;
            this.PowerOff_checkBox.CheckedChanged += new System.EventHandler(this.PowerOff_checkBox_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(426, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(152, 259);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Shied Setting";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.ShiedON_button, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ShiedSwitch_checkBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ShiedOFF_button, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(146, 227);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // ShiedSwitch_checkBox
            // 
            this.ShiedSwitch_checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShiedSwitch_checkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShiedSwitch_checkBox.Font = new System.Drawing.Font("Calibri", 12F);
            this.ShiedSwitch_checkBox.Location = new System.Drawing.Point(3, 3);
            this.ShiedSwitch_checkBox.Name = "ShiedSwitch_checkBox";
            this.ShiedSwitch_checkBox.Size = new System.Drawing.Size(140, 69);
            this.ShiedSwitch_checkBox.TabIndex = 0;
            this.ShiedSwitch_checkBox.Text = "Shied Switch";
            this.ShiedSwitch_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShiedSwitch_checkBox.UseVisualStyleBackColor = true;
            this.ShiedSwitch_checkBox.CheckedChanged += new System.EventHandler(this.ShiedSwitch_checkBox_CheckedChanged);
            // 
            // Link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 471);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Link";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Link_FormClosing);
            this.Load += new System.EventHandler(this.Link_Load);
            this.LinkIndicator.ResumeLayout(false);
            this.LinkIndicator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Button LinkOpen;
        private System.Windows.Forms.Button LinkClose;
        private System.Windows.Forms.Button COMRefresh;
        private System.Windows.Forms.Panel LinkIndicator;
        private System.Windows.Forms.Label LinkIndicatorStatus;
        private System.Windows.Forms.Button ShiedON_button;
        private System.Windows.Forms.Button ShiedOFF_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TimeoutVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckBox PowerOn_checkBox;
        private System.Windows.Forms.CheckBox PowerOff_checkBox;
        private System.Windows.Forms.CheckBox UVOn_checkBox;
        private System.Windows.Forms.CheckBox UVOff_checkBox;
        private System.Windows.Forms.CheckBox ShiedSwitch_checkBox;

    }
}