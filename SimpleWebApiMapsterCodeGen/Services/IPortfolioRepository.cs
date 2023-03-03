using WebApiMapsterCodeGen.Domains;

namespace WebApiMapsterCodeGen.Services
{
    public interface IPortfolioRepository
    {
        IEnumerable<PortfolioMap> GetPortfolios();
        PortfolioMap GetPortfolio(int portfolioId);
    }
}
