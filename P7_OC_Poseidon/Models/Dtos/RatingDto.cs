namespace P7_OC_Poseidon.Models.Dtos
{
    public record struct RatingDto
    (
     int Id,
     string? MoodysRating,
     string? SandPRating,
     string? FitchRating,
     int? OrderNumber
    );
}
