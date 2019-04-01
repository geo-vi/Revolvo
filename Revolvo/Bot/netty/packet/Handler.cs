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
using Revolvo.Bot.netty.handlers.legacy;
using Revolvo.Utils;
using RevolvoCore.Commands;
using RevolvoCore.Commands.requests;

namespace Revolvo.Bot.netty.packet
{
    class Handler
    {
        public Dictionary<short, IHandler> HandledCommands = new Dictionary<short, IHandler>();
        public Dictionary<string, ILegacyHandler> HandledPackets = new Dictionary<string, ILegacyHandler>();
        public Dictionary<short, string> ParsedCommandNames = new Dictionary<short, string>();

        public Handler()
        {
            AddCommands();
        }

        public void AddCommands()
        {
            ParseAllCommands();
            HandledCommands.Add(VersionRequest.ID, new VersionHandler());
            HandledCommands.Add(ShipInitializationCommand.ID, new ShipInitializationHandler());
            HandledCommands.Add(MoveCommand.ID, new MoveCommandHandler());
            HandledCommands.Add(MoveRequest.ID, new MoveRequestHandler());
            HandledPackets.Add("p", new CreatePortalHandler());
            HandledPackets.Add("c", new CreateCollectableHandler());
        }

        private void ParseAllCommands()
        {
            foreach (var reflectedClass in XReflect.GetTypesInNamespace(Assembly.GetAssembly(typeof(ByteParser)), 
                "RevolvoCore.Commands"))
            {
                var id = XReflect.GetConstantCommandId(XReflect.GetConstants(reflectedClass));
                var name = reflectedClass.Name;
                if (id == 0 || name == "")
                {
                    Console.WriteLine("Error adding [" + id + ", " + name + "]");
                    continue;
                }
                if (!ParsedCommandNames.ContainsKey(id))
                { ParsedCommandNames.Add(id,name);}
                else
                {
                    Console.WriteLine("Duplicate: " + id + " " + name + " || " + ParsedCommandNames[id]);
                }
            }
        }


        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="bytes"></param>
        public void HandleGameClientBytes(byte[] bytes)
        {
            var parsed = new ByteParser(bytes);
            var id = parsed.CMD_ID;
            if (id <= 0 || parsed.Lenght <= 0 || bytes.Length < parsed.Lenght + 2)
            {
                Console.WriteLine("Wrong length [" + parsed.Lenght + "] + " + parsed.CMD_ID);
                return;
            }
            var reformedBytes = new byte[parsed.Lenght + 2];
            Array.Copy(bytes, reformedBytes, parsed.Lenght + 2);
            parsed = new ByteParser(reformedBytes);
            id = parsed.CMD_ID;
            Console.WriteLine("Received: " + id + " [" + ParsedCommandNames[id] + "] - " + parsed.Lenght);

            if (HandledCommands.ContainsKey(id))
            {
                HandledCommands[id].execute(reformedBytes);
            }
            else
            {
                if (id == LegacyModule.ID)
                {
                    var request = new LegacyModule();
                    request.readCommand(bytes);
                    if (request.message.Contains('|'))
                    {
                        var split = request.message.Split('|');
                        if (HandledPackets.ContainsKey(split[1]))
                        {
                            HandledPackets[split[1]].execute(split);
                        }
                        else MainController.Instance.Session.TryRedirectToGameServer(reformedBytes);
                    }
                    else
                    {
                        if (HandledPackets.ContainsKey(request.message))
                        {
                            HandledPackets[request.message].execute(new[] { request.message });
                        }
                        else MainController.Instance.Session.TryRedirectToGameServer(reformedBytes);
                    }
                }
                else MainController.Instance.Session.TryRedirectToGameServer(reformedBytes);
            }
        }

        public void HandleGameServerBytes(byte[] bytes)
        {
            var parsed = new ByteParser(bytes);
            var id = parsed.CMD_ID;
            if (id < 0 || parsed.Lenght < 0)
            {
                Console.WriteLine("Wrong length");
                return;
            }
            var reformedBytes = new byte[parsed.Lenght + 2];
            Array.Copy(bytes, reformedBytes, parsed.Lenght + 2);

            if (HandledCommands.ContainsKey(id))
            {
                HandledCommands[id].execute(reformedBytes);
            }
            else
            {
                MainController.Instance.Session.TryRedirectToGameClient(reformedBytes);
            }
        }
        
    }
}
