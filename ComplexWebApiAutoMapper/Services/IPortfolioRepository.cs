using System.Collections.Generic;
using WebApiAutoMapper.Dto;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper.Services
{
    public interface IPortfolioRepository
    {
        IEnumerable<DtoPortfolio> GetPortfolios();
        DtoPortfolio GetPortfolio(int portfolioId);
    }
}
