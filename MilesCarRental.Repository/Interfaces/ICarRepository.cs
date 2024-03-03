using MilesCarRental.Models;

namespace MilesCarRental.Repository.Interfaces
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCarsByLocation(Guid pickUpLocationId, Guid returnLocationId);        
    }
}