using SRP_Single_Responsibility_Principle.Common.Model;
using System.Collections.Generic;

namespace SRP_Single_Responsibility_Principle.After.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(IList<OrderItem> items);
    }
}
