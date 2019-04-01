using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.managers;
using Revolvo.Bot.objects;
using Revolvo.Bot.objects.map;
using Revolvo.Main;
using RevolvoCore.Commands;

namespace Revolvo.Bot.netty.handlers.legacy
{
    class CreatePortalHandler : ILegacyHandler
    {
        public void execute(string[] packet)
        {
            var id = int.Parse(packet[2]);
            var x = int.Parse(packet[5]);
            var y = int.Parse(packet[6]);
            StorageManager.CurrentSpacemap.Portals.TryAdd(id, new Jumpgate(id, new Vector(x, y), 0));
            MainController.Instance.Session.TryRedirectToGameServer(LegacyModule.write(string.Join("|", packet)).Bytes);
        }
    }
}
