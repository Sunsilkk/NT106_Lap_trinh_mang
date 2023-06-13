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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(255, 235, 211);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Location = new System.Drawing.Point(740, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(216, 16);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(255, 235, 211);
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Location = new System.Drawing.Point(740, 310);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(216, 16);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(789, 443);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8388521;
            pictureBox1.Location = new System.Drawing.Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1152, 650);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1154, 663);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Login_Page";
            Text = "Login_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}