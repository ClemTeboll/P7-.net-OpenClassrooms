using AutoMapper;
using P7_OC_Poseidon.Data;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.BidListService
{
    public class BidListService : IBidListService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public Task<List<BidListService>> AddBidListService(BidListDto BidListDto, BidList hero)
        {
            throw new NotImplementedException();
        }

        public Task<List<BidListService>> DeleteBidListService(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BidListService?> GetSingleBidListService(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BidListService>> UpdateBidListService(int id, BidListDto BidListDto)
        {
            throw new NotImplementedException();
        }
    }
}
