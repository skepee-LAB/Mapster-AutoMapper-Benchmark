using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using FlattenedBenchmarkMapper.Domains;
using FlattenedBenchmarkMapper.Dto;

namespace FlattenedBenchmarkMapper
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class AutoMapperBenchmarkPortfolioSmall
    {
        [Params(10, 100)]
        public int numElements { get; set; }
        private IEnumerable<PortfolioSmall> portfolios { get; set; }
        private static readonly IMapper automapper = new Mapper(new MapperConfiguration(z => z.AddProfile(new AutomapperProfile())));

        public PortfolioSmall PortfolioSample()
        {
            return new PortfolioSmall()
            {
                Id = 1,
                Code = "ABCD1",
                Name = "NameABCD1",
                Type = "Type1",
                Status = "Status2"
            };
        }

        [GlobalSetup]
        public void Init()
        {
            portfolios = Enumerable.Range(1, numElements).Select(x => PortfolioSample());
        }

        internal class AutomapperProfile : Profile
        {
            public AutomapperProfile()
            {
                CreateMap<PortfolioSmall, DtoPortfolioSmallWithAdapter>();
            }
        }

        [Benchmark]
        public void FlattenedAutoMapperPortfolioSmallWithAdapter()
        {
            foreach (var p in portfolios)
            {
                var pDto = automapper.Map<DtoPortfolioSmallWithAdapter>(p);
            }
        }

        [Benchmark]
        public void FlattenedAutoMapperPortfolioSmallNoAdapter()
        {
            foreach (var p in portfolios)
            {
                var pDto = automapper.Map<DtoPortfolioSmallNoAdapter>(p);
            }
        }
    }
}
