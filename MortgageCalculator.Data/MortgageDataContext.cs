using Microsoft.EntityFrameworkCore;
using MortgageCalculator.Data.Models;

namespace MortgageCalculator.Data
{
    public class MortgageDataContext : DbContext
    {
        public MortgageDataContext(DbContextOptions<MortgageDataContext> options)
            : base(options)
        {

        }

        // Define DbSet for the Mortgage table
        public DbSet<Mortgage> Mortgage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings (optional)
            modelBuilder.Entity<Mortgage>()
                .HasKey(m => m.MortgageId); // Set primary key for the Mortgage table
        }
    }
}
