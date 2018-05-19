namespace DeviceLibrary.Abstract.Server
{
    public delegate void EventDataHandler<T>(object sender, EventDataArg<T> e);
}