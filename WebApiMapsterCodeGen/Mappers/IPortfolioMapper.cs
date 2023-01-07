using Mapster;
using System.Linq.Expressions;
using WebApiMapsterCodeGen.Domains;

namespace WebApiMapsterCodeGen.Mappers
{
    [Mapper]
    public interface IPortfolioMapper
    {
       Expression<Func<Portfolio, DtoPortfolio>> PortfolioProjection { get; }
    }
}
