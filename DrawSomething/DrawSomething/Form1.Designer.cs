namespace DrawSomething
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox_main = new System.Windows.Forms.PictureBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_black = new System.Windows.Forms.Button();
            this.btn_white = new System.Windows.Forms.Button();
            this.txt_receive = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.txt_serverIP = new System.Windows.Forms.TextBox();
            this.txt_serverPort = new System.Windows.Forms.TextBox();
            this.txt_room = new System.Windows.Forms.TextBox();
            this.btn_link = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_main
            // 
            this.picBox_main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picBox_main.Location = new System.Drawing.Point(167, 73);
            this.picBox_main.Name = "picBox_main";
            this.picBox_main.Size = new System.Drawing.Size(769, 458);
            this.picBox_main.TabIndex = 0;
            this.picBox_main.TabStop = false;
            this.picBox_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_main_MouseDown);
            this.picBox_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_main_MouseMove);
            this.picBox_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_main_MouseUp);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(21, 73);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 1;
            this.btn_test.Text = "test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(21, 121);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.Location = new System.Drawing.Point(21, 205);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(30, 30);
            this.btn_red.TabIndex = 3;
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.Blue;
            this.btn_blue.Location = new System.Drawing.Point(21, 234);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(30, 30);
            this.btn_blue.TabIndex = 4;
            this.btn_blue.UseVisualStyleBackColor = false;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // btn_green
            // 
            this.btn_green.BackColor = System.Drawing.Color.Green;
            this.btn_green.Location = new System.Drawing.Point(21, 263);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(30, 30);
            this.btn_green.TabIndex = 5;
            this.btn_green.UseVisualStyleBackColor = false;
            this.btn_green.Click += new System.EventHandler(this.btn_green_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.Location = new System.Drawing.Point(21, 292);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(30, 30);
            this.btn_yellow.TabIndex = 6;
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_black
            // 
            this.btn_black.BackColor = System.Drawing.Color.Black;
            this.btn_black.Location = new System.Drawing.Point(21, 321);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(30, 30);
            this.btn_black.TabIndex = 7;
            this.btn_black.UseVisualStyleBackColor = false;
            this.btn_black.Click += new System.EventHandler(this.btn_black_Click);
            // 
            // btn_white
            // 
            this.btn_white.BackColor = System.Drawing.Color.White;
            this.btn_white.Location = new System.Drawing.Point(21, 350);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(30, 30);
            this.btn_white.TabIndex = 8;
            this.btn_white.UseVisualStyleBackColor = false;
            this.btn_white.Click += new System.EventHandler(this.btn_white_Click);
            // 
            // txt_receive
            // 
            this.txt_receive.Location = new System.Drawing.Point(971, 73);
            this.txt_receive.Multiline = true;
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.Size = new System.Drawing.Size(209, 399);
            this.txt_receive.TabIndex = 9;
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(971, 505);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(147, 25);
            this.txt_send.TabIndex = 10;
            // 
            // txt_serverIP
            // 
            this.txt_serverIP.Location = new System.Drawing.Point(237, 15);
            this.txt_serverIP.Name = "txt_serverIP";
            this.txt_serverIP.Size = new System.Drawing.Size(100, 25);
            this.txt_serverIP.TabIndex = 11;
            this.txt_serverIP.Text = "42.192.76.250";
            // 
            // txt_serverPort
            // 
            this.txt_serverPort.Location = new System.Drawing.Point(458, 15);
            this.txt_serverPort.Name = "txt_serverPort";
            this.txt_serverPort.Size = new System.Drawing.Size(100, 25);
            this.txt_serverPort.TabIndex = 12;
            this.txt_serverPort.Text = "7777";
            // 
            // txt_room
            // 
            this.txt_room.Location = new System.Drawing.Point(650, 15);
            this.txt_room.Name = "txt_room";
            this.txt_room.Size = new System.Drawing.Size(100, 25);
            this.txt_room.TabIndex = 13;
            this.txt_room.Text = "730";
            // 
            // btn_link
            // 
            this.btn_link.Location = new System.Drawing.Point(771, 16);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(85, 23);
            this.btn_link.TabIndex = 14;
            this.btn_link.Text = "进入房间";
            this.btn_link.UseVisualStyleBackColor = true;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "服务器IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "服务器端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "房间号：";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(1124, 504);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(56, 23);
            this.btn_send.TabIndex = 18;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 566);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_link);
            this.Controls.Add(this.txt_room);
            this.Controls.Add(this.txt_serverPort);
            this.Controls.Add(this.txt_serverIP);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.txt_receive);
            this.Controls.Add(this.btn_white);
            this.Controls.Add(this.btn_black);
            this.Controls.Add(this.btn_yellow);
            this.Controls.Add(this.btn_green);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.picBox_main);
            this.Name = "Form1";
            this.Text = "DrawSomething";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_main;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.Button btn_white;
        private System.Windows.Forms.TextBox txt_receive;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.TextBox txt_serverIP;
        private System.Windows.Forms.TextBox txt_serverPort;
        private System.Windows.Forms.TextBox txt_room;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_send;
    }
}

