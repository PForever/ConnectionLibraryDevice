using System.Collections.Generic;

namespace DeviceLibrary.Abstract.DataObjects.Devices
{
    public class Devices : Dictionary<string, IDevice>
    {
        public Devices() : base()
        {
            
        }
    }
}