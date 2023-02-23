using BenchmarkMapper.Domains;
using BenchmarkMapper.Dto;
using Mapster;

namespace BenchmarkMapper
{
    internal class MapsterCodeGenConfig: ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            config.AdaptTo("[name]Map")
                .ForType<PortfolioUnflattened>()
                .ForType<StringPropertiesUnflattened>()
                .ForType<IntPropertiesUnflattened>()
                .ForType<DecimalPropertiesUnflattened>()
                .ForType<DateTimePropertiesUnflattened>();

            config.GenerateMapper("[name]Mapper")
                .ForType<PortfolioUnflattened>()
                .ForType<IntPropertiesUnflattened>()
                .ForType<DecimalPropertiesUnflattened>()
                .ForType<DateTimePropertiesUnflattened>()
                .ForType<StringPropertiesUnflattened>();
        }
    }
}
