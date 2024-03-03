using MilesCarRental.Business.Interfaces;
using MilesCarRental.Models;
using MilesCarRental.Repository.Interfaces;

namespace MilesCarRental.Business
{
    public class CarBusiness : ICarBusiness
    {
        ICarRepository _carRepository;

        public CarBusiness(ICarRepository carRepository) 
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> GetCarsByLocation(Guid pickUpLocationId, Guid returnLocationId)
        {
            return _carRepository.GetCarsByLocation(pickUpLocationId, returnLocationId);
        }
    }
}
