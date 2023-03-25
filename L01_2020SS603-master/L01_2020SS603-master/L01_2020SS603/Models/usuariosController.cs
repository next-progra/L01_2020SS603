using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace L01_2020SS603.Models




{
    public class usuariosController : DbContext
    {
        public usuariosController(DbContextOptions<usuariosController> options) : base(options)
        {

        }
        public DbSet<usuarios> usuarios { get; set; } = null!;
        public DbSet<calificaciones> calificaciones { get; set; } = null!;
        public DbSet<comentarios> comentarios { get; set; } = null!;
    }
}


