using Pet_Management;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            AddNewTab(new Billing_panel2(), "Billing");
            AddNewTab(new Customer_panel2(), "Customers");
            AddNewTab(new Product_panel2(), "Products");
            AddNewTab(new Transaction_panel2(), "Transactions");
        }

        private void AddNewTab(Control control, string tabTitle)
        {
            var tab = new TabPage(control.Text);
            tab.Text = tabTitle;
            control.Dock = DockStyle.Fill;
            tab.Controls.Add(control);
            tabControl1.TabPages.Add(tab);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
