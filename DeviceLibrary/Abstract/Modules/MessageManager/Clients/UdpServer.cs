using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles;
using DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles.Containers;
using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;
using DeviceLibrary.Abstract.Server;
using LogSingleton;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Clients
{
    public class UdpServer : IUdp, IListener<string, int>, ILoggable
    {
        public const string Name = "UDP";
        public void Dispose()
        {
            Stop();
        }

        public UdpServer(string multicastHost, int port)
        {
            Logger = Logging.Log;
            Logger.Debug("Create UdpServer");
            _multicastHost = multicastHost;
            LocalHost = new ConnectionPort { Value = port };
        }
        public UdpClient UdpClient { get; set; }
        public IConnectPoint<int> LocalHost { get; set; }

        #region OnMessage

        private event Action<object, EventDataArg<string>> _OnMessage;
        public event Action<object, EventDataArg<string>> OnMessage
        {
            add => _OnMessage += value;
            remove => _OnMessage -= value;
        }

        #endregion

        public bool IsListening { get; private set; }
        public void Start()
        {
            Logger.Debug("Start UdpServer");
            UdpClient = new UdpClient(/*{ExclusiveAddressUse = false}*/);
            //UdpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //UdpClient.ExclusiveAddressUse = false;

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, LocalHost.Value);
            UdpClient.Client.Bind(endPoint);


            UdpClient.JoinMulticastGroup(IPAddress.Parse(_multicastHost));
            IsListening = true;
            _openConnection = Task.Run(() => ConnectionAsync());
        }
        //TODO тоже самое -- дисконект
        private Task _openConnection;
        private string _multicastHost;
        private async void ConnectionAsync()
        {
            while (IsListening)
            {
                Logger.Debug($"Reciving message from localPort via {Name}");
                try
                {
                    var receiveResult = await UdpClient.ReceiveAsync();

                    byte[] bytes = receiveResult.Buffer;
                    string message = Encoding.UTF8.GetString(bytes);
                    string host = receiveResult.RemoteEndPoint.Address.ToString();
                    RemoteHostInfo hostInfo = new RemoteHostInfo(host, Name);
                    Logger.Debug($"Recived from {host} via {Name} message {message}");
                    _OnMessage?.Invoke(this, new EventDataArg<string>(hostInfo, message));
                }
                catch (Exception e)
                {
                    Logger.Debug($"Reciving message from localPort via {Name} stoped");
                }

            }
        }
        public void Stop()
        {
            Logger.Debug("Stop UdpServer");
            IsListening = false;
            UdpClient?.Close();
            _openConnection.Wait();
        }

        public ILogger Logger { get; }
    }
}