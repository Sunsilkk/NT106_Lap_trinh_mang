using SuperSimpleTcp;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Multi_Client_Server_chat
{
    public partial class PrivateChat : Form
    {
        private readonly SimpleTcpClient _client;
        private readonly string _id;
        private readonly string _name;
        private Image selectedImage;

        public PrivateChat(SimpleTcpClient client, string name, string id)
        {
            InitializeComponent();
            _client = client;
            _name = name;
            _id = id;
            //Hồng sáng
            this.BackColor = Color.FromArgb(255, 228, 225);

            privateRichTextBox.BackColor = Color.FromArgb(255, 192, 203);
            privateRichTextBox.ForeColor = Color.FromArgb(50, 50, 50); ; //hồng nhạt

            fileChooser.BackColor = Color.FromArgb(192, 0, 0);
            fileChooser.ForeColor = Color.FromArgb(0, 0, 0);

            sendButton.BackColor = Color.FromArgb(192, 0, 0);
            sendButton.ForeColor = Color.FromArgb(0, 0, 0);

            messageTextBox.BackColor = Color.FromArgb(255, 192, 203);
            messageTextBox.ForeColor = Color.FromArgb(50, 50, 50);


        }

        public class PrivateMessageEventArgs : EventArgs
        {
            public string Id { get; set; }
            public string Message { get; set; }
            public bool IsImage { get; set; }

            public PrivateMessageEventArgs(string id, string message, bool isImage)
            {
                Id = id;
                Message = message;
                IsImage = isImage;
            }
        }


        private void fileChooser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG",
                Title = "Select an image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                privateRichTextBox.AppendText($"Me: {messageTextBox.Text}" + Environment.NewLine);
                await _client.SendAsync($"(TO)-{_id}-{messageTextBox.Text}");
                messageTextBox.Clear();
                return;
            }
            else if (selectedImage != null)
            {
                string imageId = Guid.NewGuid().ToString();
                byte[] imageBytes = ImageToByteArray(selectedImage);
                await _client.SendAsync($"(IMG)-{_id}-{imageId}-{Convert.ToBase64String(imageBytes)}");
                InsertImageToRichTextBox(privateRichTextBox, selectedImage); 
                selectedImage = null;
            }
        }


        public void PrivateMessageReceived(object sender, Client.PrivateMessageEventArgs e)
        {
            if (e.Id == _id)
            {
                if (e.IsImage)
                {
                    Image receivedImage = ByteArrayToImage(Convert.FromBase64String(e.Message));
                    privateRichTextBox.Invoke(new Action(() => InsertImageToRichTextBox(privateRichTextBox, receivedImage)));
                }
                else
                {
                    privateRichTextBox.Invoke(new Action(() => privateRichTextBox.AppendText($"{_name}: {e.Message}" + Environment.NewLine)));
                }
            }
        }


        private void InsertImageToRichTextBox(RichTextBox rtb, Image image)
        {
            Clipboard.SetImage(image);
            rtb.Paste();
            rtb.AppendText(Environment.NewLine);
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void privateRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
