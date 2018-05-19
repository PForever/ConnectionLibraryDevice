using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles.Containers;
using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;

namespace DeviceLibrary.Abstract.Modules.MessageManager
{
    public abstract class AConnectionWorker : AAddressManager
    {
        protected abstract ConnectionResult GetIp(string deviceCode, TimeSpan timeOut, out string ip);
        protected abstract ConnectionResult UpdateAddressBook(string deviceCode, AddressBook addressBook);
        public abstract ConnectionResult OpenDeviceConnection(string deviceCode, out RemoteHostInfo hostInfo);
    }
}