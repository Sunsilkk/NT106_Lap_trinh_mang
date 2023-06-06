namespace WindowsFormsApp1
{
    partial class Customers_Registration_Form
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
            panel2 = new System.Windows.Forms.Panel();
            txt_phone = new System.Windows.Forms.TextBox();
            txt_address = new System.Windows.Forms.TextBox();
            txt_name = new System.Windows.Forms.TextBox();
            lb_phone = new System.Windows.Forms.Label();
            lb_address = new System.Windows.Forms.Label();
            lb_name = new System.Windows.Forms.Label();
            bt_add = new System.Windows.Forms.Button();
            Delete = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_phone);
            panel2.Controls.Add(txt_address);
            panel2.Controls.Add(txt_name);
            panel2.Controls.Add(lb_phone);
            panel2.Controls.Add(lb_address);
            panel2.Controls.Add(lb_name);
            panel2.Location = new System.Drawing.Point(89, 103);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(567, 300);
            panel2.TabIndex = 1;
            // 
            // txt_phone
            // 
            txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_phone.Location = new System.Drawing.Point(187, 205);
            txt_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new System.Drawing.Size(246, 30);
            txt_phone.TabIndex = 5;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_address
            // 
            txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_address.Location = new System.Drawing.Point(187, 117);
            txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_address.Name = "txt_address";
            txt_address.Size = new System.Drawing.Size(246, 30);
            txt_address.TabIndex = 4;
            // 
            // txt_name
            // 
            txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name.Location = new System.Drawing.Point(187, 33);
            txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(246, 30);
            txt_name.TabIndex = 3;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_phone.Location = new System.Drawing.Point(33, 211);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new System.Drawing.Size(89, 29);
            lb_phone.TabIndex = 2;
            lb_phone.Text = "Phone:";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_address.Location = new System.Drawing.Point(33, 117);
            lb_address.Name = "lb_address";
            lb_address.Size = new System.Drawing.Size(108, 29);
            lb_address.TabIndex = 1;
            lb_address.Text = "Address:";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_name.Location = new System.Drawing.Point(33, 33);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(84, 29);
            lb_name.TabIndex = 0;
            lb_name.Text = "Name:";
            // 
            // bt_add
            // 
            bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_add.Location = new System.Drawing.Point(194, 429);
            bt_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bt_add.Name = "bt_add";
            bt_add.Size = new System.Drawing.Size(107, 45);
            bt_add.TabIndex = 2;
            bt_add.Text = "Add";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // Delete
            // 
            Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Delete.Location = new System.Drawing.Point(398, 429);
            Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(109, 45);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.7499962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(1, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(755, 107);
            label1.TabIndex = 6;
            label1.Text = "Customer Registration";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customers_Registration_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(246, 241, 233);
            ClientSize = new System.Drawing.Size(755, 496);
            Controls.Add(label1);
            Controls.Add(Delete);
            Controls.Add(bt_add);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Customers_Registration_Form";
            Text = "Customers_Registration_Form";
            Load += Customers_Registration_Form_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
    }
}