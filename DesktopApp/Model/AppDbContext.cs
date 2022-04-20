using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Model
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DesktopAppP11C1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //API FLUENT 
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Empleado>().HasKey(emp => emp.Rut);
            modelBuilder.Entity<Empleado>().
                Property(emp => emp.FechaNacimiento).HasColumnType("date");
        }
        public DbSet<Empleado> Empleados { get; set; }

    }
}
