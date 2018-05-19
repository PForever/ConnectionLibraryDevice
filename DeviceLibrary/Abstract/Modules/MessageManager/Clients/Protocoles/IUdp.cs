using System;
using System.Net.Sockets;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles
{
    public interface IUdp : IDisposable
    {
        UdpClient UdpClient { get; }
    }
}