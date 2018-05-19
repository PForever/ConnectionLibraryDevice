using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public class EventCallArgs : EventArgs, IEventIMessageArgs
    {
        public Call CallInfo { get; }
        public IMessage Message => CallInfo;

        public EventCallArgs(Call callInfo)
        {
            CallInfo = callInfo;
        }
    }
}