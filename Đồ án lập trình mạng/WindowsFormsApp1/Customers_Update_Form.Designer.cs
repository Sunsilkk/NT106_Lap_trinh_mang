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
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // dgv_customer
            // 
            dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Name_T, address, Phone, Created_At });
            dgv_customer.Location = new System.Drawing.Point(12, 164);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 62;
            dgv_customer.RowTemplate.Height = 28;
            dgv_customer.Size = new System.Drawing.Size(825, 290);
            dgv_customer.TabIndex = 37;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // Name_T
            // 
            Name_T.HeaderText = "Name";
            Name_T.MinimumWidth = 8;
            Name_T.Name = "Name_T";
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 8;
            address.Name = "address";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            // 
            // Created_At
            // 
            Created_At.HeaderText = "Created At";
            Created_At.MinimumWidth = 6;
            Created_At.Name = "Created_At";
            // 
            // bt_update
            // 
            bt_update.Location = new System.Drawing.Point(434, 56);
            bt_update.Name = "bt_update";
            bt_update.Size = new System.Drawing.Size(89, 35);
            bt_update.TabIndex = 45;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(641, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 36);
            label2.TabIndex = 44;
            label2.Text = "Update";
            // 
            // txt_phone
            // 
            txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_phone.Location = new System.Drawing.Point(157, 111);
            txt_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new System.Drawing.Size(246, 30);
            txt_phone.TabIndex = 43;
            txt_phone.TextChanged += txt_phone_TextChanged;
            // 
            // txt_address
            // 
            txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_address.Location = new System.Drawing.Point(157, 71);
            txt_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_address.Name = "txt_address";
            txt_address.Size = new System.Drawing.Size(246, 30);
            txt_address.TabIndex = 42;
            // 
            // txt_name
            // 
            txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name.Location = new System.Drawing.Point(157, 27);
            txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(246, 30);
            txt_name.TabIndex = 41;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_phone.Location = new System.Drawing.Point(28, 111);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new System.Drawing.Size(89, 29);
            lb_phone.TabIndex = 40;
            lb_phone.Text = "Phone:";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_address.Location = new System.Drawing.Point(28, 71);
            lb_address.Name = "lb_address";
            lb_address.Size = new System.Drawing.Size(108, 29);
            lb_address.TabIndex = 39;
            lb_address.Text = "Address:";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_name.Location = new System.Drawing.Point(28, 27);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(84, 29);
            lb_name.TabIndex = 38;
            lb_name.Text = "Name:";
            // 
            // Customers_Update_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(857, 510);
            Controls.Add(dgv_customer);
            Controls.Add(bt_update);
            Controls.Add(label2);
            Controls.Add(txt_phone);
            Controls.Add(txt_address);
            Controls.Add(txt_name);
            Controls.Add(lb_phone);
            Controls.Add(lb_address);
            Controls.Add(lb_name);
            Name = "Customers_Update_Form";
            Text = "Customers_Update_Form";
            Load += Customers_Update_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
    }
}