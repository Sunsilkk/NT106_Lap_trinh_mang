using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supabase;
using Supabase.Interfaces;
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
            dgv_transactions.ColumnCount = 4;
            dgv_transactions.Columns[0].Name = "ID";
            dgv_transactions.Columns[1].Name = "customer_id";
            dgv_transactions.Columns[2].Name = "product_id";
            dgv_transactions.Columns[3].Name = "cashier_id";

            foreach (var transaction in transactions)
            {
                dgv_transactions.Rows.Add(transaction.Id, transaction.Customer_id, transaction.Product_id, transaction.Cashier_id);
            }

            dgv_transactions.Dock = DockStyle.Fill;
            panel_List_Transactor.Controls.Add(dgv_transactions);
        }

        //private class SupabaseClient
        //{
        //    private string supabaseUrl;
        //    private string supabaseKey;

        //    public SupabaseClient(string supabaseUrl, string supabaseKey)
        //    {
        //        this.supabaseUrl = supabaseUrl;
        //        this.supabaseKey = supabaseKey;
        //    }

        //    internal IEnumerable<object> From(string tableName)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
