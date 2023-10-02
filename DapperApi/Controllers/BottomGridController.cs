using DapperApi.Repositories.BottomGridRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }


        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values =await _bottomGridRepository.GetAllBottomGrid();
            return Ok(values);
        }
    }
}
