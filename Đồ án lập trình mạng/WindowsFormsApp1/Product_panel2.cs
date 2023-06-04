﻿using System;
using System.Collections.Generic;
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
        Supabase.Client supabase;


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
        }
        private async Task<List<products>> GetProducts()
        {
            var result = await supabase.From<products>().Get();
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





        private void btn_Add_Click(object sender, EventArgs e)
        {
            products_Registration_Form.ShowDialog();
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
