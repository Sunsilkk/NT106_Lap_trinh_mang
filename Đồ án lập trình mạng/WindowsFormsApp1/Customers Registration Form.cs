using Pet_Management;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Customers_Registration_Form : Form
    {
        private SupabaseManager supabaseManager;
        public Customers_Registration_Form()
        {
            InitializeComponent();
            supabaseManager = new SupabaseManager();
        }
        public Supabase.Client SupabaseClient
        {
            get;
            set;
        }

        private async void bt_add_Click(object sender, EventArgs e)
        {
            await Insert_Customers();
            txt_address.Clear();
            txt_name.Clear();
            txt_phone.Clear();
        }

        async Task Insert_Customers()
        {
            var createdAt = DateTimeOffset.UtcNow;
            try
            {
                var model = new Customers
                {
                    Name = txt_name.Text,
                    Address = txt_address.Text,
                    Phone = Int32.Parse(txt_phone.Text),
                    Created_at = createdAt
                };

                var result = await supabaseManager.Client.From<Customers>().Insert(model);
                MessageBox.Show("Them khach hang thanh cong!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them khach hang khong thanh cong!" + ex.Message);
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            txt_name.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_phone.Text = string.Empty;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_phone.Text) && !txt_phone.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Vui long nhap dung dinh dang!");
                txt_phone.Clear();
            }
        }

        private void Customers_Registration_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Ten khong hop le!");
                e.Handled = true;
            }
        }

    }
}