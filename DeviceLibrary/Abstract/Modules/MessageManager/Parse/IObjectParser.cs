using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;
using DeviceLibrary.Abstract.Server;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Parse
{
    public interface IObjectParser
    {
        void OnRequest(RemoteHostInfo remoteHost, EventRequestArgs args);
        void OnConnectMessage(RemoteHostInfo remoteHost, EventMessageConnectArgs args);
        void OnCommandMessage(RemoteHostInfo remoteHost, EventCommandMessageArgs args);
        void OnTelemetry(RemoteHostInfo remoteHost, EventTelemetryArgs args);
        void OnEventErrorMessage(RemoteHostInfo remoteHost, EventErrArgs args);
        void OnOrder(RemoteHostInfo remoteHost, EventOrderArgs args);
        void OnCall(RemoteHostInfo remoteHost, EventCallArgs args);
        void OnSend(object sender, EventDataArg<string> e);
    }
}