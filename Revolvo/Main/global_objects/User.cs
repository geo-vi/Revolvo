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
            CLIENT,
            SERVER
        }

        private IClient Client { get; }

        private IServer Server { get; }

        public User(IClient client, IServer server)
        {
            Client = client;
            Server = server;
        }

        public void RedirectPacket(PacketDestinations destination, byte[] bytes)
        {
            if (destination == PacketDestinations.CLIENT_TO_SERVER)
            {
                Console.WriteLine("CLIENT->SERVER");
                Server.XSocket.Write(bytes);
            }
            else
            {
                Console.WriteLine("SERVER->CLIENT");
                Client.XSocket.Write(bytes);
            }
        }

        public void RedirectPacket(PacketDestinations destination, string content)
        {
            if (destination == PacketDestinations.CLIENT_TO_SERVER)
                Server.XSocket.Write(content);
            else Client.XSocket.Write(content);
        }

        public void Close(Senders sender)
        {
            if (sender == Senders.CLIENT)
                Client.XSocket.Close();
            else Server.XSocket.Close();
        }
    }
}
