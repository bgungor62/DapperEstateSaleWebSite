using Dapper;
using DapperApi.Dtos.BottomGridDto;
using DapperApi.Models.DapperContext;

namespace DapperApi.Repositories.BottomGridRepository
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }

        public void CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultBottomGridDto>> GetAllBottomGrid()
        {
            string query = @"SELECT * FROM BottomGrid";
            using(var connection=_context.CreateConnection())
            {
                var values=await connection.QueryAsync<ResultBottomGridDto>(query);
                return values.ToList();
            }

        }

        public void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            throw new NotImplementedException();
        }
    }
}
