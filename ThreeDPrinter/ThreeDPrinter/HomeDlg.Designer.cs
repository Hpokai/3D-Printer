namespace ThreeDPrinter
{
    partial class HomeDlg
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
            this.components = new System.ComponentModel.Container();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.msgLabel = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Homing_progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // HomeTimer
            // 
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // msgLabel
            // 
            this.msgLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.Location = new System.Drawing.Point(-1, 32);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(477, 55);
            this.msgLabel.TabIndex = 0;
            this.msgLabel.Text = "Homing";
            this.msgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit_button
            // 
            this.Exit_button.BackgroundImage = global::ThreeDPrinter.Properties.Resources.exit;
            this.Exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_button.Location = new System.Drawing.Point(402, 168);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(60, 60);
            this.Exit_button.TabIndex = 1;
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Homing_progressBar
            // 
            this.Homing_progressBar.Location = new System.Drawing.Point(74, 105);
            this.Homing_progressBar.Maximum = 330;
            this.Homing_progressBar.Name = "Homing_progressBar";
            this.Homing_progressBar.Size = new System.Drawing.Size(327, 41);
            this.Homing_progressBar.Step = 1;
            this.Homing_progressBar.TabIndex = 2;
            // 
            // HomeDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 234);
            this.ControlBox = false;
            this.Controls.Add(this.Homing_progressBar);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.msgLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homing Page";
            this.Load += new System.EventHandler(this.HomeDlg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.ProgressBar Homing_progressBar;
    }
}