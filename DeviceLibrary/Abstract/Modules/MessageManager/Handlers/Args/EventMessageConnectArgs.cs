using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public class EventMessageConnectArgs : EventArgs, IEventIMessageArgs
    {
        public EventMessageConnectArgs(ConnectMessage connectMessage)
        {
            ConnectMessage = connectMessage;
        }

        public ConnectMessage ConnectMessage { get; }
        public IMessage Message => ConnectMessage;
    }
}