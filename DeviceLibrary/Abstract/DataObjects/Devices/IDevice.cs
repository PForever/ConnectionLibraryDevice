using System;
using DeviceLibrary.Abstract.DataObjects.Containers;

namespace DeviceLibrary.Abstract.DataObjects.Devices
{
    public interface IDevice : ICloneable
    {
        string Code { get; }
        string MacAddress { get; set; }
        string Name { get; }
        Properties Info { get; }
    }
}