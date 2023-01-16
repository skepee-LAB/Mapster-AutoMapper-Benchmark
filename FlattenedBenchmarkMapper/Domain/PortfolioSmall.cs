using Mapster;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace FlattenedBenchmarkMapper.Domains
{
    public class PortfolioSmall
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
}
