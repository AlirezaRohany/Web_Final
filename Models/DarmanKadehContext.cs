using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web_Final.Models;

namespace Web_Final.Models
{
    public class DarmanKadehContext : IdentityDbContext<ApplicationUser>
    {
        public DarmanKadehContext(DbContextOptions options) : base(options)
        {
        }

        protected DarmanKadehContext()
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.LogTo()
        // }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}