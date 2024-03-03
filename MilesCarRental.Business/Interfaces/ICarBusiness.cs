using MilesCarRental.Models;

namespace MilesCarRental.Business.Interfaces
{
    public interface ICarBusiness
    {
        IEnumerable<Car> GetCarsByLocation(Guid pickUpLocationId, Guid returnLocationId);
    }
}