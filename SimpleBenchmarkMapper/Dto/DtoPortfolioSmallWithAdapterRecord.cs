using Mapster;
using System.ComponentModel.DataAnnotations;

namespace SimpleBenchmarkMapper.Dto
{
    public record struct DtoPortfolioSmallWithAdapterRecord
    {
        [Key]
        [AdaptMember("Id")]
        public int DtoId { get; set; }
        [AdaptMember("Code")]
        public string? DtoCode { get; set; }
        [AdaptMember("name")]
        public string? DtoName { get; set; }
        [AdaptMember("Type")]
        public string? DtoType { get; set; }
        [AdaptMember("Status")]
        public string? DtoStatus { get; set; }
    }
}
