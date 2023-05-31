using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class Transaction_panel2 : Form
    {
        Supabase.Client supabase;
        DataGridView dgv_transactions = new DataGridView();
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

        private async Task LoadData()
        {
            var transactions = await GetTransactions();
            foreach (var transaction in transactions)
            {
                dgv_transaction.Rows.Add(transaction.Id, transaction.Customer_id, transaction.Product_id, transaction.Cashier_id);
            }
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
