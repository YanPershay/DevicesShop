using DevicesShop.Data.Interfaces;
using DevicesShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Repository
{
    public class CategoryRepository : IDeviceCategory
    {
        private readonly DeviceContext _context;
        public CategoryRepository(DeviceContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories => _context.Categories;
    }
}
