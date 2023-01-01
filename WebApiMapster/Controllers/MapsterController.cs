using Microsoft.AspNetCore.Mvc;
using WebApiMapster.Model;
using WebApiMapster.Services;

namespace WebApiMapster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsterController : Controller
    {
        public readonly IPortfolioRepository repository;

        public MapsterController(IPortfolioRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        [Route("{portfolioId}")]
        public IActionResult GetPortfolio(int portfolioId)
        {
            var res = repository.GetPortfolio(portfolioId);
            return Ok(res);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetPortfolios()
        {
            var res = repository.GetPortfolios();
            return Ok(res);
        }

        [HttpPost]
        public IActionResult AddPortfolio([FromBody] portfolio item)
        {
            repository.InsertPortfolio(item);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePortfolio([FromBody] portfolio item)
        {
            repository.UpdatePortfolio(item);
            return Ok();
        }

        [HttpDelete]
        [Route("{portfolioId}")]
        public IActionResult RemovePortfolio(int portfolioId)
        {
            repository.DeletePortfolio(portfolioId);
            return Ok();
        }
    }
}
