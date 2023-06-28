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



        //Get une plage horaire avec L'ID d'un coiffeur

        [HttpGet("{coiffeurId}")]
        public IActionResult GetPlageHorairesByCoiffeur(int coiffeurId)
        {
            var plagesHoraires = _plagesHorairesService.GetPlageHorairesByCoiffeur(coiffeurId);
            return Ok(plagesHoraires);
        }
    }
}
