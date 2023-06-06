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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            l_total = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)chart_pet).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chart_pet
            // 
            chart_pet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chart_pet.BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            chart_pet.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            chart_pet.BorderlineColor = System.Drawing.Color.FromArgb(249, 224, 187);
            chartArea1.Name = "ChartArea1";
            chart_pet.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_pet.Legends.Add(legend1);
            chart_pet.Location = new System.Drawing.Point(47, 156);
            chart_pet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            chart_pet.Name = "chart_pet";
            chart_pet.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Số lượng thú cưng";
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            chart_pet.Series.Add(series1);
            chart_pet.Size = new System.Drawing.Size(614, 391);
            chart_pet.TabIndex = 0;
            chart_pet.Text = "chart_pet";
            title1.Name = "Title1";
            title1.Text = "Chart Pet";
            chart_pet.Titles.Add(title1);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 47.9999924F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(328, 64);
            label1.TabIndex = 2;
            label1.Text = "Doanh thu";
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1246, 140);
            label2.TabIndex = 3;
            label2.Text = "Home";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_total
            // 
            l_total.Font = new System.Drawing.Font("Qaz", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            l_total.ForeColor = System.Drawing.Color.Crimson;
            l_total.Location = new System.Drawing.Point(0, 78);
            l_total.Name = "l_total";
            l_total.Size = new System.Drawing.Size(330, 73);
            l_total.TabIndex = 4;
            l_total.Text = "0";
            l_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(l_total);
            panel1.Location = new System.Drawing.Point(801, 319);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(330, 174);
            panel1.TabIndex = 5;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(chart_pet);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Home";
            Size = new System.Drawing.Size(1246, 777);
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)chart_pet).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Panel panel1;
    }
}