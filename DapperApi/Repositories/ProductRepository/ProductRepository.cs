using Dapper;
using DapperApi.Dtos.ProductDtos;
using DapperApi.Models.DapperContext;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DapperApi.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository

    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }


        public async Task<List<ResultProductDto>> GetAllProducts()
        {
            string query = "SELECT * FROM Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();

            }
        }

        public async Task<List<ResultJoinCategoryDto>> GetAllProductsJoin()
        {
            string query = @"select p.Title,p.Price,p.City,p.Adress,p.CoverImage,c.CategoryName from Product p
            inner join Category c on c.CategoryID=p.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultJoinCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
