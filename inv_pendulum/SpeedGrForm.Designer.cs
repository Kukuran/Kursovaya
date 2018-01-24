namespace Equalizer
{
    partial class SpeedGrForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtVel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtVel)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtVel
            // 
            this.chrtVel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chrtVel.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chrtVel.Legends.Add(legend7);
            this.chrtVel.Location = new System.Drawing.Point(12, 12);
            this.chrtVel.Name = "chrtVel";
            this.chrtVel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Velocity";
            this.chrtVel.Series.Add(series7);
            this.chrtVel.Size = new System.Drawing.Size(614, 348);
            this.chrtVel.TabIndex = 12;
            this.chrtVel.Text = "chart1";
            // 
            // SpeedGrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 372);
            this.ControlBox = false;
            this.Controls.Add(this.chrtVel);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(700, 50);
            this.MaximumSize = new System.Drawing.Size(649, 411);
            this.MinimumSize = new System.Drawing.Size(649, 411);
            this.Name = "SpeedGrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Скорость по времени";
            ((System.ComponentModel.ISupportInitialize)(this.chrtVel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtVel;
    }
}