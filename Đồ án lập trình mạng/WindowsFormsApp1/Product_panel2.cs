using Pet_Management;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Product_panel2 : SupabaseControl
    {

        Products_Registration_Form products_Registration_Form = new Products_Registration_Form();
        Products_Update_Form products_Update_Form = new Products_Update_Form();
        private List<product_types> productList;
        private List<pet_types> pet_typeList;

        public Product_panel2(SupabaseManager manager) : base(manager)
        {
            InitializeComponent();
        }

        private async void Product_panel2_Load(object sender, EventArgs e)
        {
            await ClientRefresh();
        }

        public override async Task ClientRefresh()
        {
            dgv_product.Rows.Clear();
            var product = await Get<Products>();
            productList = await Get<product_types>();
            pet_typeList = await Get<pet_types>();

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
            string keyword = txt_search.Text.ToLower();

            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dgv_product.Rows)
                {
                    if (!row.IsNewRow) // Chỉ xử lý những dòng không phải là dòng mới
                    {
                        bool rowVisible = false;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            try
                            {
                                string cellValue = cell.Value?.ToString().ToLower();

                                if (!string.IsNullOrEmpty(cellValue) && cellValue.Contains(keyword))
                                {
                                    rowVisible = true;
                                    break;
                                }
                            }
                            catch { }
                        }

                        row.Visible = rowVisible;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv_product.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = true;
                    }
                }
            }
        }

        private async void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgv_product.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_product.Rows[selectedRowIndex];

                string columnValue = selectedRow.Cells["Name_pro"].Value.ToString();
                await supabase.From<Products>().Where(x => x.Name == columnValue).Delete();
                MessageBox.Show("Xoá sản phẩm thành công");
                dgv_product.Rows.Clear();
                Product_panel2_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.Size = new Size(600, 800);
            form.Controls.Add(products_Registration_Form);
            form.ShowDialog();
            dgv_product.Rows.Clear();
            Product_panel2_Load(sender, e);
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            var form = new Form();
            form.Size = new Size(600, 800);
            form.Controls.Add(products_Update_Form);
            form.ShowDialog();
            dgv_product.Rows.Clear();
            Product_panel2_Load(sender, e);
        }
    }
}