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
            this.button5 = new System.Windows.Forms.Button();
            this.bn_products = new System.Windows.Forms.Button();
            this.bt_customer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(870, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 505);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.bn_products);
            this.panel3.Controls.Add(this.bt_customer);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 505);
            this.panel3.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 70);
            this.button5.TabIndex = 8;
            this.button5.Text = "Transaction";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // bn_products
            // 
            this.bn_products.Dock = System.Windows.Forms.DockStyle.Top;
            this.bn_products.Location = new System.Drawing.Point(0, 254);
            this.bn_products.Name = "bn_products";
            this.bn_products.Size = new System.Drawing.Size(148, 70);
            this.bn_products.TabIndex = 7;
            this.bn_products.Text = "Products";
            this.bn_products.UseVisualStyleBackColor = true;
            this.bn_products.Click += new System.EventHandler(this.bn_products_Click);
            // 
            // bt_customer
            // 
            this.bt_customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_customer.Location = new System.Drawing.Point(0, 184);
            this.bt_customer.Name = "bt_customer";
            this.bt_customer.Size = new System.Drawing.Size(148, 70);
            this.bt_customer.TabIndex = 6;
            this.bt_customer.Text = "Customer";
            this.bt_customer.UseVisualStyleBackColor = true;
            this.bt_customer.Click += new System.EventHandler(this.bt_customer_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 114);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(148, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(722, 60);
            this.panel4.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(148, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(722, 445);
            this.panel6.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 505);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bn_products;
        private System.Windows.Forms.Button bt_customer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}

