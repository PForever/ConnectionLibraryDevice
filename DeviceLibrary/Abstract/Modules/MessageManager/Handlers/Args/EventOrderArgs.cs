using System;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Messages;

namespace DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args
{
    public class EventOrderArgs : EventArgs, IEventIMessageArgs
    {
        public Order Order { get; }
        public EventOrderArgs(Order order)
        {
            Order = order;
        }

        public IMessage Message => Order;
    }
}