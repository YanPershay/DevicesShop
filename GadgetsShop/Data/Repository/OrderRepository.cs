using DevicesShop.Data.Interfaces;
using DevicesShop.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Repository
{
    public class OrderRepository : IAllOrders
    {
        private readonly DeviceContext _deviceContext;
        private readonly ShopCart _shopCart;

        public OrderRepository(DeviceContext deviceContext, ShopCart shopCart)
        {
            _deviceContext = deviceContext;
            _shopCart = shopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _deviceContext.Orders.Add(order);
            _deviceContext.SaveChanges();
            var items = _shopCart.ListShopItems;

            foreach(var item in items)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    DeviceId = item.Device.Id,
                    OrderId = order.Id,
                    Price = item.Device.Price
                };
                _deviceContext.OrderDetails.Add(orderDetail);
                _deviceContext.SaveChanges();
            }

            _deviceContext.SaveChanges();
        }
    }
}
