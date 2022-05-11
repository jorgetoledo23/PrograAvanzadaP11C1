using Microsoft.EntityFrameworkCore;

namespace API.Model
{
    public class AppDbContext : DbContext
    {

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration
                .GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
