using DapperApi.Repositories.PopularLocationRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _locationRepository;
        public PopularLocationController(IPopularLocationRepository popularLocationRepository)
        {
                _locationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values=await _locationRepository.GetAllPopularLocation();
            return Ok(values);
        }

    }
}
