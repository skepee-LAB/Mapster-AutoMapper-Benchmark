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

        public DtoPortfolio GetPortfolio(int portfolioId)
        {
            var dtoPortfolio = new DtoPortfolio();
            var item = _myContext.portfolio.FirstOrDefault(x => x.PortfolioId == portfolioId);
            item.Adapt(dtoPortfolio);
            return dtoPortfolio;
        }

        public void DeletePortfolio(int portfolioId)
        {
            var item = _myContext.portfolio.FirstOrDefault(x => x.PortfolioId == portfolioId);

            if (item != null)
            {
                _myContext.portfolio.Remove(item);
                _myContext.SaveChanges();
            }
        }

        public void InsertPortfolio(portfolio item)
        {
            if (item != null)
            {
                _myContext.portfolio.Add(item);
                _myContext.SaveChanges();
            }
        }

        public void UpdatePortfolio(portfolio item)
        {
            if (item != null)
            {
                _myContext.portfolio.Update(item);
                _myContext.SaveChanges();
            }
        }

        public IEnumerable<DtoPortfolio> GetPortfolios()
        {
            var dtoPortfolios = new List<DtoPortfolio>();
            var item = _myContext.portfolio.ToList();
            item.Adapt(dtoPortfolios);
            return dtoPortfolios;
        }
    }
}
