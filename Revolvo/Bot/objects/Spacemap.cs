using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        #endregion

        public Spacemap(int id, string ip)
        {
            Id = id;
            IP = ip;
        }
    }
}
