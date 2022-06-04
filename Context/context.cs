using BootCamp_API_REST_Clase17.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCamp_API_REST_Clase17.Context
{
    public class context : DbContext
    {
        public context(DbContextOptions<context> options) : base(options)
        {
        
        }

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }

    }
}
