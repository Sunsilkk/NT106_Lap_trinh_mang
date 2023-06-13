namespace Pet_Management
{
    partial class Login_Page
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
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new RoundButton();
            textBox1 = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox2.BackColor = System.Drawing.Color.FromArgb(252, 217, 172);
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Font = new System.Drawing.Font("Qaz", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(971, 441);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(339, 28);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(72, 122, 61);
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Mouldy Cheese", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.FromArgb(236, 176, 58);
            button1.Location = new System.Drawing.Point(1003, 511);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(265, 46);
            button1.TabIndex = 2;
            button1.Text = "SUBMIT";
            button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            textBox1.BackColor = System.Drawing.Color.FromArgb(252, 217, 172);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Qaz", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(971, 342);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(339, 28);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Mesa_de_trabajo_1_4x;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1473, 833);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1473, 833);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            ForeColor = System.Drawing.Color.FromArgb(72, 122, 61);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Login_Page";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private RoundButton button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}