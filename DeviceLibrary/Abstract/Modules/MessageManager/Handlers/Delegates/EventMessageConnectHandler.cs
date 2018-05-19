using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Delegates
{
    public delegate void EventMessageConnectHandler(RemoteHostInfo remoteHost, EventMessageConnectArgs args);
}