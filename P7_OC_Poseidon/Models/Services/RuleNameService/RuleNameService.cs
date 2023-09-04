using AutoMapper;
using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Data;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.RuleNameService
{
    public class RuleNameService : IRuleNameService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public RuleNameService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<RuleName>> AddRule(RuleDto RuleDto)
        {
            RuleName newRuleName = _mapper.Map<RuleDto, RuleName>(RuleDto);

            _context.RuleNames.Add(newRuleName);
            await _context.SaveChangesAsync();

            return await _context.RuleNames.ToListAsync();
        }

        public async Task<List<RuleName>> DeleteRule(int id)
        {
            var ruleName = await _context.RuleNames.FindAsync(id);
            if (ruleName == null)
            {
                return null;
            }

            _context.RuleNames.Remove(ruleName);
            await _context.SaveChangesAsync();

            return await _context.RuleNames.ToListAsync();
        }

        public async Task<List<RuleDto>> GetAllRules()
        {
            var ruleNames = await _context.RuleNames.ToListAsync();
            if (ruleNames == null)
                return null;

            List<RuleDto> ruleDto = ruleNames.Select(_mapper.Map<RuleDto>).ToList();

            return ruleDto;
        }

        public async Task<RuleDto?> GetSingleRule(int id)
        {
            var ruleName = await _context.RuleNames.FindAsync(id);
            if (ruleName == null)
                return null;

            RuleDto RuleDto = _mapper.Map<RuleDto>(ruleName);

            return RuleDto;
        }

        public async Task<List<RuleName>> UpdateRule(int id, RuleDto RuleDto)
        {
            var ruleName = await _context.RuleNames.FindAsync(id);

            if (ruleName == null)
                return null;

            _mapper.Map(RuleDto, ruleName);

            _context.Update(ruleName);
            await _context.SaveChangesAsync();

            return await _context.RuleNames.ToListAsync();
        }
    }
}
