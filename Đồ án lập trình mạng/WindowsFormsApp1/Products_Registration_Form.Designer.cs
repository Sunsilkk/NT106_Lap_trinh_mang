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
            this.Delete = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_product_type_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_id = new System.Windows.Forms.Label();
            this.txt_pet_type_id = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_pet_type = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_type = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pet_type)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_type)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(528, 361);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 36);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(324, 361);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(108, 36);
            this.bt_add.TabIndex = 6;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_product_type_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Product_id);
            this.panel2.Controls.Add(this.txt_pet_type_id);
            this.panel2.Controls.Add(this.txt_price);
            this.panel2.Controls.Add(this.txt_stock);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.lb_phone);
            this.panel2.Controls.Add(this.lb_address);
            this.panel2.Controls.Add(this.lb_name);
            this.panel2.Location = new System.Drawing.Point(27, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 246);
            this.panel2.TabIndex = 5;
            // 
            // txt_product_type_id
            // 
            this.txt_product_type_id.Enabled = false;
            this.txt_product_type_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_type_id.Location = new System.Drawing.Point(187, 148);
            this.txt_product_type_id.Name = "txt_product_type_id";
            this.txt_product_type_id.Size = new System.Drawing.Size(176, 30);
            this.txt_product_type_id.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pet Type Id:";
            // 
            // Product_id
            // 
            this.Product_id.AutoSize = true;
            this.Product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_id.Location = new System.Drawing.Point(15, 151);
            this.Product_id.Name = "Product_id";
            this.Product_id.Size = new System.Drawing.Size(166, 25);
            this.Product_id.TabIndex = 8;
            this.Product_id.Text = "Product Types Id:";
            // 
            // txt_pet_type_id
            // 
            this.txt_pet_type_id.Enabled = false;
            this.txt_pet_type_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pet_type_id.Location = new System.Drawing.Point(153, 202);
            this.txt_pet_type_id.Name = "txt_pet_type_id";
            this.txt_pet_type_id.Size = new System.Drawing.Size(210, 30);
            this.txt_pet_type_id.TabIndex = 7;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(308, 102);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(55, 30);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(117, 102);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(53, 30);
            this.txt_stock.TabIndex = 4;
            this.txt_stock.TextChanged += new System.EventHandler(this.txt_stock_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(117, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(246, 30);
            this.txt_name.TabIndex = 3;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(240, 102);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(62, 25);
            this.lb_phone.TabIndex = 2;
            this.lb_phone.Text = "Price:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(15, 102);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(49, 25);
            this.lb_address.TabIndex = 1;
            this.lb_address.Text = "Qty:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(15, 44);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(70, 25);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 61);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_pet_type);
            this.panel3.Location = new System.Drawing.Point(491, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 225);
            this.panel3.TabIndex = 6;
            // 
            // dgv_pet_type
            // 
            this.dgv_pet_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pet_type.Location = new System.Drawing.Point(0, 1);
            this.dgv_pet_type.Name = "dgv_pet_type";
            this.dgv_pet_type.RowHeadersWidth = 51;
            this.dgv_pet_type.RowTemplate.Height = 24;
            this.dgv_pet_type.Size = new System.Drawing.Size(246, 225);
            this.dgv_pet_type.TabIndex = 0;
            this.dgv_pet_type.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pet_type_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_type);
            this.panel4.Location = new System.Drawing.Point(770, 106);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 225);
            this.panel4.TabIndex = 7;
            // 
            // dgv_type
            // 
            this.dgv_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_type.Location = new System.Drawing.Point(0, -1);
            this.dgv_type.Name = "dgv_type";
            this.dgv_type.RowHeadersWidth = 51;
            this.dgv_type.RowTemplate.Height = 24;
            this.dgv_type.Size = new System.Drawing.Size(246, 226);
            this.dgv_type.TabIndex = 1;
            this.dgv_type.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_type_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pet Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(765, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Product Type:";
            // 
            // Products_Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 425);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Products_Registration_Form";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Registration_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pet_type)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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