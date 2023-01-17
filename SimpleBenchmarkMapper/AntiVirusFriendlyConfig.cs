using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

namespace SimpleBenchmarkMapper
{
    internal class AntiVirusFriendlyConfig : ManualConfig
    {
        public AntiVirusFriendlyConfig() 
        {
            //AddJob(Job.MediumRun.WithToolchain(InProcessNoEmitToolchain.Instance));
            AddJob(Job.MediumRun.WithToolchain(InProcessToolchain.Instance));

        }
    }
}
