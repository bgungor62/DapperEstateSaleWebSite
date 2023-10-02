using DapperApi.Dtos.BottomGridDto;
using DapperApi.Dtos.CategoryDtos;

namespace DapperApi.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGrid();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
    }
}
