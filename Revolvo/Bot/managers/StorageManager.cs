using Revolvo.Bot.objects;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.managers
{
    public class StorageManager
    {
        /// <summary>
        /// Game server spacemaps
        /// </summary>
        public static ConcurrentDictionary<int, Spacemap> Spacemaps = new ConcurrentDictionary<int, Spacemap>();

    }
}
