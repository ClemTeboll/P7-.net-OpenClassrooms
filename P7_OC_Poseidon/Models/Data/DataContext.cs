using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Models;

namespace P7_OC_Poseidon.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected void OnConfiguring(ModelBuilder modelBuilder)
        {
            DatabaseConfig.Configure(modelBuilder);
        }

        public DbSet<BidList> BidLists { get; set; }
        public DbSet<CurvePoint> CurvePoints { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RuleName> RuleNames { get; set; }
        public DbSet<Trade> Trades { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
