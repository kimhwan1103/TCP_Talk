using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using MySql.Data.MySqlClient.Memcached;


/// <summary>
/// 참고 코드 
/// https://yeolco.tistory.com/31
/// https://docs.microsoft.com/ko-kr/dotnet/api/system.net.sockets.tcplistener?view=netcore-3.1
/// https://docs.microsoft.com/ko-kr/dotnet/api/system.net.sockets.tcpclient?view=netcore-3.1
/// </summary>

namespace talk_client
{

    public delegate void up_ip_port(string ip, string port);

    public partial class main_talk : Form
    {

       

        public Socket clientSocket;
        public delegate void addtextdelegate(string text);
        
        public static event up_ip_port list_text;
        bool connetion;
        NetworkStream Stream;
        StreamReader reander;
        StreamWriter writer;

        TcpClient client;
        TcpListener server;


        public main_talk()
        {
            InitializeComponent();
        }



        private void cn_server_Click(object sender, EventArgs e)
        {
            server_open.Enabled = false;
            Client(input_msg.Text);

        }

        private void server_open_Click(object sender, EventArgs e)
        {

            cn_server.Enabled = false;

            Thread thread = new Thread(new ThreadStart(server_start));
            thread.Start();
         
        }
        public void test()
        {
            list_text(server_ip.Text, server_port.Text);

            Server server = new Server();
            server.msg();
        }

        

        public void server_start()
        {

            /*
            string[] ip_prot_str = new string[] { server_ip.Text, server_port.Text };

            list_text(ip_prot_str);
            */
            
            try
            {

                addtextdelegate addtext = new addtextdelegate(server_log.AppendText);
                Invoke(addtext, "서버 시작중...\r\n");
                IPAddress iPAddress = IPAddress.Parse(server_ip.Text);
                server = new TcpListener(iPAddress, Convert.ToInt32(server_port.Text));

                server.Start();
                Invoke(addtext, "클라이언트 접속 대기중...\r\n");
                
                TcpClient client = server.AcceptTcpClient();
                Invoke(addtext, "클라이언트 연결 완료\r\n");
             
            
            
            connetion = true;

                Stream = client.GetStream();
                reander = new StreamReader(Stream);
                writer = new StreamWriter(Stream);
                Thread reciveThread = new Thread(new ThreadStart(send_msg));
                reciveThread.Start();

            }
            catch(SocketException e)
            {
                MessageBox.Show($"{e}");
            }
            

            

        }

        
        public void send_msg()
        {
            addtextdelegate addtext = new addtextdelegate(server_log.AppendText);
            while(connetion)
            {
                //Thread.Sleep(1);
                if (Stream.CanRead)
                {
                    string msg = reander.ReadLine();
                    if(msg.Length > 0)
                    {
                        Invoke(addtext, msg + "\r\n");
                    }
                }
            }

        }
        

        public void Client(string msg)
        {

            try
            {
                client = new TcpClient();
                client.Connect(server_ip.Text, Convert.ToInt32(server_port.Text));
                Stream = client.GetStream();
                connetion = true;
                server_log.AppendText("서버 연결 완료\r\n");
                reander = new StreamReader(Stream);
                writer = new StreamWriter(Stream);
                Thread reciveThread = new Thread(new ThreadStart(send_msg));
                reciveThread.Start();
            }
            catch (SocketException e)
            {
                MessageBox.Show($"서버가 오픈된 상태가 아니거나 서버의 아이피 혹은 포트가 잘못되었습니다. 다시 확인해 주세요");
                server_open.Enabled = true;
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            server_log.AppendText(input_msg.Text + "\r\n");
            writer.WriteLine(input_msg.Text);
            writer.Flush();
            input_msg.Clear();
        }
        
    }   
    

}
