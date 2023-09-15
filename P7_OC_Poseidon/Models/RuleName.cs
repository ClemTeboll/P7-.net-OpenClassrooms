using Microsoft.EntityFrameworkCore;

namespace P7_OC_Poseidon.Models
{
    public class RuleName
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Json { get; set; }
        public string Template { get; set; }
        public string SqlStr { get; set; }
        public string SqlPart { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RuleName>(rn =>
            {
                rn.HasKey(x => x.Id);
                rn.ToTable("Rule");
            });
        }
    }
}
