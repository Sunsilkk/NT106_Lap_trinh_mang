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
            EMPTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Cages).BeginInit();
            SuspendLayout();
            // 
            // dgv_Cages
            // 
            dgv_Cages.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_Cages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Cages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, PET_ID, PET_TYPE_ID, EMPTY });
            dgv_Cages.Location = new System.Drawing.Point(14, 23);
            dgv_Cages.Margin = new System.Windows.Forms.Padding(2);
            dgv_Cages.Name = "dgv_Cages";
            dgv_Cages.RowHeadersWidth = 62;
            dgv_Cages.RowTemplate.Height = 33;
            dgv_Cages.Size = new System.Drawing.Size(1023, 627);
            dgv_Cages.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // PET_ID
            // 
            PET_ID.HeaderText = "PET ID";
            PET_ID.MinimumWidth = 8;
            PET_ID.Name = "PET_ID";
            PET_ID.Width = 150;
            // 
            // PET_TYPE_ID
            // 
            PET_TYPE_ID.HeaderText = "PET TYPE ID";
            PET_TYPE_ID.MinimumWidth = 8;
            PET_TYPE_ID.Name = "PET_TYPE_ID";
            PET_TYPE_ID.Width = 150;
            // 
            // EMPTY
            // 
            EMPTY.HeaderText = "EMPTY";
            EMPTY.MinimumWidth = 8;
            EMPTY.Name = "EMPTY";
            EMPTY.Width = 150;
            // 
            // Cage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dgv_Cages);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Cage";
            Size = new System.Drawing.Size(1051, 652);
            Load += Cage_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Cages).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cages;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PET_TYPE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPTY;
    }
}