using DevicesShop.Data.Interfaces;
using DevicesShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Mocks
{
    public class MockDevices : IDevices
    {
        private readonly IDeviceCategory deviceCategory = new MockCategory();

        public IEnumerable<Device> Devices
        {
            get
            {
                return new List<Device>
                {
                    new Device {Name = "IPhone 12 Pro",
                        ShortDesc = "Blast past fast.",
                        LongDesc = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII",
                        ImageUrl = "/img/iphone.jpg",
                        Price = 700,
                        IsFavourite = true, Available = true, Category = deviceCategory.Categories.First() },
                    new Device {Name = "Playstation 5",
                        ShortDesc = "New playstation",
                        LongDesc = "PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP",
                        ImageUrl = "/img/ps5.jpg",
                        Price = 700,
                        IsFavourite = true, Available = true, Category = deviceCategory.Categories.ElementAt(1) },
                    new Device {Name = "iBUYPOWER Gaming PC",
                        ShortDesc = "Gaming computer",
                        LongDesc = "GGGGGGGGGGGGGGGGGGGGGGGGGGGGG",
                        ImageUrl = "/img/pk.jpg",
                        Price = 700,
                        IsFavourite = true, Available = true, Category = deviceCategory.Categories.Last() }
                };
            }
        }

        public IEnumerable<Device> FavDevices { get; set; }

        public Device GetDevice(int id)
        {
            throw new NotImplementedException();
        }
    }
}
