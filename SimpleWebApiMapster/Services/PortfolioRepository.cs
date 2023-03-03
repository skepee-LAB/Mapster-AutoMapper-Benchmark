using Mapster;
using WebApiMapster.Dto;

namespace WebApiMapster.Services
{
    public class PortfolioRepository:IPortfolioRepository
    {
        private MyContext _myContext;

        public PortfolioRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public DtoPortfolio? GetPortfolio(int Id)
        {
            var item = _myContext.portfolio.FirstOrDefault(x => x.Id == Id);
            var dtoPortfolio = item?.Adapt<DtoPortfolio>();
            return dtoPortfolio;
        }

        public IEnumerable<DtoPortfolio> GetPortfolios()
        {
            var item = _myContext.portfolio.ToList();
            var dtoPortfolios = item.Adapt<IEnumerable<DtoPortfolio>>();
            return dtoPortfolios;
        }
    }
}
