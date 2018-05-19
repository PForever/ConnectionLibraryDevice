using System;
using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;

namespace DeviceLibrary.Abstract.Modules.MessageManager
{
    public interface IFullMessageReceiver
    {
        event Action<object, EventRequestArgs> RequestReceived;
        event Action<object, EventTelemetryArgs> TelemetryReceived;
        event Action<object, EventMessageConnectArgs> ConnectMessageReceived;
        event Action<object, EventErrArgs> ErrorMessageReceived;
        event Action<object, EventCommandMessageArgs> CommandMessageReceived;
    }
}