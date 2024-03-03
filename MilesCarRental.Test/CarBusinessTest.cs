using MilesCarRental.Business;
using MilesCarRental.Business.Interfaces;
using MilesCarRental.Models;
using MilesCarRental.Repository.Interfaces;
using Moq;

namespace MilesCarRental.Test
{
    public class CarBusinessTest
    {
        private Mock<ICarRepository> _carRepository;

        private ICarBusiness _carBusiness;

        [SetUp]
        public void Setup()
        {
            _carRepository = new Mock<ICarRepository>();
            _carBusiness = new CarBusiness(_carRepository.Object);

        }

        [Test]
        public void GetCarsByLocationAnyInformation()
        {
            // Arrange
            IEnumerable<Car> expectedCars = new Car[] { new Car { Id = Guid.NewGuid() }, new Car { Id = Guid.NewGuid() } };
            _carRepository.Setup(it => it.GetCarsByLocation(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(expectedCars);

            // Act
            IEnumerable<Car> actualCars = _carBusiness.GetCarsByLocation(It.IsAny<Guid>(), It.IsAny<Guid>());

            // Assert
            Assert.IsTrue(actualCars.Any());
        }

        [Test]
        public void GetCarsByLocationNoInformation()
        {
            // Arrange
            IEnumerable<Car> expectedCars = new Car[] { };
            _carRepository.Setup(it => it.GetCarsByLocation(It.IsAny<Guid>(), It.IsAny<Guid>())).Returns(expectedCars);

            // Act
            IEnumerable<Car> actualCars = _carBusiness.GetCarsByLocation(It.IsAny<Guid>(), It.IsAny<Guid>());

            // Assert
            Assert.IsFalse(actualCars.Any());
        }
    }
}