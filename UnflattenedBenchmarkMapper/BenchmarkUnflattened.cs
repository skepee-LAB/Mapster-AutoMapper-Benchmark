using BenchmarkMapper.Domains;
using BenchmarkMapper.Dto;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Mapster;
using AutoMapper;

namespace BenchmarkMapper
{
    [Config(typeof(AntiVirusFriendlyConfig))]
    [MemoryDiagnoser, Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BenchmarkUnflattened
    {
        [Params(10, 100, 1000)]
        public int numElements { get; set; }
        private IEnumerable<PortfolioUnflattened> portfolios;
        private static readonly IMapper automapper = new Mapper(new MapperConfiguration(z => z.AddProfile(new PortfolioProfile())));

        public PortfolioUnflattened PortfolioSample()
        {
           return new PortfolioUnflattened()
            {
                Id = 1,
                Code = "ABCD1",
                Name = "NameABCD1",
                Type = "Type1",
                Status = "Status2",
                GroupStringProperties = new StringPropertiesUnflattened()
                {
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
                },
                GroupIntProperties = new IntPropertiesUnflattened()
                {
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
                    Prop100 = 101
                },
                GroupDecimalProperties = new DecimalPropertiesUnflattened()
                {
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
                    Prop150 = 1500
                },
                GroupDateTimeProperties = new DateTimePropertiesUnflattened()
                {
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
                }
            };
        }

        [GlobalSetup]
        public void Init()
        {
            portfolios = Enumerable.Range(1, numElements).Select(x => PortfolioSample());
        }

        [Benchmark]
        public void AutoMapperPortfolio()
        {
            foreach (var p in portfolios)
            {
                var pDto = automapper.Map<DtoPortfolioUnflattened>(p);
            }
        }

        [Benchmark]
        public void MapsterPortfolioUnflattened()
        {
            foreach (var p in portfolios)
            {
                var pDto = p.Adapt<DtoPortfolioUnflattened>();
            }
        }

        [Benchmark]
        public void MapsterPortfolioUnflattenedCodeGen()
        {
            foreach (var p in portfolios)
            {
              var pDto = p.Adapt<PortfolioUnflattenedMap>();
            }
        }
    }
}
