using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
  public  class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public int id { get; set; }

        public string Customer { get; set; }

        public DateTime OrderDate { get; set; }

        //navigation
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
