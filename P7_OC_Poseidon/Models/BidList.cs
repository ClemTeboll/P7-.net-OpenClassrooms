using Microsoft.EntityFrameworkCore;

namespace P7_OC_Poseidon.Models
{
    public class BidList
    {
        public int BidListId { get; set; }
        public required string Account { get; set; }
        public required string Type { get; set; }
        public double BidQuantity { get; set; }
        public double AskQuantity { get; set; }
        public double Bid { get; set; }
        public string? Benchmark { get; set; }
        public DateTime BidListDate { get; set; }
        public string? Commentary { get; set; }
        public string? Security { get; set; }
        public string? Status { get; set; }
        public string? Trader { get; set; }
        public string? Book { get; set; }
        public string? CreationName { get; set; }
        public DateTime CreationDate { get; set; }
        public string? RevisionName { get; set; }
        public DateTime RevisionDate { get; set; }
        public string? DealName { get; set; }
        public string? DealType { get; set; }
        public string? SourceListId { get; set; }
        public string? Side { get; set; }


        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BidList>(bl =>
            {
                bl.HasKey(x => x.BidListId);
                bl.Property(x => x.Account).IsRequired();
                bl.Property(x => x.Type).IsRequired();
                bl.ToTable(nameof(BidList));
            });
        }
    }
}
