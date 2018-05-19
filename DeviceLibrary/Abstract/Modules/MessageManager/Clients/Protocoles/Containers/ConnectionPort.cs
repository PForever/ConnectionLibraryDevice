using DeviceLibrary.Abstract.Server;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles.Containers
{
    public class ConnectionPort : IConnectPoint<int>
    {
        public int Value { get; set; }
    }
}