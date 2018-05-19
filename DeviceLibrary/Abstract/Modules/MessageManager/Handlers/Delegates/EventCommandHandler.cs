using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Delegates
{
    public delegate void EventCommandHandler(RemoteHostInfo remoteHost, EventCommandMessageArgs args);
}