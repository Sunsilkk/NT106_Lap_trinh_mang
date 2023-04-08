namespace TCP_Client
{
    partial class TCP_Client
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
            this.b_Send = new System.Windows.Forms.Button();
            this.lsMessage = new System.Windows.Forms.ListView();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.b_Disconnect = new System.Windows.Forms.Button();
            this.b_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Send
            // 
            this.b_Send.Location = new System.Drawing.Point(430, 314);
            this.b_Send.Margin = new System.Windows.Forms.Padding(2);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(89, 68);
            this.b_Send.TabIndex = 0;
            this.b_Send.Text = "Gửi";
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsMessage
            // 
            this.lsMessage.HideSelection = false;
            this.lsMessage.Location = new System.Drawing.Point(22, 12);
            this.lsMessage.Name = "lsMessage";
            this.lsMessage.Size = new System.Drawing.Size(766, 269);
            this.lsMessage.TabIndex = 1;
            this.lsMessage.UseCompatibleStateImageBehavior = false;
            this.lsMessage.View = System.Windows.Forms.View.List;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(22, 339);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(384, 20);
            this.txtMessage.TabIndex = 2;
            // 
            // b_Disconnect
            // 
            this.b_Disconnect.Location = new System.Drawing.Point(662, 314);
            this.b_Disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.b_Disconnect.Name = "b_Disconnect";
            this.b_Disconnect.Size = new System.Drawing.Size(89, 68);
            this.b_Disconnect.TabIndex = 3;
            this.b_Disconnect.Text = "Huỷ kết nối";
            this.b_Disconnect.UseVisualStyleBackColor = true;
            this.b_Disconnect.Click += new System.EventHandler(this.b_Disconnect_Click);
            // 
            // b_Connect
            // 
            this.b_Connect.Location = new System.Drawing.Point(552, 314);
            this.b_Connect.Margin = new System.Windows.Forms.Padding(2);
            this.b_Connect.Name = "b_Connect";
            this.b_Connect.Size = new System.Drawing.Size(89, 68);
            this.b_Connect.TabIndex = 4;
            this.b_Connect.Text = "Kết nối";
            this.b_Connect.UseVisualStyleBackColor = true;
            this.b_Connect.Click += new System.EventHandler(this.b_Connect_Click);
            // 
            // TCP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Connect);
            this.Controls.Add(this.b_Disconnect);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lsMessage);
            this.Controls.Add(this.b_Send);
            this.Name = "TCP_Client";
            this.Text = "TCP Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCP_Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Send;
        private System.Windows.Forms.ListView lsMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button b_Disconnect;
        private System.Windows.Forms.Button b_Connect;
    }
}

