namespace Pet_Management
{
    partial class Tab_Pet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv_PET = new System.Windows.Forms.DataGridView();
            cb_Cus = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cb_type = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            tb_name = new System.Windows.Forms.TextBox();
            tb_age = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            bt_Add = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NAME_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PET_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_PET).BeginInit();
            SuspendLayout();
            // 
            // dgv_PET
            // 
            dgv_PET.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PET.BackgroundColor = System.Drawing.Color.FromArgb(249, 224, 187);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_PET.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_PET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, NAME_P, PET_TYPE, CUSTOMER, AGE });
            dgv_PET.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgv_PET.Location = new System.Drawing.Point(0, 250);
            dgv_PET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgv_PET.Name = "dgv_PET";
            dgv_PET.RowHeadersWidth = 51;
            dgv_PET.RowTemplate.Height = 29;
            dgv_PET.Size = new System.Drawing.Size(1386, 489);
            dgv_PET.TabIndex = 0;
            dgv_PET.CellDoubleClick += dgv_PET_CellDoubleClick;
            // 
            // cb_Cus
            // 
            cb_Cus.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_Cus.FormattingEnabled = true;
            cb_Cus.Location = new System.Drawing.Point(691, 198);
            cb_Cus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cb_Cus.Name = "cb_Cus";
            cb_Cus.Size = new System.Drawing.Size(179, 30);
            cb_Cus.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(162, 176);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 19);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(425, 176);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 19);
            label2.TabIndex = 3;
            label2.Text = "Type";
            // 
            // cb_type
            // 
            cb_type.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_type.FormattingEnabled = true;
            cb_type.Location = new System.Drawing.Point(425, 198);
            cb_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cb_type.Name = "cb_type";
            cb_type.Size = new System.Drawing.Size(133, 30);
            cb_type.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(691, 177);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 19);
            label3.TabIndex = 5;
            label3.Text = "Customer";
            // 
            // tb_name
            // 
            tb_name.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_name.Location = new System.Drawing.Point(162, 197);
            tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_name.Name = "tb_name";
            tb_name.Size = new System.Drawing.Size(110, 29);
            tb_name.TabIndex = 6;
            tb_name.KeyPress += tb_name_KeyPress;
            // 
            // tb_age
            // 
            tb_age.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_age.Location = new System.Drawing.Point(958, 197);
            tb_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_age.Name = "tb_age";
            tb_age.Size = new System.Drawing.Size(110, 29);
            tb_age.TabIndex = 7;
            tb_age.KeyPress += tb_age_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(958, 176);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 19);
            label4.TabIndex = 8;
            label4.Text = "Age";
            // 
            // bt_Add
            // 
            bt_Add.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Add.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_Add.Location = new System.Drawing.Point(1201, 190);
            bt_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new System.Drawing.Size(91, 40);
            bt_Add.TabIndex = 9;
            bt_Add.Text = "Add";
            bt_Add.UseVisualStyleBackColor = false;
            bt_Add.Click += bt_Add_Click;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Top;
            label5.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(0, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(1386, 140);
            label5.TabIndex = 10;
            label5.Text = "Pet";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // NAME_P
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            NAME_P.DefaultCellStyle = dataGridViewCellStyle3;
            NAME_P.HeaderText = "NAME";
            NAME_P.MinimumWidth = 6;
            NAME_P.Name = "NAME_P";
            // 
            // PET_TYPE
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            PET_TYPE.DefaultCellStyle = dataGridViewCellStyle4;
            PET_TYPE.HeaderText = "PET TYPE";
            PET_TYPE.MinimumWidth = 6;
            PET_TYPE.Name = "PET_TYPE";
            // 
            // CUSTOMER
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            CUSTOMER.DefaultCellStyle = dataGridViewCellStyle5;
            CUSTOMER.HeaderText = "CUSTOMER";
            CUSTOMER.MinimumWidth = 6;
            CUSTOMER.Name = "CUSTOMER";
            // 
            // AGE
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            AGE.DefaultCellStyle = dataGridViewCellStyle6;
            AGE.HeaderText = "AGE";
            AGE.MinimumWidth = 6;
            AGE.Name = "AGE";
            // 
            // Tab_Pet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            Controls.Add(label5);
            Controls.Add(bt_Add);
            Controls.Add(label4);
            Controls.Add(tb_age);
            Controls.Add(tb_name);
            Controls.Add(label3);
            Controls.Add(cb_type);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_Cus);
            Controls.Add(dgv_PET);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Tab_Pet";
            Size = new System.Drawing.Size(1386, 739);
            Load += Tab_Pet_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_PET).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PET;
        private System.Windows.Forms.ComboBox cb_Cus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGE;
    }
}