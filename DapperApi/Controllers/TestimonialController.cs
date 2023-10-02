using DapperApi.Repositories.TestimonialRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialRepository _estimonialRepository;

        public TestimonialController(ITestimonialRepository estimonialRepository)
        {
            _estimonialRepository = estimonialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values=await _estimonialRepository.GetAllTestimonial();
            return Ok(values);
        }
    }
}
