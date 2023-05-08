namespace Multi_Client_Server_chat
{
    partial class Client
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
            this.rMessage = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.b_Connect = new System.Windows.Forms.Button();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_Send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.endpointListView = new System.Windows.Forms.ListView();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b_Disconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rMessage
            // 
            this.rMessage.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rMessage.Location = new System.Drawing.Point(12, 42);
            this.rMessage.Name = "rMessage";
            this.rMessage.ReadOnly = true;
            this.rMessage.Size = new System.Drawing.Size(492, 380);
            this.rMessage.TabIndex = 0;
            this.rMessage.Text = "";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(9, 466);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 29);
            this.txtName.TabIndex = 1;
            // 
            // b_Connect
            // 
            this.b_Connect.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Connect.Location = new System.Drawing.Point(373, 462);
            this.b_Connect.Name = "b_Connect";
            this.b_Connect.Size = new System.Drawing.Size(95, 37);
            this.b_Connect.TabIndex = 2;
            this.b_Connect.Text = "Connect";
            this.b_Connect.UseVisualStyleBackColor = true;
            this.b_Connect.Click += new System.EventHandler(this.b_Connect_Click);
            // 
            // txtMessages
            // 
            this.txtMessages.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMessages.Location = new System.Drawing.Point(9, 532);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(358, 27);
            this.txtMessages.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Participants";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "YourName";
            // 
            // b_Send
            // 
            this.b_Send.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Send.Location = new System.Drawing.Point(373, 528);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(95, 37);
            this.b_Send.TabIndex = 8;
            this.b_Send.Text = "Send";
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.b_Send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Messages";
            // 
            // endpointListView
            // 
            this.endpointListView.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.endpointListView.HideSelection = false;
            this.endpointListView.Location = new System.Drawing.Point(510, 42);
            this.endpointListView.Name = "endpointListView";
            this.endpointListView.Size = new System.Drawing.Size(195, 380);
            this.endpointListView.TabIndex = 10;
            this.endpointListView.UseCompatibleStateImageBehavior = false;
            this.endpointListView.Click += new System.EventHandler(this.endpointListView_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIPAddress.Location = new System.Drawing.Point(180, 467);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(187, 29);
            this.txtIPAddress.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "IPAddress";
            // 
            // b_Disconnect
            // 
            this.b_Disconnect.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Disconnect.Location = new System.Drawing.Point(474, 462);
            this.b_Disconnect.Name = "b_Disconnect";
            this.b_Disconnect.Size = new System.Drawing.Size(114, 37);
            this.b_Disconnect.TabIndex = 13;
            this.b_Disconnect.Text = "Disconnect";
            this.b_Disconnect.UseVisualStyleBackColor = true;
            this.b_Disconnect.Click += new System.EventHandler(this.b_Disconnect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 577);
            this.Controls.Add(this.b_Disconnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.endpointListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.b_Connect);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rMessage);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rMessage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button b_Connect;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_Send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView endpointListView;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_Disconnect;
    }
}