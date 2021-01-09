using DevicesShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.ViewModels
{
    public class DeviceListViewModel
    {
        public IEnumerable<Device> Devices { get; set; }
        public string CurrentCategory { get; set; }
    }
}
