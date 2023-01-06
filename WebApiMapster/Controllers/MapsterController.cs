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
        [Route("{Id}")]
        public IActionResult GetPortfolio(int Id)
        {
            var res = repository.GetPortfolio(Id);
            return Ok(res);
        }

        [HttpGet]
        [Route("all")]
        public IActionResult GetPortfolios()
        {
            var res = repository.GetPortfolios();
            return Ok(res);
        }
    }
}
