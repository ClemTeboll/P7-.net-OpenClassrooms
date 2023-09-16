using AutoMapper;
using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Models.Data;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.RatingService
{
    public class RatingService : IRatingService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public RatingService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Rating>> AddRating(RatingDto ratingDto)
        {
            Rating newrating = _mapper.Map<Rating>(ratingDto);

            _context.Ratings.Add(newrating);
            await _context.SaveChangesAsync();

            return await _context.Ratings.ToListAsync();
        }

        public async Task<List<Rating>> DeleteRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
            {
                return null;
            }

            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();

            return await _context.Ratings.ToListAsync();
        }

        public async Task<List<RatingDto>> GetAllRatings()
        {
            var ratings = await _context.Ratings.ToListAsync();
            if (ratings == null)
                return null;

            List<RatingDto> ratingsDto = ratings.Select(_mapper.Map<RatingDto>).ToList();

            return ratingsDto;
        }

        public async Task<RatingDto?> GetSingleRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
                return null;

            RatingDto ratingDto = _mapper.Map<RatingDto>(rating);

            return ratingDto;
        }

        public async Task<List<Rating>> UpdateRating(int id, RatingDto ratingDto)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
                return null;

            _mapper.Map(ratingDto, rating);

            _context.Update(rating);
            await _context.SaveChangesAsync();

            return await _context.Ratings.ToListAsync();
        }
    }
}
