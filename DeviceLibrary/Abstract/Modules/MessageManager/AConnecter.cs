using DeviceLibrary.Abstract.Modules.MessageManager.Parse;

namespace DeviceLibrary.Abstract.Modules.MessageManager
{
    public abstract class AConnecter
    {
        protected IObjectParser Sender;
        protected IMessageParser Server;
    }
}