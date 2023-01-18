using AutoMapper;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SimpleBenchmarkMapper.Domains;
using SimpleBenchmarkMapper.Dto;

namespace SimpleBenchmarkMapper
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class AutoMapperBenchmarkSmall
    {
        [Params(10, 100)]
        public int numElements { get; set; }
        private IEnumerable<PortfolioSmall> portfoliosSmall { get; set; }
        private static readonly IMapper automapperSmall = new Mapper(new MapperConfiguration(z => z.AddProfile(new AutomapperProfileSmallPortfolio())));
        private static readonly IMapper automapperProfileSmall = new Mapper(new MapperConfiguration(z => z.AddProfile(new PortfolioProfileSmall())));


        public PortfolioSmall PortfolioSampleSmall()
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
            portfoliosSmall = Enumerable.Range(1, numElements).Select(x => PortfolioSampleSmall());
        }

        internal class AutomapperProfileSmallPortfolio : Profile
        {
            public AutomapperProfileSmallPortfolio()
            {
                CreateMap<PortfolioSmall, DtoPortfolioSmallNoAdapter>();
            }
        }

        [Benchmark]
        public void AutoMapperPortfolioSmallNoAdapter()
        {
            foreach (var p in portfoliosSmall)
            {
                var pDto = automapperSmall.Map<DtoPortfolioSmallNoAdapter>(p);
            }
        }

        [Benchmark]
        public void AutoMapperPortfolioSmallWithAdapter()
        {
            foreach (var p in portfoliosSmall)
            {
                var pDto = automapperProfileSmall.Map<DtoPortfolioSmallWithAdapter>(p);
            }
        }
    }
}
