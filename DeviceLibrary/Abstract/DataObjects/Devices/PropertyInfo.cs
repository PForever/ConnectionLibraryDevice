namespace DeviceLibrary.Abstract.DataObjects.Devices
{
    public struct PropertyInfo
    {
        public string Description { get; set; }
        public bool IsSetter { get; set; }
        public ProperyType Type { get; set; }

        public PropertyInfo(string description, bool isSetter, ProperyType type)
        {
            Description = description;
            IsSetter = isSetter;
            Type = type;
        }
    }
}