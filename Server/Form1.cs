using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;


namespace Server
{
    public partial class FormServer : Form
    {
        IPEndPoint ipep;
        Socket newsock;
        Socket client;
        Socket server;
        IPEndPoint clientep;
        byte[] data = new byte[1024];
        string input;
        delegate void MyDelegate(string mess);
        string mess = "Server: ";
        public FormServer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                ipep = new IPEndPoint(IPAddress.Any, 9999);
                newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                newsock.Bind(ipep);
                newsock.Listen(10);
                listBoxserver.Items.Add("Waiting for a client...");
                newsock.BeginAccept(new AsyncCallback(CallAccept), newsock);
                
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex);
            }
            

        }
        public void CallAccept(IAsyncResult iar)
        {
             server = (Socket)iar.AsyncState;
             client = server.EndAccept(iar);
            data = new byte[1024];
            client.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceivedData), client);
        }


        private void buttonsend_Click(object sender, EventArgs e)
        {
            input =  textBox1.Text;
            listBoxserver.Items.Add(input);
            textBox1.Text = "";
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(input );
            client.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendData), client);
        }
        private void SendData(IAsyncResult iar)
        {
             server = (Socket)iar.AsyncState;
            int sent = server.EndSend(iar);
            Invoke(new MethodInvoker(delegate { listBoxserver.Items.Add(input); }));
            client.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceivedData), client);
        }
        void ReceivedData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            data = new byte[1024];
            string receivedData = Encoding.ASCII.GetString(data, 0, recv);
            Invoke(new MethodInvoker(delegate{ listBoxserver.Items.Add(receivedData); }));
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public void addlistbox(string mess)
        //{
        //    listBoxserver.Items.Add(mess);
        //}
    }
}
