using DevicesShop.Data.Interfaces;
using DevicesShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Mocks
{
    public class MockCategory : IDeviceCategory
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Portative devices", Description = "Mobile phones, tablets"},
                    new Category{CategoryName = "Game zone", Description = "Gaming consoles"},
                    new Category{CategoryName = "Computers", Description = "Personal computers, notebooks"},
                };
            }
        }
    }
}
