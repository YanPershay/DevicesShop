using DevicesShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DevicesShop.Data
{
    public class DeviceContext : DbContext
    {
        public DeviceContext(DbContextOptions<DeviceContext> options) : base(options)
        {

        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<ShopCartItem> ShopCartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
