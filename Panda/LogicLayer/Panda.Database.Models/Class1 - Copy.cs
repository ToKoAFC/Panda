using Panda.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.Database.Models
{
    public class VMOrder
    {
        public string OrderCode { get; set; }

        public decimal Cost { get; set; }

        public string CreatedDate { get; set; }

        public string TimeElapsedFromOrder { get; set; }

        public string PredicitonDeliveryTime { get; set; }
    }

    public class Context
    {
        public DbSet<DbOrder> DbOrders { get; set; }
    }

    public class ShopService
    {
        public TimeSpan GetDeliveryTime()
        {
            return new DateTime();
        }
    }


    public class VMOrdera
    {
        public Context _context { get; set; }
        public ShopService _shopSerivce { get; set; }

        public List<VMOrder> GetOrders(int userId)
        {
            var deliveryTime = _shopSerivce.GetDeliveryTime();

            var vmOrders = _context.DbOrders.Where(o => o.UserId == userId).Select(o => new VMOrder
            {
                Cost = o.Cost,
                OrderCode = o.OrderCode,
                CreatedDate = o.CreatedDate.ToLongDateString(),
                PredicitonDeliveryTime = o.CreatedDate.Add(deliveryTime).ToShortDateString(),
                TimeElapsedFromOrder = DateTime.Now.Subtract(o.CreatedDate).ToString()
            }).ToList();
            return vmOrders;
        }
    }
}
