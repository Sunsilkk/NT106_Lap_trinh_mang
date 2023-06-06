using Pet_Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Product_panel2 : UserControl
    {
        public Product_panel2()
        {
            InitializeComponent();
            InitializeSupabase();
        }
        Products_Registration_Form products_Registration_Form = new Products_Registration_Form();
        Products_Update_Form products_Update_Form = new Products_Update_Form();
        Supabase.Client supabase;
        private List<product_types> productList;
        private List<pet_types> pet_typeList;
        private async Task<List<product_types>> GetProducts_type()
        {
            var result = await supabase.From<product_types>().Get();
            var product_type = result.Models;
            return product_type;
        }
        private async Task<List<pet_types>> Getpet_type()
        {
            var result = await supabase.From<pet_types>().Get();
            var pet_type = result.Models;
            return pet_type;
        }

        private async void Product_panel2_Load(object sender, EventArgs e)
        {
            await loaddata();
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
        private async Task<List<Products>> GetProducts()
        {
            var result = await supabase.From<Products>().Get();
            var product = result.Models;
            return product;
        }

        async Task loaddata()
        {
            var product = await GetProducts();
            productList = await GetProducts_type();
            pet_typeList = await Getpet_type();


            foreach (var pro in product)
            {
                var existingProducttype = productList.FirstOrDefault(t => t.Id.ToString() == pro.Type_id.ToString());
                var existingPettype = pet_typeList.FirstOrDefault(t => t.Id.ToString() == pro.Pet_type_id.ToString());
                if (existingProducttype != null && existingPettype != null)
                    dgv_product.Rows.Add(pro.Id, existingProducttype.Type, existingPettype.Type, pro.Name, pro.Stock, pro.Price, pro.Created_at);

            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_search.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dgv_product.Rows)
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
                foreach (DataGridViewRow row in dgv_product.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private async void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgv_product.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_product.Rows[selectedRowIndex];

                string columnValue = selectedRow.Cells["name"].Value.ToString();
                await supabase.From<Products>().Where(x => x.Name == columnValue).Delete();
                MessageBox.Show("Xoá sản phẩm thành công");
                dgv_product.Rows.Clear();
                Product_panel2_Load(sender, e);

            }
            catch
            {
                MessageBox.Show("loi");
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            products_Registration_Form.ShowDialog();
            dgv_product.Rows.Clear();
            Product_panel2_Load(sender, e);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            products_Update_Form.ShowDialog();
            dgv_product.Rows.Clear();
            Product_panel2_Load(sender, e);
        }

        private void dgv_product_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
