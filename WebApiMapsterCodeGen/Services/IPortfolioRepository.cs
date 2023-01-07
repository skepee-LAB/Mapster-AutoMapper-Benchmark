using System.Collections.Generic;
//using WebApiMapsterCodeGen.Dto;
using WebApiMapsterCodeGen.Model;

namespace WebApiMapsterCodeGen.Services
{
    public interface IPortfolioRepository
    {
        IEnumerable<DtoPortfolio> GetPortfolios();
        DtoPortfolio GetPortfolio(int portfolioId);
    }
}
