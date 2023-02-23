using AutoMapper;
using BenchmarkMapper.Domains;
using BenchmarkMapper.Dto;
using BenchmarkMapper.Resolver;

namespace BenchmarkMapper
{
    public class PortfolioProfile: Profile
    {
        public PortfolioProfile()
        {
            CreateMap<PortfolioUnflattened, DtoPortfolioUnflattened>();
            CreateMap<StringPropertiesUnflattened, DtoStringPropertiesUnflattened>();
            CreateMap<IntPropertiesUnflattened, DtoIntPropertiesUnflattened>();
            CreateMap<DecimalPropertiesUnflattened, DtoDecimalPropertiesUnflattened>();
            CreateMap<DateTimePropertiesUnflattened, DtoDateTimePropertiesUnflattened>();

            //CreateMap<Portfolio, DtoPortfolio>()
            //    .ForMember(dest => dest.DtoId, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(dest => dest.DtoCode, opt => opt.MapFrom(src => src.Code))
            //    .ForMember(dest => dest.DtoName, opt => opt.MapFrom(src => src.Name))
            //    .ForMember(dest => dest.DtoType, opt => opt.MapFrom(src => src.Type))
            //    .ForMember(dest => dest.DtoStatus, opt => opt.MapFrom(src => src.Status))
            //    .ForMember(dest => dest.GroupDecimalProperties, src => src.MapFrom<PortfolioResolver>())
            //    .ForMember(dest => dest.GroupStringProperties, src => src.MapFrom<PortfolioResolver>())
            //    .ForMember(dest => dest.GroupIntProperties, src => src.MapFrom<PortfolioResolver>())
            //    .ForMember(dest => dest.GroupDateTimeProperties, src => src.MapFrom<PortfolioResolver>());
        }
    }
}
