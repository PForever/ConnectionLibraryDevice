using System.Collections.Generic;
using DeviceLibrary.Abstract.Modules.MessageManager.Clients.Protocoles.Containers;

namespace DeviceLibrary.Abstract.Modules.MessageManager
{
    public abstract class AAddressManager : AConnecter
    {

        protected AddressBook AddressBook;
        protected abstract AddressBook GetAddressBookDb(IList<string> hostCodes);
    }
}