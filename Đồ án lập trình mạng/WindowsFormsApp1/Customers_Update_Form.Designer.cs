namespace Pet_Management
{
    partial class Customers_Update_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv_customer = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name_T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bt_update = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txt_phone = new System.Windows.Forms.TextBox();
            txt_address = new System.Windows.Forms.TextBox();
            txt_name = new System.Windows.Forms.TextBox();
            lb_phone = new System.Windows.Forms.Label();
            lb_address = new System.Windows.Forms.Label();
            lb_name = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_customer
            // 
            dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.BackgroundColor = System.Drawing.Color.FromArgb(249, 224, 187);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Name_T, address, Phone, Created_At });
            dgv_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgv_customer.Location = new System.Drawing.Point(0, 426);
            dgv_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 62;
            dgv_customer.RowTemplate.Height = 28;
            dgv_customer.Size = new System.Drawing.Size(1311, 317);
            dgv_customer.TabIndex = 37;
            // 
            // ID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // Name_T
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            Name_T.DefaultCellStyle = dataGridViewCellStyle3;
            Name_T.HeaderText = "Name";
            Name_T.MinimumWidth = 8;
            Name_T.Name = "Name_T";
            // 
            // address
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            address.DefaultCellStyle = dataGridViewCellStyle4;
            address.HeaderText = "Address";
            address.MinimumWidth = 8;
            address.Name = "address";
            // 
            // Phone
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            Phone.DefaultCellStyle = dataGridViewCellStyle5;
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            // 
            // Created_At
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            Created_At.DefaultCellStyle = dataGridViewCellStyle6;
            Created_At.HeaderText = "Created At";
            Created_At.MinimumWidth = 6;
            Created_At.Name = "Created_At";
            // 
            // bt_update
            // 
            bt_update.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_update.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_update.Location = new System.Drawing.Point(1013, 207);
            bt_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bt_update.Name = "bt_update";
            bt_update.Size = new System.Drawing.Size(119, 57);
            bt_update.TabIndex = 45;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = false;
            bt_update.Click += bt_update_Click;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 47.9999924F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1311, 128);
            label2.TabIndex = 44;
            label2.Text = "Customer Update";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_phone
            // 
            txt_phone.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_phone.Location = new System.Drawing.Point(384, 181);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new System.Drawing.Size(402, 34);
            txt_phone.TabIndex = 43;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_address
            // 
            txt_address.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_address.Location = new System.Drawing.Point(384, 100);
            txt_address.Name = "txt_address";
            txt_address.Size = new System.Drawing.Size(402, 34);
            txt_address.TabIndex = 42;
            // 
            // txt_name
            // 
            txt_name.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name.Location = new System.Drawing.Point(384, 19);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(402, 34);
            txt_name.TabIndex = 41;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_phone.Location = new System.Drawing.Point(41, 191);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new System.Drawing.Size(175, 24);
            lb_phone.TabIndex = 40;
            lb_phone.Text = "Phone Number:";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_address.Location = new System.Drawing.Point(41, 105);
            lb_address.Name = "lb_address";
            lb_address.Size = new System.Drawing.Size(110, 24);
            lb_address.TabIndex = 39;
            lb_address.Text = "Address:";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_name.Location = new System.Drawing.Point(41, 19);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(192, 24);
            lb_name.TabIndex = 38;
            lb_name.Text = "Customer Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_address);
            panel1.Controls.Add(lb_name);
            panel1.Controls.Add(lb_address);
            panel1.Controls.Add(lb_phone);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_name);
            panel1.Location = new System.Drawing.Point(137, 120);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(878, 237);
            panel1.TabIndex = 46;
            // 
            // Customers_Update_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            ClientSize = new System.Drawing.Size(1311, 743);
            Controls.Add(bt_update);
            Controls.Add(dgv_customer);
            Controls.Add(panel1);
            Controls.Add(label2);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Customers_Update_Form";
            Text = "Customers_Update_Form";
            Load += Customers_Update_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
    }
}