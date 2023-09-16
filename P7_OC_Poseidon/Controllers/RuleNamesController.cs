using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using P7_OC_Poseidon.Models.Dtos;
using P7_OC_Poseidon.Models.Services.RuleNameService;

namespace P7_OC_Poseidon.Controllers
{
    [ApiController, Authorize]
    [Route("api/[controller]")]
    public class RuleController : ControllerBase
    {
        private readonly IRuleNameService _ruleNameService;

        public RuleController(IRuleNameService ruleNameService)
        {
            _ruleNameService = ruleNameService;
        }

        // GET: api/RuleDtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RuleDto>>> GetRules()
        {
            var result = await _ruleNameService.GetAllRules();
            if (result == null)
                return NotFound("RuleNams not found");

            return Ok(result);
        }

        // GET: api/RuleDtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RuleDto>> GetRule(int id)
        {
            var result = await _ruleNameService.GetSingleRule(id);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }

        // PUT: api/RuleDtos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRule(int id, RuleDto ruleDto)
        {
            var result = await _ruleNameService.UpdateRule(id, ruleDto);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }

        // POST: api/RuleDtos
        [HttpPost]
        public async Task<ActionResult<RuleDto>> PostRule(RuleDto ruleDto)
        {
            var result = await _ruleNameService.AddRule(ruleDto);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }

        // DELETE: api/RuleDtos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRule(int id)
        {
            var result = await _ruleNameService.DeleteRule(id);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }
    }
}
