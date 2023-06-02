using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Billing : Form
    {
        Supabase.Client supabase;
        List<products> productList;
        public Billing()
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
        private async Task<List<products>> GetProducts()
        {
            var result = await supabase.From<products>().Get();
            var product = result.Models;
            return product;
        }
        private void bt_Add_Product_Click(object sender, EventArgs e)
        {
            if (cb_Qty.SelectedItem != null && cb_Select.SelectedItem !=null)
            {
                

            }
        }
        private async Task LoadData()
        {
            productList = await GetProducts(); // Lưu danh sách sản phẩm vào biến tạm thời
            foreach (var product in productList)
            {
                cb_Select.Items.Add(product.Name);
            }
        }
        private async void Billing_Load(object sender, EventArgs e)
        {
            lb_total.Text = string.Empty;

            await LoadData();
        }

        private void cb_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Qty.Items.Clear();
            cb_Qty.SelectedIndex = -1;
           
            foreach (var product in productList)
            {
                if (product.Name == cb_Select.SelectedItem.ToString())
                {
                    int x = 0;
                    try
                    {
                        x = Int32.Parse(product.Stock);
                    }
                    catch
                    {
                        x = 1;
                    }
                    for (int i = 1; i <= x; i++)
                    {
                        cb_Qty.Items.Add(i);
                    }
                    break;
                }
            }
        }
    }
}
