using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawSomething
{
    public partial class Form1 : Form
    {
        Bitmap img;
        int pictureBox_width;
        int pictureBox_height;

        bool painting;
        bool moving;

        int posX, posY;
        Color penColor = Color.Black;

        public Form1()
        {
            InitializeComponent();

            pictureBox_width = picBox_main.Width;
            pictureBox_height = picBox_main.Height;
            painting = false;
            moving = false;
            posX = 0;
            posY = 0;
        }

        private void btn_test_Click(object sender, EventArgs e)
        {

        }

        private TcpClient client;
        public BinaryReader br;
        public BinaryWriter bw;

        private void btn_link_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(ClientA);
            myThread.Start();
        }
        private void ClientA()
        {
            //通过服务器的ip和端口号，创建TcpClient实例
            client = new TcpClient(txt_serverIP.Text, Convert.ToInt32(txt_serverPort.Text));
            this.Invoke(new Action(() =>
            {
                txt_receive.Text += "与服务器连接成功\n\n";
            }));
            while (true)
            {
                try
                {
                    NetworkStream clientStream = client.GetStream();
                    br = new BinaryReader(clientStream);
                    string receive = null;

                    receive = br.ReadString();
                    this.Invoke(new Action(() =>
                    {
                        txt_receive.Text += receive + "\r\n";
                    }));
                }
                catch
                {
                    MessageBox.Show("接收失败！");
                }
            }
        }
        //发送消息
        private void btn_send_Click(object sender, EventArgs e)
        {
            NetworkStream clientStream = client.GetStream();
            bw = new BinaryWriter(clientStream);
            bw.Write(txt_send.Text);

            this.Invoke(new Action(() =>
            {
                txt_receive.Text += txt_send.Text + "\r\n";
                txt_send.Text = "";
            }));
        }



        //清空画板
        private void btn_clear_Click(object sender, EventArgs e)
        {
            img = new Bitmap(pictureBox_width, pictureBox_height);
            Graphics graphics = Graphics.FromImage(img);
            graphics.Clear(Color.White);

            picBox_main.Image = img;

            painting = true;
        }

        #region 按住鼠标左键进行绘画
        private void picBox_main_MouseDown(object sender, MouseEventArgs e)
        {
            if(painting == true)
            {
                if(e.Button == MouseButtons.Left)
                {
                    posX = e.X;
                    posY = e.Y;

                    moving = true;
                }
            }
        }

        private void picBox_main_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving == true)
            {
                int currentX = e.X;
                int currentY = e.Y;

                Graphics graphics = Graphics.FromImage(img);
                Pen pen = new Pen(penColor, 2);
                graphics.DrawLine(pen, posX, posY, currentX, currentY);

                picBox_main.Image = img;

                posX = currentX;
                posY = currentY;
            }
        }

        private void picBox_main_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }
        #endregion

        #region 点击按钮，变更画笔颜色

        private void btn_red_Click(object sender, EventArgs e)
        {
            penColor = Color.Red;
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            penColor = Color.Blue;
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            penColor = Color.Green;
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            penColor = Color.Yellow;
        }

        private void btn_black_Click(object sender, EventArgs e)
        {
            penColor = Color.Black;
        }
        
        private void btn_white_Click(object sender, EventArgs e)
        {
            penColor = Color.White;
        }

        #endregion


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
