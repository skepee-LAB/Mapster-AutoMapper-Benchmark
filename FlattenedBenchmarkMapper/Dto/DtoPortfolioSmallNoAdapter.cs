using System.ComponentModel.DataAnnotations;

namespace SimpleBenchmarkMapper.Dto
{
    public class DtoPortfolioSmallNoAdapter
    {
        [Key]
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
    }
}
