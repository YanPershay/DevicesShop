using DevicesShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Interfaces
{
    public interface IAllDevices
    {
        IEnumerable<Device> Devices { get; }
        IEnumerable<Device> FavDevices { get;}
        Device GetDevice(int id);
    }
}
