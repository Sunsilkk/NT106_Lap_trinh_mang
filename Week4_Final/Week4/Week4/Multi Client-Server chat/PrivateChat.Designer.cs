namespace Multi_Client_Server_chat
{
    partial class PrivateChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateChat));
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.fileChooser = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.privateRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.messageTextBox.Location = new System.Drawing.Point(12, 399);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(546, 39);
            this.messageTextBox.TabIndex = 1;
            this.messageTextBox.Text = "";
            // 
            // fileChooser
            // 
            this.fileChooser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileChooser.Location = new System.Drawing.Point(577, 399);
            this.fileChooser.Name = "fileChooser";
            this.fileChooser.Size = new System.Drawing.Size(75, 39);
            this.fileChooser.TabIndex = 2;
            this.fileChooser.Text = "...";
            this.fileChooser.UseVisualStyleBackColor = true;
            this.fileChooser.Click += new System.EventHandler(this.fileChooser_Click);
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(667, 399);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(106, 39);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // privateRichTextBox
            // 
            this.privateRichTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.privateRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.privateRichTextBox.Name = "privateRichTextBox";
            this.privateRichTextBox.Size = new System.Drawing.Size(761, 381);
            this.privateRichTextBox.TabIndex = 4;
            this.privateRichTextBox.Text = "";
            this.privateRichTextBox.TextChanged += new System.EventHandler(this.privateRichTextBox_TextChanged);
            // 
            // PrivateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.privateRichTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.fileChooser);
            this.Controls.Add(this.messageTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrivateChat";
            this.Text = "Private Chat";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.Button fileChooser;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox privateRichTextBox;
    }
}