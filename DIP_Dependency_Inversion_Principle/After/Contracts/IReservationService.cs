using DIP_Dependency_Inversion_Principle.Common.Model;

namespace DIP_Dependency_Inversion_Principle.After.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(Cart cart);
    }
}
