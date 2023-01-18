// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkMapper;

Console.WriteLine("Benchmark AutoMapper Portfolio");
var summaryAutoMapper = BenchmarkRunner.Run<AutoMapperBenchmark>();


Console.WriteLine("Benchmark Mapster Portfolio");
var summaryMapster = BenchmarkRunner.Run<MapsterBenchmark>();

Console.WriteLine("Benchmark Mapster CodeGen Portfolio");
var summaryMapsterCodeGen = BenchmarkRunner.Run<MapsterCodeGenBenchmark>();

