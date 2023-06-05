namespace Pet_Management
{
    partial class Cage
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
            metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            SuspendLayout();
            // 
            // metroProgressBar1
            // 
            metroProgressBar1.Location = new System.Drawing.Point(113, 96);
            metroProgressBar1.Name = "metroProgressBar1";
            metroProgressBar1.Size = new System.Drawing.Size(551, 65);
            metroProgressBar1.TabIndex = 0;
            metroProgressBar1.Click += metroProgressBar1_Click;
            // 
            // Cage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(metroProgressBar1);
            Name = "Cage";
            Size = new System.Drawing.Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}