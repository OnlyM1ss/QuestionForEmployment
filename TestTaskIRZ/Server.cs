using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskIRZ
{
    public class Server
    {
        private string connectIsSuccessfull()
        {
            return "Hi,great job, you have been find correct Port,\n but it's not end,you need find correct user for continue";
        }
        private string Help()
        {
            return "you need make code review for find correct user";
        }
        /// <summary>
        /// generate random port for connect
        /// </summary>
        /// <returns>random port</returns>
        private int GeneratePort()
        {
            Random random = new Random();
            return random.Next(10000, 15000);
        }
        public void RunServer()
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), GeneratePort());
            while (true)
            {
                using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.Bind(ipPoint);
                    socket.Listen(10);
                    using Socket handler = socket.Accept();
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    byte[] data = new byte[256];
                    do
                    {
                        try
                        {
                            bytes = handler.Receive(data);
                            builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    while (handler.Available > 0);
                    Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());
                    byte[] WelcomeData = new byte[256];
                    WelcomeData = Encoding.Unicode.GetBytes(connectIsSuccessfull() + "\n" + Help());
                    handler.Send(WelcomeData);
                }
            }
        }
    }
}