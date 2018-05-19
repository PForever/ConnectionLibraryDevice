using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public class EventCommandMessageArgs : EventArgs, IEventIMessageArgs
    {
        public CommandMessage CommandMessage { get; }
        public EventCommandMessageArgs(CommandMessage commandMessage)
        {
            CommandMessage = commandMessage;
        }

        public IMessage Message => CommandMessage;
    }
}