using Solid.Common.Model;

namespace Solid.After.Interfaces
{
    public interface INotificationService
    {
       void NotifyCustomerOrderCreated(Cart cart);
    }
}
