using Microsoft.EntityFrameworkCore;

namespace P7_OC_Poseidon.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string? MoodysRating { get; set; }
        public string? SandPRating { get; set; }
        public string? FitchRating { get; set; }
        public int? OrderNumber { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>(r =>
            {
                r.HasKey(x => x.Id);
                r.ToTable(nameof(Rating));
            });
        }
    }
}
