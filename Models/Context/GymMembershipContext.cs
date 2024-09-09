using Gym_Membership.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gym_Membership.Models.Context

{
    public class GymMembershipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=GymMembership;trusted_connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Uye> Uyeler { get; set; }
    }
}
