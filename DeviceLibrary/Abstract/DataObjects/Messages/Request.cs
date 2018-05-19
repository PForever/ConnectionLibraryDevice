using System;
using System.Collections.Generic;
using DeviceLibrary.Abstract.DataObjects.Containers;

namespace DeviceLibrary.Abstract.DataObjects.Messages
{
    public class Request : IMessage
    {
        public DateTime TimeMarker { get; set; }
        public MessageType MessageType { get; set; }
        public string DeviceCode { get; set; }
        //TODO Request code дял ответа на запросы
        public IDictionary<string, IList<Telemetry>> Telemetries { get; set; }
        public string TargetDeviceCode { get; set; }

        public Request()
        {
            
        }
        public Request(string deviceCode, string requestMessage, DateTime timeMarker, IDictionary<string, IList<Telemetry>> telemetries, string targetDeviceCode)
        {
            TimeMarker = timeMarker;
            Telemetries = telemetries;
            TargetDeviceCode = targetDeviceCode;
            DeviceCode = deviceCode;
            MessageType = MessageType.Request;
        }
    }
}