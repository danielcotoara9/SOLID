using DIP_Dependency_Inversion_Principle.After.Interfaces;
using DIP_Dependency_Inversion_Principle.Common.Model;
using DIP_Dependency_Inversion_Principle.Common.Services;
using System;

namespace DIP_Dependency_Inversion_Principle.After.Implementation
{
    public class ReservationService : IReservationService
    {
        public void ReserveInventory(Cart cart)
        {
            foreach (var item in cart.Items)
            {
                try
                {
                    // dependency on InventoryService
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
