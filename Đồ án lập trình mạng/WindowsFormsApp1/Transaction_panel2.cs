using Pet_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class Transaction_panel2 : SupabaseControl
    {
        private List<Products> productList;
        private SupabaseManager supabaseManager;
        public Transaction_panel2(SupabaseManager manager) : base(manager)
        {
            InitializeComponent();
            supabaseManager = new SupabaseManager();
        }

        

        private async void Transactor_panel2_Load(object sender, EventArgs e)
        {

            await ClientRefresh();
        }

        public override async Task ClientRefresh()
        {
            dgv_transaction.Rows.Clear();
            productList = await Get<Products>();
            var transactions = await Get<Transactions>();
            try
            {
                foreach (var transaction in transactions)
                {

                    var existingProduct = productList.FirstOrDefault(t => t.Id == transaction.ProductId);
                    if (existingProduct != null)
                        dgv_transaction.Rows.Add(transaction.Id, existingProduct.Name, transaction.Quantity, transaction.Total);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bt_Search_Click(object sender, EventArgs e)
        {

        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text.ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dgv_transaction.Rows)
                {
                    if (!row.IsNewRow) 
                    {
                        bool found = false;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyword))
                            {
                                found = true;
                                break;
                            }
                        }

                        row.Visible = found;
                    }
                }
            }
            else {
                foreach (DataGridViewRow row in dgv_transaction.Rows)
                {
                    row.Visible = true;
                }
            }
        }
    }
}