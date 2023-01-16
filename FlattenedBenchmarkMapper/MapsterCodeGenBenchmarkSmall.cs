using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using FlattenedBenchmarkMapper.Domains;
using Mapster;

namespace FlattenedBenchmarkMapper
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MapsterCodeGenBenchmarkSmall
    {
        [Params(10, 100)]
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
        public void FlattenedMapsterCodeGenPortfolioSmallNoAdapter()
        {
            foreach (var p in portfolios)
            {
                var pDto = p.Adapt<PortfolioSmallMap>();
            }
        }

        [Benchmark]
        public void FlattenedMapsterCodeGenPortfolioSmallWithAdapter()
        {
            foreach (var p in portfolios)
            {
                var pDto = p.Adapt<PortfolioSmallMap>();
            }
        }
    }
}
