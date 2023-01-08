using BenchmarkMapper.Domains;
using BenchmarkMapper.Dto;
using BenchmarkMapper.Json;
using Mapster;
using System.Text;

namespace BenchmarkMapper
{
    public static class MappingSamples
    {
        internal static DtoPortfolio MapsterAdaptSample()
        {
            return PortfolioSample().Adapt<DtoPortfolio>(GetTypeAdapterConfig_NoCodeGen());
        }

        public static Portfolio PortfolioSample()
        {
            return new Portfolio()
            {
                Id = 1,
                Code = "ABCD1",
                Name = "NameABCD1",
                Type = "Type1",
                Status = "Status2",
                Prop1 = "Prop1_1",
                Prop2 = "Prop2_1",
                Prop3 = "Prop3_1",
                Prop4 = "Prop4_1",
                Prop5 = "Prop5_1",
                Prop6 = "Prop6_1",
                Prop7 = "Prop7_1",
                Prop8 = "Prop8_1",
                Prop9 = "Prop9_1",
                Prop10 = "Prop10_1",
                Prop11 = "Prop11_1",
                Prop12 = "Prop12_1",
                Prop13 = "Prop13_1",
                Prop14 = "Prop14_1",
                Prop15 = "Prop15_1",
                Prop16 = "Prop16_1",
                Prop17 = "Prop17_1",
                Prop18 = "Prop18_1",
                Prop19 = "Prop19_1",
                Prop20 = "Prop20_1",
                Prop21 = "Prop21_1",
                Prop22 = "Prop22_1",
                Prop23 = "Prop23_1",
                Prop24 = "Prop24_1",
                Prop25 = "Prop25_1",
                Prop26 = "Prop26_1",
                Prop27 = "Prop27_1",
                Prop28 = "Prop28_1",
                Prop29 = "Prop29_1",
                Prop30 = "Prop30_1",
                Prop31 = "Prop31_1",
                Prop32 = "Prop32_1",
                Prop33 = "Prop33_1",
                Prop34 = "Prop34_1",
                Prop35 = "Prop35_1",
                Prop36 = "Prop36_1",
                Prop37 = "Prop37_1",
                Prop38 = "Prop38_1",
                Prop39 = "Prop39_1",
                Prop40 = "Prop40_1",
                Prop41 = "Prop41_1",
                Prop42 = "Prop42_1",
                Prop43 = "Prop43_1",
                Prop44 = "Prop44_1",
                Prop45 = "Prop45_1",
                Prop46 = "Prop46_1",
                Prop47 = "Prop47_1",
                Prop48 = "Prop48_1",
                Prop49 = "Prop49_1",
                Prop50 = "Prop50_1",
                Prop51 = 52,
                Prop52 = 53,
                Prop53 = 54,
                Prop54 = 55,
                Prop55 = 56,
                Prop56 = 57,
                Prop57 = 58,
                Prop58 = 59,
                Prop59 = 60,
                Prop60 = 61,
                Prop61 = 62,
                Prop62 = 63,
                Prop63 = 64,
                Prop64 = 65,
                Prop65 = 66,
                Prop66 = 67,
                Prop67 = 68,
                Prop68 = 69,
                Prop69 = 70,
                Prop70 = 71,
                Prop71 = 72,
                Prop72 = 73,
                Prop73 = 74,
                Prop74 = 75,
                Prop75 = 76,
                Prop76 = 77,
                Prop77 = 78,
                Prop78 = 79,
                Prop79 = 80,
                Prop80 = 81,
                Prop81 = 82,
                Prop82 = 83,
                Prop83 = 84,
                Prop84 = 85,
                Prop85 = 86,
                Prop86 = 87,
                Prop87 = 88,
                Prop88 = 89,
                Prop89 = 90,
                Prop90 = 91,
                Prop91 = 92,
                Prop92 = 93,
                Prop93 = 94,
                Prop94 = 95,
                Prop95 = 96,
                Prop96 = 97,
                Prop97 = 98,
                Prop98 = 99,
                Prop99 = 100,
                Prop100 = 101,
                Prop101 = 1010,
                Prop102 = 1020,
                Prop103 = 1030,
                Prop104 = 1040,
                Prop105 = 1050,
                Prop106 = 1060,
                Prop107 = 1070,
                Prop108 = 1080,
                Prop109 = 1090,
                Prop110 = 1100,
                Prop111 = 1110,
                Prop112 = 1120,
                Prop113 = 1130,
                Prop114 = 1140,
                Prop115 = 1150,
                Prop116 = 1160,
                Prop117 = 1170,
                Prop118 = 1180,
                Prop119 = 1190,
                Prop120 = 1200,
                Prop121 = 1210,
                Prop122 = 1220,
                Prop123 = 1230,
                Prop124 = 1240,
                Prop125 = 1250,
                Prop126 = 1260,
                Prop127 = 1270,
                Prop128 = 1280,
                Prop129 = 1290,
                Prop130 = 1300,
                Prop131 = 1310,
                Prop132 = 1320,
                Prop133 = 1330,
                Prop134 = 1340,
                Prop135 = 1350,
                Prop136 = 1360,
                Prop137 = 1370,
                Prop138 = 1380,
                Prop139 = 1390,
                Prop140 = 1400,
                Prop141 = 1410,
                Prop142 = 1420,
                Prop143 = 1430,
                Prop144 = 1440,
                Prop145 = 1450,
                Prop146 = 1460,
                Prop147 = 1470,
                Prop148 = 1480,
                Prop149 = 1490,
                Prop150 = 1500,
                Prop151 = DateTime.Parse("03/06/2023 16:47"),
                Prop152 = DateTime.Parse("04/06/2023 16:47"),
                Prop153 = DateTime.Parse("05/06/2023 16:47"),
                Prop154 = DateTime.Parse("06/06/2023 16:47"),
                Prop155 = DateTime.Parse("07/06/2023 16:47"),
                Prop156 = DateTime.Parse("08/06/2023 16:47"),
                Prop157 = DateTime.Parse("09/06/2023 16:47"),
                Prop158 = DateTime.Parse("10/06/2023 16:47"),
                Prop159 = DateTime.Parse("11/06/2023 16:47"),
                Prop160 = DateTime.Parse("12/06/2023 16:47"),
                Prop161 = DateTime.Parse("13/06/2023 16:47"),
                Prop162 = DateTime.Parse("14/06/2023 16:47"),
                Prop163 = DateTime.Parse("15/06/2023 16:47"),
                Prop164 = DateTime.Parse("16/06/2023 16:47"),
                Prop165 = DateTime.Parse("17/06/2023 16:47"),
                Prop166 = DateTime.Parse("18/06/2023 16:47"),
                Prop167 = DateTime.Parse("19/06/2023 16:47"),
                Prop168 = DateTime.Parse("20/06/2023 16:47"),
                Prop169 = DateTime.Parse("21/06/2023 16:47"),
                Prop170 = DateTime.Parse("22/06/2023 16:47"),
                Prop171 = DateTime.Parse("23/06/2023 16:47"),
                Prop172 = DateTime.Parse("24/06/2023 16:47"),
                Prop173 = DateTime.Parse("25/06/2023 16:47"),
                Prop174 = DateTime.Parse("26/06/2023 16:47"),
                Prop175 = DateTime.Parse("27/06/2023 16:47"),
                Prop176 = DateTime.Parse("28/06/2023 16:47"),
                Prop177 = DateTime.Parse("29/06/2023 16:47"),
                Prop178 = DateTime.Parse("30/06/2023 16:47"),
                Prop179 = DateTime.Parse("01/07/2023 16:47"),
                Prop180 = DateTime.Parse("02/07/2023 16:47"),
                Prop181 = DateTime.Parse("03/07/2023 16:47"),
                Prop182 = DateTime.Parse("04/07/2023 16:47"),
                Prop183 = DateTime.Parse("05/07/2023 16:47"),
                Prop184 = DateTime.Parse("06/07/2023 16:47"),
                Prop185 = DateTime.Parse("07/07/2023 16:47"),
                Prop186 = DateTime.Parse("08/07/2023 16:47"),
                Prop187 = DateTime.Parse("09/07/2023 16:47"),
                Prop188 = DateTime.Parse("10/07/2023 16:47"),
                Prop189 = DateTime.Parse("11/07/2023 16:47"),
                Prop190 = DateTime.Parse("12/07/2023 16:47"),
                Prop191 = DateTime.Parse("13/07/2023 16:47"),
                Prop192 = DateTime.Parse("14/07/2023 16:47"),
                Prop193 = DateTime.Parse("15/07/2023 16:47"),
                Prop194 = DateTime.Parse("16/07/2023 16:47"),
                Prop195 = DateTime.Parse("17/07/2023 16:47"),
                Prop196 = DateTime.Parse("18/07/2023 16:47"),
                Prop197 = DateTime.Parse("19/07/2023 16:47"),
                Prop198 = DateTime.Parse("20/07/2023 16:47"),
                Prop199 = DateTime.Parse("21/07/2023 16:47"),
                Prop200 = DateTime.Parse("22/07/2023 16:47")
            };
        }


