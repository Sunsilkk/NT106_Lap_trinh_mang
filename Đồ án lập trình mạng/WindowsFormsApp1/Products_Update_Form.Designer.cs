namespace Pet_Management
{
    partial class Products_Update_Form
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
            label1 = new System.Windows.Forms.Label();
            dgv_product = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Pet_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bt_update = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txt_price = new System.Windows.Forms.TextBox();
            txt_stock = new System.Windows.Forms.TextBox();
            txt_name = new System.Windows.Forms.TextBox();
            lb_phone = new System.Windows.Forms.Label();
            lb_address = new System.Windows.Forms.Label();
            lb_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(444, -45);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 40);
            label1.TabIndex = 26;
            label1.Text = "Update";
            // 
            // dgv_product
            // 
            dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Type_Id, Pet_type_id, Name, Stock, Price, Created_At });
            dgv_product.Location = new System.Drawing.Point(39, 244);
            dgv_product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            dgv_product.Name = "dgv_product";
            dgv_product.RowHeadersWidth = 62;
            dgv_product.RowTemplate.Height = 28;
            dgv_product.Size = new System.Drawing.Size(1038, 389);
            dgv_product.TabIndex = 27;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Type_Id
            // 
            Type_Id.HeaderText = "Type Id";
            Type_Id.MinimumWidth = 8;
            Type_Id.Name = "Type_Id";
            Type_Id.Width = 200;
            // 
            // Pet_type_id
            // 
            Pet_type_id.HeaderText = "Pet type id";
            Pet_type_id.MinimumWidth = 8;
            Pet_type_id.Name = "Pet_type_id";
            Pet_type_id.Width = 200;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 200;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Created_At
            // 
            Created_At.HeaderText = "Created At";
            Created_At.MinimumWidth = 6;
            Created_At.Name = "Created_At";
            Created_At.Width = 125;
            // 
            // bt_update
            // 
            bt_update.Location = new System.Drawing.Point(501, 166);
            bt_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            bt_update.Name = "bt_update";
            bt_update.Size = new System.Drawing.Size(111, 44);
            bt_update.TabIndex = 35;
            bt_update.Text = "Update";
            bt_update.UseVisualStyleBackColor = true;
            bt_update.Click += bt_update_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(490, 25);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(153, 40);
            label2.TabIndex = 34;
            label2.Text = "Update";
            // 
            // txt_price
            // 
            txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_price.Location = new System.Drawing.Point(874, 120);
            txt_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_price.Name = "txt_price";
            txt_price.Size = new System.Drawing.Size(135, 35);
            txt_price.TabIndex = 33;
            // 
            // txt_stock
            // 
            txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_stock.Location = new System.Drawing.Point(636, 120);
            txt_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new System.Drawing.Size(116, 35);
            txt_stock.TabIndex = 32;
            txt_stock.TextChanged += txt_stock_TextChanged;
            // 
            // txt_name
            // 
            txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name.Location = new System.Drawing.Point(201, 120);
            txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(306, 35);
            txt_name.TabIndex = 31;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_phone.Location = new System.Drawing.Point(789, 120);
            lb_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new System.Drawing.Size(75, 29);
            lb_phone.TabIndex = 30;
            lb_phone.Text = "Price:";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_address.Location = new System.Drawing.Point(568, 120);
            lb_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_address.Name = "lb_address";
            lb_address.Size = new System.Drawing.Size(55, 29);
            lb_address.TabIndex = 29;
            lb_address.Text = "Qty:";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_name.Location = new System.Drawing.Point(74, 120);
            lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(84, 29);
            lb_name.TabIndex = 28;
            lb_name.Text = "Name:";
            // 
            // Products_Update_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1121, 648);
            Controls.Add(dgv_product);
            Controls.Add(bt_update);
            Controls.Add(label2);
            Controls.Add(txt_price);
            Controls.Add(txt_stock);
            Controls.Add(txt_name);
            Controls.Add(lb_phone);
            Controls.Add(lb_address);
            Controls.Add(lb_name);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            
            Load += Products_Update_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pet_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
    }
}