using Microsoft.AspNetCore.Mvc;
using P7_OC_Poseidon.Models;
using P7_OC_Poseidon.Models.Dtos;
using P7_OC_Poseidon.Models.Services.BidListService;

namespace P7_OC_Poseidon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidListsController : ControllerBase
    {
        private readonly IBidListService _bidListService;

        public BidListsController(IBidListService bidListService)
        {
            _bidListService = bidListService;
        }

        // GET: api/BidLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BidList>>> GetBidLists()
        {
            var result = await _bidListService.GetAllBidLists();
            if (result == null)
                return NotFound("BidLists not found");

            return Ok(result);
        }

        // GET: api/BidLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BidList>> GetBidList(int id)
        {
            var result = await _bidListService.GetSingleBidList(id);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // PUT: api/BidLists/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutBidList(int id, BidListDto bidListDto)
        {
            var result = await _bidListService.UpdateBidList(id, bidListDto);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // POST: api/BidLists
        [HttpPost]
        public async Task<ActionResult<BidList>> PostBidList(BidListDto bidListDto)
        {
            var result = await _bidListService.AddBidList(bidListDto);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // DELETE: api/BidLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBidList(int id)
        {
            var result = await _bidListService.DeleteBidList(id);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }
    }
}
