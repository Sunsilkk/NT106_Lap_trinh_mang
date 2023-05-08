namespace Multi_Client_Server_chat
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.b_Server = new System.Windows.Forms.Button();
            this.b_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Server
            // 
            this.b_Server.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Server.Location = new System.Drawing.Point(22, 22);
            this.b_Server.Name = "b_Server";
            this.b_Server.Size = new System.Drawing.Size(92, 40);
            this.b_Server.TabIndex = 0;
            this.b_Server.Text = "Server";
            this.b_Server.UseVisualStyleBackColor = true;
            this.b_Server.Click += new System.EventHandler(this.b_Server_Click);
            // 
            // b_Client
            // 
            this.b_Client.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Client.Location = new System.Drawing.Point(151, 22);
            this.b_Client.Name = "b_Client";
            this.b_Client.Size = new System.Drawing.Size(92, 40);
            this.b_Client.TabIndex = 1;
            this.b_Client.Text = "Client";
            this.b_Client.UseVisualStyleBackColor = true;
            this.b_Client.Click += new System.EventHandler(this.b_Client_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 90);
            this.Controls.Add(this.b_Client);
            this.Controls.Add(this.b_Server);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Server;
        private System.Windows.Forms.Button b_Client;
    }
}

