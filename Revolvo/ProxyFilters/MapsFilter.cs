using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Fiddler;
using Revolvo.Bot.objects;
using Revolvo.Main;
using RevolvoCore.Networking;
using Revolvo.Bot.managers;

namespace Revolvo.ProxyFilters
{
    internal class MapsFilter : IProxyFilter
    {
        public void BeforeRequest(Session session)
        {
            if (session.HTTPMethodIs("CONNECT") &&
                !session.hostname.Contains("play.univ3rse.com") &&
                !session.PathAndQuery.Contains("maps.php"))
            {
                session["x-no-decrypt"] = "noDecrypt";
                return;
            }

            session.bBufferResponse = true;
        }

        public void BeforeResponse(Session session)
        {
            if (!session.PathAndQuery.Contains("maps.php")) return;

            session.utilDecodeResponse();

            var maps = session.GetResponseBodyAsString();
            if (maps == "") return;
            
            maps = DecodeXML(maps);
            session.utilSetResponseBody(maps);
            Console.WriteLine(@"maps.php replaced");
            Console.WriteLine();
        }

        private string DecodeXML(string xmlContent)
        {
            XDocument xml = XDocument.Parse(xmlContent);
            foreach (var xmlElement in xml.Descendants("map"))
            {
                int spacemapId = 0;
                string spacemapIP = "";
                string spacemapName = "";
                foreach (var attribute in xmlElement.Attributes())
                {
                    if (attribute.Name.LocalName == "id") spacemapId = int.Parse(attribute.Value);
                    else if (attribute.Name.LocalName == "name") spacemapName = attribute.Value;
                }
                foreach (var element in xmlElement.Elements())
                    if (element.Name.LocalName == "gameserverIP")
                    {
                        spacemapIP = element.Value;
                        element.ReplaceAll("127.0.0.1");
                    }

                StorageManager.Spacemaps.TryAdd(spacemapId, new Spacemap(spacemapId, spacemapIP, spacemapName));
                Console.WriteLine(@"map #{0} => {1}", spacemapId, spacemapIP);
            }
            return xml.ToString();
        }
    }
}
