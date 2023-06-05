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
            bt_Add_Product = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lb_total = new System.Windows.Forms.Label();
            dgv_Billing = new System.Windows.Forms.DataGridView();
            NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dgv_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cb_Select = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cb_Qty = new System.Windows.Forms.ComboBox();
            bt_Cash = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Billing).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bt_Add_Product
            // 
            bt_Add_Product.Location = new System.Drawing.Point(38, 78);
            bt_Add_Product.Name = "bt_Add_Product";
            bt_Add_Product.Size = new System.Drawing.Size(67, 31);
            bt_Add_Product.TabIndex = 0;
            bt_Add_Product.Text = "(+)";
            bt_Add_Product.UseVisualStyleBackColor = true;
            bt_Add_Product.Click += bt_Add_Product_Click;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(136, 86);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label2.Location = new System.Drawing.Point(1016, 86);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Total: ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_total
            // 
            lb_total.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lb_total.Location = new System.Drawing.Point(1071, 86);
            lb_total.Name = "lb_total";
            lb_total.Size = new System.Drawing.Size(128, 15);
            lb_total.TabIndex = 3;
            lb_total.Text = "null";
            // 
            // dgv_Billing
            // 
            dgv_Billing.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_Billing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Billing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Billing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NO, dgv_Name, Type, Category, Qty, Price });
            dgv_Billing.Location = new System.Drawing.Point(0, 137);
            dgv_Billing.Name = "dgv_Billing";
            dgv_Billing.RowHeadersWidth = 62;
            dgv_Billing.RowTemplate.Height = 28;
            dgv_Billing.Size = new System.Drawing.Size(1266, 567);
            dgv_Billing.TabIndex = 4;
            dgv_Billing.CellContentClick += dgv_Billing_CellContentClick;
            // 
            // NO
            // 
            NO.HeaderText = "NO";
            NO.MinimumWidth = 8;
            NO.Name = "NO";
            // 
            // dgv_Name
            // 
            dgv_Name.HeaderText = "Name";
            dgv_Name.MinimumWidth = 8;
            dgv_Name.Name = "dgv_Name";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            // 
            // cb_Select
            // 
            cb_Select.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cb_Select.FormattingEnabled = true;
            cb_Select.Location = new System.Drawing.Point(365, 83);
            cb_Select.Name = "cb_Select";
            cb_Select.Size = new System.Drawing.Size(163, 23);
            cb_Select.TabIndex = 5;
            cb_Select.SelectedIndexChanged += cb_Select_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.Location = new System.Drawing.Point(266, 86);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 15);
            label3.TabIndex = 6;
            label3.Text = "Select Product";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.Location = new System.Drawing.Point(611, 86);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(93, 15);
            label4.TabIndex = 7;
            label4.Text = "Quantity";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_Qty
            // 
            cb_Qty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cb_Qty.FormattingEnabled = true;
            cb_Qty.Location = new System.Drawing.Point(715, 83);
            cb_Qty.Name = "cb_Qty";
            cb_Qty.Size = new System.Drawing.Size(163, 23);
            cb_Qty.TabIndex = 8;
            // 
            // bt_Cash
            // 
            bt_Cash.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            bt_Cash.Location = new System.Drawing.Point(403, 737);
            bt_Cash.Name = "bt_Cash";
            bt_Cash.Size = new System.Drawing.Size(487, 48);
            bt_Cash.TabIndex = 9;
            bt_Cash.Text = "Cash";
            bt_Cash.UseVisualStyleBackColor = true;
            bt_Cash.Click += bt_Cash_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1264, 50);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(1258, 50);
            label5.TabIndex = 13;
            label5.Text = "Billing";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Billing_panel2
            // 
            Controls.Add(tableLayoutPanel1);
            Controls.Add(bt_Cash);
            Controls.Add(cb_Qty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_Select);
            Controls.Add(dgv_Billing);
            Controls.Add(lb_total);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bt_Add_Product);
            Name = "Billing_panel2";
            Size = new System.Drawing.Size(1264, 797);
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Billing).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
    }
}