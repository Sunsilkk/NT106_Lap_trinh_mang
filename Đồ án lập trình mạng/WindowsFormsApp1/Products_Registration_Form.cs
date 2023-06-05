using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Products_Registration_Form : Form
    {
        public Products_Registration_Form()
        {
            InitializeComponent();

        }
        public Supabase.Client SupabaseClient { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void bt_add_Click(object sender, EventArgs e)
        {
            await Insert_Products();
            txt_name.Clear();
            txt_stock.Clear();
            txt_price.Clear();
            txt_pet_type_id.Clear();
            txt_product_type_id.Clear();
        }
        async Task Insert_Products()
        {
            var createdAt = DateTimeOffset.UtcNow;
            try
            {
                var model = new Products
                {
                    Type_id = txt_product_type_id.Text,
                    Pet_type_id = txt_pet_type_id.Text,
                    Name = txt_name.Text,
                    Stock = Int32.Parse(txt_stock.Text),
                    Price = long.Parse(txt_price.Text),
                    Created_at = createdAt
                };

                var result = await SupabaseClient.From<Products>().Insert(model);
                MessageBox.Show("Them khach hang thanh cong!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them khach hang khong thanh cong!" + ex.Message);
            }
        }


        async Task load_product_type()
        {

            var response = await SupabaseClient.From<product_types>().Get();

            var type = response.Models;

            dgv_type.ColumnCount = 2;
            dgv_type.Columns[0].Name = "Id";
            dgv_type.Columns[1].Name = "Name";

            foreach (var ty in type)
            {
                dgv_type.Rows.Add(ty.Id, ty.Type);
            }

            dgv_type.Dock = DockStyle.Fill;
            panel3.Controls.Add(dgv_type);

        }
        async Task load_pet_type()
        {
            var response1 = await SupabaseClient.From<pet_types>().Get();
            var type1 = response1.Models;
            dgv_pet_type.ColumnCount = 2;
            dgv_pet_type.Columns[0].Name = "Id";
            dgv_pet_type.Columns[1].Name = "Name";
            foreach (var pty in type1)
            {
                dgv_pet_type.Rows.Add(pty.Id, pty.Type);
            }
            dgv_pet_type.Dock = DockStyle.Fill;
            panel4.Controls.Add(dgv_pet_type);

        }


        private void Delete_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_stock.Clear();
            txt_price.Clear();
            txt_pet_type_id.Clear();
            txt_product_type_id.Clear();
        }

        private async void Products_Registration_Form_Load(object sender, EventArgs e)
        {
            dgv_pet_type.Rows.Clear();
            dgv_type.Rows.Clear();
            await load_pet_type();
            await load_product_type();

        }

        private void txt_stock_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_stock.Text) && !txt_stock.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Vui long nhap dung dinh dang!");
                txt_stock.Clear();
            }
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_pet_type_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgv_pet_type.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgv_pet_type.Rows[selectedRowIndex];
            if (!selectedRow.IsNewRow)
            {
                string columnValue = selectedRow.Cells["id"].Value.ToString();
                txt_pet_type_id.Text = columnValue;
            }

        }

        private void dgv_type_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = dgv_type.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgv_type.Rows[selectedRowIndex];
            if (!selectedRow.IsNewRow)
            {
                string columnValue = selectedRow.Cells["id"].Value.ToString();
                txt_product_type_id.Text = columnValue;
            }

        }
    }
}
