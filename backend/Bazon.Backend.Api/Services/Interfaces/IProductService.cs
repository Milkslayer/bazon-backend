using Bazon.Backend.Api.Models;

namespace Bazon.Backend.Api.Services;

public interface IProductService
{
    Task<Product> CreateProduct(ProductCreateDto productCreateDto);
    Task<Product> UpdateProduct(ProductUpdateDto productUpdateDto);
    Task<Product> DeleteProduct(int productId);
}