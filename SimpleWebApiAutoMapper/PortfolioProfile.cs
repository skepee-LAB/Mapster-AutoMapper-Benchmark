using AutoMapper;
using WebApiAutoMapper.Dto;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper
{
    public class PortfolioProfile: Profile
    {
        public PortfolioProfile()
        {
            CreateMap<portfolio, DtoPortfolio>();
        }
    }
}
