using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.BidListService
{
    public interface IBidListService
    {
        Task<BidListService?> GetSingleBidListService(int id);
        Task<List<BidListService>> AddBidListService(BidListDto BidListDto, BidList bidList);
        Task<List<BidListService>> UpdateBidListService(int id, BidListDto BidListDto);
        Task<List<BidListService>> DeleteBidListService(int id);
    }
}
