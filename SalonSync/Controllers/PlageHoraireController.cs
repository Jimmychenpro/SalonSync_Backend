using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonSync.BLL.Interfaces;
using SalonSync.BLL.Services;
namespace SalonSync.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlageHoraireController : ControllerBase
    {
        private readonly IPlageHoraireService _plagesHorairesService;

        public PlageHoraireController(IPlageHoraireService plagesHorairesService)
        {
            _plagesHorairesService = plagesHorairesService;
        }

        [HttpGet("{coiffeurId}")]
        public IActionResult GetPlagesHoraires(int coiffeurId)
        {
            var plagesHoraires = _plagesHorairesService.GetPlagesHoraires(coiffeurId);
            return Ok(plagesHoraires);
        }
    }
}
