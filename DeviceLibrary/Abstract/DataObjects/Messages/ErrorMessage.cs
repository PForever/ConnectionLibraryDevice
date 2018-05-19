using System;
using DeviceLibrary.Abstract.DataObjects.Containers;

namespace DeviceLibrary.Abstract.DataObjects.Messages
{
    public class ErrorMessage : IMessage
    {
        public ErrorMessage(string deviceCode, string errInfo, string targetDeviceCode)
        {
            DeviceCode = deviceCode;
            ErrInfo = errInfo;
            TargetDeviceCode = targetDeviceCode;
            MessageType = MessageType.Err;
        }

        public ErrorMessage()
        {
            
        }
        public DateTime TimeMarker { get; set; }
        public MessageType MessageType { get; set; }
        public string DeviceCode { get; set; }
        public string ErrInfo { get; set; }
        public string TargetDeviceCode { get; }
    }
}