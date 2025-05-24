using ShoppingNightMongo.Dtos.ProductDetailDtos;

namespace ShoppingNightMongo.Services.ProductDetailService
{
    public interface IProductDetailService
    {
        Task<List<ResultProductDetailDto>> GetAllProductDetailAsync();
        Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
        Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
        Task DeleteProductDetailAsync(string id);
        Task<GetProductDetailByIdDto> GetProductDetailByIdAsync(string id);
    }
}
