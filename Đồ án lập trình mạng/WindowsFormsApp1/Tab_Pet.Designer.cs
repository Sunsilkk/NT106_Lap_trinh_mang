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
            dgv_PET = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NAME_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PET_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CUSTOMER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cb_Cus = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            cb_type = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            tb_name = new System.Windows.Forms.TextBox();
            tb_age = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            bt_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgv_PET).BeginInit();
            SuspendLayout();
            // 
            // dgv_PET
            // 
            dgv_PET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, NAME_P, PET_TYPE, CUSTOMER, AGE });
            dgv_PET.Location = new System.Drawing.Point(3, 155);
            dgv_PET.Name = "dgv_PET";
            dgv_PET.RowHeadersWidth = 51;
            dgv_PET.RowTemplate.Height = 29;
            dgv_PET.Size = new System.Drawing.Size(794, 292);
            dgv_PET.TabIndex = 0;
            dgv_PET.CellDoubleClick += dgv_PET_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // NAME_P
            // 
            NAME_P.HeaderText = "NAME";
            NAME_P.MinimumWidth = 6;
            NAME_P.Name = "NAME_P";
            NAME_P.Width = 125;
            // 
            // PET_TYPE
            // 
            PET_TYPE.HeaderText = "PET TYPE";
            PET_TYPE.MinimumWidth = 6;
            PET_TYPE.Name = "PET_TYPE";
            PET_TYPE.Width = 125;
            // 
            // CUSTOMER
            // 
            CUSTOMER.HeaderText = "CUSTOMER";
            CUSTOMER.MinimumWidth = 6;
            CUSTOMER.Name = "CUSTOMER";
            CUSTOMER.Width = 125;
            // 
            // AGE
            // 
            AGE.HeaderText = "AGE";
            AGE.MinimumWidth = 6;
            AGE.Name = "AGE";
            AGE.Width = 125;
            // 
            // cb_Cus
            // 
            cb_Cus.FormattingEnabled = true;
            cb_Cus.Location = new System.Drawing.Point(331, 105);
            cb_Cus.Name = "cb_Cus";
            cb_Cus.Size = new System.Drawing.Size(151, 28);
            cb_Cus.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(174, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Type";
            // 
            // cb_type
            // 
            cb_type.FormattingEnabled = true;
            cb_type.Location = new System.Drawing.Point(174, 105);
            cb_type.Name = "cb_type";
            cb_type.Size = new System.Drawing.Size(151, 28);
            cb_type.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(346, 82);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Customer";
            // 
            // tb_name
            // 
            tb_name.Location = new System.Drawing.Point(10, 106);
            tb_name.Name = "tb_name";
            tb_name.Size = new System.Drawing.Size(125, 27);
            tb_name.TabIndex = 6;
            tb_name.KeyPress += tb_name_KeyPress;
            // 
            // tb_age
            // 
            tb_age.Location = new System.Drawing.Point(563, 108);
            tb_age.Name = "tb_age";
            tb_age.Size = new System.Drawing.Size(125, 27);
            tb_age.TabIndex = 7;
            tb_age.KeyPress += tb_age_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(563, 82);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(36, 20);
            label4.TabIndex = 8;
            label4.Text = "Age";
            // 
            // bt_Add
            // 
            bt_Add.Location = new System.Drawing.Point(22, 31);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new System.Drawing.Size(94, 29);
            bt_Add.TabIndex = 9;
            bt_Add.Text = "Add";
            bt_Add.UseVisualStyleBackColor = true;
            bt_Add.Click += bt_Add_Click;
            // 
            // Tab_Pet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            Name = "Tab_Pet";
            Size = new System.Drawing.Size(800, 450);
            Load += Tab_Pet_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_PET).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTOMER;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGE;
        private System.Windows.Forms.ComboBox cb_Cus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_Add;
    }
}