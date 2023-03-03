using Mapster;
using WebApiMapsterCodeGen.Domains;

namespace WebApiMapsterCodeGen.Services
{
    public class PortfolioRepository:IPortfolioRepository
    {
        private MyContext myContext;

        public PortfolioRepository(MyContext _myContext)
        {
            myContext = _myContext;
        }

        public PortfolioMap GetPortfolio(int Id)
        {
            var res = myContext.portfolio.FirstOrDefault(x => x.Id == Id);
            return res.Adapt<PortfolioMap>();
        }

        public IEnumerable<PortfolioMap> GetPortfolios()
        {
            var res = myContext.portfolio.ToList();
            return res.Adapt<IEnumerable<PortfolioMap>>();
        }
    }
}