        public static TypeAdapterConfig GetTypeAdapterConfig_NoCodeGen()
        { 
            var config = new TypeAdapterConfig();
            config.NewConfig<Portfolio, DtoPortfolio>()
                .Map(dest => dest.DtoId, src => src.Id)
                .Map(dest => dest.DtoCode, src => src.Code)
                .Map(dest => dest.DtoName, src => src.Name)
                .Map(dest => dest.DtoType, src => src.Type)
                .Map(dest => dest.DtoStatus, src => src.Status)
                .Map(dest => dest.GroupStringProperties, src => CalculateStringOperation(new List<string> { src.Prop1, src.Prop2, src.Prop3, src.Prop4, src.Prop5, src.Prop6, src.Prop7, src.Prop8, src.Prop9, src.Prop10, src.Prop11, src.Prop12, src.Prop13, src.Prop14, src.Prop15, src.Prop16, src.Prop17, src.Prop18, src.Prop19, src.Prop20, src.Prop21, src.Prop22, src.Prop23, src.Prop24, src.Prop25, src.Prop26, src.Prop27, src.Prop28, src.Prop29, src.Prop30, src.Prop31, src.Prop32, src.Prop33, src.Prop34, src.Prop35, src.Prop36, src.Prop37, src.Prop38, src.Prop39, src.Prop40, src.Prop41, src.Prop42, src.Prop43, src.Prop44, src.Prop45, src.Prop46, src.Prop47, src.Prop48, src.Prop49, src.Prop50 }))

                .Map(dest => dest.GroupIntProperties, src => CalculateIntOperation(new int[] { src.Prop51, src.Prop52, src.Prop53, src.Prop54, src.Prop55, src.Prop56, src.Prop57, src.Prop58, src.Prop59, src.Prop60, src.Prop61, src.Prop62, src.Prop63, src.Prop64, src.Prop65, src.Prop66, src.Prop67, src.Prop68, src.Prop69, src.Prop71, src.Prop72, src.Prop73, src.Prop74, src.Prop75, src.Prop76, src.Prop77, src.Prop78, src.Prop79, src.Prop80, src.Prop81, src.Prop82, src.Prop83, src.Prop84, src.Prop85, src.Prop86, src.Prop87, src.Prop88, src.Prop89, src.Prop90, src.Prop91, src.Prop92, src.Prop93, src.Prop94, src.Prop95, src.Prop96, src.Prop97, src.Prop98, src.Prop99, src.Prop100 }))

                .Map(dest => dest.GroupDecimalProperties, src => CalculateDecimalOperation(src))

                .Map(dest => dest.GroupDateTimeProperties, src => CalculateDateTimeOperation(new List<DateTime> { src.Prop151, src.Prop152, src.Prop153, src.Prop154, src.Prop155, src.Prop156, src.Prop157, src.Prop158, src.Prop159, src.Prop160, src.Prop161, src.Prop162, src.Prop163, src.Prop164, src.Prop165, src.Prop166, src.Prop167, src.Prop168, src.Prop169, src.Prop170, src.Prop171, src.Prop172, src.Prop173, src.Prop174, src.Prop175, src.Prop176, src.Prop177, src.Prop178, src.Prop179, src.Prop180, src.Prop181, src.Prop182, src.Prop183, src.Prop184, src.Prop185, src.Prop186, src.Prop187, src.Prop188, src.Prop189, src.Prop190, src.Prop191, src.Prop192, src.Prop193, src.Prop194, src.Prop195, src.Prop196, src.Prop197, src.Prop198, src.Prop199, src.Prop190, src.Prop200 }));
            return config;
        }

