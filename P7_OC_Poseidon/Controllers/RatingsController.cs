using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using P7_OC_Poseidon.Models;
using P7_OC_Poseidon.Models.Dtos;
using P7_OC_Poseidon.Models.Services.RatingService;

namespace P7_OC_Poseidon.Controllers
{
    [ApiController, Authorize]
    [Route("api/[controller]")]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        // GET: api/Ratings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
        {
            var result = await _ratingService.GetAllRatings();
            if (result == null)
                return NotFound("Ratings not found");

            return Ok(result);
        }

        // GET: api/Ratings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rating>> GetRating(int id)
        {
            var result = await _ratingService.GetSingleRating(id);
            if (result == null)
                return NotFound("Rating not found");

            return Ok(result);
        }

        // PUT: api/Ratings/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, RatingDto ratingDto)
        {
            var result = await _ratingService.UpdateRating(id, ratingDto);
            if (result == null)
                return NotFound("Rating not found");

            return Ok(result);
        }

        // POST: api/Ratings
        [HttpPost]
        public async Task<ActionResult<Rating>> PostRating(RatingDto ratingDto)
        {
            var result = await _ratingService.AddRating(ratingDto);
            if (result == null)
                return NotFound("Rating not found");

            return Ok(result);
        }

        // DELETE: api/Ratings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            var result = await _ratingService.DeleteRating(id);
            if (result == null)
                return NotFound("Rating not found");

            return Ok(result);
        }
    }
}
