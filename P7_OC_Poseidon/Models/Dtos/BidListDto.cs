namespace P7_OC_Poseidon.Models.Dtos
{
    public record struct BidListDto(
        int? bidListId,
        string account, 
        string type, 
        double? bidQuantity);
}
