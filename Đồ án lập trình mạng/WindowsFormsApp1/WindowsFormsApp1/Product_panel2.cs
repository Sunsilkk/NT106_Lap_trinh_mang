using System;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Product_panel2 : Form
    {
        public Product_panel2()
        {
            InitializeComponent();
        }
        Products_Registration_Form products_Registration_Form= new Products_Registration_Form();
        Supabase.Client supabase;
        DataGridView dgv_product = new DataGridView();

        private async void Product_panel2_Load(object sender, EventArgs e)
        {
          await  loaddata();
        }
       

        async Task loaddata()
        {
            var url = "https://hpvdlorgdoeaooibnffe.supabase.co";
            var key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImhwdmRsb3JnZG9lYW9vaWJuZmZlIiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODQ0MzA3ODMsImV4cCI6MjAwMDAwNjc4M30.toI_Vn6TKJFbM8YBT3qbYzLCiAfQtj9VHKw53qQNYOU";

            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            supabase = new Supabase.Client(url, key, options);
            await supabase.InitializeAsync();

            var session = await supabase.Auth.SignIn("admin@test.com", "@admin123");

            var result = await supabase.From<products>().Get();
            var product = result.Models;
            products_Registration_Form.SupabaseClient = supabase;

             dgv_product.ColumnCount = 7;
              dgv_product.Columns[0].Name = "Id";
              dgv_product.Columns[1].Name = "Type_Id";
              dgv_product.Columns[2].Name = "Pet_type_id";
              dgv_product.Columns[3].Name = "Name";
              dgv_product.Columns[4].Name = "Stock";
              dgv_product.Columns[5].Name = "Price";
              dgv_product.Columns[6].Name = "Created At";
           
            foreach (var pro in product)
            {
                

                dgv_product.Rows.Add(pro.Id, pro.Type_id, pro.Pet_type_id, pro.Name, pro.Stock, pro.Price, pro.Created_at);
            }
            dgv_product.Dock = DockStyle.Fill;
            panel1.Controls.Add(dgv_product);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            products_Registration_Form.ShowDialog();
        }

        private async void bt_search_Click(object sender, EventArgs e)
        {
            var result = await supabase.From<products>().Where(x => x.Name == txt_search.Text).Get();
            try
            {


                if (result != null && result.Models != null)
                {
                    BindingSource searchResult = new BindingSource();
                    searchResult.DataSource = result.Models;                   
                    dgv_product.Columns[0].DataPropertyName = "Id";
                    dgv_product.Columns[1].DataPropertyName = "Type_Id";
                    dgv_product.Columns[2].DataPropertyName = "Pet_type_id";
                    dgv_product.Columns[3].DataPropertyName = "Name";
                    dgv_product.Columns[4].DataPropertyName = "Stock";
                    dgv_product.Columns[5].DataPropertyName = "Price";
                    dgv_product.Columns[6].DataPropertyName = "Created At";

                    dgv_product.DataSource = searchResult;


                    dgv_product.Refresh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }
        }

        private async void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                dgv_product.Columns.Clear();
                var result = await supabase.From<products>().Get();
                var pro = result.Models;
                dgv_product.AutoGenerateColumns = false;
                dgv_product.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "ID",
                    DataPropertyName = "ID"
                });
                dgv_product.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Type_Id",
                    DataPropertyName = "Type_Id"
                });
                dgv_product.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Pet_type_id",
                    DataPropertyName = "Pet_type_id"
                });
                dgv_product.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Name",
                    DataPropertyName = "Name"
                });
                dgv_product.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Stock",
                    DataPropertyName = "Stock"
                });
                dgv_product.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Price",
                    DataPropertyName = "Price"
                });
                dgv_product.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Created At",
                    DataPropertyName = "Created_at"
                });
                dgv_product.DataSource = pro;
            }
        }

        private async void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRowIndex = dgv_product.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgv_product.Rows[selectedRowIndex];

                string columnValue = selectedRow.Cells["name"].Value.ToString();
                await supabase.From<products>().Where(x => x.Name == columnValue).Delete();
                MessageBox.Show("Xoa khach hang thanh cong");
                dgv_product.Rows.Clear();
                Product_panel2_Load(sender, e);

            }
            catch
            {
                MessageBox.Show("loi");
            }
        }
    }
}
    