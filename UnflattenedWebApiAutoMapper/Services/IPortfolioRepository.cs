using System.Collections.Generic;
using WebApiAutoMapper.Dto;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper.Services
{
    public interface IPortfolioRepository
    {
        IEnumerable<DtoPortfolioFull> GetPortfolios();
        DtoPortfolioFull GetPortfolio(int portfolioId);
    }
}
