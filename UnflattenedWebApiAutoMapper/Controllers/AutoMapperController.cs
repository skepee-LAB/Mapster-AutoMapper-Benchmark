using Microsoft.AspNetCore.Mvc;
using WebApiAutoMapper.Services;

namespace WebApiAutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoMapperController : Controller
    {
        public readonly IPortfolioRepository repository;

        public AutoMapperController(IPortfolioRepository _repository)
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
