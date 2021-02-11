using Microsoft.EntityFrameworkCore;
using Web_Final.Models.Patient;

namespace Web_Final.Models
{
    public class DarmanKadehContext : DbContext
    {
        public DarmanKadehContext(DbContextOptions options) : base(options)
        {
        }

        protected DarmanKadehContext()
        {
        }

        public DbSet<PatientEntity> Patients { get; set; }
    }
}