using Bazon.Backend.Api.Models;
using Bazon.Backend.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bazon.Backend.Api.Controllers;

[ApiController]
[Route("api/v0/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IProductService _productService;

    public ProductController(ILogger<UserController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(ProductCreateDto productCreateDto)
    {
        var result = await _productService.CreateProduct(productCreateDto);
        return Ok(result);
    }
    
    [HttpPatch]
    public async Task<IActionResult> UpdateUser(ProductUpdateDto productUpdateDto)
    {
        var result = await _productService.UpdateProduct(productUpdateDto);
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> DeleteUser(int productId)
    {
        var result = await _productService.DeleteProduct(productId);
        return Ok(result);
    }
}