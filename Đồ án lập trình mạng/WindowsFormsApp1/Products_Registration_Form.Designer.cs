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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            dgv_pet_type = new System.Windows.Forms.DataGridView();
            panel4 = new System.Windows.Forms.Panel();
            dgv_type = new System.Windows.Forms.DataGridView();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_pet_type).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_type).BeginInit();
            SuspendLayout();
            // 
            // Delete
            // 
            Delete.Location = new System.Drawing.Point(660, 564);
            Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(135, 56);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new System.Drawing.Point(405, 564);
            bt_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            bt_add.Name = "bt_add";
            bt_add.Size = new System.Drawing.Size(135, 56);
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
            panel2.Location = new System.Drawing.Point(34, 131);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(540, 385);
            panel2.TabIndex = 5;
            // 
            // txt_product_type_id
            // 
            txt_product_type_id.Enabled = false;
            txt_product_type_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_product_type_id.Location = new System.Drawing.Point(234, 231);
            txt_product_type_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_product_type_id.Name = "txt_product_type_id";
            txt_product_type_id.Size = new System.Drawing.Size(219, 35);
            txt_product_type_id.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(19, 320);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 29);
            label2.TabIndex = 9;
            label2.Text = "Pet Type Id:";
            // 
            // Product_id
            // 
            Product_id.AutoSize = true;
            Product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Product_id.Location = new System.Drawing.Point(19, 236);
            Product_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Product_id.Name = "Product_id";
            Product_id.Size = new System.Drawing.Size(201, 29);
            Product_id.TabIndex = 8;
            Product_id.Text = "Product Types Id:";
            // 
            // txt_pet_type_id
            // 
            txt_pet_type_id.Enabled = false;
            txt_pet_type_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_pet_type_id.Location = new System.Drawing.Point(191, 315);
            txt_pet_type_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_pet_type_id.Name = "txt_pet_type_id";
            txt_pet_type_id.Size = new System.Drawing.Size(262, 35);
            txt_pet_type_id.TabIndex = 7;
            // 
            // txt_price
            // 
            txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_price.Location = new System.Drawing.Point(385, 160);
            txt_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_price.Name = "txt_price";
            txt_price.Size = new System.Drawing.Size(68, 35);
            txt_price.TabIndex = 5;
            txt_price.TextChanged += txt_price_TextChanged;
            // 
            // txt_stock
            // 
            txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_stock.Location = new System.Drawing.Point(146, 160);
            txt_stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new System.Drawing.Size(65, 35);
            txt_stock.TabIndex = 4;
            txt_stock.TextChanged += txt_stock_TextChanged;
            // 
            // txt_name
            // 
            txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name.Location = new System.Drawing.Point(146, 69);
            txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txt_name.Name = "txt_name";
            txt_name.Size = new System.Drawing.Size(306, 35);
            txt_name.TabIndex = 3;
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_phone.Location = new System.Drawing.Point(300, 160);
            lb_phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new System.Drawing.Size(75, 29);
            lb_phone.TabIndex = 2;
            lb_phone.Text = "Price:";
            // 
            // lb_address
            // 
            lb_address.AutoSize = true;
            lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_address.Location = new System.Drawing.Point(19, 160);
            lb_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_address.Name = "lb_address";
            lb_address.Size = new System.Drawing.Size(55, 29);
            lb_address.TabIndex = 1;
            lb_address.Text = "Qty:";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_name.Location = new System.Drawing.Point(19, 69);
            lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(84, 29);
            lb_name.TabIndex = 0;
            lb_name.Text = "Name:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1285, 95);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(234, 14);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(490, 48);
            label1.TabIndex = 6;
            label1.Text = "Product Registration";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_pet_type);
            panel3.Location = new System.Drawing.Point(614, 164);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(308, 351);
            panel3.TabIndex = 6;
            // 
            // dgv_pet_type
            // 
            dgv_pet_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pet_type.Location = new System.Drawing.Point(0, 1);
            dgv_pet_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgv_pet_type.Name = "dgv_pet_type";
            dgv_pet_type.RowHeadersWidth = 51;
            dgv_pet_type.RowTemplate.Height = 24;
            dgv_pet_type.Size = new System.Drawing.Size(308, 351);
            dgv_pet_type.TabIndex = 0;
            dgv_pet_type.CellClick += dgv_pet_type_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgv_type);
            panel4.Location = new System.Drawing.Point(962, 165);
            panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(308, 351);
            panel4.TabIndex = 7;
            // 
            // dgv_type
            // 
            dgv_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_type.Location = new System.Drawing.Point(0, -1);
            dgv_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dgv_type.Name = "dgv_type";
            dgv_type.RowHeadersWidth = 51;
            dgv_type.RowTemplate.Height = 24;
            dgv_type.Size = new System.Drawing.Size(308, 352);
            dgv_type.TabIndex = 1;
            dgv_type.CellClick += dgv_type_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(962, 120);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 29);
            label3.TabIndex = 8;
            label3.Text = "Pet Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(614, 120);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(163, 29);
            label4.TabIndex = 9;
            label4.Text = "Product Type:";
            // 
            // Products_Registration_Form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1285, 664);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(Delete);
            Controls.Add(bt_add);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Products_Registration_Form";
            Text = "Products";
            Load += Products_Registration_Form_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_pet_type).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_type).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Product_id;
        private System.Windows.Forms.TextBox txt_pet_type_id;
        private System.Windows.Forms.TextBox txt_product_type_id;
        private System.Windows.Forms.DataGridView dgv_pet_type;
        private System.Windows.Forms.DataGridView dgv_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}