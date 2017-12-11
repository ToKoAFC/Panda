using Panda.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda.Database.Models
{
    public class DbOrder
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        [StringLength(8)]
        public string OrderCode { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Cost { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}
