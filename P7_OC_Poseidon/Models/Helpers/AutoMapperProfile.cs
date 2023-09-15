using AutoMapper;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BidList, BidListDto>();
            CreateMap<BidListDto, BidList>()
                .ForMember(dest => dest.BidListId, opt => opt.Ignore());

            CreateMap<CurvePoint, CurvePointDto>();
            CreateMap<CurvePointDto, CurvePoint>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Rating, RatingDto>();
            CreateMap<RatingDto, Rating>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<RuleName, RuleDto>();
            CreateMap<RuleDto, RuleName>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Trade, TradeDto>();
            CreateMap<TradeDto, Trade>()
                .ForMember(dest => dest.TradeId, opt => opt.Ignore());

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
