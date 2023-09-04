namespace P7_OC_Poseidon.Models.Dtos
{
    public record struct RuleDto
    (
        int Id,
        string Name,
        string Description,
        string Json,
        string Template,
        string SqlStr,
        string SqlPart
    );
}
