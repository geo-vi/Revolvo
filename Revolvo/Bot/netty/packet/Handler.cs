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
            var parsed = new ByteParser(bytes);
            //Console.WriteLine($"Received from Client (0.0.0.0)->{CommandFinder.Find(parsed.CMD_ID)}");
            switch (parsed.CMD_ID)
            {
                case ShipInitializationCommand.ID:
                case 29052:
                default:
                    MainController.Instance.User.RedirectPacket(PacketDestinations.CLIENT_TO_SERVER, bytes);
                    break;
            }

        }

        public void HandleClientCommand(byte[] bytes)
        {
            var parsed = new ByteParser(bytes);
            Console.WriteLine($"{parsed.CMD_ID}");
            if (parsed.CMD_ID == 666)
            {
                MainController.Instance.User.RedirectPacket(PacketDestinations.CLIENT_TO_SERVER, ShipInitializationCommand.write(9001, "nigro", 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, true, 1, 1, 1, 1, 1, 1, 1, "", 1, false, false, new List<VisualModifierCommand>()));
                Console.WriteLine("STAY ALIIIIVE");
                return;
            }

            MainController.Instance.User.RedirectPacket(PacketDestinations.SERVER_TO_CLIENT, bytes);
        }

        /// - TILL HERE ///

        public void HandlePolicyServer(string packet)
        {
            Console.WriteLine("PolicyServer>" + packet);
            MainController.Instance.User.RedirectPacket(PacketDestinations.CLIENT_TO_SERVER, packet);
            MainController.Instance.User.Close(User.Senders.CLIENT);
            MainController.Instance.User.Close(User.Senders.SERVER);
            InitiateGame();
        }

        public void HandlePolicyClient(string packet)
        {
            Console.WriteLine("PolicyClient>" + packet);
            MainController.Instance.User.RedirectPacket(PacketDestinations.SERVER_TO_CLIENT, packet);
        }

        private void InitiateGame()
        {
            var client = new IClient(8080);
            var server = new IServer(Bot.managers.StorageManager.Spacemaps[MainController.Instance.MapId].IP, 8080);
            server.Connected += (s, e) => MainController.Instance.User = new User(client, server);
            server.Connect();
            Console.WriteLine("Emulator started");
            server.XSocket.Write(VersionRequest.write(9001, "cm3ed2ph4te3galk2jcs89k1ga"));

            Console.WriteLine("Keeping client alive, waiting for incoming connection.");
        }
    }
}
