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
            txt_search = new System.Windows.Forms.TextBox();
            btn_Add = new System.Windows.Forms.Button();
            bt_delete = new System.Windows.Forms.Button();
            dgv_product = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Pet_type_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            search = new System.Windows.Forms.Label();
            bt_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            SuspendLayout();
            // 
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(693, 81);
            txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(215, 27);
            txt_search.TabIndex = 6;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            btn_Add.Location = new System.Drawing.Point(45, 81);
            btn_Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(67, 38);
            btn_Add.TabIndex = 5;
            btn_Add.Text = "(+)";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            bt_delete.Location = new System.Drawing.Point(191, 81);
            bt_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new System.Drawing.Size(67, 38);
            bt_delete.TabIndex = 8;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // dgv_product
            // 
            dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Type_Name, Pet_type_Name, Name_pro, Stock, Price, Created_At });
            dgv_product.Location = new System.Drawing.Point(0, 168);
            dgv_product.Name = "dgv_product";
            dgv_product.RowHeadersWidth = 62;
            dgv_product.RowTemplate.Height = 28;
            dgv_product.Size = new System.Drawing.Size(989, 401);
            dgv_product.TabIndex = 9;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // Type_Name
            // 
            Type_Name.HeaderText = "Product Type Name";
            Type_Name.MinimumWidth = 8;
            Type_Name.Name = "Type_Name";
            // 
            // Pet_type_Name
            // 
            Pet_type_Name.HeaderText = "Pet type Name";
            Pet_type_Name.MinimumWidth = 8;
            Pet_type_Name.Name = "Pet_type_Name";
            // 
            // Name_pro
            // 
            Name_pro.HeaderText = "Name";
            Name_pro.MinimumWidth = 8;
            Name_pro.Name = "Name_pro";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Created_At
            // 
            Created_At.HeaderText = "Created At";
            Created_At.MinimumWidth = 6;
            Created_At.Name = "Created_At";
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search.Location = new System.Drawing.Point(599, 80);
            search.Name = "search";
            search.Size = new System.Drawing.Size(74, 28);
            search.TabIndex = 10;
            search.Text = "Search:";
            // 
            // bt_update
            // 
            bt_update.BackColor = System.Drawing.Color.WhiteSmoke;
            bt_update.Location = new System.Drawing.Point(118, 81);
            bt_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bt_update.Name = "bt_update";
            bt_update.Size = new System.Drawing.Size(67, 38);
            bt_update.TabIndex = 12;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = false;
            bt_update.Click += bt_update_Click;
            // 
            // Product_panel2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(bt_update);
            Controls.Add(search);
            Controls.Add(dgv_product);
            Controls.Add(bt_delete);
            Controls.Add(txt_search);
            Controls.Add(btn_Add);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Product_panel2";
            Size = new System.Drawing.Size(1046, 591);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pet_type_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
    }
}