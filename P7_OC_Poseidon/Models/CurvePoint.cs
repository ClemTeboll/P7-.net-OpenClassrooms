using Microsoft.EntityFrameworkCore;

namespace P7_OC_Poseidon.Models
{
    public class CurvePoint
    {
        public int Id { get; set; }
        public int? CurveId { get; set; }
        public DateTime? AsOfDate { get; set; }
        public double? Term { get; set; }
        public double? Value { get; set; }
        public DateTime? CreationDate { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurvePoint>(cp =>
            {
                cp.HasKey(x => x.Id);
                cp.ToTable(nameof(CurvePoint));
            });
        }
    }
}
