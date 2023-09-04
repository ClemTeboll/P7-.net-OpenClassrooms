using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.RuleNameService
{
    public interface IRuleNameService
    {
        Task<List<RuleDto>> GetAllRules();
        Task<RuleDto?> GetSingleRule(int id);
        Task<List<RuleName>> AddRule(RuleDto RuleDto);
        Task<List<RuleName>> UpdateRule(int id, RuleDto RuleDto);
        Task<List<RuleName>> DeleteRule(int id);
    }
}
