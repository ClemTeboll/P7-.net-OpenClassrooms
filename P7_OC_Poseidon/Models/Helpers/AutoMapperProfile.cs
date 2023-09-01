using AutoMapper;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BidList, BidListDto>();
            CreateMap<BidListDto, BidList>();

            CreateMap<CurvePoint, CurvePointDto>();
            CreateMap<CurvePointDto, CurvePoint>();
        }
    }
}
