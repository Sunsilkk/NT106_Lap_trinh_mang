namespace FTP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Download = new System.Windows.Forms.Button();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Pickfile = new System.Windows.Forms.Button();
            this.btn_View = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.lbl_Wrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP FTP Sever:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(162, 29);
            this.txt_host.Multiline = true;
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(476, 33);
            this.txt_host.TabIndex = 3;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(162, 168);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(476, 33);
            this.txt_password.TabIndex = 5;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(162, 103);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(476, 33);
            this.txt_username.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Remote Site:";
            // 
            // btn_Upload
            // 
            this.btn_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.Location = new System.Drawing.Point(1029, 401);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(182, 52);
            this.btn_Upload.TabIndex = 10;
            this.btn_Upload.Text = "UPLOAD";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Download.Location = new System.Drawing.Point(1029, 552);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(182, 52);
            this.btn_Download.TabIndex = 11;
            this.btn_Download.Text = "DOWNLOAD";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(162, 263);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(476, 33);
            this.txt_url.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "File to Upload:";
            // 
            // btn_Pickfile
            // 
            this.btn_Pickfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pickfile.Location = new System.Drawing.Point(679, 263);
            this.btn_Pickfile.Name = "btn_Pickfile";
            this.btn_Pickfile.Size = new System.Drawing.Size(49, 33);
            this.btn_Pickfile.TabIndex = 14;
            this.btn_Pickfile.Text = "...";
            this.btn_Pickfile.UseVisualStyleBackColor = true;
            this.btn_Pickfile.Click += new System.EventHandler(this.btn_Pickfile_Click);
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(1029, 683);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(182, 52);
            this.btn_View.TabIndex = 15;
            this.btn_View.Text = "VIEW";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // lv
            // 
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(42, 401);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(893, 334);
            this.lv.TabIndex = 16;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Wrong
            // 
            this.lbl_Wrong.AutoSize = true;
            this.lbl_Wrong.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Wrong.ForeColor = System.Drawing.Color.Red;
            this.lbl_Wrong.Location = new System.Drawing.Point(167, 318);
            this.lbl_Wrong.Name = "lbl_Wrong";
            this.lbl_Wrong.Size = new System.Drawing.Size(0, 21);
            this.lbl_Wrong.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 764);
            this.Controls.Add(this.lbl_Wrong);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btn_Pickfile);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Pickfile;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Label lbl_Wrong;
    }
}

