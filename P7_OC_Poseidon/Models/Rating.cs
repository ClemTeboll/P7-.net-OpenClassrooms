namespace P7_OC_Poseidon.Models
{
    public class Rating
    {
        public int id { get; set; }
        public string moodysRating { get; set; }
        public string sandPRating { get; set; }
        public string fitchRating { get; set; }
        public int orderNumber { get; set; }
    }
}
