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


namespace Buoi2_client
{
    public partial class FormClient : Form
    {
        delegate void MyDelegate(string mess);
        byte[] data = new byte[1024];
        string input, stringData;
        IPEndPoint ipep;
        Socket server;
        Socket sock;
        string mess = "Client: ";
        public FormClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            this.Close();
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            input =  textBox1.Text;
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes(input);
            textBox1.Text = "";
            server.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendData), server);
        }
        private  void SendData(IAsyncResult iar)
        {
            Socket server = (Socket)iar.AsyncState;
            int sent = server.EndSend(iar);
            Invoke(new MethodInvoker(delegate { listBoxclient.Items.Add(input); }));
            data = new byte[1024];
            server.BeginReceive(data, 0, data.Length, SocketFlags.None, new AsyncCallback(ReceivedData), server);
        }
        void ReceivedData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string receivedData = Encoding.ASCII.GetString(data, 0, recv);
            Invoke(new MethodInvoker(delegate { listBoxclient.Items.Add(receivedData); }));
        }



        private void buttonketnoi_Click(object sender, EventArgs e)
        {
            ipep = new IPEndPoint(IPAddress.Parse(textBox2.Text), 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {

                server.BeginConnect(ipep, new AsyncCallback(Connected), server);
                
            }
            catch (SocketException ex)
            {
                listBoxclient.Items.Add("Unable to connect to servers.");
                listBoxclient.Items.Add(ex.ToString());
                return;
            }
        }
        public void Connected(IAsyncResult iar)
        {
            sock = (Socket)iar.AsyncState;
            sock.EndConnect(iar);
        }

    }
}
