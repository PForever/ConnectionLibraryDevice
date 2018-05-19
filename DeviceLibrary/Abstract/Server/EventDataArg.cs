using System;
using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;

namespace DeviceLibrary.Abstract.Server
{
    public class EventDataArg<T> : EventArgs
    {
        public RemoteHostInfo HostInfo { get; set; }
        public T Data { get; set; }

        public EventDataArg(RemoteHostInfo hostInfo, T data)
        {
            HostInfo = hostInfo;
            Data = data;
        }
    }
}