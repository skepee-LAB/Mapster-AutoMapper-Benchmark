using Mapster;
using Microsoft.AspNetCore.Components;
using WebApiMapster.Dto;
using WebApiMapster.Model;

namespace WebApiMapster.Services
{
    public class PortfolioRepository:IPortfolioRepository
    {
        private MyContext _myContext;

        public PortfolioRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public DtoPortfolio GetPortfolio(int Id)
        {
            //var dtoPortfolio = new DtoPortfolio();
            var item = _myContext.portfolio.FirstOrDefault(x => x.Id == Id);
            //item.Adapt(dtoPortfolio);
            var dtoPortfolio = item.Adapt<DtoPortfolio>();
            return dtoPortfolio;
        
        }

        public IEnumerable<DtoPortfolio> GetPortfolios()
        {
            //var dtoPortfolios = new List<DtoPortfolio>();
            var item = _myContext.portfolio.ToList();
            //item.Adapt(dtoPortfolios);
            var dtoPortfolios = item.Adapt<IEnumerable<DtoPortfolio>>();
            return dtoPortfolios;
        }
    }
}
