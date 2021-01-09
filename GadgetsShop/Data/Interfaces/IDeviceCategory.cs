using DevicesShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Interfaces
{
    public interface IDeviceCategory
    {
        IEnumerable<Category> Categories { get; }
    }
}
