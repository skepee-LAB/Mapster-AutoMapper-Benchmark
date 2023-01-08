// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkMapper;
using System.Text;

Console.WriteLine("Hello, World!");
//var summary = BenchmarkRunner.Run<MemoryBenchmarkerDemo>();
var summary = BenchmarkRunner.Run<MappingBenchmark>();


//[MemoryDiagnoser]
//public class MemoryBenchmarkerDemo
//{
//    int NumberOfItems = 100000;
//    [Benchmark]
//    public string ConcatStringsUsingStringBuilder()
//    {
//        var sb = new StringBuilder();
//        for (int i = 0; i < NumberOfItems; i++)
//        {
//            sb.Append("Hello World!" + i);
//        }
//        return sb.ToString();
//    }
//    [Benchmark]
//    public string ConcatStringsUsingGenericList()
//    {
//        var list = new List<string>(NumberOfItems);
//        for (int i = 0; i < NumberOfItems; i++)
//        {
//            list.Add("Hello World!" + i);
//        }
//        return list.ToString();
//    }
//}