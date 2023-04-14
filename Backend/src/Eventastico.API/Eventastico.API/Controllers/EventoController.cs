using Eventastico.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventastico.API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventoController : ControllerBase
    {

        public EventoController() { }

        [HttpGet(Name = "GetEvent")]
        public IEnumerable<Evento> Get()
        {
            return null;
        }
    }

}