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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dgv_PET = new System.Windows.Forms.DataGridView();
            panel2 = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txt_ID_HT = new System.Windows.Forms.TextBox();
            txt_name_ht = new System.Windows.Forms.TextBox();
            txt_type_ht = new System.Windows.Forms.TextBox();
            txt_age_ht = new System.Windows.Forms.TextBox();
            txt_cus_ht = new System.Windows.Forms.TextBox();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NAME_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_PET).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cb_Cus
            // 
            cb_Cus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_Cus.FormattingEnabled = true;
            cb_Cus.Location = new System.Drawing.Point(348, 280);
            cb_Cus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cb_Cus.Name = "cb_Cus";
            cb_Cus.Size = new System.Drawing.Size(179, 32);
            cb_Cus.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 254);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(64, 21);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(173, 254);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 21);
            label2.TabIndex = 3;
            label2.Text = "Type";
            // 
            // cb_type
            // 
            cb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_type.FormattingEnabled = true;
            cb_type.Location = new System.Drawing.Point(173, 280);
            cb_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cb_type.Name = "cb_type";
            cb_type.Size = new System.Drawing.Size(133, 32);
            cb_type.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(348, 254);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 21);
            label3.TabIndex = 5;
            label3.Text = "Customer";
            // 
            // tb_name
            // 
            tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_name.Location = new System.Drawing.Point(16, 280);
            tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_name.Name = "tb_name";
            tb_name.Size = new System.Drawing.Size(110, 29);
            tb_name.TabIndex = 6;
            tb_name.KeyPress += tb_name_KeyPress;
            // 
            // tb_age
            // 
            tb_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_age.Location = new System.Drawing.Point(557, 282);
            tb_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_age.Name = "tb_age";
            tb_age.Size = new System.Drawing.Size(110, 29);
            tb_age.TabIndex = 7;
            tb_age.KeyPress += tb_age_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(557, 254);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 21);
            label4.TabIndex = 8;
            label4.Text = "Age";
            // 
            // bt_Add
            // 
            bt_Add.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Add.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_Add.Location = new System.Drawing.Point(712, 275);
            bt_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new System.Drawing.Size(95, 43);
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
            label5.Size = new System.Drawing.Size(1320, 106);
            label5.TabIndex = 10;
            label5.Text = "Pet";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_PET
            // 
            dgv_PET.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PET.BackgroundColor = System.Drawing.Color.FromArgb(249, 224, 187);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_PET.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_PET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, NAME_P });
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv_PET.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_PET.Location = new System.Drawing.Point(16, 328);
            dgv_PET.Name = "dgv_PET";
            dgv_PET.RowHeadersWidth = 51;
            dgv_PET.RowTemplate.Height = 24;
            dgv_PET.Size = new System.Drawing.Size(550, 410);
            dgv_PET.TabIndex = 14;
            dgv_PET.CellClick += dgv_PET_CellClick;
            dgv_PET.CellDoubleClick += dgv_PET_CellDoubleClick_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_ID_HT);
            panel2.Controls.Add(txt_name_ht);
            panel2.Controls.Add(txt_type_ht);
            panel2.Controls.Add(txt_age_ht);
            panel2.Controls.Add(txt_cus_ht);
            panel2.Location = new System.Drawing.Point(584, 328);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(481, 410);
            panel2.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(39, 186);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(98, 21);
            label10.TabIndex = 20;
            label10.Text = "Pet Type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(39, 261);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(112, 21);
            label9.TabIndex = 19;
            label9.Text = "Customer:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(39, 347);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(54, 21);
            label8.TabIndex = 18;
            label8.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(39, 109);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(69, 21);
            label7.TabIndex = 17;
            label7.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Mouldy Cheese", 15.7499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(39, 41);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(33, 21);
            label6.TabIndex = 16;
            label6.Text = "ID:";
            // 
            // txt_ID_HT
            // 
            txt_ID_HT.Enabled = false;
            txt_ID_HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_ID_HT.Location = new System.Drawing.Point(215, 39);
            txt_ID_HT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_ID_HT.Name = "txt_ID_HT";
            txt_ID_HT.Size = new System.Drawing.Size(227, 29);
            txt_ID_HT.TabIndex = 12;
            // 
            // txt_name_ht
            // 
            txt_name_ht.Enabled = false;
            txt_name_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_name_ht.Location = new System.Drawing.Point(215, 107);
            txt_name_ht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_name_ht.Name = "txt_name_ht";
            txt_name_ht.Size = new System.Drawing.Size(227, 29);
            txt_name_ht.TabIndex = 11;
            // 
            // txt_type_ht
            // 
            txt_type_ht.Enabled = false;
            txt_type_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_type_ht.Location = new System.Drawing.Point(215, 183);
            txt_type_ht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_type_ht.Name = "txt_type_ht";
            txt_type_ht.Size = new System.Drawing.Size(227, 29);
            txt_type_ht.TabIndex = 10;
            // 
            // txt_age_ht
            // 
            txt_age_ht.Enabled = false;
            txt_age_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_age_ht.Location = new System.Drawing.Point(215, 343);
            txt_age_ht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_age_ht.Name = "txt_age_ht";
            txt_age_ht.Size = new System.Drawing.Size(227, 29);
            txt_age_ht.TabIndex = 9;
            // 
            // txt_cus_ht
            // 
            txt_cus_ht.Enabled = false;
            txt_cus_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txt_cus_ht.Location = new System.Drawing.Point(215, 259);
            txt_cus_ht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txt_cus_ht.Name = "txt_cus_ht";
            txt_cus_ht.Size = new System.Drawing.Size(227, 29);
            txt_cus_ht.TabIndex = 8;
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
            // Tab_Pet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            Controls.Add(panel2);
            Controls.Add(dgv_PET);
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
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Tab_Pet";
            Size = new System.Drawing.Size(1320, 855);
            Load += Tab_Pet_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_PET).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private System.Windows.Forms.DataGridView dgv_PET;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ID_HT;
        private System.Windows.Forms.TextBox txt_name_ht;
        private System.Windows.Forms.TextBox txt_type_ht;
        private System.Windows.Forms.TextBox txt_age_ht;
        private System.Windows.Forms.TextBox txt_cus_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_P;
    }
}