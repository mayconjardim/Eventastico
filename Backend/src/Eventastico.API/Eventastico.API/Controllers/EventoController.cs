using Eventastico.API.Data;
using Eventastico.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eventastico.API.Controllers
{
    [ApiController]
    [Route("api/events")]
    public class EventoController : ControllerBase
    {

        private readonly DataContext _context;

        public EventoController(DataContext dataContext)
        { 
            _context = dataContext;
        }

        [HttpGet(Name = "GetEvent")]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos.ToList();
        }
    }

}