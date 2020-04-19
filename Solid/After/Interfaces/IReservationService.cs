using Solid.Common.Model;
using System.Collections.Generic;

namespace Solid.After.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(IList<Product> items);
    }
}
