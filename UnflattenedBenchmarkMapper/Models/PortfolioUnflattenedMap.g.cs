using BenchmarkMapper.Domains;

namespace BenchmarkMapper.Domains
{
    public partial class PortfolioUnflattenedMap
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public StringPropertiesUnflattenedMap GroupStringProperties { get; set; }
        public IntPropertiesUnflattenedMap GroupIntProperties { get; set; }
        public DecimalPropertiesUnflattenedMap GroupDecimalProperties { get; set; }
        public DateTimePropertiesUnflattenedMap GroupDateTimeProperties { get; set; }
    }
}