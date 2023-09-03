using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.RatingService
{
    public interface IRatingService
    {
        Task<List<RatingDto>> GetAllRatings();
        Task<RatingDto?> GetSingleRating(int id);
        Task<List<Rating>> AddRating(RatingDto RatingDto);
        Task<List<Rating>> UpdateRating(int id, RatingDto RatingDto);
        Task<List<Rating>> DeleteRating(int id);
    }
}
