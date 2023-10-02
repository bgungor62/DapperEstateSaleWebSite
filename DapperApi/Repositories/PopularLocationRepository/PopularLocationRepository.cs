using Dapper;
using DapperApi.Dtos.PopularLocationDto;
using DapperApi.Models.DapperContext;

namespace DapperApi.Repositories.PopularLocationRepository
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            throw new NotImplementedException();
        }

        public void DeletePopularLocation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocation()
        {
            string query = @"SELECT * FROM PopularLocation";
            using(var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByPopularLocation> GetPopularLocationValue(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            throw new NotImplementedException();
        }
    }
}
