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
using P7_OC_Poseidon.Models.Services.RuleNameService;

namespace P7_OC_Poseidon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RuleDtosController : ControllerBase
    {
        private readonly IRuleNameService _ruleNameService;

        public RuleDtosController(IRuleNameService ruleNameService)
        {
            _ruleNameService = ruleNameService;
        }

        // GET: api/RuleDtos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RuleDto>>> GetRuleDtos()
        {
            var result = await _ruleNameService.GetAllRules();
            if (result == null)
                return NotFound("RuleNams not found");

            return Ok(result);
        }

        // GET: api/RuleDtos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RuleDto>> GetRuleDto(int id)
        {
            var result = await _ruleNameService.GetSingleRule(id);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }

        // PUT: api/RuleDtos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRuleDto(int id, RuleDto ruleDto)
        {
            var result = await _ruleNameService.UpdateRule(id, ruleDto);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }

        // POST: api/RuleDtos
        [HttpPost]
        public async Task<ActionResult<RuleDto>> PostRuleDto(RuleDto ruleDto)
        {
            var result = await _ruleNameService.AddRule(ruleDto);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }

        // DELETE: api/RuleDtos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRuleDto(int id)
        {
            var result = await _ruleNameService.DeleteRule(id);
            if (result == null)
                return NotFound("Rule not found");

            return Ok(result);
        }
    }
}
