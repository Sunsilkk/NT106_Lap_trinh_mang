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
    public partial class Customers_Update_Form : Form
    {
        public Customers_Update_Form()
        {
            InitializeComponent();
        }
        public Supabase.Client SupabaseClient { get; set; }
        Guid idcustomer;
        private async Task<List<Customers>> GetCustomers()
        {
            var result = await SupabaseClient.From<Customers>().Get();
            var cust = result.Models;
            return cust;
        }

        async Task loaddata()
        {
            var cust = await GetCustomers();


            foreach (var cus in cust)
            {
                dgv_customer.Rows.Add(cus.Id, cus.Name, cus.Address, cus.Phone, cus.Created_at);


            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Ten khong hop le!");
                e.Handled = true;
            }
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_phone.Text) && !txt_phone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Vui long nhap dung dinh dang!");
                txt_phone.Clear();
            }
        }

        private async void Customers_Update_Form_Load(object sender, EventArgs e)
        {
            dgv_customer.Rows.Clear();
            await loaddata();
        }

        private async void bt_update_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgv_customer.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgv_customer.Rows[selectedRowIndex];
            if (selectedRow.Cells["id"].Value != null)
            {
                string columnValue = selectedRow.Cells["id"].Value.ToString();
                idcustomer = Guid.Parse(columnValue);
                try
                {
                    var update = await SupabaseClient
                        .From<Customers>()
                        .Where(x => x.Id == idcustomer)
                        .Single();
                    update.Name = txt_name.Text;
                    update.Address = txt_address.Text;
                    update.Phone = (int)Convert.ToInt64(txt_phone.Text);
                    await update.Update<Customers>();
                    dgv_customer.Rows.Clear();
                    Customers_Update_Form_Load(sender, e);
                    MessageBox.Show("Cap nhat thanh cong!");
                    txt_name.Clear();
                    txt_address.Clear();
                    txt_phone.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cap nhat khong thanh cong!\r\n " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("vui long chon khách hàng!");

            }
        }
        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tb_Search.Text.ToLower();

            if (!string.IsNullOrEmpty(keyword))
            {
                foreach (DataGridViewRow row in dgv_customer.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool found = false;

                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            try
                            {
                                if (cell.Value != null)
                                {
                                    string cellValue = cell.Value.ToString().ToLower();

                                    if (cellValue.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                                    {
                                        found = true;
                                        break;
                                    }
                                }
                            }
                            catch { }
                        }

                        row.Visible = found;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv_customer.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = true;
                    }
                }
            }
        }
    }
}
