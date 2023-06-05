namespace WindowsFormsApp1
{
    partial class Customer_panel2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_panel2));
            search = new System.Windows.Forms.Label();
            bt_delete = new System.Windows.Forms.Button();
            txt_search = new System.Windows.Forms.TextBox();
            btn_Add = new System.Windows.Forms.Button();
            dgv_customer = new System.Windows.Forms.DataGridView();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Name_T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Created_At = new System.Windows.Forms.DataGridViewTextBoxColumn();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            metroButton1 = new MetroFramework.Controls.MetroButton();
            kryptonColorButton1 = new Krypton.Toolkit.KryptonColorButton();
            ((System.ComponentModel.ISupportInitialize)dgv_customer).BeginInit();
            SuspendLayout();
            // 
            // search
            // 
            search.AutoSize = true;
            search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            search.Location = new System.Drawing.Point(809, 162);
            search.Name = "search";
            search.Size = new System.Drawing.Size(60, 21);
            search.TabIndex = 7;
            search.Text = "Search:";
            // 
            // bt_delete
            // 
            bt_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            bt_delete.Location = new System.Drawing.Point(179, 150);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new System.Drawing.Size(93, 49);
            bt_delete.TabIndex = 6;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new System.Drawing.Point(918, 162);
            txt_search.Name = "txt_search";
            txt_search.Size = new System.Drawing.Size(189, 23);
            txt_search.TabIndex = 4;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            btn_Add.Location = new System.Drawing.Point(61, 150);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new System.Drawing.Size(95, 49);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "ADD";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // dgv_customer
            // 
            dgv_customer.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgv_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, Name_T, address, Phone, Created_At });
            dgv_customer.Location = new System.Drawing.Point(0, 223);
            dgv_customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgv_customer.Name = "dgv_customer";
            dgv_customer.RowHeadersWidth = 62;
            dgv_customer.RowTemplate.Height = 28;
            dgv_customer.Size = new System.Drawing.Size(1139, 413);
            dgv_customer.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // Name_T
            // 
            Name_T.HeaderText = "Name";
            Name_T.MinimumWidth = 8;
            Name_T.Name = "Name_T";
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.MinimumWidth = 8;
            address.Name = "address";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            // 
            // Created_At
            // 
            Created_At.HeaderText = "Created At";
            Created_At.MinimumWidth = 6;
            Created_At.Name = "Created_At";
            // 
            // kryptonButton1
            // 
            kryptonButton1.CornerRoundingRadius = -1F;
            kryptonButton1.Location = new System.Drawing.Point(189, 87);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new System.Drawing.Size(119, 45);
            kryptonButton1.TabIndex = 8;
            kryptonButton1.Values.Text = "kryptonButton1";
            // 
            // metroButton1
            // 
            metroButton1.Location = new System.Drawing.Point(192, 33);
            metroButton1.Name = "metroButton1";
            metroButton1.Size = new System.Drawing.Size(116, 48);
            metroButton1.TabIndex = 9;
            metroButton1.Text = "metroButton1";
            // 
            // kryptonColorButton1
            // 
            kryptonColorButton1.CustomColorPreviewShape = Krypton.Toolkit.KryptonColorButtonCustomColorPreviewShape.None;
            kryptonColorButton1.Location = new System.Drawing.Point(364, 72);
            kryptonColorButton1.Name = "kryptonColorButton1";
            kryptonColorButton1.Size = new System.Drawing.Size(114, 60);
            kryptonColorButton1.TabIndex = 10;
            kryptonColorButton1.Values.Image = (System.Drawing.Image)resources.GetObject("kryptonColorButton1.Values.Image");
            kryptonColorButton1.Values.Text = "kryptonColorButton1";
            // 
            // Customer_panel2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(kryptonColorButton1);
            Controls.Add(metroButton1);
            Controls.Add(kryptonButton1);
            Controls.Add(btn_Add);
            Controls.Add(bt_delete);
            Controls.Add(search);
            Controls.Add(dgv_customer);
            Controls.Add(txt_search);
            Name = "Customer_panel2";
            Size = new System.Drawing.Size(1139, 638);
            Load += Customer_panel2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_customer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DataGridView dgv_customer;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_T;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created_At;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Krypton.Toolkit.KryptonColorButton kryptonColorButton1;
    }
}