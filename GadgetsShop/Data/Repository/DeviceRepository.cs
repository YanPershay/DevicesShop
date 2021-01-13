using DevicesShop.Data.Interfaces;
using DevicesShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Repository
{
    public class DeviceRepository : IAllDevices
    {
        private readonly DeviceContext _context;

        public DeviceRepository(DeviceContext context)
        {
            _context = context;
        }
        public IEnumerable<Device> Devices => _context.Devices.Include(d => d.Category);

        public IEnumerable<Device> FavDevices => _context.Devices.Where(d => d.IsFavourite).Include(d => d.Category);

        public Device GetDevice(int id) => _context.Devices.FirstOrDefault(d => d.Id == id);
    }
}
