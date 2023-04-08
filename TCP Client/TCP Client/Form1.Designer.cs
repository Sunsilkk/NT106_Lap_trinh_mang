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
            this.b_gửi = new System.Windows.Forms.Button();
            this.lsMessage = new System.Windows.Forms.ListView();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_gửi
            // 
            this.b_gửi.Location = new System.Drawing.Point(639, 343);
            this.b_gửi.Margin = new System.Windows.Forms.Padding(2);
            this.b_gửi.Name = "b_gửi";
            this.b_gửi.Size = new System.Drawing.Size(89, 68);
            this.b_gửi.TabIndex = 0;
            this.b_gửi.Text = "button1";
            this.b_gửi.UseVisualStyleBackColor = true;
            this.b_gửi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsMessage
            // 
            this.lsMessage.HideSelection = false;
            this.lsMessage.Location = new System.Drawing.Point(40, 23);
            this.lsMessage.Name = "lsMessage";
            this.lsMessage.Size = new System.Drawing.Size(688, 272);
            this.lsMessage.TabIndex = 1;
            this.lsMessage.UseCompatibleStateImageBehavior = false;
            this.lsMessage.View = System.Windows.Forms.View.List;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(40, 368);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(367, 20);
            this.txtMessage.TabIndex = 2;
            // 
            // TCP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lsMessage);
            this.Controls.Add(this.b_gửi);
            this.Name = "TCP_Client";
            this.Text = "TCP Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TCP_Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_gửi;
        private System.Windows.Forms.ListView lsMessage;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

