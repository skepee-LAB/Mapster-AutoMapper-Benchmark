// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkMapper;

Console.WriteLine("Benchmark Mapster Portfolio");
var summaryMapster = BenchmarkRunner.Run<BenchmarkUnflattened>();

Console.WriteLine("Benchmark Mapster Elaboration Wrong Performance");
var summaryMapsterWrong = BenchmarkRunner.Run<BenchmarkWrongPerformance>();

