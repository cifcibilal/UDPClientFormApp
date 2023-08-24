using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPClientFormApp
{
    public partial class Form1 : Form
    {
        UdpClient client;
        IPEndPoint endPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int serverPort = int.Parse(txtServerPort.Text);
            int clientPort = int.Parse(txtClientPort.Text);
            string hostName = txtHostName.Text;

            string msg = $"{clientPort}/{hostName}/{txtMsg.Text.Trim()}";
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            
            client.Send(buffer,buffer.Length,hostName,serverPort);

            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);
            msg = Encoding.UTF8.GetString(buffer);

            WriteLog(msg);
        }

        private void WriteLog(string msg)
        {
            MethodInvoker methodInvoker = new MethodInvoker(delegate
            {
                //txtLog.Text += string.Format("Server Yanıtı : {0}.{1}", msg, Environment.NewLine);
                txtLog.Text += $"Server Yanıtı : {msg}.{Environment.NewLine}";
                txtMsg.Text += string.Empty;
            });
            this.BeginInvoke(methodInvoker);
        }

        private void btnCreateClint_Click(object sender, EventArgs e)
        {
            int clientPort = int.Parse(txtClientPort.Text);
            client = new UdpClient(clientPort);

            btnCreateClint.Enabled = txtClientPort.Enabled = txtHostName.Enabled = txtServerPort.Enabled = false;
            btnSend.Enabled = true;

        }
    }
}
