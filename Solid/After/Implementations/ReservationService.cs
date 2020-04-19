using Solid.After.Interfaces;
using Solid.Common.Model;
using Solid.Common.Services;
using System;
using System.Collections.Generic;

namespace Solid.After.Implementations
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
