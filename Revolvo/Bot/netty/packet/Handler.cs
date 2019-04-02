using Microsoft.CSharp;
using Revolvo.Bot.netty.handlers;
using Revolvo.Main;
using Revolvo.Main.global_objects;
using RevolvoCore;
using RevolvoCore.Utils;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RevolvoCore.Commands;
using RevolvoCore.Commands.requests;

namespace Revolvo.Bot.netty.packet
{
    class Handler
    {
        public Dictionary<short, IHandler> HandledClientCommands = new Dictionary<short, IHandler>();
        public Dictionary<short, IHandler> HandledServerCommands = new Dictionary<short, IHandler>();

        public void AddCommands()
        {
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="bytes"></param>
        public void HandleServerCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            Console.WriteLine($"Received parser id ->{parser.CMD_ID}");
            Console.WriteLine($"Received from Server ->{CommandFinder.Find(parser.CMD_ID)}");
            switch (parser.CMD_ID) {
                case 23508:
                    Console.WriteLine("Received UserKeyBindingsUpdate");
                    var times = parser.readShort();
                    Console.WriteLine("Times: " + times);
                    break;
            }

            //MainController.Instance.User.SendPacket(bytes);

        }

        public void HandleClientCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            Console.WriteLine($"Sending parser id ->{parser.CMD_ID}");
            Console.WriteLine($"Sending to Server ->{CommandFinder.Find(parser.CMD_ID)}");

            //if (parser.CMD_ID == 666)
            //{
            //    MainForm.Connected = true;
            //    MainController.Instance.User.RedirectPacket(PacketDestinations.SERVER_TO_CLIENT, ShipInitializationCommand.write(2103, "devsnowy", 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, true, 1, 1, 1, 1, 1, 1, 1, "", 1, false, false, new List<VisualModifierCommand>()));
            //    Console.WriteLine("STAY ALIIIIVE");
            //}
        }
        
        public void HandlePolicyServer(string packet)
        {
            Console.WriteLine("Policy Server message received:");
            Console.WriteLine(packet);
            InitiateGame();
        }

        private void InitiateGame()
        {
            Console.WriteLine("Connecting to the game server...");
            var server = new IServer(Defaults.HOST_IP, Defaults.GAME_PORT, false);
            server.Connected += (s, e) =>
            {
                Console.WriteLine("Keeping client alive, waiting for incoming connection.");
                MainController.Instance.User.SendPacket(VersionRequest.write(2199, "06qt7tmo0jlp97jqlcstpe1muj"));
            };
            server.Connect();
        }
    }
}