        public static TypeAdapterConfig GetTypeAdapterConfig_CodeGen()
        {
            var config = new TypeAdapterConfig();
            config.NewConfig<PortfolioMap, JsonPortfolio>()
                .Map(dest => dest.DtoId, src => src.Id)
                .Map(dest => dest.DtoCode, src => src.Code)
                .Map(dest => dest.DtoName, src => src.Name)
                .Map(dest => dest.DtoType, src => src.Type)
                .Map(dest => dest.DtoStatus, src => src.Status)
                .Map(dest => dest.GroupStringProperties, src => CalculateStringOperation(new List<string> { src.Prop1, src.Prop2, src.Prop3, src.Prop4, src.Prop5, src.Prop6, src.Prop7, src.Prop8, src.Prop9, src.Prop10, src.Prop11, src.Prop12, src.Prop13, src.Prop14, src.Prop15, src.Prop16, src.Prop17, src.Prop18, src.Prop19, src.Prop20, src.Prop21, src.Prop22, src.Prop23, src.Prop24, src.Prop25, src.Prop26, src.Prop27, src.Prop28, src.Prop29, src.Prop30, src.Prop31, src.Prop32, src.Prop33, src.Prop34, src.Prop35, src.Prop36, src.Prop37, src.Prop38, src.Prop39, src.Prop40, src.Prop41, src.Prop42, src.Prop43, src.Prop44, src.Prop45, src.Prop46, src.Prop47, src.Prop48, src.Prop49, src.Prop50 }))

                .Map(dest => dest.GroupIntProperties, src => CalculateIntOperation(new int[] { src.Prop51, src.Prop52, src.Prop53, src.Prop54, src.Prop55, src.Prop56, src.Prop57, src.Prop58, src.Prop59, src.Prop60, src.Prop61, src.Prop62, src.Prop63, src.Prop64, src.Prop65, src.Prop66, src.Prop67, src.Prop68, src.Prop69, src.Prop71, src.Prop72, src.Prop73, src.Prop74, src.Prop75, src.Prop76, src.Prop77, src.Prop78, src.Prop79, src.Prop80, src.Prop81, src.Prop82, src.Prop83, src.Prop84, src.Prop85, src.Prop86, src.Prop87, src.Prop88, src.Prop89, src.Prop90, src.Prop91, src.Prop92, src.Prop93, src.Prop94, src.Prop95, src.Prop96, src.Prop97, src.Prop98, src.Prop99, src.Prop100 }))

                .Map(dest => dest.GroupDecimalProperties, src => CalculateDecimalOperation(src))

                .Map(dest => dest.GroupDateTimeProperties, src => CalculateDateTimeOperation(new List<DateTime> { src.Prop151, src.Prop152, src.Prop153, src.Prop154, src.Prop155, src.Prop156, src.Prop157, src.Prop158, src.Prop159, src.Prop160, src.Prop161, src.Prop162, src.Prop163, src.Prop164, src.Prop165, src.Prop166, src.Prop167, src.Prop168, src.Prop169, src.Prop170, src.Prop171, src.Prop172, src.Prop173, src.Prop174, src.Prop175, src.Prop176, src.Prop177, src.Prop178, src.Prop179, src.Prop180, src.Prop181, src.Prop182, src.Prop183, src.Prop184, src.Prop185, src.Prop186, src.Prop187, src.Prop188, src.Prop189, src.Prop190, src.Prop191, src.Prop192, src.Prop193, src.Prop194, src.Prop195, src.Prop196, src.Prop197, src.Prop198, src.Prop199, src.Prop190, src.Prop200 }));
            return config;
        }

