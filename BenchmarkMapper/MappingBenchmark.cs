using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkMapper.Dto;
using BenchmarkMapper.Json;

namespace BenchmarkMapper
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MappingBenchmark
    {
        [Benchmark]
        public DtoPortfolio MapsterAdapt() => MappingSamples.MapsterAdaptSample();

        [Benchmark]
        public JsonPortfolio MapsterCodeGen() => MappingSamples.MapsterCodeGenSample();

        [Benchmark]
        public DtoPortfolio AutoMapper() => MappingSamples.AutoMapperSample();
    }
}
