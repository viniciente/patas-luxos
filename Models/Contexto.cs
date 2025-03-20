using Microsoft.EntityFrameworkCore;

namespace PatasLuxos.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produtos> Produtos { get; set; }
    }

}
