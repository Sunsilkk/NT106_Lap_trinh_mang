namespace WindowsFormsApp1
{
    partial class Products_Registration_Form
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
            Delete = new System.Windows.Forms.Button();
            bt_add = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            txt_product_type_id = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            Product_id = new System.Windows.Forms.Label();
            txt_pet_type_id = new System.Windows.Forms.TextBox();
            txt_price = new System.Windows.Forms.TextBox();
            txt_stock = new System.Windows.Forms.TextBox();
            txt_name = new System.Windows.Forms.TextBox();
            lb_phone = new System.Windows.Forms.Label();
            lb_address = new System.Windows.Forms.Label();
            lb_name = new System.Windows.Forms.Label();
            dgv_pet_type = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NAME_t = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgv_type = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            PET_TYPE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PET_T_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_pet_type).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_type).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Delete.Location = new System.Drawing.Point(753, 679);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(96, 43);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // bt_add
            // 
            bt_add.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_add.Location = new System.Drawing.Point(597, 679);
            bt_add.Name = "bt_add";
            bt_add.Size = new System.Drawing.Size(96, 43);
            bt_add.TabIndex = 6;
            bt_add.Text = "Add";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_product_type_id);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Product_id);
            panel2.Controls.Add(txt_pet_type_id);
            panel2.Controls.Add(txt_price);
            panel2.Controls.Add(txt_stock);
            panel2.Controls.Add(txt_name);
            panel2.Controls.Add(lb_phone);
            panel2.Controls.Add(lb_address);
            panel2.Controls.Add(lb_name);
            panel2.Location = new System.Drawing.Point(239, 98);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(966, 265);
            panel2.TabIndex = 5;
            // 
            // txt_product_type_id
            // 
            txt_product_type_id.Enabled = false;
            txt_product_type_id.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_product_type_id.Location = new System.Drawing.Point(297, 147);
            txt_product_type_id.Name = "txt_product_type_id";
            txt_product_type_id.Size = new System.Drawing.Size(202, 34);
            txt_product_type_id.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 217);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(137, 24);
            label2.TabIndex = 9;
            label2.Text = "Pet Type Id:";
            // 
            // Product_id
            // 
            Product_id.AutoSize = true;
            Product_id.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Product_id.Location = new System.Drawing.Point(13, 162);
            Product_id.Name = "Product_id";
            Product_id.Size = new System.Drawing.Size(203, 24);
            Product_id.TabIndex = 8;
            Product_id.Text = "Product Types Id:";
            // 
            // txt_pet_type_id
            // 
            txt_pet_type_id.Enabled = false;
            txt_pet_type_id.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_pet_type_id.Location = new System.Drawing.Point(297, 205);
            txt_pet_type_id.Name = "txt_pet_type_id";
            txt_pet_type_id.Size = new System.Drawing.Size(202, 34);
            txt_pet_type_id.TabIndex = 7;
            // 
            // txt_price
            // 
            txt_price.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_price.Location = new System.Drawing.Point(552, 91);
            txt_price.Name = "txt_price";
            txt_price.Size = new System.Drawing.Size(72, 34);
            txt_price.TabIndex = 5;
            txt_price.TextChanged += txt_price_TextChanged;
            // 
            // txt_stock
            // 
            txt_stock.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_stock.Location = new System.Drawing.Point(297, 89);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new System.Drawing.Size(82, 34);
            txt_stock.TabIndex = 4;
            txt_stock.TextChanged += txt_stock_TextChanged;
            // 
            // txt_name
            // 
            txt_name.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name.Location = new System.Drawing.Point(297, 31);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(327, 34);
            txt_name.TabIndex = 3;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_phone.Location = new System.Drawing.Point(448, 96);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new System.Drawing.Size(72, 24);
            lb_phone.TabIndex = 2;
            lb_phone.Text = "Price:";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_address.Location = new System.Drawing.Point(13, 113);
            lb_address.Name = "lb_address";
            lb_address.Size = new System.Drawing.Size(107, 24);
            lb_address.TabIndex = 1;
            lb_address.Text = "Quantity";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_name.Location = new System.Drawing.Point(13, 41);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(173, 24);
            lb_name.TabIndex = 0;
            lb_name.Text = "Product Name:";
            // 
            // dgv_pet_type
            // 
            dgv_pet_type.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_pet_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pet_type.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, NAME_t });
            dgv_pet_type.Location = new System.Drawing.Point(0, 0);
            dgv_pet_type.Name = "dgv_pet_type";
            dgv_pet_type.RowHeadersWidth = 51;
            dgv_pet_type.RowTemplate.Height = 24;
            dgv_pet_type.Size = new System.Drawing.Size(452, 245);
            dgv_pet_type.TabIndex = 0;
            dgv_pet_type.CellClick += dgv_pet_type_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NAME_t
            // 
            NAME_t.HeaderText = "NAME";
            NAME_t.Name = "NAME_t";
            // 
            // dgv_type
            // 
            dgv_type.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_type.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { PET_TYPE_ID, PET_T_N });
            dgv_type.Location = new System.Drawing.Point(3, 3);
            dgv_type.Name = "dgv_type";
            dgv_type.RowHeadersWidth = 51;
            dgv_type.RowTemplate.Height = 24;
            dgv_type.Size = new System.Drawing.Size(452, 248);
            dgv_type.TabIndex = 1;
            dgv_type.CellClick += dgv_type_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(753, 379);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 24);
            label3.TabIndex = 8;
            label3.Text = "Pet Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Mouldy Cheese", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(239, 379);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(163, 24);
            label4.TabIndex = 9;
            label4.Text = "Product Type:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_pet_type);
            panel3.Location = new System.Drawing.Point(239, 406);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(452, 248);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgv_type);
            panel4.Location = new System.Drawing.Point(753, 406);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(452, 248);
            panel4.TabIndex = 7;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 47.9999924F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1445, 117);
            label1.TabIndex = 6;
            label1.Text = "Product Registration";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // PET_TYPE_ID
            // 
            PET_TYPE_ID.HeaderText = "ID";
            PET_TYPE_ID.Name = "PET_TYPE_ID";
            // 
            // PET_T_N
            // 
            PET_T_N.HeaderText = "NAME";
            PET_T_N.Name = "PET_T_N";
            // 
            // Products_Registration_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            ClientSize = new System.Drawing.Size(1445, 761);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(Delete);
            Controls.Add(bt_add);
            Controls.Add(panel2);
            Name = "Products_Registration_Form";
            Text = "Products";
            Load += Products_Registration_Form_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_pet_type).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_type).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Product_id;
        private System.Windows.Forms.TextBox txt_pet_type_id;
        private System.Windows.Forms.TextBox txt_product_type_id;
        private System.Windows.Forms.DataGridView dgv_pet_type;
        private System.Windows.Forms.DataGridView dgv_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_t;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_TYPE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_T_N;
    }
}