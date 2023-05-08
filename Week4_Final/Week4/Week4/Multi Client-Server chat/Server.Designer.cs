namespace Multi_Client_Server_chat
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.rMessage = new System.Windows.Forms.RichTextBox();
            this.b_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.b_Send = new System.Windows.Forms.Button();
            this.endpointListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rMessage
            // 
            this.rMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rMessage.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rMessage.Location = new System.Drawing.Point(12, 33);
            this.rMessage.Name = "rMessage";
            this.rMessage.ReadOnly = true;
            this.rMessage.Size = new System.Drawing.Size(451, 327);
            this.rMessage.TabIndex = 1;
            this.rMessage.Text = "";
            // 
            // b_Start
            // 
            this.b_Start.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Start.Location = new System.Drawing.Point(553, 21);
            this.b_Start.Name = "b_Start";
            this.b_Start.Size = new System.Drawing.Size(81, 31);
            this.b_Start.TabIndex = 2;
            this.b_Start.Text = "Start";
            this.b_Start.UseVisualStyleBackColor = true;
            this.b_Start.Click += new System.EventHandler(this.b_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client IP";
            // 
            // txtMessages
            // 
            this.txtMessages.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMessages.Location = new System.Drawing.Point(12, 366);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(451, 27);
            this.txtMessages.TabIndex = 5;
            // 
            // b_Send
            // 
            this.b_Send.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Send.Location = new System.Drawing.Point(469, 363);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(112, 33);
            this.b_Send.TabIndex = 6;
            this.b_Send.Text = "Send";
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.b_Send_Click);
            // 
            // endpointListView
            // 
            this.endpointListView.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.endpointListView.HideSelection = false;
            this.endpointListView.Location = new System.Drawing.Point(469, 57);
            this.endpointListView.Name = "endpointListView";
            this.endpointListView.Size = new System.Drawing.Size(191, 303);
            this.endpointListView.TabIndex = 7;
            this.endpointListView.UseCompatibleStateImageBehavior = false;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 408);
            this.Controls.Add(this.endpointListView);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Start);
            this.Controls.Add(this.rMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rMessage;
        private System.Windows.Forms.Button b_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button b_Send;
        private System.Windows.Forms.ListView endpointListView;
    }
}