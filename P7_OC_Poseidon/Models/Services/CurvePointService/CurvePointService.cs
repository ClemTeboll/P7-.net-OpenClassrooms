using AutoMapper;
using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Models.Data;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.CurvePointService
{
    public class CurvePointService : ICurvePointService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CurvePointService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CurvePoint>> AddCurvePoint(CurvePointDto curvePointDto)
        {
            CurvePoint newCurvePoint = _mapper.Map<CurvePoint>(curvePointDto);

            _context.CurvePoints.Add(newCurvePoint);
            await _context.SaveChangesAsync();

            return await _context.CurvePoints.ToListAsync();
        }

        public async Task<List<CurvePoint>> DeleteCurvePoint(int id)
        {
            var curvePoint = await _context.CurvePoints.FindAsync(id);
            if (curvePoint == null)
            {
                return null;
            }

            _context.CurvePoints.Remove(curvePoint);
            await _context.SaveChangesAsync();

            return await _context.CurvePoints.ToListAsync();
        }

        public async Task<List<CurvePointDto>> GetAllCurvePoints()
        {
            var curvePoints = await _context.CurvePoints.ToListAsync();
            if (curvePoints == null)
                return null;

            List<CurvePointDto> curvePointsDto = curvePoints.Select(_mapper.Map<CurvePointDto>).ToList();

            return curvePointsDto;
        }

        public async Task<CurvePointDto?> GetSingleCurvePoint(int id)
        {
            var curvePoint = await _context.CurvePoints.FindAsync(id);
            if (curvePoint == null)
                return null;

            CurvePointDto curvePointDto = _mapper.Map<CurvePointDto>(curvePoint);

            return curvePointDto;
        }

        public async Task<List<CurvePoint>> UpdateCurvePoint(int id, CurvePointDto CurvePointDto)
        {
            var curvePoint = await _context.CurvePoints.FindAsync(id);

            if (curvePoint == null)
                return null;

            _mapper.Map(CurvePointDto, curvePoint);

            _context.Update(curvePoint);
            await _context.SaveChangesAsync();

            return await _context.CurvePoints.ToListAsync();
        }
    }
}
