using DapperApi.Dtos.CategoryDtos;
using DapperApi.Dtos.WhoWeAreDtos;
using DapperApi.Repositories.WhoWeAreRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreRepository;

        public WhoWeAreDetailController(IWhoWeAreRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var query = await _whoWeAreRepository.GetResultWhoWeAreDetail();
            return Ok(query);
        }
        [HttpGet("getlist{id}")]
        public async Task<IActionResult> GetList(int id)
        {
            var query = await _whoWeAreRepository.GetWhoWeAreId(id);
            return
                Ok(query);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CreateWhoAreDetailDto createWhoAreDetailDto)
        {
            _whoWeAreRepository.CreateWhoWeAre(createWhoAreDetailDto);
            return Ok();
        }
        [HttpPut("updateWhoAreDetail")]
        public async Task<IActionResult> Uptade(UpdateWhoWeAreDto updateWhoWeAreDto)
        {
            _whoWeAreRepository.UpdateWhoWeAre(updateWhoWeAreDto);
            return Ok();
        }
        [HttpPut("delete{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            _whoWeAreRepository.DeleteWhoWeAre(id);
            return Ok();
        }

    }
}
