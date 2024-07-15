using Microsoft.EntityFrameworkCore;
using sl.Entidades;
using System;

namespace sl.BdConexion
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
        }

        // Agrega DbSet para cada entidad
        public DbSet<BookingStatus> Booking { get; set; }
        //public DbSet<Category> Categories { get; set; }
        // Agrega otras entidades aquí

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura las relaciones, índices, etc.
        }
    }
}
