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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            label5 = new System.Windows.Forms.Label();
            bt_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Billing).BeginInit();
            SuspendLayout();
            // 
            // bt_Add_Product
            // 
            bt_Add_Product.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_Add_Product.Location = new System.Drawing.Point(39, 154);
            bt_Add_Product.Name = "bt_Add_Product";
            bt_Add_Product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            bt_Add_Product.Size = new System.Drawing.Size(80, 37);
            bt_Add_Product.TabIndex = 0;
            bt_Add_Product.Text = "(+)";
            bt_Add_Product.UseVisualStyleBackColor = true;
            bt_Add_Product.Click += bt_Add_Product_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(125, 165);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 19);
            label1.TabIndex = 1;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label2.Location = new System.Drawing.Point(1053, 172);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Total: ";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_total
            // 
            lb_total.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lb_total.AutoSize = true;
            lb_total.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_total.Location = new System.Drawing.Point(1118, 172);
            lb_total.Name = "lb_total";
            lb_total.Size = new System.Drawing.Size(39, 19);
            lb_total.TabIndex = 3;
            lb_total.Text = "null";
            // 
            // dgv_Billing
            // 
            dgv_Billing.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_Billing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Billing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_Billing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Billing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NO, dgv_Name, Type, Category, Qty, Price });
            dgv_Billing.Location = new System.Drawing.Point(0, 268);
            dgv_Billing.Name = "dgv_Billing";
            dgv_Billing.RowHeadersWidth = 62;
            dgv_Billing.RowTemplate.Height = 28;
            dgv_Billing.Size = new System.Drawing.Size(1266, 436);
            dgv_Billing.TabIndex = 4;
            dgv_Billing.CellDoubleClick += dgv_Billing_CellDoubleClick;
            // 
            // NO
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            NO.DefaultCellStyle = dataGridViewCellStyle1;
            NO.HeaderText = "NO";
            NO.MinimumWidth = 8;
            NO.Name = "NO";
            NO.ReadOnly = true;
            // 
            // dgv_Name
            // 
            dgv_Name.HeaderText = "Name";
            dgv_Name.MinimumWidth = 8;
            dgv_Name.Name = "dgv_Name";
            dgv_Name.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.MinimumWidth = 8;
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // cb_Select
            // 
            cb_Select.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cb_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_Select.FormattingEnabled = true;
            cb_Select.Location = new System.Drawing.Point(443, 166);
            cb_Select.Name = "cb_Select";
            cb_Select.Size = new System.Drawing.Size(163, 28);
            cb_Select.TabIndex = 5;
            cb_Select.SelectedIndexChanged += cb_Select_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(295, 170);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(142, 19);
            label3.TabIndex = 6;
            label3.Text = "Select Product";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(650, 170);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 19);
            label4.TabIndex = 7;
            label4.Text = "Quantity";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_Qty
            // 
            cb_Qty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            cb_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_Qty.FormattingEnabled = true;
            cb_Qty.Location = new System.Drawing.Point(743, 166);
            cb_Qty.Name = "cb_Qty";
            cb_Qty.Size = new System.Drawing.Size(163, 28);
            cb_Qty.TabIndex = 8;
            // 
            // bt_Cash
            // 
            bt_Cash.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            bt_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_Cash.Location = new System.Drawing.Point(507, 710);
            bt_Cash.Name = "bt_Cash";
            bt_Cash.Size = new System.Drawing.Size(251, 62);
            bt_Cash.TabIndex = 9;
            bt_Cash.Text = "Cash";
            bt_Cash.UseVisualStyleBackColor = true;
            bt_Cash.Click += bt_Cash_Click;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.Dock = System.Windows.Forms.DockStyle.Top;
            label5.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(0, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(1264, 133);
            label5.TabIndex = 13;
            label5.Text = "Billing";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Clear
            // 
            bt_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            bt_Clear.AutoSize = true;
            bt_Clear.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_Clear.ForeColor = System.Drawing.Color.Black;
            bt_Clear.Location = new System.Drawing.Point(39, 197);
            bt_Clear.Name = "bt_Clear";
            bt_Clear.Size = new System.Drawing.Size(80, 37);
            bt_Clear.TabIndex = 14;
            bt_Clear.Text = "Clear";
            bt_Clear.UseVisualStyleBackColor = true;
            bt_Clear.Click += bt_Clear_Click;
            // 
            // Billing_panel2
            // 
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            Controls.Add(bt_Clear);
            Controls.Add(label5);
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
            Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Name = "Billing_panel2";
            Size = new System.Drawing.Size(1264, 797);
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Billing).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button bt_Clear;
    }
}