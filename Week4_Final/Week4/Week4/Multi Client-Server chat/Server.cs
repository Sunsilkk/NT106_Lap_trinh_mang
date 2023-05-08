using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using SuperSimpleTcp;

namespace Multi_Client_Server_chat
{
    public partial class Server : Form
    {
        private Dictionary<string, string> clientList;
        private readonly string receivedImagesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReceivedImages");

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

        public Server()
        {
            InitializeComponent();
            clientList = new Dictionary<string, string>();
            server = new SimpleTcpServer(IPAddress.Any.ToString(), 8080);
            server.Events.DataReceived += Events_DataReceived;
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            Directory.CreateDirectory(receivedImagesDirectory);
        }

        SimpleTcpServer server;

        private void b_Start_Click(object sender, EventArgs e)
        {
            server.Start();
            rMessage.AppendText($"Starting... {Environment.NewLine}");
            b_Start.Enabled = false;
            b_Send.Enabled = true;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            b_Send.Enabled = false;
        }

        private async void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Data.ToArray());

            if (clientList.TryGetValue(e.IpPort, out var name))
            {
                if (message.StartsWith("(TO)"))
                {
                    var data = message.Split('-');
                    var otherClient = data[1];
                    var messageContent = string.Join("-", data.Skip(2));
                    if (clientList.TryGetValue(otherClient, out var otherClientName))
                    {
                        await server.SendAsync(otherClient, $"(FROM)-{e.IpPort}-{messageContent}").ConfigureAwait(false);
                    }
                    return;
                }

                if (message.StartsWith("(FILE)"))
                {
                    var data = message.Split('-');
                    var otherClient = data[1];
                    var fileName = data[2];
                    var imageContent = string.Join("-", data.Skip(3));
                    var imagePath = Path.Combine(receivedImagesDirectory, fileName);
                    File.WriteAllBytes(imagePath, Convert.FromBase64String(imageContent));
                    await server.SendAsync(otherClient, $"(FILE)-{e.IpPort}-{fileName}-{imageContent}");
                    return;
                }

                var broadcastMessage = $"{name}: {message}";
                rMessage.Invoke(new Action(() => rMessage.AppendText(broadcastMessage + Environment.NewLine)));
                foreach (var otherClient in server.GetClients().Where(client => client != e.IpPort))
                {
                    await server.SendAsync(otherClient, broadcastMessage).ConfigureAwait(false);
                }
                return;
            }

            clientList.Add(e.IpPort, message);

            endpointListView.Invoke(new Action(() => endpointListView.Items.Add(new ListViewItem()
            {
                Text = message,
                Name = e.IpPort
            })));

            foreach (var otherClient in server.GetClients().Where(client => client != e.IpPort))
            {
                await server.SendAsync(otherClient, $"(ADD)-{e.IpPort}-{message}").ConfigureAwait(false);
                if (clientList.TryGetValue(otherClient, out var otherClientName))
                    await server.SendAsync(e.IpPort, $"(ADD)-{otherClient}-{otherClientName}").ConfigureAwait(false);
            }
        }



        private async void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            rMessage.Invoke(new Action(() => rMessage.AppendText($"{e.IpPort} disconnected." + Environment.NewLine)));
            clientList.Remove(e.IpPort);
            endpointListView.Invoke(new Action(() => endpointListView.Items.RemoveByKey(e.IpPort)));
            foreach (var otherClient in server.GetClients().Where(client => client != e.IpPort))
            {
                await server.SendAsync(otherClient, $"(DEL)-{e.IpPort}").ConfigureAwait(false);
            }
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            var ipPort = e.IpPort.Split(':');
            rMessage.Invoke(new Action(() => rMessage.AppendText($"New client connected from {ipPort[0]} on port {ipPort[1]}" + Environment.NewLine)));
        }

        private async void b_Send_Click(object sender, EventArgs e)
        {
            if (!server.IsListening || string.IsNullOrEmpty(txtMessages.Text))
            {
                return;
            }

            var message = txtMessages.Text;

            if (endpointListView.SelectedItems.Count > 0)
            {
                var clientAddress = endpointListView.SelectedItems[0].Name;
                if (clientList.TryGetValue(clientAddress, out var name))
                {
                    var broadcastMessageBuilder = new StringBuilder();
                    broadcastMessageBuilder.Append(name);
                    broadcastMessageBuilder.Append(": ");
                    broadcastMessageBuilder.Append(message);
                    var broadcastMessage = broadcastMessageBuilder.ToString();

                    rMessage.Invoke(new Action(() => rMessage.AppendText(broadcastMessage + Environment.NewLine)));

                    await server.SendAsync(clientAddress, message).ConfigureAwait(false);
                }
                else
                {
                    MessageBox.Show("Invalid client address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var broadcastMessage = $"Server: {message}";
                rMessage.Invoke(new Action(() => rMessage.AppendText(broadcastMessage + Environment.NewLine)));
                foreach (var otherClient in server.GetClients())
                {
                    await server.SendAsync(otherClient, broadcastMessage).ConfigureAwait(false);
                }
            }

            txtMessages.Invoke(new Action(() => txtMessages.Text = string.Empty));
        }




        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Form properties
            this.Text = "Multi-Client Server Chat";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(255, 228, 225); // Hồng sáng

            // ... other UI components

            // rMessage properties
            rMessage.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            rMessage.ForeColor = Color.FromArgb(50, 50, 50);

            // txtMessages properties
            txtMessages.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            txtMessages.ForeColor = Color.FromArgb(50, 50, 50);

            // b_Send properties
            b_Send.BackColor = Color.FromArgb(255, 99, 71); // Đỏ đậm
            b_Send.ForeColor = Color.FromArgb(255, 255, 255);

            // b_Start properties
            b_Start.BackColor = Color.FromArgb(255, 99, 71); // Đỏ đậm
            b_Start.ForeColor = Color.FromArgb(255, 255, 255);

            // endpointListView properties
            endpointListView.BackColor = Color.FromArgb(255, 192, 203); // Hồng nhạt
            endpointListView.ForeColor = Color.FromArgb(50, 50, 50);
            endpointListView.FullRowSelect = true;
            endpointListView.GridLines = true;
        }

    }
}
