using Pet_Management;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
<<<<<<< HEAD
        private Home homeTab;
        private Transaction_panel2 TranTab;
        Supabase.Client supabase;
=======
        private SupabaseManager _manager;
>>>>>>> 434708280cb2bed5bb7bf448544167a887325e46
        public MainForm()
        {
            InitializeComponent();
<<<<<<< HEAD
<<<<<<< HEAD
            InitializeSupabase();
            AddNewTab(new Home(supabase), "Home");
            AddNewTab(new Customer_panel2(), "Customers");
            AddNewTab(new Tab_Pet(), "Pet");
            AddNewTab(new Cage(), "Cage");
            AddNewTab(new Product_panel2(), "Products");
           AddNewTab(new Billing_panel2(supabase), "Billing");
           // AddNewTab(new Transaction_panel2(supabase), "Transactions");

=======
            AddNewTab(new Home(_manager), "Home");
            AddNewTab(new Customer_panel2(_manager), "Customers");
            AddNewTab(new Tab_Pet(_manager), "Pet");
            AddNewTab(new Cage(_manager), "Cage");
            AddNewTab(new Product_panel2(_manager), "Products");
            AddNewTab(new Billing_panel2(_manager), "Billing");
            AddNewTab(new Transaction_panel2(_manager), "Transactions");
>>>>>>> 434708280cb2bed5bb7bf448544167a887325e46
        }
        private async void InitializeSupabase()
        {
            supabase = await SupabaseManager.GetSupabase();
        }
        private void AddNewTab(Control control, string tabTitle)
=======
        }

        private TabPage AddNewTab(Control control, string tabTitle)
>>>>>>> 6f1b6e0a95d1c79f8483809a05b0d1003b0394d9
        {
            var tab = new TabPage(control.Text);
            tab.Text = tabTitle;
            control.Dock = DockStyle.Fill;
            tab.Controls.Add(control);
            tabControl1.TabPages.Add(tab);
            return tab;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            using var Loginform = new Login_Page();
            if (Loginform.ShowDialog() == DialogResult.OK && Loginform.SupabaseManager != null)
            {
                _manager = Loginform.SupabaseManager;
                var homeTab = AddNewTab(new Home(_manager), "Home");
                AddNewTab(new Customer_panel2(_manager), "Customers");
                AddNewTab(new Tab_Pet(_manager), "Pet");
                AddNewTab(new Cage(_manager), "Cage");
                AddNewTab(new Product_panel2(_manager), "Products");
                AddNewTab(new Billing_panel2(_manager), "Billing");
                AddNewTab(new Transaction_panel2(_manager), "Transactions");
                tabControl1.SelectedTab = homeTab;
            }
            else
            {
                Close();
            }
        }
    }
}