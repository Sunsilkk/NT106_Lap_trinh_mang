using Pet_Management;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private SupabaseManager _manager;
        public MainForm()
        {
            _manager = new SupabaseManager();
            _ = _manager.Connect();
            InitializeComponent();
            AddNewTab(new Home(_manager), "Home");
            AddNewTab(new Customer_panel2(_manager), "Customers");
            AddNewTab(new Tab_Pet(_manager), "Pet");
            AddNewTab(new Cage(_manager), "Cage");
            AddNewTab(new Product_panel2(_manager), "Products");
            AddNewTab(new Billing_panel2(_manager), "Billing");
            AddNewTab(new Transaction_panel2(_manager), "Transactions");
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
            var tabControls = tabControl1.TabPages[tabControl1.SelectedIndex].Controls;
            var tab = tabControls[0];
            if (tab is SupabaseControl supabaseTab)
            {
                supabaseTab.ClientRefresh();
            }
        }
    }
}