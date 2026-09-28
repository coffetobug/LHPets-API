using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LHPets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Models.Cliente> ListaClientes = new List<Models.Cliente>();
        [HttpGet]
        public ActionResult<List<Models.Cliente>> Get()

        {
            return Ok(ListaClientes);
        }
        [HttpPost]
        public ActionResult<Models.Cliente> Post(Models.Cliente cliente)
        {
            ListaClientes.Add(cliente);
            return Created("", cliente);
        }
    }
}
