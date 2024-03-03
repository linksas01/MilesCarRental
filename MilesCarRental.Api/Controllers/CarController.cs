using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilesCarRental.Business.Interfaces;
using MilesCarRental.Models;

namespace MilesCarRental.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarBusiness _carBusiness;
        public CarController(ICarBusiness carBusiness) 
        {
            _carBusiness = carBusiness;
        }
        
        [HttpGet]
        public ActionResult GetCarsByLocation(Guid pickUpLocationId, Guid returnLocationId)
        {
            return Ok(_carBusiness.GetCarsByLocation(pickUpLocationId, returnLocationId));
        }
    }
}
