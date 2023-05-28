using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Security;
using Npgsql;
using Postgrest.Attributes;
using Postgrest.Models;
using System.Security.Policy;
using System.Windows.Input;
using System.Reflection;
using Supabase.Interfaces;
using System.Xml.Linq;
using Supabase;
using static Supabase.StatelessClient;
using static Supabase.SupabaseModel;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Customer_panel2 : Form
    {
      
        public Customer_panel2()
        {
            InitializeComponent();
            
        }
       
        private async void Customer_panel2_Load(object sender, EventArgs e)
        {
           await loaddata();
        }
         
        Supabase.Client supabase;
        DataGridView dgv_customer= new DataGridView();
         Customers_Registration_Form customers_Registration_Form = new Customers_Registration_Form();
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

             var result = await supabase.From<Customers>().Get();
             var customers = result.Models;
            
             customers_Registration_Form.SupabaseClient = supabase;
            
             dgv_customer.ColumnCount = 5; 
             dgv_customer.Columns[0].Name = "ID";
             dgv_customer.Columns[1].Name = "Name";
             dgv_customer.Columns[2].Name = "Address";
             dgv_customer.Columns[3].Name = "Phone";
             dgv_customer.Columns[4].Name = "Created At";           
          
            foreach (var customer in customers)
             {                 
                  dgv_customer.Rows.Add(customer.Id, customer.Name, customer.Address, customer.Phone, customer.Created_at);
             }
           
            dgv_customer.Dock = DockStyle.Fill;
            panel1.Controls.Add(dgv_customer);
        }
        



        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            customers_Registration_Form.ShowDialog();
            dgv_customer.Rows.Clear();
            Customer_panel2_Load(sender, e );
            

            
        }


        private async void btn_search_Click(object sender, EventArgs e)
        {
           
           var result = await supabase.From<Customers>().Where(x => x.Name == txt_search.Text).Get();
            try
            {


                if (result != null && result.Models != null)
                {
                    BindingSource searchResult = new BindingSource();
                    searchResult.DataSource = result.Models;
                    dgv_customer.Columns[0].DataPropertyName = "ID";
                    dgv_customer.Columns[1].DataPropertyName = "Name";
                    dgv_customer.Columns[2].DataPropertyName = "Address";
                    dgv_customer.Columns[3].DataPropertyName = "Phone";
                    dgv_customer.Columns[4].DataPropertyName = "Created_at";

                    dgv_customer.DataSource = searchResult;
                   

                    dgv_customer.Refresh();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("loi"+ ex.Message);
            }
        }
       


        private async void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                    int selectedRowIndex = dgv_customer.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dgv_customer.Rows[selectedRowIndex];
                    
                    string columnValue = selectedRow.Cells["name"].Value.ToString();
                    await supabase.From<Customers>().Where(x => x.Name == columnValue).Delete();
                    MessageBox.Show("Xoa khach hang thanh cong");
                    dgv_customer.Rows.Clear();
                    Customer_panel2_Load(sender, e);

            }
            catch
            {
                MessageBox.Show("loi");
            }
        }

        private async void txt_search_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_search.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                dgv_customer.Columns.Clear();                
                var result = await supabase.From<Customers>().Get();
                var customers = result.Models;                
                dgv_customer.AutoGenerateColumns = false;
                dgv_customer.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "ID",
                    DataPropertyName = "ID"
                });
                dgv_customer.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Name",
                    DataPropertyName = "Name"
                });
                dgv_customer.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Address",
                    DataPropertyName = "Address"
                });
                dgv_customer.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Phone",
                    DataPropertyName = "Phone"
                });
                dgv_customer.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "Created At",
                    DataPropertyName = "Created_at"
                });                
                dgv_customer.DataSource = customers;
            }
        }
       
    }
}

