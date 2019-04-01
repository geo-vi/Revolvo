using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Codecs;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using Revolvo.Bot.managers;
using Revolvo.Bot.netty;
using Revolvo.Main;
using Revolvo.Main.global_objects;
using Revolvo.Networking.local_servers;
using Revolvo.Networking.netty.policy;
using RevolvoCore.Networking;

namespace Revolvo.Networking.remote_servers
{
    class PolicyClient
    {
        private PolicyServer Server;

        private MultithreadEventLoopGroup _threadGroup;
        private IChannel _channel;

        public PolicyClient(PolicyServer server)
        {
            Server = server;
        }

        public async Task Connect()
        {
            //TODO: Connect
            var ip = StorageManager.GetIP();
            var bootstrap = new Bootstrap();
            var group = new MultithreadEventLoopGroup();
            bootstrap
                .Group(group)
                .Channel<TcpSocketChannel>()
                .Option(ChannelOption.TcpNodelay, true)
                .Handler(new ActionChannelInitializer<ISocketChannel>(channel =>
                {
                    IChannelPipeline pipeline = channel.Pipeline;
                    pipeline.AddLast(new StringEncoder(), new StringDecoder(), new PolicyClientReceivedHandler(Server));
                }));

            _channel = await bootstrap.ConnectAsync(ip, Defaults.DEFAULT_POLICY_PORT);
        }

        public async Task Write(string content)
        {
            try
            {
                await _channel.WriteAndFlushAsync(content);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed writing");
            }
        }
    }
}
