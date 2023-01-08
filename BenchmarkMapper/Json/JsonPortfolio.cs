using System.ComponentModel.DataAnnotations;

namespace BenchmarkMapper.Json
{
    public class JsonPortfolio
    {
        [Key]
        public int DtoId { get; set; }
        public string? DtoCode { get; set; }
        public string? DtoName { get; set; }
        public string? DtoType { get; set; }
        public string? DtoStatus { get; set; }
        public StringProperties? GroupStringProperties { get; set; }
        public IntProperties? GroupIntProperties { get; set; }
        public DecimalProperties? GroupDecimalProperties { get; set; }
        public DateTimeProperties? GroupDateTimeProperties { get; set; }

    }

    public class StringProperties
    {
        public string value { get; set; }
        public int numWords { get; set; }
        public int length { get; set; }
    }


    public class IntProperties
    {
        public int minValue { get; set; }

        public int maxValue { get; set; }

        public double avgValue { get; set; }
    }

    public class DecimalProperties
    {
        public decimal minValue { get; set; }

        public decimal maxValue { get; set; }

        public decimal avgValue { get; set; }
    }

    public class DateTimeProperties
    {
        public DateTime minValue { get; set; }

        public DateTime maxValue { get; set; }
    }
}
