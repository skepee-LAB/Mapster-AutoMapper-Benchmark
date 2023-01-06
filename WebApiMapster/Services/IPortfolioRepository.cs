using System.Collections.Generic;
using WebApiMapster.Dto;
using WebApiMapster.Model;

namespace WebApiMapster.Services
{
    public interface IPortfolioRepository
    {
        IEnumerable<DtoPortfolio> GetPortfolios();
        DtoPortfolio GetPortfolio(int portfolioId);
    }
}
