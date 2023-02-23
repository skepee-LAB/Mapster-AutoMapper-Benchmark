using Mapster;
using WebApiMapsterCodeGen.Domains;
using WebApiMapsterCodeGen.Json;

namespace WebApiMapsterCodeGen.Services
{
    public class PortfolioRepository:IPortfolioRepository
    {
        private MyContext myContext;

        public PortfolioRepository(MyContext _myContext)
        {
            myContext = _myContext;
        }

        public JsonPortfolio GetPortfolio(int Id)
        {
            var res = myContext.portfolio.FirstOrDefault(x => x.Id == Id);
            var res_map = res?.Adapt<PortfolioMap>();
            var jsonPortfolio = res_map?.Adapt<JsonPortfolio>();
            return jsonPortfolio;
        }

        public IEnumerable<JsonPortfolio> GetPortfolios()
        {
            var res = myContext.portfolio.ToList();
            var jsonPortfolio = res?.Adapt<IEnumerable<JsonPortfolio>>();
            return jsonPortfolio;
        }
    }
}
