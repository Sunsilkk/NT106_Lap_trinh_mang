namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Transactor = new System.Windows.Forms.Button();
            this.bn_products = new System.Windows.Forms.Button();
            this.bt_customer = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(979, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 631);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_Transactor);
            this.panel3.Controls.Add(this.bn_products);
            this.panel3.Controls.Add(this.bt_customer);
            this.panel3.Controls.Add(this.btn_Home);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 631);
            this.panel3.TabIndex = 3;
            // 
            // bt_Transactor
            // 
            this.bt_Transactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Transactor.Location = new System.Drawing.Point(0, 406);
            this.bt_Transactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Transactor.Name = "bt_Transactor";
            this.bt_Transactor.Size = new System.Drawing.Size(166, 88);
            this.bt_Transactor.TabIndex = 8;
            this.bt_Transactor.Text = "Transaction";
            this.bt_Transactor.UseVisualStyleBackColor = true;
            this.bt_Transactor.Click += new System.EventHandler(this.bt_Transactor_Click);
            // 
            // bn_products
            // 
            this.bn_products.Dock = System.Windows.Forms.DockStyle.Top;
            this.bn_products.Location = new System.Drawing.Point(0, 318);
            this.bn_products.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bn_products.Name = "bn_products";
            this.bn_products.Size = new System.Drawing.Size(166, 88);
            this.bn_products.TabIndex = 7;
            this.bn_products.Text = "Products";
            this.bn_products.UseVisualStyleBackColor = true;
            this.bn_products.Click += new System.EventHandler(this.bn_products_Click);
            // 
            // bt_customer
            // 
            this.bt_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_customer.Location = new System.Drawing.Point(0, 230);
            this.bt_customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_customer.Name = "bt_customer";
            this.bt_customer.Size = new System.Drawing.Size(166, 88);
            this.bt_customer.TabIndex = 6;
            this.bt_customer.Text = "Customer";
            this.bt_customer.UseVisualStyleBackColor = true;
            this.bt_customer.Click += new System.EventHandler(this.bt_customer_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.Location = new System.Drawing.Point(0, 142);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(166, 88);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 142);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(166, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(813, 75);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(166, 75);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(813, 556);
            this.panel6.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 631);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Transactor;
        private System.Windows.Forms.Button bn_products;
        private System.Windows.Forms.Button bt_customer;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}

