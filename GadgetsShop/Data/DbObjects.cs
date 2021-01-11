using DevicesShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data
{
    public class DbObjects
    {
        public static void Init(DeviceContext context)
        {

            if(!context.Categories.Any())
                context.Categories.AddRange(Categories.Select(c => c.Value));

            if (!context.Devices.Any())
            {
                context.AddRange(
                    new Device
                    {
                        Name = "IPhone 12 Pro",
                        ShortDesc = "Blast past fast.",
                        LongDesc = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII",
                        ImageUrl = "/img/iphone.jpg",
                        Price = 700,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Mobile phones"]
                    },
                    new Device
                    {
                        Name = "Playstation 5",
                        ShortDesc = "New playstation",
                        LongDesc = "PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP",
                        ImageUrl = "/img/ps5.jpg",
                        Price = 700,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Game zone"]
                    },
                    new Device
                    {
                        Name = "iBUYPOWER Gaming PC",
                        ShortDesc = "Gaming computer",
                        LongDesc = "GGGGGGGGGGGGGGGGGGGGGGGGGGGGG",
                        ImageUrl = "/img/pk.jpg",
                        Price = 700,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Computers"]
                    }
                    );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categoryDict;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(categoryDict == null)
                {
                    var list = new Category[]
                    {
                        new Category{CategoryName = "Mobile phones", Description = "Mobile phones, tablets"},
                        new Category{CategoryName = "Game zone", Description = "Gaming consoles"},
                        new Category{CategoryName = "Computers", Description = "Personal computers, notebooks"},
                    };

                    categoryDict = new Dictionary<string, Category>();
                    foreach(var category in list)
                    {
                        categoryDict.Add(category.CategoryName, category);
                    }
                }

                return categoryDict;
            }
        }
    }
}
