using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Models
{
    public class ShopCartItem
    {
        public int id { get; set; }
        public Cake cake { get; set; }
        public int price { get; set; }


        public string ShopCakeId { get; set; }
    }
}
