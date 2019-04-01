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
    class CreateCollectableHandler : ILegacyHandler
    {
        public void execute(string[] packet)
        {
            var hash = packet[2];
            var type = (Collectables)int.Parse(packet[3]);
            var position = Vector.Parse(packet[4],packet[5]);
            var collectable = new Collectable(hash, position, type);
            StorageManager.CurrentSpacemap.Collectables.TryAdd(hash, collectable);
            MainController.Instance.Session.TryRedirectToGameServer(LegacyModule.write(string.Join("|", packet)).Bytes);
        }
    }
}
