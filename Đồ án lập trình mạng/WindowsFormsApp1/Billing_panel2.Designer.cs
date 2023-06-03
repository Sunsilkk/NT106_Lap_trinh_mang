namespace WindowsFormsApp1
{
    partial class Billing_panel2
    {
        private const string V = "Billing";

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
            this.bt_Add_Product = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.dgv_Billing = new System.Windows.Forms.DataGridView();
            this.NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_Select = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Qty = new System.Windows.Forms.ComboBox();
            this.bt_Cash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Billing)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Add_Product
            // 
            this.bt_Add_Product.Location = new System.Drawing.Point(26, 26);
            this.bt_Add_Product.Name = "bt_Add_Product";
            this.bt_Add_Product.Size = new System.Drawing.Size(41, 31);
            this.bt_Add_Product.TabIndex = 0;
            this.bt_Add_Product.Text = "(+)";
            this.bt_Add_Product.UseVisualStyleBackColor = true;
            this.bt_Add_Product.Click += new System.EventHandler(this.bt_Add_Product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(773, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total: ";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(843, 26);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(33, 20);
            this.lb_total.TabIndex = 3;
            this.lb_total.Text = "null";
            // 
            // dgv_Billing
            // 
            this.dgv_Billing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Billing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NO,
            this.dgv_Name,
            this.Type,
            this.Category,
            this.Qty,
            this.Price});
            this.dgv_Billing.Location = new System.Drawing.Point(0, 63);
            this.dgv_Billing.Name = "dgv_Billing";
            this.dgv_Billing.RowHeadersWidth = 62;
            this.dgv_Billing.RowTemplate.Height = 28;
            this.dgv_Billing.Size = new System.Drawing.Size(971, 452);
            this.dgv_Billing.TabIndex = 4;
            // 
            // NO
            // 
            this.NO.HeaderText = "NO";
            this.NO.MinimumWidth = 8;
            this.NO.Name = "NO";
            this.NO.Width = 150;
            // 
            // dgv_Name
            // 
            this.dgv_Name.HeaderText = "Name";
            this.dgv_Name.MinimumWidth = 8;
            this.dgv_Name.Name = "dgv_Name";
            this.dgv_Name.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.Width = 150;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 8;
            this.Qty.Name = "Qty";
            this.Qty.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // cb_Select
            // 
            this.cb_Select.FormattingEnabled = true;
            this.cb_Select.Location = new System.Drawing.Point(330, 26);
            this.cb_Select.Name = "cb_Select";
            this.cb_Select.Size = new System.Drawing.Size(121, 28);
            this.cb_Select.TabIndex = 5;
            this.cb_Select.SelectedIndexChanged += new System.EventHandler(this.cb_Select_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // cb_Qty
            // 
            this.cb_Qty.FormattingEnabled = true;
            this.cb_Qty.Location = new System.Drawing.Point(557, 26);
            this.cb_Qty.Name = "cb_Qty";
            this.cb_Qty.Size = new System.Drawing.Size(121, 28);
            this.cb_Qty.TabIndex = 8;
            // 
            // bt_Cash
            // 
            this.bt_Cash.Location = new System.Drawing.Point(403, 548);
            this.bt_Cash.Name = "bt_Cash";
            this.bt_Cash.Size = new System.Drawing.Size(192, 48);
            this.bt_Cash.TabIndex = 9;
            this.bt_Cash.Text = "Cash";
            this.bt_Cash.UseVisualStyleBackColor = true;
            this.bt_Cash.Click += new System.EventHandler(this.bt_Cash_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 608);
            this.Controls.Add(this.bt_Cash);
            this.Controls.Add(this.cb_Qty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Select);
            this.Controls.Add(this.dgv_Billing);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Add_Product);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Billing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Add_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Billing;
        private System.Windows.Forms.ComboBox cb_Select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Qty;
        private System.Windows.Forms.Button bt_Cash;
        public System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}