using Mapster;
using System.Linq.Expressions;

namespace WebApiMapsterCodeGen.Mappers
{
    [Mapper]
    public interface IPortfolioMapper
    {
       Expression<Func<Portfolio, DtoPortfolio>> PortfolioProjection { get; }
        //DtoPortfolio Map(Portfolio portfolio);

    }
}
