using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        Socket Server;
        IPEndPoint IP;
        List<Socket> Clientlist;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void b_Send_Click(object sender, EventArgs e)
        {
            foreach (Socket item in Clientlist)
            {
                Send(item);
            }
           txtMessage.Clear();
            
        }

        void Connect()
        {
            Clientlist = new List<Socket>();

            IP = new IPEndPoint(IPAddress.Any, 8080);
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            Server.Bind(IP);


            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        Server.Listen(1000);
                        Socket client = Server.Accept();
                        Clientlist.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch 
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
               
                 
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        //note
        void Close()
        {
            Server.Close();
        }

        void Send(Socket client)
        {
            if(txtMessage.Text != string.Empty)
            {
                client.Send(Serialize(txtMessage.Text));
            }
            
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    AddMessage(message);
                }
            }
            catch (Exception ex)
            {
                Clientlist.Remove(client);
                client.Close();              
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
