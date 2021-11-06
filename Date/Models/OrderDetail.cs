using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int CakeID { get; set; }

        public uint price { get; set; }

        public virtual Cake cake { get; set; }
        public virtual Order order { get; set; }
    }
}
