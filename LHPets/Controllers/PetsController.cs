using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LHPets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private static List<Models.Pet> ListaPets = new List<Models.Pet>();
        [HttpGet]
        public ActionResult<List<Models.Pet>> Get()
        {
            return Ok(ListaPets);
        }
        [HttpPost]
        public ActionResult<Models.Pet> Post(Models.Pet pet)
        {
            ListaPets.Add(pet);
            return Created("", pet);
        }
        [HttpGet("cliente/{clienteId}")]
        public ActionResult<List<Models.Pet>> GetPorCliente( int clienteId)
        {
            var petsDoCliente = ListaPets.Where(p => p.ClienteId == clienteId).ToList();
            return Ok(petsDoCliente);
        }
    }
}
