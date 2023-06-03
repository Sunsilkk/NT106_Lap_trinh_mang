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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_Billing = new System.Windows.Forms.Button();
            this.bt_Transactor = new System.Windows.Forms.Button();
            this.bn_products = new System.Windows.Forms.Button();
            this.bt_customer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1917, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 1050);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.bt_Billing);
            this.panel3.Controls.Add(this.bt_Transactor);
            this.panel3.Controls.Add(this.bn_products);
            this.panel3.Controls.Add(this.bt_customer);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(14, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 910);
            this.panel3.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 670);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 88);
            this.button4.TabIndex = 11;
            this.button4.Text = "Transaction";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 582);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 88);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cage";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bt_Billing
            // 
            this.bt_Billing.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Billing.Location = new System.Drawing.Point(0, 494);
            this.bt_Billing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Billing.Name = "bt_Billing";
            this.bt_Billing.Size = new System.Drawing.Size(188, 88);
            this.bt_Billing.TabIndex = 9;
            this.bt_Billing.Text = "Billing";
            this.bt_Billing.UseVisualStyleBackColor = true;
            this.bt_Billing.Click += new System.EventHandler(this.bt_Billing_Click);
            // 
            // bt_Transactor
            // 
            this.bt_Transactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Transactor.Location = new System.Drawing.Point(0, 406);
            this.bt_Transactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Transactor.Name = "bt_Transactor";
            this.bt_Transactor.Size = new System.Drawing.Size(188, 88);
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
            this.bn_products.Size = new System.Drawing.Size(188, 88);
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
            this.bt_customer.Size = new System.Drawing.Size(188, 88);
            this.bt_customer.TabIndex = 6;
            this.bt_customer.Text = "Customer";
            this.bt_customer.UseVisualStyleBackColor = true;
            this.bt_customer.Click += new System.EventHandler(this.bt_customer_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 88);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 142);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(324, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(813, 554);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(208, 15);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1190, 919);
            this.panel6.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Transactor;
        private System.Windows.Forms.Button bn_products;
        private System.Windows.Forms.Button bt_customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_Billing;
        private System.Windows.Forms.Button button4;
    }
}

