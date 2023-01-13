// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkMapper;

Console.WriteLine("Benchmark");
var summary = BenchmarkRunner.Run<MappingBenchmark>();
