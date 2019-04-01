using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.objects.map;

namespace Revolvo.Bot.objects
{
    public class Spacemap
    {
        #region Variables
        /// <summary>
        /// Spacemap id
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Ip where the current spacemap is hosted in DarkOrbit servers
        /// </summary>
        public string IP { get; }

        public string Name { get; }
        public ConcurrentDictionary<int, Jumpgate> Portals = new ConcurrentDictionary<int, Jumpgate>();
        public ConcurrentDictionary<string, Collectable> Collectables = new ConcurrentDictionary<string, Collectable>();
        #endregion

        public Spacemap(int id, string ip, string name)
        {
            Id = id;
            Name = name;
            IP = ip;
        }
    }
}
