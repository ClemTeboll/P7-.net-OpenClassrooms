using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.CurvePointService
{
    public interface ICurvePointService
    {
        Task<List<CurvePointDto>> GetAllCurvePoints();
        Task<CurvePointDto?> GetSingleCurvePoint(int id);
        Task<List<CurvePoint>> AddCurvePoint(CurvePointDto CurvePointDto);
        Task<List<CurvePoint>> UpdateCurvePoint(int id, CurvePointDto CurvePointDto);
        Task<List<CurvePoint>> DeleteCurvePoint(int id);
    }
}
