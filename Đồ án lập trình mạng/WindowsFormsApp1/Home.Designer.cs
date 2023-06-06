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
            tb_Total = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)chart_pet).BeginInit();
            SuspendLayout();
            // 
            // chart_pet
            // 
            chartArea1.Name = "ChartArea1";
            chart_pet.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_pet.Legends.Add(legend1);
            chart_pet.Location = new System.Drawing.Point(14, 28);
            chart_pet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chart_pet.Name = "chart_pet";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Số lượng thú cưng";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            chart_pet.Series.Add(series1);
            chart_pet.Size = new System.Drawing.Size(428, 264);
            chart_pet.TabIndex = 0;
            chart_pet.Text = "chart_pet";
            title1.Name = "Title1";
            title1.Text = "Chart Pet";
            chart_pet.Titles.Add(title1);
            // 
            // tb_Total
            // 
            tb_Total.Location = new System.Drawing.Point(464, 177);
            tb_Total.Name = "tb_Total";
            tb_Total.Size = new System.Drawing.Size(174, 23);
            tb_Total.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(464, 141);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Doanh thu";
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(tb_Total);
            Controls.Add(chart_pet);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Home";
            Size = new System.Drawing.Size(700, 338);
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)chart_pet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pet;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label label1;
    }
}