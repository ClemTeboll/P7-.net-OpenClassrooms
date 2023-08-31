using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Models;

namespace P7_OC_Poseidon.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost;Database=P7_OC_Poseidon;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<BidList> BidLists { get; set; }
    }
}
