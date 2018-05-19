using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public class EventRequestArgs : EventArgs, IEventIMessageArgs
    {
        public Request RequestInfo { get; }
        public EventRequestArgs(Request requestInfo)
        {
            RequestInfo = requestInfo;
        }

        public IMessage Message => RequestInfo;
    }
}