using Microsoft.EntityFrameworkCore;
using SistemadeClubDeportivo.Models;

namespace SistemadeClubDeportivo.Contexto
{
    public class MyContexto : DbContext
    {
        public MyContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Horario> Horarios { get; set; }
    }
}
