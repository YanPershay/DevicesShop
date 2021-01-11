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
    public class ShopCartController : Controller
    {
        private readonly IDevices _deviceRepository;
        private readonly ShopCart _shopCart;

        public ShopCartController(IDevices deviceRepository, ShopCart shopCart)
        {
            _deviceRepository = deviceRepository;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetAllItems();
            _shopCart.ListShopItems = items;

            var viewModel = new ShopCartViewModel()
            {
                ShopCart = _shopCart
            };

            return View(viewModel);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _deviceRepository.Devices.FirstOrDefault(i => i.Id == id);

            if(item != null)
            {
                _shopCart.AddToCart(item);
            }

            return RedirectToAction("Index");
        }
    }
}
