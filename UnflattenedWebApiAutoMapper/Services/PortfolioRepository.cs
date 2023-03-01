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

        public DtoPortfolioFull GetPortfolio(int Id)
        {
            return new DtoPortfolioFull
            {
                portfolio = _mapper.Map<DtoPortfolio>(_myContext.portfolio.FirstOrDefault(x => x.PortfolioId == Id)),
                dateTimeProperties= _mapper.Map<DtoDateTimeProperties>(_myContext.dateTimeProperties.FirstOrDefault(x => x.Id == Id)),
                stringProperties = _mapper.Map<DtoStringProperties>(_myContext.stringProperties.FirstOrDefault(x => x.Id == Id)),
                decimalProperties = _mapper.Map<DtoDecimalProperties>(_myContext.decimalProperties.FirstOrDefault(x => x.Id == Id)),
                intProperties = _mapper.Map<DtoIntProperties>(_myContext.intProperties.FirstOrDefault(x => x.Id == Id)),
            };
        }

        public IEnumerable<DtoPortfolioFull> GetPortfolios()
        {
            var res = new List<DtoPortfolioFull>();

            var portfolio = _mapper.Map<List<DtoPortfolio>>(_myContext.portfolio);
            var dateTimeProperties = _mapper.Map<List<DtoDateTimeProperties>>(_myContext.dateTimeProperties);
            var stringProperties = _mapper.Map<List<DtoStringProperties>>(_myContext.stringProperties);
            var decimalProperties = _mapper.Map<List<DtoDecimalProperties>>(_myContext.decimalProperties);
            var intProperties = _mapper.Map<List<DtoIntProperties>>(_myContext.intProperties);

            foreach (DtoPortfolio p in portfolio)
            {
                res.Add(new DtoPortfolioFull()
                {
                    portfolio = p,
                    dateTimeProperties = dateTimeProperties.FirstOrDefault(x => x.Id == p.PortfolioId),
                    stringProperties = stringProperties.FirstOrDefault(x => x.Id == p.PortfolioId),
                    decimalProperties = decimalProperties.FirstOrDefault(x => x.Id == p.PortfolioId),
                    intProperties = intProperties.FirstOrDefault(x => x.Id == p.PortfolioId),
                });
            }

            return res;
        }
    }
}
