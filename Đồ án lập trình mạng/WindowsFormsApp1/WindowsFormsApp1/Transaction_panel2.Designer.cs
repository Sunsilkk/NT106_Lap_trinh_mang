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
            this.dgv_transaction = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custommer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashier_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_transaction
            // 
            this.dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.custommer_ID,
            this.product_ID,
            this.cashier_ID});
            this.dgv_transaction.Location = new System.Drawing.Point(1, 66);
            this.dgv_transaction.Name = "dgv_transaction";
            this.dgv_transaction.RowHeadersWidth = 62;
            this.dgv_transaction.RowTemplate.Height = 28;
            this.dgv_transaction.Size = new System.Drawing.Size(799, 384);
            this.dgv_transaction.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // custommer_ID
            // 
            this.custommer_ID.HeaderText = "Customer ID";
            this.custommer_ID.MinimumWidth = 8;
            this.custommer_ID.Name = "custommer_ID";
            this.custommer_ID.Width = 200;
            // 
            // product_ID
            // 
            this.product_ID.HeaderText = "Product ID";
            this.product_ID.MinimumWidth = 8;
            this.product_ID.Name = "product_ID";
            this.product_ID.Width = 200;
            // 
            // cashier_ID
            // 
            this.cashier_ID.HeaderText = "Cashier ID";
            this.cashier_ID.MinimumWidth = 8;
            this.cashier_ID.Name = "cashier_ID";
            this.cashier_ID.Width = 200;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(570, 22);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(187, 26);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // Transaction_panel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dgv_transaction);
            this.Name = "Transaction_panel2";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transactor_panel2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn custommer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashier_ID;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label1;
    }
}