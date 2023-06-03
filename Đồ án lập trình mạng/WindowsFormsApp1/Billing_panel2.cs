using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Client.Result;
using ZXing.Common;
using ZXing.PDF417.Internal;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using ZXing.Windows.Compatibility;

namespace WindowsFormsApp1
{
    public partial class Billing_panel2 : Form
    {
        Supabase.Client supabase;
        List<products> productList;
        products product_t=new products();
        public Billing_panel2()
        {
            InitializeComponent();
            InitializeSupabase();
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
        }

        private async Task<List<products>> GetProducts()
        {
            var result = await supabase.From<products>().Get();
            var product = result.Models;
            return product;
        }

        private void bt_Add_Product_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Qty.SelectedItem != null && cb_Select.SelectedItem != null)
                {
                    int row = dgv_Billing.RowCount;
                    dgv_Billing.Rows.Add(row, product_t.Name, product_t.Type_id, product_t.Pet_type_id, cb_Qty.SelectedItem, product_t.Price);
                }
                long sum = Int32.Parse(lb_total.Text);
                int qty = (int)cb_Qty.SelectedItem;
                sum += Int32.Parse(product_t.Price) * qty;
                lb_total.Text = sum.ToString();
            }
            catch { }
        }

        private async Task LoadData()
        {
            productList = await GetProducts();
            foreach (var product in productList)
            {
                cb_Select.Items.Add(product.Name);
            }
        }

        private async void Billing_Load(object sender, EventArgs e)
        {
            lb_total.Text = "0";
            await LoadData();
        }

        private void cb_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Qty.Items.Clear();
            cb_Qty.SelectedIndex = -1;
            foreach (var product in productList)
            {
                if (product.Name == cb_Select.SelectedItem.ToString())
                {
                    product_t = product;
                    int x = 0;
                    try
                    {
                        x = Int32.Parse(product.Stock);
                    }
                    catch
                    {
                        x = 1;
                    }
                    for (int i = 1; i <= x; i++)
                    {
                        cb_Qty.Items.Add(i);
                    }
                    break;
                }
            }
        }

        private void bt_Cash_Click(object sender, EventArgs e)
        {
            var qrcode_text = $"2|99|{"0355082441"}|{"Vo Thi Hoai Thanh"}|{"21520458@gm.uit.edu.vn"}|0|0|{lb_total.Text}";
            var barcodeWriter = new BarcodeWriter<Bitmap>();
            EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOptions;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(qrcode_text);
            Bitmap logo = resizeImage(Properties.Resources.MoMo_Logo, 64, 64) as Bitmap;
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));

            using (var qrCodeForm = new QRCodeForm(bitmap))
            {
                qrCodeForm.ShowDialog();
            }
        }

        public Bitmap resizeImage(Image originalImage, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage(new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(originalImage, 0, 0, new_width, new_height);
            return new_image;
        }
    }

    public partial class QRCodeForm : Form
    {
        private PictureBox pictureBox;

        public QRCodeForm(Image qrCodeImage)
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(qrCodeImage.Width, qrCodeImage.Height);
            pictureBox.Image = qrCodeImage;
            Controls.Add(pictureBox);
        }

        private void InitializeComponent()
        {
        }

    }
}

