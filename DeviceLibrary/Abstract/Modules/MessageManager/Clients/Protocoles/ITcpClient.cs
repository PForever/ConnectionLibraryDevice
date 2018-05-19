using System.Net.Sockets;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles
{
    public interface ITcpClient
    {
        TcpClient TcpClient { get; }
    }
}