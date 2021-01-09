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
                        ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-12-pro-family-hero?wid=940&hei=1112&fmt=jpeg&qlt=80&op_usm=0.5,0.5&.v=1604021663000",
                        Price = 700,
                        IsFavourite = true, Available = true, Category = deviceCategory.Categories.First() },
                    new Device {Name = "Playstation 5",
                        ShortDesc = "New playstation",
                        LongDesc = "PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP",
                        ImageUrl = "https://sony-playstation-store.com/wp-content/uploads/2013/06/143354-games-feature-sony-playstation-5-release-date-rumours-and-everything-you-need-to-know-about-ps5-image1-cvz3adase9.jpg",
                        Price = 700,
                        IsFavourite = true, Available = true, Category = deviceCategory.Categories.ElementAt(1) },
                    new Device {Name = "iBUYPOWER Gaming PC",
                        ShortDesc = "Gaming computer",
                        LongDesc = "GGGGGGGGGGGGGGGGGGGGGGGGGGGGG",
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/819XYUimTuL._AC_SL1500_.jpg",
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