        private static Dto.StringProperties CalculateStringOperation(List<string> listStrings)
        {
            var res = new StringBuilder();
            foreach (string item in listStrings)
                res.Append(item);

            return new Dto.StringProperties
            {
                value = res.ToString(),
                length = res.Length,
                numWords = listStrings.Count
            };
        }

        private static Dto.DateTimeProperties CalculateDateTimeOperation(List<DateTime> dateTimeSrcValues)
        {
            return new Dto.DateTimeProperties
            {
                minValue = dateTimeSrcValues.Min(),
                maxValue = dateTimeSrcValues.Max()
            };
        }

        private static Dto.IntProperties CalculateIntOperation(int[] srcIntValues)
        {
            return new Dto.IntProperties
            {
                minValue = srcIntValues.Min(),
                maxValue = srcIntValues.Max(),
                avgValue = srcIntValues.Average()
            };
        }

        private static Dto.DecimalProperties CalculateDecimalOperation(Portfolio src)
        {
            return new Dto.DecimalProperties
            {
                minValue = new decimal[] { src.Prop101, src.Prop102, src.Prop103, src.Prop104, src.Prop105, src.Prop106, src.Prop107, src.Prop108, src.Prop109, src.Prop110 }.Min(),
                maxValue = new decimal[] { src.Prop111, src.Prop112, src.Prop113, src.Prop114, src.Prop115, src.Prop116, src.Prop117, src.Prop118, src.Prop119, src.Prop120 }.Max(),
                avgValue = new decimal[] { src.Prop121, src.Prop122, src.Prop123, src.Prop124, src.Prop125, src.Prop126, src.Prop127, src.Prop128, src.Prop129, src.Prop130, src.Prop131, src.Prop132, src.Prop133, src.Prop134, src.Prop135, src.Prop136, src.Prop137, src.Prop138, src.Prop139, src.Prop140, src.Prop141, src.Prop142, src.Prop143, src.Prop144, src.Prop145, src.Prop146, src.Prop147, src.Prop148, src.Prop149, src.Prop150 }.Average()
            };
        }

