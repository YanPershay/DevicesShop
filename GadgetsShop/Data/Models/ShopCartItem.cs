using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Device Device { get; set; }
        public int Price { get; set; }
        public string ShopCartId { get; set; }
    }
}
