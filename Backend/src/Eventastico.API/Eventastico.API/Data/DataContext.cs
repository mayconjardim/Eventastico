using Eventastico.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventastico.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Evento> Eventos { get; set; }

    }
}
