namespace Equalizer
{
    partial class MainForm
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.TimerRefresh = new System.Windows.Forms.Timer(this.components);
            this.LbSpeed = new System.Windows.Forms.Label();
            this.LbAngle = new System.Windows.Forms.Label();
            this.LbAngSpeed = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnClr = new System.Windows.Forms.Button();
            this.SpeedTB = new System.Windows.Forms.TextBox();
            this.AngleTb = new System.Windows.Forms.TextBox();
            this.AngSpeedTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(12, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(121, 32);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "Старт";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TimerRefresh
            // 
            this.TimerRefresh.Interval = 500;
            this.TimerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // LbSpeed
            // 
            this.LbSpeed.AutoSize = true;
            this.LbSpeed.Location = new System.Drawing.Point(42, 64);
            this.LbSpeed.Name = "LbSpeed";
            this.LbSpeed.Size = new System.Drawing.Size(55, 13);
            this.LbSpeed.TabIndex = 7;
            this.LbSpeed.Text = "Скорость";
            // 
            // LbAngle
            // 
            this.LbAngle.AutoSize = true;
            this.LbAngle.Location = new System.Drawing.Point(181, 64);
            this.LbAngle.Name = "LbAngle";
            this.LbAngle.Size = new System.Drawing.Size(32, 13);
            this.LbAngle.TabIndex = 8;
            this.LbAngle.Text = "Угол";
            // 
            // LbAngSpeed
            // 
            this.LbAngSpeed.AutoSize = true;
            this.LbAngSpeed.Location = new System.Drawing.Point(278, 64);
            this.LbAngSpeed.Name = "LbAngSpeed";
            this.LbAngSpeed.Size = new System.Drawing.Size(100, 13);
            this.LbAngSpeed.TabIndex = 9;
            this.LbAngSpeed.Text = "Угловая скорость";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(139, 12);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(121, 32);
            this.BtnStop.TabIndex = 12;
            this.BtnStop.Text = "Cтоп";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnClr
            // 
            this.BtnClr.Location = new System.Drawing.Point(266, 12);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Size = new System.Drawing.Size(121, 32);
            this.BtnClr.TabIndex = 13;
            this.BtnClr.Text = "Сброс";
            this.BtnClr.UseVisualStyleBackColor = true;
            this.BtnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // SpeedTB
            // 
            this.SpeedTB.BackColor = System.Drawing.SystemColors.Window;
            this.SpeedTB.Location = new System.Drawing.Point(12, 80);
            this.SpeedTB.Multiline = true;
            this.SpeedTB.Name = "SpeedTB";
            this.SpeedTB.ReadOnly = true;
            this.SpeedTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpeedTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SpeedTB.Size = new System.Drawing.Size(121, 263);
            this.SpeedTB.TabIndex = 14;
            // 
            // AngleTb
            // 
            this.AngleTb.BackColor = System.Drawing.SystemColors.Window;
            this.AngleTb.Location = new System.Drawing.Point(139, 80);
            this.AngleTb.Multiline = true;
            this.AngleTb.Name = "AngleTb";
            this.AngleTb.ReadOnly = true;
            this.AngleTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AngleTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AngleTb.Size = new System.Drawing.Size(121, 263);
            this.AngleTb.TabIndex = 15;
            // 
            // AngSpeedTb
            // 
            this.AngSpeedTb.BackColor = System.Drawing.SystemColors.Window;
            this.AngSpeedTb.Location = new System.Drawing.Point(266, 80);
            this.AngSpeedTb.Multiline = true;
            this.AngSpeedTb.Name = "AngSpeedTb";
            this.AngSpeedTb.ReadOnly = true;
            this.AngSpeedTb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AngSpeedTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AngSpeedTb.Size = new System.Drawing.Size(121, 263);
            this.AngSpeedTb.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 359);
            this.Controls.Add(this.AngSpeedTb);
            this.Controls.Add(this.AngleTb);
            this.Controls.Add(this.SpeedTB);
            this.Controls.Add(this.BtnClr);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.LbAngSpeed);
            this.Controls.Add(this.LbAngle);
            this.Controls.Add(this.LbSpeed);
            this.Controls.Add(this.BtnStart);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Тележка с маятником";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer TimerRefresh;
        private System.Windows.Forms.Label LbSpeed;
        private System.Windows.Forms.Label LbAngle;
        private System.Windows.Forms.Label LbAngSpeed;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnClr;
        private System.Windows.Forms.TextBox SpeedTB;
        private System.Windows.Forms.TextBox AngleTb;
        private System.Windows.Forms.TextBox AngSpeedTb;
    }
}

