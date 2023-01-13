// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using FlattenedBenchmarkMapper;

Console.WriteLine("Benchmark AutoMapper");
var summaryAutoMapper = BenchmarkRunner.Run<AutoMapperBenchmarkPortfolioSmall>();


Console.WriteLine("Benchmark Mapster");
//var summaryMapster = BenchmarkRunner.Run<MapsterBenchmark>();


Console.WriteLine("Benchmark Mapster CodeGen");
//var summaryMapsterCodeGen = BenchmarkRunner.Run<MapsterCodeGenBenchmark>();
