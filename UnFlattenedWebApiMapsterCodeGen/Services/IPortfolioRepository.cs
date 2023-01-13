using WebApiMapsterCodeGen.Json;

namespace WebApiMapsterCodeGen.Services
{
    public interface IPortfolioRepository
    {
        IEnumerable<JsonPortfolio> GetPortfolios();
        JsonPortfolio GetPortfolio(int portfolioId);
    }
}
