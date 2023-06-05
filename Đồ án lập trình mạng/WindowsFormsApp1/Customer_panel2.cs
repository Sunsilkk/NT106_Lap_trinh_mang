using Pet_Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Customer_panel2 : UserControl
    {

        public Customer_panel2()
        {
            InitializeComponent();
            InitializeSupabase();
        }

        private async void Customer_panel2_Load(object sender, EventArgs e)
        {
            await loaddata();
        }

        Supabase.Client supabase;

        Customers_Registration_Form customers_Registration_Form = new Customers_Registration_Form();
        Customers_Update_Form customers_Update_Form = new Customers_Update_Form();  
        private void InitializeSupabase()
        {
            var url = "https://hpvdlorgdoeaooibnffe.supabase.co";
            var key = "c";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client(url, key, options);
            customers_Registration_Form.SupabaseClient = supabase;
            customers_Update_Form.SupabaseClient = supabase;
        }
        private async Task<List<Customers>> GetCustomers()
        {
            var result = await supabase.From<Customers>().Get();
            var customers = result.Models;
            return customers;
        }

        async Task loaddata()
        {
            var customers = await GetCustomers();


            foreach (var customer in customers)
            {
                dgv_customer.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Phone, customer.Created_at);
            }


        }


        private void btn_Add_Click(object sender, EventArgs e)
        {

            customers_Registration_Form.ShowDialog();
            dgv_customer.Rows.Clear();
            Customer_panel2_Load(sender, e);
        }




        private async void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgv_customer.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_customer.Rows[selectedRowIndex];

                string columnValue = selectedRow.Cells["Name_T"].Value.ToString();
                await supabase.From<Customers>().Where(x => x.Name == columnValue).Delete();
                MessageBox.Show("Xoa khach hang thanh cong");
                dgv_customer.Rows.Clear();
                Customer_panel2_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi\r\n" + ex.Message);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dgv_customer.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        try
                        {
                            if (cell.Value != null && cell.Value.ToString().Contains(keyword))
                            {
                                row.Visible = true;
                                break;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                        catch { }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv_customer.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            customers_Update_Form.ShowDialog();
            dgv_customer.Rows.Clear();
            Customer_panel2_Load(sender, e);
        }
    }
}

