using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Main.global_objects
{
    class User
    {
        public enum Senders
        {
            SERVER
        }

        private IServer Server { get; }

        public User(IServer server)
        {
            Server = server;
        }

        public void SendPacket(byte[] bytes)
        {
            Console.WriteLine("Sending packet server.");
            Server.XSocket.Write(bytes);
        }

        public void SendPacket(string content)
        {
            Server.XSocket.Write(content);
        }

        public void Close(Senders sender)
        {
            Server.XSocket.Close();
        }
    }
}
