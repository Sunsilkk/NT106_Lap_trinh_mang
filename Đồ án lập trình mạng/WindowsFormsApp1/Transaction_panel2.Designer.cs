namespace WindowsFormsApp1
{
    partial class Transaction_panel2
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
            dgv_transaction = new System.Windows.Forms.DataGridView();
            tb_Search = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_transaction).BeginInit();
            SuspendLayout();
            // 
            // dgv_transaction
            // 
            dgv_transaction.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, productName, quantity, total });
            dgv_transaction.Location = new System.Drawing.Point(18, 83);
            dgv_transaction.Name = "dgv_transaction";
            dgv_transaction.RowHeadersWidth = 62;
            dgv_transaction.RowTemplate.Height = 28;
            dgv_transaction.Size = new System.Drawing.Size(1063, 651);
            dgv_transaction.TabIndex = 0;
            // 
            // tb_Search
            // 
            tb_Search.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tb_Search.Location = new System.Drawing.Point(913, 28);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new System.Drawing.Size(167, 27);
            tb_Search.TabIndex = 1;
            tb_Search.TextChanged += tb_Search_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(843, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // productName
            // 
            productName.HeaderText = "Product Name";
            productName.MinimumWidth = 8;
            productName.Name = "productName";
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.MinimumWidth = 8;
            total.Name = "total";
            // 
            // Transaction_panel2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(tb_Search);
            Controls.Add(dgv_transaction);
            Name = "Transaction_panel2";
            Size = new System.Drawing.Size(1111, 751);
            Load += Transactor_panel2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_transaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}