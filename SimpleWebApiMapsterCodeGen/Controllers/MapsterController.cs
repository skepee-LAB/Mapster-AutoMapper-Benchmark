using Microsoft.AspNetCore.Mvc;
using WebApiMapsterCodeGen.Services;

namespace WebApiMapsterCodeGen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsterCodeGenController : Controller
    {
        public readonly IPortfolioRepository repository;

        public MapsterCodeGenController(IPortfolioRepository _repository)
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
