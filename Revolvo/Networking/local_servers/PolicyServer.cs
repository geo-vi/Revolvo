using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Codecs;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using Revolvo.Bot.netty;
using Revolvo.Main;
using Revolvo.Main.global_objects;
using Revolvo.Networking.netty.policy;
using Revolvo.Networking.remote_servers;
using RevolvoCore.Networking;

namespace Revolvo.Networking.local_servers
{
    class PolicyServer
    {
        private MultithreadEventLoopGroup _threadGroup;
        private IChannel _channel;

        public PolicyServer()
        {
            Listen();
        }

        public async void Listen()
        {
            _threadGroup = new MultithreadEventLoopGroup();

            var bootstrap = new ServerBootstrap();
            bootstrap
                .Group(_threadGroup)
                .Channel<TcpServerSocketChannel>()
                .ChildHandler(new ActionChannelInitializer<ISocketChannel>(channel =>
                {
                    IChannelPipeline pipeline = channel.Pipeline;
                    pipeline.AddLast(new StringEncoder(), new StringDecoder(), new PolicyServerReceivedHandler(this));
                }));

            _channel = await bootstrap.BindAsync(Defaults.DEFAULT_POLICY_PORT);

        }

        public async Task Write(string msg)
        {
            try
            {
                await _channel.WriteAndFlushAsync(msg);
            }
            catch (Exception)
            {

            }
        }

        public async Task Close()
        {
            await _channel.CloseAsync();
            await _threadGroup.ShutdownGracefullyAsync();
        }
    }
}
