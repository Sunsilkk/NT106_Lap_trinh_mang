using Pet_Management;
using System;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            AddNewTab(new Home(), "Home");
            AddNewTab(new Customer_panel2(), "Customers");
            AddNewTab(new Cage(), "Cage");
            AddNewTab(new Product_panel2(), "Products");
            AddNewTab(new Billing_panel2(), "Billing");
            AddNewTab(new Transaction_panel2(), "Transactions");

        }

        private void AddNewTab(Control control, string tabTitle)
        {
            var tab = new TabPage(control.Text);
            tab.Text = tabTitle;
            control.Dock = DockStyle.Fill;
            tab.Controls.Add(control);
            tabControl1.TabPages.Add(tab);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Tạo đối tượng PrivateFontCollection
            PrivateFontCollection privateFonts = new PrivateFontCollection();

            // Truy xuất tài nguyên nhúng của font
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream fontStream = assembly.GetManifestResourceStream("WindowsFormsApp1.Resources.Qaz-ZV74m.ttf");

            // Đọc dữ liệu font từ luồng
            byte[] fontData = new byte[fontStream.Length];
            fontStream.Read(fontData, 0, (int)fontStream.Length);
            fontStream.Close();

            // Thêm font vào PrivateFontCollection
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            privateFonts.AddMemoryFont(fontPtr, fontData.Length);

            // Sử dụng font trong các điều khiển WinForms
           // Font customFont = new Font(privateFonts.Families[0], 12f, FontStyle.Regular);
           // yourLabel.Font = customFont;
           // yourButton.Font = customFont;

            // Giải phóng bộ nhớ cho font
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
