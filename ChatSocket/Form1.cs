using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSocket
{
    public partial class Form1 : Form
    {
        public Socket socket;
        public Socket ns;
        public IPEndPoint ep;
        public Form1()
        {
            InitializeComponent();
        }

        public void MsgRecive(IAsyncResult ar) //колбек-функция
        {
            socket = (Socket)ar.AsyncState; //получаем ссылку на слушающий сокет            
            ns = socket.EndAccept(ar); //получаем сокет для обмена данными с клиентом            
            byte[] buf = new byte[1024]; //создаем буфер
            int l = ns.Receive(buf); //создаем буфер и записываем в буфер сообщение от клиента
            Invoke((MethodInvoker)delegate
            {
                tbAllMsg.Text += System.Text.Encoding.Unicode.GetString(buf, 0, l) + "\r\n";
            });
            ns.Send(buf, 0, buf.Length, SocketFlags.None); // отправляем данные в подключенный Socket            
            socket.BeginAccept(new AsyncCallback(MsgRecive), socket); //возобновляем асинхронное подключение
            ns.Shutdown(SocketShutdown.Both); //блокируем передачу и получение данных
            ns.Close(); //закрываем подключение
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);  //создаем новый сокет
            socket.Bind(new IPEndPoint(IPAddress.Any, (int)PortText.Value)); //наш сервер, к нему будут подклучатся
            socket.Listen(10); //слушаем 10 входящих
            socket.BeginAccept(new AsyncCallback(MsgRecive), socket); //начинаем асинхронное прослушивание
            btnConnect.BackColor = Color.Green; //при подключении кнопка меняе цвет
            btnConnect.Enabled = false; // при подключении кнопка блокируется
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Socket ss = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP); //создаем новый сокет
            ep = new IPEndPoint(IPAddress.Parse(IPText.Text), (int)PortText.Value); //создаем новый  endPoint с ip адрессом к которому хотим подключиться
            if (!ss.Connected)
            {
                ss.Connect(ep);
            }
            ss.Send(System.Text.Encoding.Unicode.GetBytes(tbMsgText.Text)); //отправляем сообщение клиенту
            tbAllMsg.Text += "My messange => " + tbMsgText.Text + "\r\n"; //выводим наше сообщение в textbox
            tbMsgText.Clear(); // очистить поле ввода сообщений
            ss.Shutdown(SocketShutdown.Both);  //блокируем передачу и получение данных
            ss.Close();  //закрываем подключение
        }
    }
}
