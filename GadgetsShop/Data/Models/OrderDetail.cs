using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int DeviceId { get; set; }
        public uint Price { get; set; }
        public virtual Device Device { get; set; }
        public virtual Order Order { get; set; }
    }
}
