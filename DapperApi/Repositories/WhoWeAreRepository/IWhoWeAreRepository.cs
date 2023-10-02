using DapperApi.Dtos.CategoryDtos;
using DapperApi.Dtos.WhoWeAreDtos;

namespace DapperApi.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetResultWhoWeAreDetail();
        void CreateWhoWeAre(CreateWhoAreDetailDto whoAreDetailDto);
        void DeleteWhoWeAre(int id);
        void UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAre);
        Task<GetByWhoWeAreIdDto> GetWhoWeAreId(int id);
    }
}
