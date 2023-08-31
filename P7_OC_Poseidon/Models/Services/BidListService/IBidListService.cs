using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.BidListService
{
    public interface IBidListService
    {
        Task<BidListDto?> GetSingleBidList(int id);
        Task<List<BidList>> AddBidList(BidListDto bidListDto);
        Task<List<BidList>> UpdateBidList(int id, BidListDto bidListDto);
        Task<List<BidList>> DeleteBidList(int id);
    }
}
