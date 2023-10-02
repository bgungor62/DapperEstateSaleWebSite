using Dapper;
using DapperApi.Dtos.ServiceDtos;
using DapperApi.Models.DapperContext;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DapperApi.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }

        public async void CreateService(CreateServiceDto createServiceDto)
        {
            string query = "INSERT INTO Service (ServiceName,ServiceStatus) Values(@servicename,@servicestatus)";
            var parameteres = new DynamicParameters();
            parameteres.Add("@servicename", createServiceDto.ServiceName);
            parameteres.Add("@servicestatus", createServiceDto.ServiceStatus);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameteres);
            }

        }

        public async void DeleteService(int id)
        {
            string query = "UPDATE Service SET ServiceStatus=0 where ServiceID=@serviceid";
            var parameteres = new DynamicParameters();
            parameteres.Add("@serviceid", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameteres);
            }
        }

        public async Task<List<ResultServiceDto>> GetAllService()
        {
            string query = "SELECT * FROM Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetServiceDto> GetServiceId(int id)
        {
            string query = "SELECT * FROM Service WHERE ServiceID=@serviceid";
            var paramaters = new DynamicParameters();
            paramaters.Add("@serviceid", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetServiceDto>(query, paramaters);
                return values;
            }
        }

        public async void UpdateService(UpdateServiceDto updateServiceDto)
        {
            string query = "UPDATE Service SET  ServiceName=@servicename WHERE ServiceID=@serviceid";
            var parameters = new DynamicParameters();
            parameters.Add("@servicename", updateServiceDto.ServiceName);
            parameters.Add("@serviceid", updateServiceDto.ServiceID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
              
            }

        }
    }
}
