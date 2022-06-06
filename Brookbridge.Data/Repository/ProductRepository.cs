using Brookbridge.Data.Domain;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Brookbridge.Data.Repository
{
    public class IProductRepository : IProductRespository
    {
        private readonly IConfiguration config;

        public IProductRepository(IConfiguration config)
        {
            this.config = config;
        }
        public async Task<int> CreateProduct(Product product, CancellationToken cancellationToken)
        {
            using (SqlConnection connection = new(config["ConnectionStrings:DefaultConnection"]
))
            {
                using (SqlCommand command = new())
                {
                    await connection.OpenAsync(cancellationToken);

                    command.Connection = connection;
                    command.CommandText = "usp_product_add";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.Name;
                    command.Parameters.Add("@description", SqlDbType.NVarChar).Value = product.Description;
                    command.Parameters.Add("@code", SqlDbType.NVarChar).Value = product.Code;
                    command.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;
                    command.Parameters.Add("@qty", SqlDbType.Int).Value = product.Qty;
                    command.Parameters.Add("@veg", SqlDbType.Bit).Value = product.Veg;
                    command.Parameters.Add("@date_added", SqlDbType.DateTime).Value = DateTime.Now;

                    int id = (int)await command.ExecuteScalarAsync(cancellationToken);
                    return id;
                }
            }
        }

        public Task<Product> GetProductById(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<> GetProduct(Product product, CancellationToken cancellationToken)
        {
            using (SqlConnection connection = new(Config["ConnectionStrings:DefaultConnection"]))

            using (SqlCommand command = new())
            {
                await connection.OpenAsync(cancellationToken);

                command.Connection = connection;
                command.CommandText = "usp_get_product";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.("@name", SqlDbType.NVarChar).Value = product.Name;
                command.Parameters.Add("@description", SqlDbType.NVarChar).Value = product.Description;
                command.Parameters.Add("@code", SqlDbType.NVarChar).Value = product.Code;
                command.Parameters.Add("@price", SqlDbType.Decimal).Value = product.Price;
                command.Parameters.Add("@qty", SqlDbType.Int).Value = product.Qty;
                command.Parameters.Add("@veg", SqlDbType.Bit).Value = product.Veg;
                command.Parameters.Add("@date_added", SqlDbType.DateTime).Value = DateTime.Now;

                int id = (int)await command.ExecuteScalarAsync(cancellationToken);
                return id;
            }
        }

           
    }
}
