using System;
using System.Threading.Tasks;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using Revolvo.Main.global_objects;
using Revolvo.Networking.netty.policy;

namespace Revolvo.Networking.local_servers
{
    class GameServer
    {
        private MultithreadEventLoopGroup _threadGroup;
        private IChannel _channel;

        public async void Listen()
        {
            _threadGroup = new MultithreadEventLoopGroup();

            var bootstrap = new Bootstrap();
            bootstrap
                .Group(_threadGroup)
                .Channel<SocketDatagramChannel>()
                .Option(ChannelOption.SoBroadcast, true)
                .Handler(new ActionChannelInitializer<IChannel>(channel =>
                {
                    channel.Pipeline.AddLast("Game", new GameServerHandler());
                }));

            _channel = await bootstrap.BindAsync(Defaults.DEFAULT_GAME_PORT);
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
