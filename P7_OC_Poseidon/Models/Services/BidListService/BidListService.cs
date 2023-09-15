using AutoMapper;
using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Models.Data;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.BidListService
{
    public class BidListService : IBidListService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BidListService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<BidList>> AddBidList(BidListDto bidListDto)
        {
            BidList newBidList = _mapper.Map<BidList>(bidListDto);

            _context.BidLists.Add(newBidList);
            await _context.SaveChangesAsync();

            return await _context.BidLists.ToListAsync();
        }

        public async Task<List<BidList>> DeleteBidList(int id)
        {
            var bidList = await _context.BidLists.FindAsync(id);
            if (bidList == null)
            {
                return null;
            }

            _context.BidLists.Remove(bidList);
            await _context.SaveChangesAsync();

            return await _context.BidLists.ToListAsync();
        }

        public async Task<List<BidListDto>> GetAllBidLists()
        {
            var bidLists = await _context.BidLists.ToListAsync();
            if (bidLists == null)
                return null;

            List<BidListDto> bidListsDto = bidLists.Select(_mapper.Map<BidListDto>).ToList();

            return bidListsDto;
        }

        public async Task<BidListDto?> GetSingleBidList(int id)
        {
            var bidList = await _context.BidLists.FindAsync(id);
            if (bidList == null)
                return null;

            BidListDto bidListDto = _mapper.Map<BidListDto>(bidList);

            return bidListDto;
        }

        public async Task<List<BidList>> UpdateBidList(int id, BidListDto bidListDto)
        {
            var bidList = await _context.BidLists.FindAsync(id);

            if (bidList == null)
                return null;

            _mapper.Map(bidListDto, bidList);

            _context.Update(bidList);
            await _context.SaveChangesAsync();

            return await _context.BidLists.ToListAsync();
        }
    }
}
