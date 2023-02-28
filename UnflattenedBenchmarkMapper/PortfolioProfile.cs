using AutoMapper;
using BenchmarkMapper.Domains;
using BenchmarkMapper.Dto;
using BenchmarkMapper.Resolver;

namespace BenchmarkMapper
{
    public class PortfolioProfile: Profile
    {
        public PortfolioProfile()
        {
            CreateMap<PortfolioUnflattened, DtoPortfolioUnflattened>();
            CreateMap<StringPropertiesUnflattened, DtoStringPropertiesUnflattened>();
            CreateMap<IntPropertiesUnflattened, DtoIntPropertiesUnflattened>();
            CreateMap<DecimalPropertiesUnflattened, DtoDecimalPropertiesUnflattened>();
            CreateMap<DateTimePropertiesUnflattened, DtoDateTimePropertiesUnflattened>();
        }
    }
}
