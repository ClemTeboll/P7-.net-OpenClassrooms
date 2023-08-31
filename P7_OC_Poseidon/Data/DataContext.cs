using Microsoft.EntityFrameworkCore;

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
            optionsBuilder.UseSqlServer("Server=;Database=;Trusted_Connection=true;TrustServerCertificate=true;");
        }
    }
}
