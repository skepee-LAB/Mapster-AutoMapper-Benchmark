using Mapster;
using System.Reflection;
//using WebApiMapsterCodeGen.Model;

namespace WebApiMapsterCodeGen
{
    public class MapsterCodeGen : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            config.AdaptTo("Dto[name]", MapType.Map | MapType.MapToTarget | MapType.Projection).ForType<Portfolio>();
            //.ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Sample.CodeGen.Domains");

            //config.AdaptFrom("Dto[name]", MapType.Map).ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Sample.CodeGen.Domains");

            //config.AdaptTwoWays("Dto[name]").ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Sample.CodeGen.Domains");


            config.GenerateMapper("Dto[name]").ForType<Portfolio>();
        }
    }
}
