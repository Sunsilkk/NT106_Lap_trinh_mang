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
            panel1 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            progressBar = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(922, 16);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download_upscayl_4x_realesrgan_x4plus;
            pictureBox1.Location = new System.Drawing.Point(44, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(306, 333);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar
            // 
            progressBar.Location = new System.Drawing.Point(356, 344);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(544, 23);
            progressBar.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(356, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(544, 200);
            label1.TabIndex = 3;
            label1.Text = "My Pet";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(0, 389);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(123, 21);
            label2.TabIndex = 4;
            label2.Text = "Loading ......";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.filhote_de_golden_retriever_fofo_com_desenho_de_óculos_de_sol__ilustração_vetorial;
            pictureBox2.Location = new System.Drawing.Point(738, 222);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(251, 176);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Premium_Vector___Lazy_beagle_puppy_lying_on_back_icon_upscayl_4x_realesrgan_x4plus;
            pictureBox3.Location = new System.Drawing.Point(0, 293);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(922, 196);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Landing
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(922, 410);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "Landing";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Landing";
            Load += Landing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}