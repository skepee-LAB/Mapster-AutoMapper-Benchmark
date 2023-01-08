using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using BenchmarkMapper.Dto;
using BenchmarkMapper.Json;

namespace BenchmarkMapper
{
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class MappingBenchmark
    {
        [Benchmark]
        public DtoPortfolio MapsterAdapt() => MappingSamples.MapsterAdaptSample();

        [Benchmark]
        public JsonPortfolio MapsterCodeGen() => MappingSamples.MapsterCodeGenSample();



    }
}
