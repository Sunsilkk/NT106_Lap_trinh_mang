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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv_transaction = new System.Windows.Forms.DataGridView();
            tb_Search = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_transaction).BeginInit();
            SuspendLayout();
            // 
            // dgv_transaction
            // 
            dgv_transaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_transaction.BackgroundColor = System.Drawing.Color.FromArgb(249, 224, 187);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_transaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_transaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, productName, quantity, total });
            dgv_transaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgv_transaction.Location = new System.Drawing.Point(0, 263);
            dgv_transaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgv_transaction.Name = "dgv_transaction";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_transaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgv_transaction.RowHeadersWidth = 62;
            dgv_transaction.RowTemplate.Height = 28;
            dgv_transaction.Size = new System.Drawing.Size(1191, 547);
            dgv_transaction.TabIndex = 0;
            // 
            // tb_Search
            // 
            tb_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tb_Search.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_Search.Location = new System.Drawing.Point(909, 204);
            tb_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new System.Drawing.Size(199, 28);
            tb_Search.TabIndex = 1;
            tb_Search.TextChanged += tb_Search_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(825, 208);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 21);
            label1.TabIndex = 2;
            label1.Text = "Search";
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1191, 140);
            label2.TabIndex = 3;
            label2.Text = "Transaction";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // productName
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            productName.DefaultCellStyle = dataGridViewCellStyle3;
            productName.HeaderText = "Product Name";
            productName.MinimumWidth = 8;
            productName.Name = "productName";
            // 
            // quantity
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            quantity.DefaultCellStyle = dataGridViewCellStyle4;
            quantity.HeaderText = "Quantity";
            quantity.MinimumWidth = 8;
            quantity.Name = "quantity";
            // 
            // total
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            total.DefaultCellStyle = dataGridViewCellStyle5;
            total.HeaderText = "Total";
            total.MinimumWidth = 8;
            total.Name = "total";
            // 
            // Transaction_panel2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Search);
            Controls.Add(dgv_transaction);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Transaction_panel2";
            Size = new System.Drawing.Size(1191, 810);
            Load += Transactor_panel2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_transaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_transaction;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}