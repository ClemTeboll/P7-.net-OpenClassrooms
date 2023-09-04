namespace P7_OC_Poseidon.Models.Dtos
{
    public record struct TradeDto
    (
        int TradeId,
        string Account,
        string Type,
        double BuyQuantity,
        double SellQuantity,
        double BuyPrice,
        double SellPrice,
        string Benchmark,
        DateTime TradeDate,
        string Security,
        string Status,
        string Trader,
        string Nook,
        string CreationName,
        DateTime CreationDate,
        string RevisionName,
        DateTime RevisionDate,
        string DealName,
        string DealType,
        string SourceListId,
        string Side
    );
}
