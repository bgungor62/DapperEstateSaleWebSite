using DapperApi.Dtos.CategoryDtos;
using DapperApi.Repositories.CategoryRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategorysController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoryAsycn();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryRepository.CreateCategory(createCategoryDto);
            return Ok("Kategori başarılı bir şekilde eklendi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFromStatus(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok();
        }
        [HttpPut("updateCategory")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryRepository.UptadeCategory(updateCategoryDto);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByCategoryValue(int id) 
        {
            var values = await _categoryRepository.GetCategoryId(id);
            return Ok(values);
        }
    }
}
