using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Pet_Management
{
    public partial class Products_Update_Form : Form
    {
        public Products_Update_Form()
        {
            InitializeComponent();
        }
        public Supabase.Client SupabaseClient { get; set; }
        Guid idproduct;
        private async Task<List<Products>> GetProducts()
        {
            var result = await SupabaseClient.From<Products>().Get();
            var product = result.Models;
            return product;
        }

        async Task loaddata()
        {
            var product = await GetProducts();


            foreach (var pro in product)
            {
                dgv_product.Rows.Add(pro.Id, pro.Type_id, pro.Pet_type_id, pro.Name, pro.Stock, pro.Price, pro.Created_at);

            }
        }

        private async void Products_Update_Form_Load(object sender, EventArgs e)
        {
            dgv_product.Rows.Clear();
            await loaddata();
        }

        private async void bt_update_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgv_product.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgv_product.Rows[selectedRowIndex];
            if (selectedRow.Cells["id"].Value != null)
            {
                string columnValue = selectedRow.Cells["id"].Value.ToString();
                idproduct = Guid.Parse(columnValue);
                try
                {
                    var update = await SupabaseClient
                        .From<Products>()
                        .Where(x => x.Id == idproduct)
                        .Single();
                    update.Name = txt_name.Text;
                    update.Price = Int32.Parse(txt_price.Text);
                    update.Stock = Int32.Parse(txt_stock.Text);
                    await update.Update<Products>();
                    dgv_product.Rows.Clear();
                    Products_Update_Form_Load(sender, e);
                    MessageBox.Show("Cap nhat thanh cong!");
                    txt_name.Clear();
                    txt_price.Clear();
                    txt_stock.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cap nhat khong thanh cong!\r\n " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("vui long chon san pham!");

            }
        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_stock.Text) && !txt_stock.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Vui long nhap dung dinh dang!");
                txt_stock.Clear();
            }
        }
    }
}
