namespace Equalizer
{
    partial class AngleGrForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtAngle = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtAngle
            // 
            this.chrtAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.Name = "ChartArea1";
            this.chrtAngle.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chrtAngle.Legends.Add(legend9);
            this.chrtAngle.Location = new System.Drawing.Point(12, 12);
            this.chrtAngle.Name = "chrtAngle";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.IsXValueIndexed = true;
            series9.Legend = "Legend1";
            series9.Name = "Angle";
            this.chrtAngle.Series.Add(series9);
            this.chrtAngle.Size = new System.Drawing.Size(625, 387);
            this.chrtAngle.TabIndex = 11;
            this.chrtAngle.Text = "Скорость";
            // 
            // AngleGrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 372);
            this.ControlBox = false;
            this.Controls.Add(this.chrtAngle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(700, 500);
            this.MaximumSize = new System.Drawing.Size(649, 411);
            this.MinimumSize = new System.Drawing.Size(649, 411);
            this.Name = "AngleGrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Угол по времени";
            ((System.ComponentModel.ISupportInitialize)(this.chrtAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAngle;
    }
}