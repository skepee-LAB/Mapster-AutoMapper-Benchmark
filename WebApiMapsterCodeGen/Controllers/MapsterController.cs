using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebApiMapsterCodeGen.Mappers;
//using WebApiMapsterCodeGen.Model;

namespace WebApiMapsterCodeGen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsterController : Controller
    {
        public readonly MyContext myContext;
        public readonly IPortfolioMapper portfolioMapper;

        public MapsterController(MyContext _myContext, IPortfolioMapper _portfolioMapper)
        {
            myContext = _myContext;
            portfolioMapper = _portfolioMapper;
        }

        [HttpGet]
        [Route("{Id}")]
        public IActionResult GetPortfolio(int Id)
        {
            var res = myContext.portfolio.Select(portfolioMapper.PortfolioProjection).FirstOrDefault(x=>x.Id==Id);
            var jsonPortfolio = res?.Adapt<JsonPortfolio>();
            return Ok(jsonPortfolio);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetPortfolios()
        {
            var res = myContext.portfolio.Select(portfolioMapper.PortfolioProjection);
            return Ok(res);
        }
    }
}
