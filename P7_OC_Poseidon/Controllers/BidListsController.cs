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

        // GET: api/BidLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BidList>> GetBidList(int id)
        {
            var result = _bidListService.GetSingleBidList(id);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // PUT: api/BidLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult> PutBidList(int id, BidListDto bidListDto)
        {
            var result = _bidListService.UpdateBidList(id, bidListDto);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // POST: api/BidLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
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
