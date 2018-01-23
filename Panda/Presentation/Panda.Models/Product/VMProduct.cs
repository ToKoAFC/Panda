using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Panda.Models.Product
{
    public class VMProduct
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}