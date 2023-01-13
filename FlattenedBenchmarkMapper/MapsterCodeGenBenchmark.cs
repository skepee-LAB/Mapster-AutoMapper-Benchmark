using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using FlattenedBenchmarkMapper.Domains;
using Mapster;

namespace FlattenedBenchmarkMapper
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MapsterCodeGenBenchmark
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
        public void FlattenedMapsterCodeGen()
        {
            foreach (var p in portfolios)
            {
                var pDto = p.Adapt<PortfolioMap>();
            }
        }
    }
}
