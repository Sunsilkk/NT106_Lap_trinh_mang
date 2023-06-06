namespace WindowsFormsApp1
{
    partial class Product_panel2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            txt_search = new System.Windows.Forms.TextBox();
            btn_Add = new System.Windows.Forms.Button();
            bt_delete = new System.Windows.Forms.Button();
            dgv_product = new System.Windows.Forms.DataGridView();
            search = new System.Windows.Forms.Label();
            bt_update = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Pet_type_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            SuspendLayout();
            // 
            // txt_search
            // 
            txt_search.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            txt_search.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_search.Location = new System.Drawing.Point(925, 218);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(189, 28);
            txt_search.TabIndex = 6;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btn_Add.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Add.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Add.Location = new System.Drawing.Point(63, 209);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(86, 42);
            btn_Add.TabIndex = 5;
            btn_Add.Text = "(+)";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // bt_delete
            // 
            bt_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bt_delete.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            bt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_delete.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_delete.Location = new System.Drawing.Point(171, 209);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new System.Drawing.Size(86, 42);
            bt_delete.TabIndex = 8;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // dgv_product
            // 
            dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.BackgroundColor = System.Drawing.Color.FromArgb(249, 224, 187);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Type_Name, Pet_type_Name, Name_pro, Stock, Price, Created_At });
            dgv_product.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgv_product.Location = new System.Drawing.Point(0, 267);
            dgv_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgv_product.Name = "dgv_product";
            dgv_product.RowHeadersWidth = 62;
            dgv_product.RowTemplate.Height = 28;
            dgv_product.Size = new System.Drawing.Size(1129, 468);
            dgv_product.TabIndex = 9;
            // 
            // search
            // 
            search.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            search.AutoSize = true;
            search.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search.Location = new System.Drawing.Point(825, 223);
            search.Name = "search";
            search.Size = new System.Drawing.Size(83, 21);
            search.TabIndex = 10;
            search.Text = "Search:";
            // 
            // bt_update
            // 
            bt_update.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bt_update.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            bt_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_update.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_update.Location = new System.Drawing.Point(289, 209);
            bt_update.Name = "bt_update";
            bt_update.Size = new System.Drawing.Size(86, 42);
            bt_update.TabIndex = 12;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = false;
            bt_update.Click += bt_update_Click;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1129, 140);
            label1.TabIndex = 13;
            label1.Text = "Product";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Type_Name
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            Type_Name.DefaultCellStyle = dataGridViewCellStyle3;
            Type_Name.HeaderText = "Product Type Name";
            Type_Name.MinimumWidth = 8;
            Type_Name.Name = "Type_Name";
            // 
            // Pet_type_Name
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            Pet_type_Name.DefaultCellStyle = dataGridViewCellStyle4;
            Pet_type_Name.HeaderText = "Pet type Name";
            Pet_type_Name.MinimumWidth = 8;
            Pet_type_Name.Name = "Pet_type_Name";
            // 
            // Name_pro
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            Name_pro.DefaultCellStyle = dataGridViewCellStyle5;
            Name_pro.HeaderText = "Name";
            Name_pro.MinimumWidth = 8;
            Name_pro.Name = "Name_pro";
            // 
            // Stock
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            Stock.DefaultCellStyle = dataGridViewCellStyle6;
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // Price
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            Price.DefaultCellStyle = dataGridViewCellStyle7;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Created_At
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            Created_At.DefaultCellStyle = dataGridViewCellStyle8;
            Created_At.HeaderText = "Created At";
            Created_At.MinimumWidth = 6;
            Created_At.Name = "Created_At";
            // 
            // Product_panel2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            Controls.Add(label1);
            Controls.Add(bt_update);
            Controls.Add(search);
            Controls.Add(dgv_product);
            Controls.Add(bt_delete);
            Controls.Add(txt_search);
            Controls.Add(btn_Add);
            Name = "Product_panel2";
            Size = new System.Drawing.Size(1129, 735);
            Load += Product_panel2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pet_type_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
    }
}