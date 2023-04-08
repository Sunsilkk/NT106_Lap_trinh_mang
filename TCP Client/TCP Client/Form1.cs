using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{
    public partial class TCP_Client : Form
    {
        Socket client;
        public TCP_Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
            AddMessage(txtMessage.Text);
        }

        void Connect()
        {
            IPEndPoint IP = new IPEndPoint(IPAddress.Parse("172.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra:", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            Thread listen = new Thread(Receive);
            listen.Start();
        }

        //note
        void Close()
        {
           client.Close();
        }

        void Send()
        {
            client.Send(Serialize(txtMessage.Text));
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    AddMessage(message );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Close();
            }
           
            
        }

        void AddMessage(string s)
        {
            lsMessage.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
        }

        byte[] Serialize (object obj) 
        { 
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, obj);

            return stream.ToArray();
        }

        object Deserialize (byte [] data) 
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();

            return bf.Deserialize(stream);
        }


        private void TCP_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
