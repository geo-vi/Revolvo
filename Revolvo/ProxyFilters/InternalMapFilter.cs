using System;
using System.Text.RegularExpressions;
using Fiddler;
using Revolvo.Bot.objects;
using Revolvo.Main;
using RevolvoCore.Networking;
using Revolvo.Bot.managers;

namespace Revolvo.ProxyFilters
{
    internal class InternalMapFilter : IProxyFilter
    {
        public void BeforeRequest(Session session)
        {
            if (session.HTTPMethodIs("CONNECT") &&
                !session.hostname.Contains("play.univ3rse.com") &&
                !session.PathAndQuery.Contains("internalMapRevolution"))
            {
                session["x-no-decrypt"] = "noDecrypt";
                return;
            }

            session.bBufferResponse = true;
        }

        public void BeforeResponse(Session session)
        {
            if (!session.PathAndQuery.Contains("internalMapRevolution")) return;

            session.utilDecodeResponse();

            var response = session.GetResponseBodyAsString();
            string pattern = @"""mapID"": ""([1-9]+)""";
            var regex = new Regex(pattern);

            var mapId = int.Parse(regex.Matches(response)[0].Groups[1].Value);
            Console.WriteLine(@"MapId: {0}", mapId);
            MainController.Instance.MapId = mapId;
        }
    }
}