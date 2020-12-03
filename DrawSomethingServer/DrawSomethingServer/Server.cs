using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace DrawSomethingServer
{
    public partial class Server : Form
    {
        private TcpListener myListener;
        private TcpClient newClient;
        public BinaryReader br;
        public BinaryWriter bw;


        public Server()
        {
            InitializeComponent();

        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            //利用TcpClient对象GetStream方法得到网络流
            NetworkStream clientStream = newClient.GetStream();
            bw = new BinaryWriter(clientStream);
            //写入
            string time = DateTime.Now.ToString();
            bw.Write(time + "\nmessage received!\n");
            txt_messages.Text += time + "\nmessage sent!\n";
        }


        private void ServerA()
        {
            IPAddress ip = IPAddress.Parse(txt_ip.Text);//服务器端ip
            myListener = new TcpListener(ip, Convert.ToInt32(txt_port.Text));//创建TcpListener实例
            myListener.Start();//start

            this.Invoke(new Action(() =>
            {
                txt_messages.Text += "waiting for connection...\n";
            }));

            newClient = myListener.AcceptTcpClient();//等待客户端连接

            this.Invoke(new Action(() =>
            {
                txt_messages.Text += "收到来自 " + newClient.Client.RemoteEndPoint.ToString() + " 的连接。\n";
            }));
            
            while (true)
            {
                try
                {
                    NetworkStream clientStream = newClient.GetStream();//利用TcpClient对象GetStream方法得到网络流
                    br = new BinaryReader(clientStream);
                    string receive = null;
                    receive = br.ReadString();//读取

                    this.Invoke(new Action(() =>
                    {
                        txt_messages.Text += receive + "\r\n";
                    }));
                }
                catch
                {
                    MessageBox.Show("接收失败！");
                    break;
                }
            }
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(ServerA);
            myThread.Start();
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
