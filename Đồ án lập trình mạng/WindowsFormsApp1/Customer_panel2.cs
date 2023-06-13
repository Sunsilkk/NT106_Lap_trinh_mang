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
            await LoadDataAsync();
        }

        private Supabase.Client supabase;
        private Customers_Registration_Form customers_Registration_Form = new Customers_Registration_Form();
        private Customers_Update_Form customers_Update_Form = new Customers_Update_Form();

        private async void InitializeSupabase()
        {
            supabase = await SupabaseManager.GetSupabase();
        }

        private async Task<List<Customers>> GetCustomersAsync()
        {
            var result = await supabase.From<Customers>().Get();
            var customers = result.Models;
            return customers;
        }

        private async Task LoadDataAsync()
        {
            dgv_customer.Rows.Clear();
            var customers = await GetCustomersAsync();

            foreach (var customer in customers)
            {
                dgv_customer.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Phone, customer.Created_at);
            }
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

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "loi");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text.ToLower();

            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dgv_customer.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool found = false;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            try
                            {
                                if (cell.Value != null)
                                {
                                    string cellValue = cell.Value.ToString().ToLower();

                                    if (cellValue.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            catch { }
                        }

                        row.Visible = found;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv_customer.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            customers_Registration_Form.ShowDialog();
            LoadDataAsync().ConfigureAwait(false);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            customers_Update_Form.ShowDialog();
            LoadDataAsync().ConfigureAwait(false);
        }
    }
}