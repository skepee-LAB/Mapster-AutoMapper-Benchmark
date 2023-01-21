using AutoMapper;
using SimpleBenchmarkMapper.Domains;
using SimpleBenchmarkMapper.Dto;

namespace SimpleBenchmarkMapper
{
    public class PortfolioProfileSmall: Profile
    {
        public PortfolioProfileSmall()
        {
            CreateMap<PortfolioSmall, DtoPortfolioSmallWithAdapter>()
                .ForMember(dest => dest.DtoId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DtoCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.DtoName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DtoType, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.DtoStatus, opt => opt.MapFrom(src => src.Status));

            CreateMap<PortfolioSmall, DtoPortfolioSmallWithAdapterRecord>()
                .ForMember(dest => dest.DtoId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DtoCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.DtoName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DtoType, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.DtoStatus, opt => opt.MapFrom(src => src.Status));

        }
    }
}
