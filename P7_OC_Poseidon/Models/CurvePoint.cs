namespace P7_OC_Poseidon.Models
{
    public class CurvePoint
    {
        public int id { get; set; }
        public int curveId { get; set; }
        public DateTime asOfDate { get; set; }
        public double term { get; set; }
        public double value { get; set; }
        public DateTime creationDate { get; set; }
    }
}
