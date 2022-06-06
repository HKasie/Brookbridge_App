using Brookbridge.Contracts;
using Brookbridge.Data.Domain;
using Brookbridge.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Brookbridge.Api.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public async Task CreateProduct([FromBody] CreateProductDto productDto)
        {
            try
            {
                CancellationToken token = new();
                Product product = new(productDto.Name, productDto.Description, productDto.Code, productDto.Price,productDto.Qty, productDto.Veg);
                await _productRepository.CreateProduct(product, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
