using Panda.Database.Models;

namespace Panda.Services
{
    public class ProductService
    {
        private readonly PandaEntities _context;

        public ProductService()
        {
            _context = new PandaEntities();
        }

        
    }
}
