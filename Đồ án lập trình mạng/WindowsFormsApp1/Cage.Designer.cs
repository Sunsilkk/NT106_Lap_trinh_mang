namespace Pet_Management
{
    partial class Cage
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
            dgv_Cages = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PET_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PET_TYPE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EMPTY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            tb_petType = new System.Windows.Forms.TextBox();
            PetType = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cb_PetName = new System.Windows.Forms.ComboBox();
            checkEmpty = new System.Windows.Forms.CheckBox();
            bt_Update = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Cages).BeginInit();
            SuspendLayout();
            // 
            // dgv_Cages
            // 
            dgv_Cages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Cages.BackgroundColor = System.Drawing.Color.FromArgb(249, 224, 187);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_Cages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Cages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, PET_ID, PET_TYPE_ID, EMPTY });
            dgv_Cages.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgv_Cages.Location = new System.Drawing.Point(0, 283);
            dgv_Cages.Margin = new System.Windows.Forms.Padding(2);
            dgv_Cages.Name = "dgv_Cages";
            dgv_Cages.RowHeadersWidth = 62;
            dgv_Cages.RowTemplate.Height = 33;
            dgv_Cages.Size = new System.Drawing.Size(1242, 525);
            dgv_Cages.TabIndex = 0;
            dgv_Cages.CellDoubleClick += dgv_Cages_CellDoubleClick;
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
            // PET_ID
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            PET_ID.DefaultCellStyle = dataGridViewCellStyle3;
            PET_ID.HeaderText = "PET ID";
            PET_ID.MinimumWidth = 8;
            PET_ID.Name = "PET_ID";
            // 
            // PET_TYPE_ID
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            PET_TYPE_ID.DefaultCellStyle = dataGridViewCellStyle4;
            PET_TYPE_ID.HeaderText = "PET TYPE ID";
            PET_TYPE_ID.MinimumWidth = 8;
            PET_TYPE_ID.Name = "PET_TYPE_ID";
            // 
            // EMPTY
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 245, 184);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Qaz", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            EMPTY.DefaultCellStyle = dataGridViewCellStyle5;
            EMPTY.HeaderText = "EMPTY";
            EMPTY.MinimumWidth = 8;
            EMPTY.Name = "EMPTY";
            EMPTY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            EMPTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tb_petType
            // 
            tb_petType.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_petType.Location = new System.Drawing.Point(543, 201);
            tb_petType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tb_petType.Name = "tb_petType";
            tb_petType.Size = new System.Drawing.Size(154, 28);
            tb_petType.TabIndex = 1;
            // 
            // PetType
            // 
            PetType.AutoSize = true;
            PetType.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PetType.Location = new System.Drawing.Point(428, 204);
            PetType.Name = "PetType";
            PetType.Size = new System.Drawing.Size(85, 19);
            PetType.TabIndex = 2;
            PetType.Text = "Pet Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(102, 204);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 19);
            label1.TabIndex = 3;
            label1.Text = "Pet Name";
            // 
            // cb_PetName
            // 
            cb_PetName.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cb_PetName.FormattingEnabled = true;
            cb_PetName.Location = new System.Drawing.Point(219, 199);
            cb_PetName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cb_PetName.Name = "cb_PetName";
            cb_PetName.Size = new System.Drawing.Size(180, 27);
            cb_PetName.TabIndex = 4;
            cb_PetName.SelectedIndexChanged += cb_PetName_SelectedIndexChanged;
            // 
            // checkEmpty
            // 
            checkEmpty.AutoSize = true;
            checkEmpty.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkEmpty.Location = new System.Drawing.Point(795, 203);
            checkEmpty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            checkEmpty.Name = "checkEmpty";
            checkEmpty.Size = new System.Drawing.Size(84, 23);
            checkEmpty.TabIndex = 5;
            checkEmpty.Text = "Empty";
            checkEmpty.UseVisualStyleBackColor = true;
            // 
            // bt_Update
            // 
            bt_Update.BackColor = System.Drawing.Color.FromArgb(195, 129, 84);
            bt_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_Update.Font = new System.Drawing.Font("Mouldy Cheese", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            bt_Update.Location = new System.Drawing.Point(974, 188);
            bt_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            bt_Update.Name = "bt_Update";
            bt_Update.Size = new System.Drawing.Size(126, 50);
            bt_Update.TabIndex = 6;
            bt_Update.Text = "Update";
            bt_Update.UseVisualStyleBackColor = false;
            bt_Update.Click += bt_Update_Click;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Mouldy Cheese", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(1242, 140);
            label2.TabIndex = 7;
            label2.Text = "Cages";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(249, 224, 187);
            Controls.Add(bt_Update);
            Controls.Add(checkEmpty);
            Controls.Add(cb_PetName);
            Controls.Add(label1);
            Controls.Add(PetType);
            Controls.Add(tb_petType);
            Controls.Add(dgv_Cages);
            Controls.Add(label2);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Cage";
            Size = new System.Drawing.Size(1242, 808);
            Load += Cage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Cages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cages;
        private System.Windows.Forms.TextBox tb_petType;
        private System.Windows.Forms.Label PetType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_PetName;
        private System.Windows.Forms.CheckBox checkEmpty;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_TYPE_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EMPTY;
    }
}