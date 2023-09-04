using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Data;
using P7_OC_Poseidon.Models;
using P7_OC_Poseidon.Models.Dtos;
using P7_OC_Poseidon.Models.Services.TradeService;

namespace P7_OC_Poseidon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        private readonly ITradeService _tradeService;

        public TradesController(ITradeService tradeService)
        {
            _tradeService = tradeService;
        }

        // GET: api/Trades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trade>>> GetTrades()
        {
            var result = await _tradeService.GetAllTrades();
            if (result == null)
                return NotFound("Trades not found");

            return Ok(result);
        }

        // GET: api/Trades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trade>> GetTrade(int id)
        {
            var result = await _tradeService.GetSingleTrade(id);
            if (result == null)
                return NotFound("Trade not found");

            return Ok(result);
        }

        // PUT: api/Trades/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrade(int id, TradeDto tradeDto)
        {
            var result = await _tradeService.UpdateTrade(id, tradeDto);
            if (result == null)
                return NotFound("Trade not found");

            return Ok(result);
        }

        // POST: api/Trades
        [HttpPost]
        public async Task<ActionResult<Trade>> PostTrade(TradeDto tradeDto)
        {
            var result = await _tradeService.AddTrade(tradeDto);
            if (result == null)
                return NotFound("Trade not found");

            return Ok(result);
        }

        // DELETE: api/Trades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrade(int id)
        {
            var result = await _tradeService.DeleteTrade(id);
            if (result == null)
                return NotFound("Trade not found");

            return Ok(result);
        }
    }
}
