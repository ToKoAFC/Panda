using Panda.Database.Models;
using Panda.Models.Product;
using System.Linq;

namespace Panda.Services
{
    public class ProductService
    {
        private readonly PandaEntities _context;

        public ProductService()
        {
            _context = new PandaEntities();
        }

        public VMProduct GetProduct(int productId)
        {
            return _context.Products.Where(p => p.ProductId == productId).Select(p => new VMProduct
            {
                Description = p.Description,
                Name = p.Name,
                Price = p.Price.HasValue ? p.Price.Value : 0,
                ProductId = p.ProductId
            }).FirstOrDefault();
        }
    }
}
