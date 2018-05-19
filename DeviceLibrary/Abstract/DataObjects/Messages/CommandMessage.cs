using System;
using DeviceLibrary.Abstract.DataObjects.Containers;

namespace DeviceLibrary.Abstract.DataObjects.Messages
{
    public class CommandMessage : IMessage
    {
        //TODO парс и валидация команды
        //TODO добавить информацию о способе связи в описание устройств
        public string Message { get; set; }
        public CommandMessage(string message, string deviceCode, DateTime timeMarker, string targetDeviceCode)
        {
            TimeMarker = timeMarker;
            TargetDeviceCode = targetDeviceCode;
            Message = message;
            DeviceCode = deviceCode;
            MessageType = MessageType.Command;
        }

        public CommandMessage()
        {
            
        }
        public string TargetDeviceCode { get; set; }

        public DateTime TimeMarker { get; set; }
        public MessageType MessageType { get; set; }
        public string DeviceCode { get; set; }
    }
}