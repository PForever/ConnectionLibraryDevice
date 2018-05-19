using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public class EventErrArgs : EventArgs, IEventIMessageArgs
    {
        public ErrorMessage ErrorMessage { get; }

        public IMessage Message => ErrorMessage;

        public EventErrArgs(ErrorMessage errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}