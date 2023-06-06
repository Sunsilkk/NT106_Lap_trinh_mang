namespace Pet_Management
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chart_pet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart_pet).BeginInit();
            SuspendLayout();
            // 
            // chart_pet
            // 
            chartArea1.Name = "ChartArea1";
            chart_pet.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_pet.Legends.Add(legend1);
            chart_pet.Location = new System.Drawing.Point(24, 34);
            chart_pet.Name = "chart_pet";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Số lượng thú cưng";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            chart_pet.Series.Add(series1);
            chart_pet.Size = new System.Drawing.Size(489, 352);
            chart_pet.TabIndex = 0;
            chart_pet.Text = "chart_pet";
            title1.Name = "Title1";
            title1.Text = "Chart Pet";
            chart_pet.Titles.Add(title1);
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(chart_pet);
            Name = "Home";
            Size = new System.Drawing.Size(800, 450);
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)chart_pet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pet;
    }
}