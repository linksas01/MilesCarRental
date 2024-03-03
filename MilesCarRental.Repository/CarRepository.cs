using Microsoft.EntityFrameworkCore;
using MilesCarRental.Models;
using MilesCarRental.Repository.Interfaces;

namespace MilesCarRental.Repository
{
    public class CarRepository : ICarRepository
    {
        private MilesCarRentalContext _context;

        public CarRepository(MilesCarRentalContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCarsByLocation(Guid pickUpLocationId, Guid returnLocationId)
        {
            return _context.Cars
                .Where(c => c.PickUpLocationId.Equals(pickUpLocationId) && c.ReturnLocationId.Equals(returnLocationId));
        }
    }
}