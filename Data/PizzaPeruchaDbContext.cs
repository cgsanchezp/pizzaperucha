using Microsoft.EntityFrameworkCore;
using PizzaPeruchaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPeruchaApp.Data
{
    public class PizzaPeruchaDbContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-M6QL1VU;Database=PizzaPeruchaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
