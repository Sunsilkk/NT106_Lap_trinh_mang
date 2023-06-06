using Pet_Management;
using System;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            AddNewTab(new Home(), "Home");
            AddNewTab(new Customer_panel2(), "Customers");
            AddNewTab(new Cage(), "Cage");
            AddNewTab(new Product_panel2(), "Products");
            AddNewTab(new Billing_panel2(), "Billing");
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
