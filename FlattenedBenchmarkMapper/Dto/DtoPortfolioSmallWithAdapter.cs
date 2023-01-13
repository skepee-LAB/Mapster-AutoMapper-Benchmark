using System.ComponentModel.DataAnnotations;

namespace FlattenedBenchmarkMapper.Dto
{
    public class DtoPortfolioSmallWithAdapter
    {
        [Key]
        public int DtoId { get; set; }
        public string? DtoCode { get; set; }
        public string? DtoName { get; set; }
        public string? DtoType { get; set; }
        public string? DtoStatus { get; set; }
    }
}
