using Dapper;
using DapperApi.Dtos.CategoryDtos;
using DapperApi.Models.DapperContext;

namespace DapperApi.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository

    {
        private readonly Context _context;
        CategoryQueries _queries;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) Values(@cName,@cStatus)";

            var parameters = new DynamicParameters();
            parameters.Add("@cName", categoryDto.CategoryName);
            parameters.Add("@cStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }

        }

        public async void DeleteCategory(int id)
        {
            string query = "Update Category set CategoryStatus=0 where CategoryID=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsycn()
        {
             string query = "select * from Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }

        }

        public async Task<GetByIdCategoryDto> GetCategoryId(int id)
        {
            string query = "Select * from Category WHERE CategoryID=@cId";
            var parameters = new DynamicParameters();
            parameters.Add("@cId", id);
            using(var connection = _context.CreateConnection())
            {
                var values=await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
                return values;
            }

        }

        public async void UptadeCategory(UpdateCategoryDto categoryDto)
        {
            string query = "UPDATE Category set  CategoryName=@cName where CategoryID=@cId";
            var parameters = new DynamicParameters();
            parameters.Add("@cName", categoryDto.CategoryName);
            parameters.Add("@cId", categoryDto.CategoryID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
