using DapperApi.Dtos.CategoryDtos;

namespace DapperApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsycn();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UptadeCategory(UpdateCategoryDto categoryDto);
        Task<GetByIdCategoryDto> GetCategoryId(int id);
    }
}
