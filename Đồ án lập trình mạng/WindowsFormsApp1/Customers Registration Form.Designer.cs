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
            panel2.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel2.Location = new System.Drawing.Point(169, 119);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(579, 225);
            panel2.TabIndex = 1;
            // 
            // txt_phone
            // 
            txt_phone.Font = new System.Drawing.Font("Qaz", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_phone.Location = new System.Drawing.Point(246, 154);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new System.Drawing.Size(308, 35);
            txt_phone.TabIndex = 5;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_address
            // 
            txt_address.Font = new System.Drawing.Font("Qaz", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_address.Location = new System.Drawing.Point(246, 88);
            txt_address.Name = "txt_address";
            txt_address.Size = new System.Drawing.Size(308, 35);
            txt_address.TabIndex = 4;
            // 
            // txt_name
            // 
            txt_name.Font = new System.Drawing.Font("Qaz", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name.Location = new System.Drawing.Point(246, 22);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(308, 35);
            txt_name.TabIndex = 3;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_phone.Location = new System.Drawing.Point(29, 171);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new System.Drawing.Size(82, 24);
            lb_phone.TabIndex = 2;
            lb_phone.Text = "Phone:";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_address.Location = new System.Drawing.Point(29, 102);
            lb_address.Name = "lb_address";
            lb_address.Size = new System.Drawing.Size(110, 24);
            lb_address.TabIndex = 1;
            lb_address.Text = "Address:";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_name.Location = new System.Drawing.Point(29, 33);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(77, 24);
            lb_name.TabIndex = 0;
            lb_name.Text = "Name:";
            // 
            // bt_add
            // 
            bt_add.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_add.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_add.Location = new System.Drawing.Point(312, 364);
            bt_add.Name = "bt_add";
            bt_add.Size = new System.Drawing.Size(118, 55);
            bt_add.TabIndex = 2;
            bt_add.Text = "Add";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // Delete
            // 
            Delete.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Delete.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Delete.Location = new System.Drawing.Point(486, 364);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(118, 55);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 47.9999924F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(1, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(917, 102);
            label1.TabIndex = 6;
            label1.Text = "Customer Registration";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Customers_Registration_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            ClientSize = new System.Drawing.Size(917, 491);
            Controls.Add(label1);
            Controls.Add(Delete);
            Controls.Add(bt_add);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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