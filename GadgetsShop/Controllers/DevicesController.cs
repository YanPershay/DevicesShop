using DevicesShop.Data.Interfaces;
using DevicesShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Controllers
{
    public class DevicesController : Controller
    {
        private readonly IDevices _devices;
        private readonly IDeviceCategory _categories;

        public DevicesController(IDevices devices, IDeviceCategory categories)
        {
            _devices = devices;
            _categories = categories;
        }

        public ViewResult ProductsList()
        {
            ViewBag.Title = "Devices List";

            DeviceListViewModel viewModel = new DeviceListViewModel();
            viewModel.Devices = _devices.Devices;
            viewModel.CurrentCategory = "Category";
            return View(viewModel);
        }
    }
}
