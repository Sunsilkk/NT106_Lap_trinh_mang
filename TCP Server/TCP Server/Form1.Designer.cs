namespace TCP_Server
{
    partial class Form1
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
            this.lsMessage = new System.Windows.Forms.ListView();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.b_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsMessage
            // 
            this.lsMessage.HideSelection = false;
            this.lsMessage.Location = new System.Drawing.Point(33, 12);
            this.lsMessage.Name = "lsMessage";
            this.lsMessage.Size = new System.Drawing.Size(649, 286);
            this.lsMessage.TabIndex = 0;
            this.lsMessage.UseCompatibleStateImageBehavior = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(51, 355);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(387, 20);
            this.txtMessage.TabIndex = 1;
            // 
            // b_Send
            // 
            this.b_Send.Location = new System.Drawing.Point(555, 344);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(155, 58);
            this.b_Send.TabIndex = 2;
            this.b_Send.Text = "button1";
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.b_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lsMessage);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button b_Send;
    }
}

