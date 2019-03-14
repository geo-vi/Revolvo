using System.Collections.Generic;
using Fiddler;

namespace RevolvoCore.Networking
{
    public class XProxy
    {
        #region Variables
        /// <summary>
        /// Proxy default port
        /// </summary>
        private const int DefaultPort = 8888;

        /// <summary>
        /// Custom proxy port
        /// </summary>
        public int Port { get; }
        /// <summary>
        /// If https traffic should be decrypted automactly
        /// </summary>
        public bool DecryptSsl { get; set; }
        /// <summary>
        /// List of proxy filters
        /// </summary>
        public List<IProxyFilter> ProxyFilters { get; }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor using a default port
        /// </summary>
        public XProxy() : this(DefaultPort) { }

        /// <summary>
        /// Creates a proxy using the default port
        /// </summary>
        /// <param name="decryptSsl"></param>
        public XProxy(bool decryptSsl) : this(DefaultPort, decryptSsl) { }

        /// <summary>
        /// Creates a proxy using a custom port with decrypt ssl off by default
        /// </summary>
        /// <param name="port"></param>
        public XProxy(int port) : this(port, false) { }

        /// <summary>
        /// Creates a proxy using a custom port and with the option of decrypt ssl traffic
        /// </summary>
        /// <param name="port"></param>
        /// <param name="decryptSsl"></param>
        public XProxy(int port, bool decryptSsl)
        {
            Port = port;
            DecryptSsl = decryptSsl;
            ProxyFilters = new List<IProxyFilter>();
        }
        #endregion


        /// <summary>
        /// Starts the proxy
        /// </summary>
        public void Start()
        {
            //Stops everything before start
            Stop();

            CONFIG.IgnoreServerCertErrors = false;
            CertMaker.trustRootCert();
            foreach (var filter in ProxyFilters)
            {
                FiddlerApplication.BeforeRequest += filter.BeforeRequest;
                FiddlerApplication.BeforeResponse += filter.BeforeResponse;
            }
            FiddlerApplication.Startup(Port, true, DecryptSsl);
        }

        /// <summary>
        /// Stops the proxy. Important if not called before closing the application the browser proxy options won't be set to the default ones,
        /// leaving the user without internet until the user notices
        /// </summary>
        public void Stop()
        {
            FiddlerApplication.Shutdown();
        }
    }
}
