using AutoMapper;
using WebApiAutoMapper.Dto;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper
{
    public class PortfolioProfile: Profile
    {
        public PortfolioProfile()
        {
            CreateMap<Portfolio, DtoPortfolio>();
            CreateMap<StringProperties, DtoStringProperties>();
            CreateMap<IntProperties, DtoIntProperties>();
            CreateMap<DecimalProperties, DtoDecimalProperties>();
            CreateMap<DateTimeProperties, DtoDateTimeProperties>();
        }
    }
}
