using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;

namespace DeviceLibrary.Abstract.Modules.MessageManager
{
    public interface IFullMessageSender
    {
        void OnRequest(object sender, EventRequestArgs args);
        void OnConnectMessage(object sender, EventMessageConnectArgs args);
        void OnCommandMessage(object sender, EventCommandMessageArgs args);
        void OnTelemetry(object sender, EventTelemetryArgs args);
        void OnEventErrorMessage(object sender, EventErrArgs args);
        void OnOrder(object sender, EventOrderArgs args);
    }
}