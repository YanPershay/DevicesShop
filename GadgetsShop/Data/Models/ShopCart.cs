using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Models
{
    public class ShopCart
    {
        private readonly DeviceContext _context;

        public ShopCart(DeviceContext context)
        {
            _context = context;
        }
        public string ShopCartId { get; set; }
        public List<ShopCartItem> ListShopItems { get; set; }

        public static ShopCart GetShopCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<DeviceContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Device device)
        {
            _context.ShopCartItems.Add(
                new ShopCartItem()
                {
                    ShopCartId = ShopCartId,
                    Device = device,
                    Price = device.Price
                });

            _context.SaveChanges();
        }

        public List<ShopCartItem> GetAllItems() => _context.ShopCartItems.Where(i => i.ShopCartId == ShopCartId).Include(i => i.Device).ToList();
    }
}
