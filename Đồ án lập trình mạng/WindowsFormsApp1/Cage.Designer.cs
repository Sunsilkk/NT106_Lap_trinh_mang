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
            ((System.ComponentModel.ISupportInitialize)dgv_Cages).BeginInit();
            SuspendLayout();
            // 
            // dgv_Cages
            // 
            dgv_Cages.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_Cages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Cages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, PET_ID, PET_TYPE_ID, EMPTY });
            dgv_Cages.Location = new System.Drawing.Point(2, 334);
            dgv_Cages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            dgv_Cages.Name = "dgv_Cages";
            dgv_Cages.RowHeadersWidth = 62;
            dgv_Cages.RowTemplate.Height = 33;
            dgv_Cages.Size = new System.Drawing.Size(1213, 529);
            dgv_Cages.TabIndex = 0;
            dgv_Cages.CellDoubleClick += dgv_Cages_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // PET_ID
            // 
            PET_ID.HeaderText = "PET ID";
            PET_ID.MinimumWidth = 8;
            PET_ID.Name = "PET_ID";
            // 
            // PET_TYPE_ID
            // 
            PET_TYPE_ID.HeaderText = "PET TYPE ID";
            PET_TYPE_ID.MinimumWidth = 8;
            PET_TYPE_ID.Name = "PET_TYPE_ID";
            // 
            // EMPTY
            // 
            EMPTY.HeaderText = "EMPTY";
            EMPTY.MinimumWidth = 8;
            EMPTY.Name = "EMPTY";
            EMPTY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            EMPTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tb_petType
            // 
            tb_petType.Location = new System.Drawing.Point(482, 83);
            tb_petType.Name = "tb_petType";
            tb_petType.Size = new System.Drawing.Size(125, 27);
            tb_petType.TabIndex = 1;
            // 
            // PetType
            // 
            PetType.AutoSize = true;
            PetType.Location = new System.Drawing.Point(401, 83);
            PetType.Name = "PetType";
            PetType.Size = new System.Drawing.Size(64, 20);
            PetType.TabIndex = 2;
            PetType.Text = "Pet Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(88, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Pet Name";
            // 
            // cb_PetName
            // 
            cb_PetName.FormattingEnabled = true;
            cb_PetName.Location = new System.Drawing.Point(174, 78);
            cb_PetName.Name = "cb_PetName";
            cb_PetName.Size = new System.Drawing.Size(151, 28);
            cb_PetName.TabIndex = 4;
            cb_PetName.SelectedIndexChanged += cb_PetName_SelectedIndexChanged;
            // 
            // checkEmpty
            // 
            checkEmpty.AutoSize = true;
            checkEmpty.Location = new System.Drawing.Point(785, 80);
            checkEmpty.Name = "checkEmpty";
            checkEmpty.Size = new System.Drawing.Size(73, 24);
            checkEmpty.TabIndex = 5;
            checkEmpty.Text = "Empty";
            checkEmpty.UseVisualStyleBackColor = true;
            // 
            // bt_Update
            // 
            bt_Update.Location = new System.Drawing.Point(914, 77);
            bt_Update.Name = "bt_Update";
            bt_Update.Size = new System.Drawing.Size(94, 29);
            bt_Update.TabIndex = 6;
            bt_Update.Text = "Update";
            bt_Update.UseVisualStyleBackColor = true;
            bt_Update.Click += bt_Update_Click;
            // 
            // Cage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(bt_Update);
            Controls.Add(checkEmpty);
            Controls.Add(cb_PetName);
            Controls.Add(label1);
            Controls.Add(PetType);
            Controls.Add(tb_petType);
            Controls.Add(dgv_Cages);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "Cage";
            Size = new System.Drawing.Size(1217, 865);
            Load += Cage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Cages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_TYPE_ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EMPTY;
        private System.Windows.Forms.TextBox tb_petType;
        private System.Windows.Forms.Label PetType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_PetName;
        private System.Windows.Forms.CheckBox checkEmpty;
        private System.Windows.Forms.Button bt_Update;
    }
}