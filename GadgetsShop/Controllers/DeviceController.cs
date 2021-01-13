using DevicesShop.Data.Interfaces;
using DevicesShop.Data.Models;
using DevicesShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Controllers
{
    public class DeviceController : Controller
    {
        private readonly IAllDevices _devices;
        private readonly IDeviceCategory _categories;

        public DeviceController(IAllDevices devices, IDeviceCategory categories)
        {
            _devices = devices;
            _categories = categories;
        }

        [Route("Devices/ProductsList")]
        [Route("Devices/ProductsList/{category}")]
        public ViewResult ProductsList(string category)
        {
            IEnumerable<Device> devices = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                devices = _devices.Devices.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("phones", category, StringComparison.OrdinalIgnoreCase))
                {
                    devices = _devices.Devices.Where(i => i.Category.CategoryName.Equals("Mobile phones")).OrderBy(i => i.Name);
                    currCategory = "Mobile phones";
                }
                else if (string.Equals("games", category, StringComparison.OrdinalIgnoreCase))
                {
                    devices = _devices.Devices.Where(i => i.Category.CategoryName.Equals("Game zone")).OrderBy(i => i.Name);
                    currCategory = "Game zone";
                }
                else if (string.Equals("computers", category, StringComparison.OrdinalIgnoreCase))
                {
                    devices = _devices.Devices.Where(i => i.Category.CategoryName.Equals("Computers")).OrderBy(i => i.Name);
                    currCategory = "Computers & Notebooks";
                }
                else
                {
                    return View("Error");
                }

            }


            ViewBag.Title = "Devices List";

            var deviceObj = new DeviceListViewModel
            {
                Devices = devices,
                CurrentCategory = currCategory
            };
            return View(deviceObj);
        }

        public ViewResult Error()
        {
            return View();
        }
    }
}
