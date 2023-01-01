using System.ComponentModel.DataAnnotations;

namespace WebApiMapster.Dto
{
    public class DtoPortfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string PortfolioCode { get; set; }
        public string PortfolioName { get; set; }
        public string PortfolioType { get; set; }
        public string PortfolioStatus { get; set; }
    }
}
