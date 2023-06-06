namespace WindowsFormsApp1
{
    partial class Customer_panel2
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
            bt_update = new System.Windows.Forms.Button();
            search = new System.Windows.Forms.Label();
            bt_delete = new System.Windows.Forms.Button();
            txt_search = new System.Windows.Forms.TextBox();
            btn_Add = new System.Windows.Forms.Button();
            dgv_customer = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name_T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(bt_update);
            panel2.Controls.Add(search);
            panel2.Controls.Add(bt_delete);
            panel2.Controls.Add(txt_search);
            panel2.Controls.Add(btn_Add);
            panel2.Location = new System.Drawing.Point(75, 144);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(840, 108);
            panel2.TabIndex = 1;
            // 
            // bt_update
            // 
            bt_update.BackColor = System.Drawing.Color.WhiteSmoke;
            bt_update.Location = new System.Drawing.Point(89, 34);
            bt_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bt_update.Name = "bt_update";
            bt_update.Size = new System.Drawing.Size(67, 38);
            bt_update.TabIndex = 13;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = false;
            bt_update.Click += bt_update_Click;
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search.Location = new System.Drawing.Point(312, 36);
            search.Name = "search";
            search.Size = new System.Drawing.Size(74, 28);
            search.TabIndex = 7;
            search.Text = "Search:";
            // 
            // bt_delete
            // 
            bt_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            bt_delete.Location = new System.Drawing.Point(162, 34);
            bt_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new System.Drawing.Size(61, 38);
            bt_delete.TabIndex = 6;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(402, 36);
            txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(215, 27);
            txt_search.TabIndex = 4;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            btn_Add.Location = new System.Drawing.Point(16, 34);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(67, 38);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // dgv_customer
            // 
            dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Name_T, address, Phone, Created_At });
            dgv_customer.Location = new System.Drawing.Point(0, 300);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 62;
            dgv_customer.RowTemplate.Height = 28;
            dgv_customer.Size = new System.Drawing.Size(1302, 551);
            dgv_customer.TabIndex = 2;
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
            // Customer_panel2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgv_customer);
            Controls.Add(panel2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Customer_panel2";
            Size = new System.Drawing.Size(1302, 851);
            Load += Customer_panel2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
        private System.Windows.Forms.Button bt_update;
    }
}