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
            switch (parser.CMD_ID)
            {
                case ShipInitializationCommand.ID:
                    
                    break;
            }

            MainController.Instance.User.RedirectPacket(PacketDestinations.SERVER_TO_CLIENT, bytes);

        }

        public void HandleClientCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            Console.WriteLine($"Received parser id ->{parser.CMD_ID}");
            Console.WriteLine($"Received from Client ->{CommandFinder.Find(parser.CMD_ID)}");

            if (parser.CMD_ID == 666)
            {
                MainForm.Connected = true;
                MainController.Instance.User.RedirectPacket(PacketDestinations.SERVER_TO_CLIENT, ShipInitializationCommand.write(2103, "devsnowy", 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, true, 1, 1, 1, 1, 1, 1, 1, "", 1, false, false, new List<VisualModifierCommand>()));
                Console.WriteLine("STAY ALIIIIVE");
            }

            MainController.Instance.User.RedirectPacket(PacketDestinations.CLIENT_TO_SERVER, bytes);
        }
        
        public void HandlePolicyServer(string packet)
        {
            Console.WriteLine("PolicyServer>" + packet);
            MainController.Instance.User.RedirectPacket(PacketDestinations.SERVER_TO_CLIENT, packet);
            MainController.Instance.User.Close(User.Senders.CLIENT);
            MainController.Instance.User.Close(User.Senders.SERVER);
            InitiateGame();
        }

        public void HandlePolicyClient(string packet)
        {
            Console.WriteLine("PolicyClient>" + packet);
            MainController.Instance.User.RedirectPacket(PacketDestinations.CLIENT_TO_SERVER, packet);
        }

        private void InitiateGame()
        {
            var client = new IClient(Defaults.GAME_PORT);
            var server = new IServer(Bot.managers.StorageManager.Spacemaps[MainController.Instance.MapId].IP, Defaults.GAME_PORT);
            server.Connected += (s, e) => MainController.Instance.User = new User(client, server);
            server.Connect();
            Console.WriteLine("Emulator started");
            server.XSocket.Write(VersionRequest.write(2103, "3j064e4jt572hqoqbmti6kahti"));
            Console.WriteLine("Keeping client alive, waiting for incoming connection.");
        }
    }
}
