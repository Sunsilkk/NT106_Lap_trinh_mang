using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class TCP_Client : Form
    {
        public TCP_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            int port = 11000;
            TcpClient client = new TcpClient();
            client.Connect(ip, port);
            MessageBox.Show("client connected!!");
            NetworkStream ns = client.GetStream();
            Thread thread = new Thread(o => ReceiveData((TcpClient)o));

            thread.Start(client);

            string s;
            while (!string.IsNullOrEmpty((s = textInput.Text)))
            {
                byte[] buffer = Encoding.UTF32.GetBytes(s);
                ns.Write(buffer, 0, buffer.Length);
            }

            client.Client.Shutdown(SocketShutdown.Send);
            thread.Join();
            ns.Close();
            client.Close();
          //  Console.WriteLine("disconnect from server!!");
          //  Console.ReadKey();
        }

        private void TCP_Client_Load(object sender, EventArgs e)
        {

        }

        static void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                Console.Write(Encoding.UTF32.GetString(receivedBytes, 0, byte_count));
            }
        }
    }
}
