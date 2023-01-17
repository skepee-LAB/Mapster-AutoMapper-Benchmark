// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkMapper;

Console.WriteLine("Benchmark AutoMapper Portfolio Small");
//var summaryAutoMapperSmall = BenchmarkRunner.Run<AutoMapperBenchmarkSmall>();

Console.WriteLine("Benchmark AutoMapper Portfolio Big");
//var summaryAutoMapperBig = BenchmarkRunner.Run<AutoMapperBenchmarkBig>();

Console.WriteLine("Benchmark Mapster Portfolio Small");
//var summaryMapsterSmall = BenchmarkRunner.Run<MapsterBenchmarkSmall>();

Console.WriteLine("Benchmark Mapster Portfolio Big");
var summaryMapsterBig = BenchmarkRunner.Run<MapsterBenchmarkBig>();

Console.WriteLine("Benchmark Mapster CodeGen Small");
//var summaryMapsterCodeGenSmall = BenchmarkRunner.Run<MapsterCodeGenBenchmarkSmall>();

Console.WriteLine("Benchmark Mapster CodeGen Big");
var summaryMapsterCodeGenBig = BenchmarkRunner.Run<MapsterCodeGenBenchmarkBig>();
