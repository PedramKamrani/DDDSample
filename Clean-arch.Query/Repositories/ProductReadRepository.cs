using Clean_arch.Query.Models.Products;
using Clean_arch.Query.Shared.Repository;
using MongoDB.Driver;

namespace Clean_arch.Query.Repositories
{
    public class ProductReadRepository : BaseReadRepository<ProductReadModel>, IProductReadRepository
    {
        public ProductReadRepository(IMongoClient client) : base(client)
        {
        }
    }
}