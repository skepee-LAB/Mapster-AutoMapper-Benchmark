using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SimpleBenchmarkMapper.Domains;
using SimpleBenchmarkMapper.Dto;
using Mapster;

namespace SimpleBenchmarkMapper
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MapsterBenchmarkSmall
    {
        [Params(10, 100, 1000)]
        public int numElements { get; set; }
        private IEnumerable<PortfolioSmall> portfolios;

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

        [Benchmark]
        public void MapsterPortfolioSmallNoAdapter()
        {
            foreach (var p in portfolios)
            {
                var pDto = p.Adapt<DtoPortfolioSmallNoAdapter>();
            }
        }

        [Benchmark]
        public void MapsterPortfolioSmallWithAdapter()
        {
            foreach (var p in portfolios)
            {
                var pDto = p.Adapt<DtoPortfolioSmallWithAdapter>();
            }
        }
    }
}
