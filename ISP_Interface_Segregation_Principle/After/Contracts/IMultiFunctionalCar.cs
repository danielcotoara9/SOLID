namespace ISP_Interface_Segregation_Principle.After.Interfaces
{
    // not duplicate the code for fly drive behavior => use the existent interfaces
    public interface IMultiFunctionalCar : ICar, IAirplane
    { }
}
