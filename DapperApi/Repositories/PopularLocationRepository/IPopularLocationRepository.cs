using DapperApi.Dtos.CategoryDtos;
using DapperApi.Dtos.PopularLocationDto;

namespace DapperApi.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocation();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByPopularLocation> GetPopularLocationValue(int id);
    }
}
