using AutoMapper;
using AutoMapper.QueryableExtensions;
using WebApiAutoMapper.Dto;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper.Services
{
    public class PortfolioRepository:IPortfolioRepository
    {
        private MyContext _myContext;
        private IMapper _mapper;

        public PortfolioRepository(MyContext myContext, IMapper mapper)
        {
            _myContext = myContext;
            _mapper = mapper;
        }

        public DtoPortfolio GetPortfolio(int Id)
        {
            var item = _myContext.portfolio.FirstOrDefault(x => x.Id == Id);
            return _mapper.Map<DtoPortfolio>(item);
        }

        public IEnumerable<DtoPortfolio> GetPortfolios()
        {
            var item = _myContext.portfolio.ToList();
            return _mapper.Map<IEnumerable<DtoPortfolio>>(item);
        }
    }
}
