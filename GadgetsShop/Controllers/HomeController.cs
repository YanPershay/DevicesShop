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
    public class HomeController : Controller
    {
        private readonly IAllDevices _deviceRepository;

        public HomeController(IAllDevices deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public ViewResult Index()
        {
            var favDevices = new HomeViewModel
            {
                FavDevices = _deviceRepository.FavDevices
            };
            return View(favDevices);
        }
    }
}
