using Mapster;
using Microsoft.AspNetCore.Components;
using WebApiMapsterCodeGen.Json;
using WebApiMapsterCodeGen.Mappers;

namespace WebApiMapsterCodeGen.Services
{
    public class PortfolioRepository:IPortfolioRepository
    {
        private MyContext myContext;
        public readonly IPortfolioMapper portfolioMapper;



        public PortfolioRepository(MyContext _myContext, IPortfolioMapper _portfolioMapper)
        {
            myContext = _myContext;
            portfolioMapper = _portfolioMapper;
        }

        public JsonPortfolio GetPortfolio(int Id)
        {
            var res = myContext.portfolio.Select(portfolioMapper.PortfolioProjection).FirstOrDefault(x => x.Id == Id);
            var jsonPortfolio = res?.Adapt<JsonPortfolio>();
            return jsonPortfolio;
        }

        public IEnumerable<JsonPortfolio> GetPortfolios()
        {
            var res = myContext.portfolio.Select(portfolioMapper.PortfolioProjection);
            var jsonPortfolio = res?.Adapt<IEnumerable<JsonPortfolio>>();
            return jsonPortfolio;
        }
    }
}
