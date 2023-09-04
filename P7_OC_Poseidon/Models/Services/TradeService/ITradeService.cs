using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.TradeService
{
    public interface ITradeService
    {
        Task<List<TradeDto>> GetAllTrades();
        Task<TradeDto?> GetSingleTrade(int id);
        Task<List<Trade>> AddTrade(TradeDto TradeDto);
        Task<List<Trade>> UpdateTrade(int id, TradeDto TradeDto);
        Task<List<Trade>> DeleteTrade(int id);
    }
}
