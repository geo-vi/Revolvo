using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Networking
{
    /// <summary>
    /// Used to delegate the BeforeRequest and BeforeResponse methods of XProxy.
    /// </summary>
    public interface IProxyFilter
    {
        void BeforeRequest(Fiddler.Session session);
        void BeforeResponse(Fiddler.Session session);
    }
}
