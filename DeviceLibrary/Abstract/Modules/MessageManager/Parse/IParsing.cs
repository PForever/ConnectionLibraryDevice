using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Parse
{
    public interface IParsing
    {
        Request Request { get; }
        Telemetry Telemetry { get; }
        MessageType MessageType { get; }
        string ErrInfo { get; }
    }
}