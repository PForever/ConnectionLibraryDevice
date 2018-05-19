using DeviceLibrary.Abstract.DataObjects.Containers;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public interface IEventIMessageArgs
    {
        IMessage Message { get; }
    }
}