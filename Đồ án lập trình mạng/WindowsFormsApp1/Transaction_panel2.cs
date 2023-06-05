using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class Transaction_panel2 : UserControl
    {
        Supabase.Client supabase;
        private List<Products> productList;
        //private Products currentProduct = new Products();
        public Transaction_panel2()
        {
            InitializeComponent();
            InitializeSupabase();
        }

        private void InitializeSupabase()
        {
            var url = "https://hpvdlorgdoeaooibnffe.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImhwdmRsb3JnZG9lYW9vaWJuZmZlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODQ0MzA3ODMsImV4cCI6MjAwMDAwNjc4M30.toI_Vn6TKJFbM8YBT3qbYzLCiAfQtj9VHKw53qQNYOU";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client(url, key, options);
        }

        private async Task<List<Transactions>> GetTransactions()
        {
            var result = await supabase.From<Transactions>().Get();
            var transactions = result.Models;
            return transactions;
        }

        private async void Transactor_panel2_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task<List<Products>> GetProducts()
        {
            var result = await supabase.From<Products>().Get();
            var product = result.Models;
            return product;
        }
        private async Task LoadData()
        {
            productList = await GetProducts();
            var transactions = await GetTransactions();
            try
            {
                foreach (var transaction in transactions)
                {

                    var existingProduct = productList.FirstOrDefault(t => t.Id == transaction.ProductId);
                    if (existingProduct != null)
                        dgv_transaction.Rows.Add(transaction.Id, existingProduct.Name, transaction.Quantity, transaction.Total);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void bt_Search_Click(object sender, EventArgs e)
        {

        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dgv_transaction.Rows)
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
                foreach (DataGridViewRow row in dgv_transaction.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}
