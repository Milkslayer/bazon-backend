using Bazon.Backend.Api.Models;

namespace Bazon.Backend.Api.Services;

public class ProductService: IProductService
{
    public Task<Product> CreateProduct(ProductCreateDto productCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateProduct(ProductUpdateDto productUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<Product> DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }
}