using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Devices;

namespace DeviceLibrary.Abstract.DataObjects.Messages
{
    public class ConnectMessage : IMessage
    {
        public Device Device { get; set; }

        public ConnectMessage(Device device, string deviceCode, DateTime timeMarker, string targetDeviceCode)
        {
            TimeMarker = timeMarker;
            TargetDeviceCode = targetDeviceCode;
            Device = device;
            DeviceCode = deviceCode;
            MessageType = MessageType.Connect;
        }
        public ConnectMessage(IDevice device, string deviceCode, DateTime timeMarker, string targetDeviceCode) : this(new Device(device), deviceCode, timeMarker, targetDeviceCode) {}

        public DateTime TimeMarker { get; set; }
        public MessageType MessageType { get; set; }
        public string DeviceCode { get; set; }
        public string TargetDeviceCode { get; set; }
    }
}