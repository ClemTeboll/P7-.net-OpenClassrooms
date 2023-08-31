namespace P7_OC_Poseidon.Models
{
    public class BidList
    {
        public int BidListId { get; set; }
        public string account { get; set; }
        public string type { get; set; }
        public double bidQuantity { get; set; }
        public double askQuantity { get; set; }
        public double bid { get; set; }
        public double ask { get; set; }
        public string benchmark { get; set; }
        public DateTime bidListDate { get; set; }
        public string commentary { get; set; }
        public string security { get; set; }
        public string status { get; set; }
        public string trader { get; set; }
        public string book { get; set; }
        public string creationName { get; set; }
        public DateTime creationDate { get; set; }
        public string revisionName { get; set; }
        public DateTime revisionDate { get; set; }
        public string dealName { get; set; }
        public string dealType { get; set; }
        public string sourceListId { get; set; }
        public string side { get; set; }
    }
}
