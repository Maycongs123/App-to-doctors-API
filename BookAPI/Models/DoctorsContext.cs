using Microsoft.EntityFrameworkCore;

namespace DoctorAPI.Models
{
    public class DoctorsContext : DbContext
    {
        public DoctorsContext(DbContextOptions<DoctorsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }        
    }
}
