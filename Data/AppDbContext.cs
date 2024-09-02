using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller.Models;

namespace Taller.Data
{
    public class AppDbContext: DbContext
    {
        
        public DbSet<Propietario> Propietarios {get; set; }
        public DbSet<Vehiculo> Mascotas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}