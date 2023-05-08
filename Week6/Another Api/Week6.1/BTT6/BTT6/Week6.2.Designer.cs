namespace BTT6
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
            this.bt_exit = new System.Windows.Forms.Button();
            this.ToDoList = new System.Windows.Forms.RichTextBox();
            this.bt_Get = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.IndianRed;
            this.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.ForeColor = System.Drawing.Color.Snow;
            this.bt_exit.Location = new System.Drawing.Point(737, 0);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(63, 42);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "x";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            this.bt_exit.MouseLeave += new System.EventHandler(this.bt_exit_MouseLeave);
            this.bt_exit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_exit_MouseMove);
            // 
            // ToDoList
            // 
            this.ToDoList.BackColor = System.Drawing.Color.FloralWhite;
            this.ToDoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToDoList.Location = new System.Drawing.Point(238, 48);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(363, 327);
            this.ToDoList.TabIndex = 1;
            this.ToDoList.Text = "";
            // 
            // bt_Get
            // 
            this.bt_Get.BackgroundImage = global::BTT6.Properties.Resources.dat;
            this.bt_Get.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Get.ForeColor = System.Drawing.Color.Black;
            this.bt_Get.Location = new System.Drawing.Point(622, 148);
            this.bt_Get.Name = "bt_Get";
            this.bt_Get.Size = new System.Drawing.Size(134, 43);
            this.bt_Get.TabIndex = 2;
            this.bt_Get.Text = "Get";
            this.bt_Get.UseVisualStyleBackColor = false;
            this.bt_Get.Click += new System.EventHandler(this.bt_Get_Click);
            // 
            // bt_Clear
            // 
            this.bt_Clear.BackColor = System.Drawing.Color.Transparent;
            this.bt_Clear.BackgroundImage = global::BTT6.Properties.Resources.xanhxanh1;
            this.bt_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Clear.Location = new System.Drawing.Point(622, 222);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(134, 43);
            this.bt_Clear.TabIndex = 3;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = false;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTT6.Properties.Resources.meo_800x600;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Get);
            this.Controls.Add(this.ToDoList);
            this.Controls.Add(this.bt_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.RichTextBox ToDoList;
        private System.Windows.Forms.Button bt_Get;
        private System.Windows.Forms.Button bt_Clear;
    }
}

