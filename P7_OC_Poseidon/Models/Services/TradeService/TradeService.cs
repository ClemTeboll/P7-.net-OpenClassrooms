using AutoMapper;
using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Data;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.TradeService
{
    public class TradeService : ITradeService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TradeService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Trade>> AddTrade(TradeDto tradeDto)
        {
            Trade newTrade = _mapper.Map<TradeDto, Trade>(tradeDto);

            _context.Trades.Add(newTrade);
            await _context.SaveChangesAsync();

            return await _context.Trades.ToListAsync();
        }

        public async Task<List<Trade>> DeleteTrade(int id)
        {
            var trade = await _context.Trades.FindAsync(id);
            if (trade == null)
            {
                return null;
            }

            _context.Trades.Remove(trade);
            await _context.SaveChangesAsync();

            return await _context.Trades.ToListAsync();
        }

        public async Task<List<TradeDto>> GetAllTrades()
        {
            var trades = await _context.Trades.ToListAsync();
            if (trades == null)
                return null;

            List<TradeDto> tradeDto = trades.Select(_mapper.Map<TradeDto>).ToList();

            return tradeDto;
        }

        public async Task<TradeDto?> GetSingleTrade(int id)
        {
            var trade = await _context.Trades.FindAsync(id);
            if (trade == null)
                return null;

            TradeDto tradeDto = _mapper.Map<TradeDto>(trade);

            return tradeDto;
        }

        public async Task<List<Trade>> UpdateTrade(int id, TradeDto tradeDto)
        {
            var trade = await _context.Trades.FindAsync(id);

            if (trade == null)
                return null;

            _mapper.Map(tradeDto, trade);

            _context.Update(trade);
            await _context.SaveChangesAsync();

            return await _context.Trades.ToListAsync();
        }
    }
}
