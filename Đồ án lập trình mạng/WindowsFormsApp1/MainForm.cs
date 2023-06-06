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
        private Home homeTab;
        public MainForm()
        {
            InitializeComponent();
            AddNewTab(new Home(), "Home");
            AddNewTab(new Customer_panel2(), "Customers");
            AddNewTab(new Tab_Pet(), "Pet");
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {         
                var oldTabControls = tabControl1.TabPages[tabControl1.SelectedIndex].Controls;
                var oldTab = oldTabControls[0];
                var tabType = oldTab.GetType();
                var newTab = (Control)Activator.CreateInstance(tabType);
                if (newTab == null) return;
                newTab.Dock = DockStyle.Fill;
                oldTabControls.Clear();
                oldTabControls.Add(newTab);           
        }
    }
}
