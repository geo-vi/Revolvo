using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.managers;
using Revolvo.Bot.netty;
using Revolvo.Main;
using Revolvo.Main.global_objects;
using Revolvo.Networking.local_servers;
using RevolvoCore.Networking;

namespace Revolvo.Networking.remote_servers
{
    class GameClient
    {
        //public XSocket XSocket { get; }

        //public GameClient()
        //{
        //    var ip = StorageManager.GetIP();
        //    XSocket = new XSocket(ip, Defaults.DEFAULT_GAME_PORT);
        //    XSocket.OnReceive += XSocket_OnReceive;
        //    XSocket.ConnectionClosedEvent += XSocket_ConnectionClosedEvent;
        //}

        //public void Connect()
        //{
        //    try
        //    {
        //        Console.WriteLine("connecting to " + StorageManager.GetIP());
        //        XSocket.Connect();
        //        XSocket.Read();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("<EXCEPTION>");
        //        Console.WriteLine(e);
        //        Console.WriteLine(e.StackTrace);
        //        Console.WriteLine(e.Message);
        //    }
        //}

        //private void XSocket_ConnectionClosedEvent(object sender, EventArgs e)
        //{

        //}

        //private void XSocket_OnReceive(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var args = (ByteArrayArgs) e;
        //        Packet.Handler.HandleGameClientBytes(args.ByteArray);
        //    }
        //    catch (Exception exc)
        //    {
        //        Console.WriteLine(exc);
        //        Console.WriteLine(exc.Message);
        //        Console.WriteLine(exc.StackTrace);
        //    }
        //}
    }
}
