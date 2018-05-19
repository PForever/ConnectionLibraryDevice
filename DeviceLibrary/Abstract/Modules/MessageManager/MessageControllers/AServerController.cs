using System;
using DeviceLibrary.Abstract.Modules.MessageManager.Clients;

namespace DeviceLibrary.Abstract.Modules.MessageManager.MessageControllers
{
    public abstract class AServerController : IDisposable
    {
        protected abstract TcpServer TcpServer { get; }
        protected abstract UdpServer UdpServer { get; }
        public abstract void Dispose();
    }
}