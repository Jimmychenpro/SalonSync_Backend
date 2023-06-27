using Microsoft.AspNetCore.Mvc;
using SalonSync.BLL.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SalonSync.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoiffeurController : ControllerBase
    {
        private readonly ICoiffeurService _coiffeurService;
        public CoiffeurController(ICoiffeurService coiffeurService)
        {
            _coiffeurService = coiffeurService;
        }

        // GET: api/<CoiffeurController>
        [HttpGet("{coiffeurId}")]
        public IActionResult GetCoiffeur(int coiffeurId)
        {
            var coiffeur = _coiffeurService.GetCoiffeur(coiffeurId);
            return Ok(coiffeur);
        }

        //// GET api/<CoiffeurController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<CoiffeurController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CoiffeurController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CoiffeurController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
