using Pet_Management;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Product_panel2 : UserControl
    {
        private Products_Registration_Form products_Registration_Form = new Products_Registration_Form();
        private Products_Update_Form products_Update_Form = new Products_Update_Form();
        private Supabase.Client supabase;
        private BindingList<Products> productsList;

        public Product_panel2()
        {
            InitializeComponent();
            InitializeSupabase();
        }

        private void Product_panel2_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
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
            products_Registration_Form.SupabaseClient = supabase;
            products_Update_Form.SupabaseClient = supabase;
        }

        private async Task<List<Products>> GetProductsAsync()
        {
            var result = await supabase.From<Products>().Get();
            var product = result.Models;
            return product;
        }

        private async void LoadDataAsync()
        {
            var product = await GetProductsAsync();

            productsList = new BindingList<Products>(product);
            dgv_product.DataSource = productsList;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            var filteredProducts = string.IsNullOrEmpty(keyword)
                ? productsList
                : new BindingList<Products>(productsList.Where(p => p.Name.Contains(keyword)).ToList());

            dgv_product.DataSource = filteredProducts;
        }

        private async void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgv_product.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_product.Rows[selectedRowIndex];

                string columnValue = selectedRow.Cells["name"].Value.ToString();
                await supabase.From<Products>().Where(x => x.Name == columnValue).Delete();
                MessageBox.Show("Xoa khach hang thanh cong");
                LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            products_Registration_Form.ShowDialog();
            LoadDataAsync();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            products_Update_Form.ShowDialog();
            LoadDataAsync();
        }
    }
}
