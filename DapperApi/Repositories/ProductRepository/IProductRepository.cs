using DapperApi.Dtos.ProductDtos;

namespace DapperApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProducts();
        Task<List<ResultJoinCategoryDto>> GetAllProductsJoin();

    }
}
