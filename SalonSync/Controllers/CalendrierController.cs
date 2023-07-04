using Microsoft.AspNetCore.Mvc;
using SalonSync.BLL.Interfaces;
using SalonSync.BLL.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalonSync.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CalendrierController : ControllerBase
    {
        private readonly ICalendrierService _calendrierService;
        public CalendrierController(ICalendrierService calendrierService)
        {
            _calendrierService = calendrierService;
        }

        // GET: api/<CalendrierController>
        [HttpGet]
        public IActionResult GetAllCalendrier()
        {
            var calendrier = _calendrierService.GetAllCalendrier();
            return calendrier is not null ? Ok(calendrier) : BadRequest();
        }
    }
}
