using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using FlattenedBenchmarkMapper.Domains;
using FlattenedBenchmarkMapper.Dto;
using Mapster;

namespace FlattenedBenchmarkMapper
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MapsterBenchmark
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
        public void FlattenedMapster()
        {
            foreach (var p in portfolios)
            {
                //var pDto = p.Adapt<DtoPortfolio>(GetTypeAdapterConfig_NoCodeGen());
               // var pDto = p.Adapt<DtoPortfolio>();
            }
        }
        //public static TypeAdapterConfig GetTypeAdapterConfig_NoCodeGen()
        //{
        //    var config = new TypeAdapterConfig();
        //    config.NewConfig<Portfolio, DtoPortfolio>()
        //        .Map(dest => dest.DtoId, src => src.Id)
        //        .Map(dest => dest.DtoCode, src => src.Code)
        //        .Map(dest => dest.DtoName, src => src.Name)
        //        .Map(dest => dest.DtoType, src => src.Type)
        //        .Map(dest => dest.DtoStatus, src => src.Status);
        //    return config;
        //}
    }
}
