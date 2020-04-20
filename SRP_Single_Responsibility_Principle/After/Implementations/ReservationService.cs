using SRP_Single_Responsibility_Principle.After.Interfaces;
using SRP_Single_Responsibility_Principle.Common.Model;
using SRP_Single_Responsibility_Principle.Common.Services;
using System;
using System.Collections.Generic;

namespace SRP_Single_Responsibility_Principle.After.Implementations
{
    public class ReservationService : IReservationService
    {
        public void ReserveInventory(IList<Product> items)
        {
            foreach(var item in items)
            {
                try
                {
                    var inventoryService = new InventoryService();
                    inventoryService.Reserve(item.Sku, item.Quantity);
                }
                catch (Exception ex)
                {
                    throw new Exception($"There was a problem reserving inventory for item {item.Sku}");
                }
            }

        }
    }
}
