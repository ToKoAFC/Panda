using Panda.Models.Product;
using Panda.Services;
using System.Collections.Generic;
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

        [HttpPost]
        public List<VMProduct> GetProducts()
        {
            var list = new List<VMProduct>
            {
                new VMProduct
                {
                    Name = "mąka poznańska",
                    Description = "100% mąka pszenna",
                    Price = 2.99M
                },
                new VMProduct
                {
                    Name = "Ketchup Heinz",
                    Description ="100g produktu wykonano z 140g pomidorów",
                    Price = 4.49M
                },
                new VMProduct
                {
                    Name = "Cisowianka",
                    Description = "Woda lekkogazowana",
                    Price = 1.69M
                },
                new VMProduct
                {
                    Name = "Chleb",
                    Description = "chleb pszenno-żytni",
                    Price = 1.96M
                },
                new VMProduct
                {
                    Name = "Pomarańcza",
                    Description = "kraj pochodzenia: Hiszpania",
                    Price = 2.99M
                },
                new VMProduct
                {
                    Name = "Banan",
                    Description = "Kraj pochodzenia: Argentyna",
                    Price = 3.99M
                }
            };
            return list;
        }

    }
}