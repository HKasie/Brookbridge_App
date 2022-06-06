using Brookbridge.Data.Domain;

namespace Brookbridge.Data.Repository
{
    public interface IProductRespository
    {
        Task<int> CreateProduct(Product product, CancellationToken cancellationToken);
        Task<Product> GetProductById(int id, CancellationToken cancellationToken);
    }
}
