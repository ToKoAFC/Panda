using Panda.Models.Product;
using Panda.Services;
using System.Web.Http;

namespace Panda.Web.Controllers.AngularApi
{
    public class ProductController : ApiController
    {
        private readonly ProductService _productService;
        public ProductController()
        {
            _productService = new ProductService();
        }

        [HttpPost]
        public VMProduct GetProduct(int productId)
        {
            return _productService.GetProduct(productId);
        }


    }
}