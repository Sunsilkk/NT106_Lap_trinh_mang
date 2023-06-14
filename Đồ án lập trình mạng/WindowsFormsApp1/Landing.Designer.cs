namespace Pet_Management
{
    partial class Landing
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
            components = new System.ComponentModel.Container();
            progressBar = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            progressBar.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            progressBar.Location = new System.Drawing.Point(355, 634);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(544, 23);
            progressBar.Step = 20;
            progressBar.TabIndex = 2;
            progressBar.Value = 100;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(253, 203, 166);
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1224, 154);
            label1.TabIndex = 3;
            label1.Text = "My Pet";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(255, 203, 164);
            label2.Location = new System.Drawing.Point(12, 667);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 21);
            label2.TabIndex = 4;
            label2.Text = "Loading ......";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._7757278_upscayl_4x_realesrgan_x4plus;
            pictureBox4.Location = new System.Drawing.Point(-9, 71);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(1241, 651);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // Landing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1224, 699);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "Landing";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Landing";
            Load += Landing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}