using SuperSimpleTcp;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Multi_Client_Server_chat
{
    public partial class Client : Form
    {
        public event EventHandler<PrivateMessageEventArgs> PrivateMessageReceived;
        private SimpleTcpClient client;
        public Client()
        {
            InitializeComponent();

        }

        public class PrivateMessageEventArgs : EventArgs
        {
            public string Id { get; set; }
            public string Message { get; set; }
            public bool IsImage { get; set; }

            public PrivateMessageEventArgs(string id, string message, bool isImage = false)
            {
                Id = id;
                Message = message;
                IsImage = isImage;
            }
        }

        private async void b_Connect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên không được rỗng");
                return;
            }

            if (!IPAddress.TryParse(txtIPAddress.Text, out var ipAddress))
            {
                MessageBox.Show("Địa chỉ IP không đúng định dạng.");
                return;
            }

            client = new SimpleTcpClient(ipAddress.ToString(), 8080);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;

            try
            {
                client.Connect();
                await client.SendAsync(txtName.Text);
                b_Connect.Enabled = false;
                b_Disconnect.Enabled = true;
                b_Send.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Server not responding");
                b_Connect.Enabled = true;
                b_Disconnect.Enabled = false;
                return;
            }
        }

        private void b_Disconnect_Click(object sender, EventArgs e)
        {
            if (client != null && client.IsConnected)
            {
                client.Events.Connected -= Events_Connected;
                client.Events.DataReceived -= Events_DataReceived;
                client.Events.Disconnected -= Events_Disconnected;

                client.Disconnect();
                Events_Disconnected(sender, null);
                b_Connect.Enabled = true;
                b_Disconnect.Enabled = false;
                b_Send.Enabled = false;
            }
        }

        private void b_Send_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMessages.Text))
                {
                    client.Send(txtMessages.Text);
                    rMessage.AppendText($"Me: {txtMessages.Text}" + Environment.NewLine);
                    txtMessages.Clear();
                }
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            b_Send.Enabled = false;
            b_Disconnect.Enabled = false;
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            client.Disconnect();
            rMessage.Invoke(new Action(() => rMessage.AppendText($"Server Disconnected." + Environment.NewLine)));
            b_Disconnect.Invoke(new Action(() => b_Disconnect.Enabled = false));
            b_Connect.Invoke(new Action(() => b_Connect.Enabled = true));
        }


        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            rMessage.Invoke(new Action(() => rMessage.AppendText($"Server Connected." + Environment.NewLine)));
            b_Disconnect.Invoke(new Action(() => b_Disconnect.Enabled = true));
            b_Connect.Invoke(new Action(() => b_Connect.Enabled = false));
        }


        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Data.ToArray());

            if (message.StartsWith("(ADD)"))
            {
                var _data = message.Split('-');
                var id = _data[1];
                var name = string.Join("-", _data.Skip(2));
                endpointListView.Invoke(new Action(() => endpointListView.Items.Add(new ListViewItem()
                {
                    Text = name,
                    Name = id
                })));
                return;
            }

            if (message.StartsWith("(DEL)"))
            {
                var _data = message.Split('-');
                var id = _data[1];
                endpointListView.Invoke(new Action(() => endpointListView.Items.RemoveByKey(id)));
                return;
            }

            if (message.StartsWith("(FROM)"))
            {
                var _data = message.Split('-');
                var id = _data[1];
                var messageContent = string.Join("-", _data.Skip(2));

                bool isImage = false;
                if (messageContent.StartsWith("(IMG)"))
                {
                    var imageContentData = messageContent.Split(new[] { '-' }, 2);
                    messageContent = imageContentData[1];
                    isImage = true;
                }

                PrivateMessageReceived?.Invoke(this, new PrivateMessageEventArgs(id, messageContent, isImage));
                return;
            }

            rMessage.Invoke(new Action(() => rMessage.AppendText(message + Environment.NewLine)));
        }   
            

     

        private void endpointListView_Click(object sender, EventArgs e)
        {
            var otherClientName = endpointListView.SelectedItems[0].Text;
            PrivateChat privateChat = new PrivateChat(client, otherClientName, endpointListView.SelectedItems[0].Name);
            privateChat.Text = $"Private chat from {txtName.Text} to {otherClientName}";
            PrivateMessageReceived += privateChat.PrivateMessageReceived;
            privateChat.Show();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Form properties
            this.Text = "Client Chat";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(255, 228, 225); // Hồng sáng

            // ... other UI components

            // rMessage properties
            rMessage.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            rMessage.ForeColor = Color.FromArgb(50, 50, 50);

            // txtMessages properties
            txtMessages.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            txtMessages.ForeColor = Color.FromArgb(50, 50, 50);

            // b_Connect properties
            b_Connect.BackColor = Color.FromArgb(139, 233, 253);
            b_Connect.ForeColor = Color.FromArgb(40, 42, 54);

            // b_Send properties
            b_Send.BackColor = Color.FromArgb(139, 233, 253);
            b_Send.ForeColor = Color.FromArgb(40, 42, 54);

            // txtName properties
            txtName.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            txtName.ForeColor = Color.FromArgb(50, 50, 50);

            // endpointListView properties
            endpointListView.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            endpointListView.ForeColor = Color.FromArgb(50, 50, 50);
            endpointListView.FullRowSelect = true;
            endpointListView.GridLines = true;

            // txtName properties
            txtIPAddress.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            txtIPAddress.ForeColor = Color.FromArgb(50, 50, 50);
        }
    }
}
