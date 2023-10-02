using DapperApi.Dtos.CategoryDtos;
using DapperApi.Dtos.ServiceDtos;

namespace DapperApi.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllService();
        void CreateService(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetServiceDto> GetServiceId(int id);
    }
}

