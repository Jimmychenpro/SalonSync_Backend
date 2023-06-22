using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonSync.BLL.Services;
namespace SalonSync.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlageHoraireController : ControllerBase
    {
        private readonly PlageHoraireService _plagesHorairesService;

        public PlageHoraireController(PlageHoraireService plagesHorairesService)
        {
            _plagesHorairesService = plagesHorairesService;
        }

        [HttpGet]
        public IActionResult GetPlagesHoraires()
        {
            var plagesHoraires = _plagesHorairesService.GetPlagesHoraires();
            return Ok(plagesHoraires);
        }
    }
}
