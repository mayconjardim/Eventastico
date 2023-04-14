using Microsoft.AspNetCore.Mvc;

namespace Eventastico.API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventoController : ControllerBase
    {

      public EventoController()
        {
            
        }

        [HttpGet(Name = "GetEvent")]
        public string Get()
        {
            return "Eventastico";
        }
    }
}