        private static Dto.DecimalProperties CalculateDecimalOperation(PortfolioMap src)
        {
            return new Dto.DecimalProperties
            {
                minValue = new decimal[] { src.Prop101, src.Prop102, src.Prop103, src.Prop104, src.Prop105, src.Prop106, src.Prop107, src.Prop108, src.Prop109, src.Prop110 }.Min(),
                maxValue = new decimal[] { src.Prop111, src.Prop112, src.Prop113, src.Prop114, src.Prop115, src.Prop116, src.Prop117, src.Prop118, src.Prop119, src.Prop120 }.Max(),
                avgValue = new decimal[] { src.Prop121, src.Prop122, src.Prop123, src.Prop124, src.Prop125, src.Prop126, src.Prop127, src.Prop128, src.Prop129, src.Prop130, src.Prop131, src.Prop132, src.Prop133, src.Prop134, src.Prop135, src.Prop136, src.Prop137, src.Prop138, src.Prop139, src.Prop140, src.Prop141, src.Prop142, src.Prop143, src.Prop144, src.Prop145, src.Prop146, src.Prop147, src.Prop148, src.Prop149, src.Prop150 }.Average()
            };
        }

        internal static JsonPortfolio MapsterCodeGenSample()
        {
            var res_map = PortfolioSample().Adapt<PortfolioMap>();
            return res_map.Adapt<JsonPortfolio>(GetTypeAdapterConfig_CodeGen());
        }
    }
}
