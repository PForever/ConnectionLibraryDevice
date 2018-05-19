using System.Net;
using DeviceLibrary.Abstract.Server;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles.Containers
{
    public class ConnectionIpHost : IConnectPoint<IPEndPoint>
    {
        public IPEndPoint Value { get; set; }
    }
}