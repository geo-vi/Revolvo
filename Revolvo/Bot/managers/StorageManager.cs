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

        /// <summary>
        /// Getting the server's ip
        /// </summary>
        /// <returns></returns>
        public static string GetIP()
        {
            if (!Spacemaps.IsEmpty)
            {
                return Spacemaps.FirstOrDefault().Value.IP;
            }

            return "127.0.0.1"; // default localhost return for no exceptions.
        }

    }
}
