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
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread; // add a thread to receive messages from server
        public TCP_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Convert the message to bytes
            byte[] messageBytes = Encoding.UTF8.GetBytes(txtMessage.Text);

            //Send the message
            stream.Write(messageBytes, 0, messageBytes.Length);

            //Clear the message textbox
            txtMessage.Clear();
        }


        private void TCP_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            stream.Close();
            client.Close();
        }

        private void b_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a new TCP client object
                client = new TcpClient();

                //Connect to the server
                client.Connect("127.0.0.1", 9050);

                //Get the network stream object
                stream = client.GetStream();

                //Enable the send button
                b_Send.Enabled = true;

                txtMessage.AppendText("Connected to server!\n");

                // Start the receive thread
                receiveThread = new Thread(Receive);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {

            }
        }

        private void b_Disconnect_Click(object sender, EventArgs e)
        {
            if (stream != null)
            {
                //Close the stream
                stream.Close();
            }
            if (client != null)
            {
                //Close the client
                client.Close();
            }

            //Disable the send button
            b_Send.Enabled = false;

            //Update the message textbox from the UI thread
            if (txtMessage.InvokeRequired)
            {
                txtMessage.Invoke(new MethodInvoker(delegate {
                    txtMessage.AppendText("Disconnected from server!\n");
                }));
            }
            else
            {
                txtMessage.AppendText("Disconnected from server!\n");
            }
        }



        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    stream.Read(data, 0, data.Length);
                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch (Exception ex)
            {
                stream.Close();
                client.Close();
                b_Send.Enabled = false;
                txtMessage.AppendText("Disconnected from server!\n");
            }
        }

        void AddMessage(string s)
        {
            lsMessage.Items.Add(new ListViewItem() { Text = s });
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, obj);

            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();

            return bf.Deserialize(stream);
        }
    }
}
