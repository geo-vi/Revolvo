﻿using Revolvo.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevolvoCore.Commands;

namespace Revolvo.Main.global_commands
{
    class Test : Command
    {
        public Test() : base("test", "Test command", false) { }

        public override async void Execute(string[] args = null)
        {
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("kys " + i);
            //    Console.Beep(800,90);
            //    await Task.Delay(50);
            //}
            MainController.Instance.Session.GameServer.XSocket.Write(LegacyModule.write("0|A|STD|test").Bytes);
            Debug.WriteLine("tested");
        }
    }
}
