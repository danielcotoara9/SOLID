using SRP_Single_Responsibility_Principle.Common.Model;

namespace SRP_Single_Responsibility_Principle.After.Interfaces
{
    public interface INotificationService
    {
       void NotifyCustomerOrderCreated(Cart cart);
    }
}
