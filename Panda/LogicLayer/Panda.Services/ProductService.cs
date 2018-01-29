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
            var product = (from p in _context.Products
                           where p.ProductId == productId
                           select new VMProduct
                           {
                               Description = p.Description,
                               Name = p.Name,
                               Price = p.Price.HasValue ? p.Price.Value : 0,
                               ProductId = p.ProductId
                           }).FirstOrDefault();
            return product;
        }
    }
}
