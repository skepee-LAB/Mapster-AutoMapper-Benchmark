using Mapster;
using System.Text;
using BenchmarkMapper.Dto;
using BenchmarkMapper.Domains;

namespace WebApiMapsterCodeGen
{
    public static class MapsterConfig
    {
        public static void RegisterMapsterConfiguration()
        {
            TypeAdapterConfig<PortfolioMap, DtoPortfolio>
                .NewConfig()
                .Map(dest => dest.DtoId, src => src.Id)
                .Map(dest => dest.DtoCode, src => src.Code)
                .Map(dest => dest.DtoName, src => src.Name)
                .Map(dest => dest.DtoType, src => src.Type)
                .Map(dest => dest.DtoStatus, src => src.Status)
                .Map(dest => dest.GroupStringProperties, src => CalculateStringOperation(new List<string> { src.Prop1, src.Prop2, src.Prop3, src.Prop4, src.Prop5, src.Prop6, src.Prop7, src.Prop8, src.Prop9, src.Prop10, src.Prop11, src.Prop12, src.Prop13, src.Prop14, src.Prop15, src.Prop16, src.Prop17, src.Prop18, src.Prop19, src.Prop20, src.Prop21, src.Prop22, src.Prop23, src.Prop24, src.Prop25, src.Prop26, src.Prop27, src.Prop28, src.Prop29, src.Prop30, src.Prop31, src.Prop32, src.Prop33, src.Prop34, src.Prop35, src.Prop36, src.Prop37, src.Prop38, src.Prop39, src.Prop40, src.Prop41, src.Prop42, src.Prop43, src.Prop44, src.Prop45, src.Prop46, src.Prop47, src.Prop48, src.Prop49, src.Prop50 }))

                .Map(dest => dest.GroupIntProperties, src => CalculateIntOperation(new int[] { src.Prop51, src.Prop52, src.Prop53, src.Prop54, src.Prop55, src.Prop56, src.Prop57, src.Prop58, src.Prop59, src.Prop60, src.Prop61, src.Prop62, src.Prop63, src.Prop64, src.Prop65, src.Prop66, src.Prop67, src.Prop68, src.Prop69, src.Prop71, src.Prop72, src.Prop73, src.Prop74, src.Prop75, src.Prop76, src.Prop77, src.Prop78, src.Prop79, src.Prop80, src.Prop81, src.Prop82, src.Prop83, src.Prop84, src.Prop85, src.Prop86, src.Prop87, src.Prop88, src.Prop89, src.Prop90, src.Prop91, src.Prop92, src.Prop93, src.Prop94, src.Prop95, src.Prop96, src.Prop97, src.Prop98, src.Prop99, src.Prop100 }))

                .Map(dest => dest.GroupDecimalProperties, src => CalculateDecimalOperation(src))

                .Map(dest => dest.GroupDateTimeProperties, src => CalculateDateTimeOperation(new List<DateTime> { src.Prop151, src.Prop152, src.Prop153, src.Prop154, src.Prop155, src.Prop156, src.Prop157, src.Prop158, src.Prop159, src.Prop160, src.Prop161, src.Prop162, src.Prop163, src.Prop164, src.Prop165, src.Prop166, src.Prop167, src.Prop168, src.Prop169, src.Prop170, src.Prop171, src.Prop172, src.Prop173, src.Prop174, src.Prop175, src.Prop176, src.Prop177, src.Prop178, src.Prop179, src.Prop180, src.Prop181, src.Prop182, src.Prop183, src.Prop184, src.Prop185, src.Prop186, src.Prop187, src.Prop188, src.Prop189, src.Prop190, src.Prop191, src.Prop192, src.Prop193, src.Prop194, src.Prop195, src.Prop196, src.Prop197, src.Prop198, src.Prop199, src.Prop190, src.Prop200 }));
        }

        private static StringProperties CalculateStringOperation(List<string> listStrings)
        {
            var res = new StringBuilder();
            foreach (string item in listStrings)
                res.Append(item);

            return new StringProperties
            {
                value = res.ToString(),
                length = res.Length,
                numWords = listStrings.Count
            };
        }

        private static DateTimeProperties CalculateDateTimeOperation(List<DateTime> dateTimeSrcValues)
        {
            return new DateTimeProperties
            {
                minValue = dateTimeSrcValues.Min(),
                maxValue = dateTimeSrcValues.Max()
            };
        }

        private static IntProperties CalculateIntOperation(int[] srcIntValues)
        {
            return new IntProperties
            {
                minValue = srcIntValues.Min(),
                maxValue = srcIntValues.Max(),
                avgValue = srcIntValues.Average()
            };
        }

        private static DecimalProperties CalculateDecimalOperation(PortfolioMap src)
        {
            return new DecimalProperties {
                minValue= new decimal[] { src.Prop101, src.Prop102, src.Prop103, src.Prop104, src.Prop105, src.Prop106, src.Prop107, src.Prop108, src.Prop109, src.Prop110 }.Min(),
                maxValue = new decimal[] { src.Prop111, src.Prop112, src.Prop113, src.Prop114, src.Prop115, src.Prop116, src.Prop117, src.Prop118, src.Prop119, src.Prop120 }.Max(),
                avgValue = new decimal[] { src.Prop121, src.Prop122, src.Prop123, src.Prop124, src.Prop125, src.Prop126, src.Prop127, src.Prop128, src.Prop129, src.Prop130, src.Prop131, src.Prop132, src.Prop133, src.Prop134, src.Prop135, src.Prop136, src.Prop137, src.Prop138, src.Prop139, src.Prop140, src.Prop141, src.Prop142, src.Prop143, src.Prop144, src.Prop145, src.Prop146, src.Prop147, src.Prop148, src.Prop149, src.Prop150 }.Average()
            };
        }
    }
}
