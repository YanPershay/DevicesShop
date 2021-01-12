using DevicesShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.ViewModels
{
    public class HomeViewModel
    {
        
        public IEnumerable<Device> FavDevices { get; set; }
    }
}
