using System;
using System.Net.Sockets;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles
{
    public interface ITcpServer : IDisposable
    {
        TcpListener TcpListener { get; }    
    }
}