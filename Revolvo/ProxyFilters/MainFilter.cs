using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiddler;
using RevolvoCore.Networking;

namespace Revolvo.ProxyFilters
{
    class MainFilter : IProxyFilter
    {
        public void BeforeRequest(Session session)
        {
            if (session.HTTPMethodIs("CONNECT") &&
                !session.hostname.Contains("v3.uberorbit.net") &&
                (!session.PathAndQuery.Contains("main.swf") || !session.PathAndQuery.Contains("game.php") || !session.PathAndQuery.Contains("resources.php")))
            {
                return;
            }
            if (session.PathAndQuery.Contains("main.swf") && session.hostname.Contains("v3.uberorbit.net"))
            {
                session.url = "play.univ3rse.com/spacemap/main.swf";
            }
            if (session.PathAndQuery.Contains("game.php") && session.hostname.Contains("v3.uberorbit.net"))
            {
                session.url = "play.univ3rse.com/spacemap/xml/game.xml";
            }
            if (session.PathAndQuery.Contains("resources.php") && session.hostname.Contains("v3.uberorbit.net"))
            {
                session.url = "play.univ3rse.com/spacemap/xml/resources.xml";
            }
        }

        public void BeforeResponse(Session session)
        {
            if (!session.PathAndQuery.Contains("main.swf")) return;
            session.url = Directory.GetCurrentDirectory() + "/main.swf";
        }
    }
}
