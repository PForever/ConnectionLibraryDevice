using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public class EventTelemetryArgs : EventArgs, IEventIMessageArgs
    {
        public Telemetry TelemetryInfo { get; }
        public EventTelemetryArgs(Telemetry telemetryInfo)
        {
            TelemetryInfo = telemetryInfo;
        }

        public IMessage Message => TelemetryInfo;
    }
}