using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PROYECTO_7_10_26.Modelos;

namespace PROYECTO_7_10_26.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Salas> Salas { get; set; }
        public DbSet<Reservaciones> Reservaciones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlite("Data Source=reservaciones.db");
        }
    }
}
