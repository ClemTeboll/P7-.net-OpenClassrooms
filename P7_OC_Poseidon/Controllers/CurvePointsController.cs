using Microsoft.AspNetCore.Mvc;
using P7_OC_Poseidon.Models;
using P7_OC_Poseidon.Models.Dtos;
using P7_OC_Poseidon.Models.Services.CurvePointService;

namespace P7_OC_Poseidon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurvePointsController : ControllerBase
    {
        private readonly ICurvePointService _curvePointService;

        public CurvePointsController(ICurvePointService curvePointService)
        {
            _curvePointService = curvePointService;
        }

        // GET: api/CurvePoints
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurvePoint>>> GetAllCurvePoints()
        {
            var result = await _curvePointService.GetAllCurvePoints();
            if (result == null)
                return NotFound("BidLists not found");

            return Ok(result);
        }

        // GET: api/CurvePoints/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurvePoint>> GetCurvePoint(int id)
        {
            var result = await _curvePointService.GetSingleCurvePoint(id);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // PUT: api/CurvePoints/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurvePoint(int id, CurvePointDto curvePointDto)
        {
            var result = await _curvePointService.UpdateCurvePoint(id, curvePointDto);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // POST: api/CurvePoints
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CurvePoint>> PostCurvePoint(CurvePointDto curvePointDto)
        {
            var result = await _curvePointService.AddCurvePoint(curvePointDto);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }

        // DELETE: api/CurvePoints/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurvePoint(int id)
        {
            var result = await _curvePointService.DeleteCurvePoint(id);
            if (result == null)
                return NotFound("BidList not found");

            return Ok(result);
        }
    }
}
