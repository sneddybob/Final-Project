using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalizer.Data
{
    public class MockShopData
    {
        public static Category[] categories = {
        new Category {
            ID = 1,
            Name = "Acoustic Guitars",
            Description = "Lovely, Traditional Luthier Instruments",
            BannerImageUrl = "/image/acousticBanner.jpg", Products =
            {
                new Product{
                    ID = 11,
                    Name = "Dreadnought",
                    Price = 249.99m,
                    Description = "The most popular steel-string acoustic model",
                    ProductColors =
                    {
                        new ProductColor
                        {
                            ID = 111,
                            Color = "Natural"
                        }
                    },
                     Reviews =
                    {
                        new Review{ ID = 1111, Rating = 5, Text = "I love this guitar"},
                        new Review{ ID = 1112, Rating = 5, Text = "I too love this guitar"}
                    },
                    ProductImages =
                    {
                        new ProductImage{ ID = 11111, Url = "/images/dreadnought.png", AltText="Martin Dreadnought"}
                    }
                },
                new Product{
                    ID = 12,
                    Name = "Jumbo Acoustic with Cutaway",
                    Price = 549.99m,
                    Description = "A fan favorite, the bigger body allows for warmer tones.",
                    ProductColors =
                    {
                        new ProductColor
                        {
                            ID = 112,
                            Color = "Black"
                        }
                    },
                     Reviews =
                    {
                        new Review{ ID = 1121, Rating = 5, Text = "I love this guitar"},
                        new Review{ ID = 1122, Rating = 5, Text = "So Pretty!"}
                    },
                    ProductImages =
                    {
                        new ProductImage{ ID = 11211, Url = "/images/jumboEPIblackSM.png", AltText="Epiphone Jumbo Acoustic"}
                    }
                }
            }
        },
        new Category {
            ID = 2,
            Name = "Solid Body Electric",
            Description = "These are ready to rock!",
            BannerImageUrl = "/image/solidBanner.jpg",
            Products =
            {
                new Product{
                    ID = 21,
                    Name = "Telecaster",
                    Price = 449.99m,
                    Description = "The choice for any genre!",
                    ProductColors =
                    {
                        new ProductColor
                        {
                            ID = 211,
                            Color = "Blonde"
                        }
                    },
                     Reviews =
                    {
                        new Review{ ID = 2111, Rating = 5, Text = "I love this guitar"},
                        new Review{ ID = 2112, Rating = 5, Text = "I also love this guitar"}
                    },
                    ProductImages =
                    {
                        new ProductImage{ ID = 21111, Url = "/images/telenaturalSM.png", AltText="Fender Telecaster Blonde"}
                    }
                },
                new Product{
                    ID = 22,
                    Name = "Telecaster",
                    Price = 449.99m,
                    Description = "The choice for any genre!",
                    ProductColors =
                    {
                        new ProductColor
                        {
                            ID = 221,
                            Color = "Black"
                        }
                    },
                     Reviews =
                    {
                        new Review{ ID = 2211, Rating = 5, Text = "I love this black fender."},
                        new Review{ ID = 2212, Rating = 5, Text = "I also love this black guitar."}
                    },
                    ProductImages =
                    {
                        new ProductImage{ ID = 22111, Url = "/images/teleblackSM.png", AltText="Fender Telecaster Black"}
                    }
                }

            }

        },
        new Category {
            ID = 3,
            Name = "Semi-Hollowbody Electrics",
            Description = "Lay down some Warm Tones",
            BannerImageUrl = "/image/semiBanner.jpg",
        Products =
            {
                new Product{
                    ID = 31,
                    Name = "Gibson ES-355",
                    Price = 2249.99m,
                    Description = "The crown jewel of the Gibson line.",
                    ProductColors =
                    {
                        new ProductColor
                        {
                            ID = 311,
                            Color = "Cherry"
                        }
                    },
                     Reviews =
                    {
                        new Review{ ID = 3111, Rating = 5, Text = "I love this guitar"},
                        new Review{ ID = 3211, Rating = 5, Text = "Guitar is good, meh"}
                    },
                    ProductImages =
                    {
                        new ProductImage{ ID = 31111, Url = "/images/es355redSM.png", AltText="Gibson ES-355"}
                    }
                },
                new Product{
                    ID = 32,
                    Name = "Gibson ES-355",
                    Price = 2249.99m,
                    Description = "The crown jewel of the Gibson line.",
                    ProductColors =
                    {
                        new ProductColor
                        {
                            ID = 321,
                            Color = "Natural"
                        }
                    },
                     Reviews =
                    {
                        new Review{ ID = 3211, Rating = 5, Text = "I love this guitar"},
                        new Review{ ID = 3212, Rating = 5, Text = "Guitar is good, i like natural"}
                    },
                    ProductImages =
                    {
                        new ProductImage{ ID = 32111, Url = "/images/es355naturalSM.png", AltText="Gibson ES-355 Natural"}
                    }
                },
                new Product{
                    ID = 33,
                    Name = "Gibson ES-355",
                    Price = 2249.99m,
                    Description = "The crown jewel of the Gibson line.",
                    ProductColors =
                    {
                        new ProductColor
                        {
                            ID = 331,
                            Color = "Black"
                        }
                    },
                     Reviews =
                    {
                        new Review{ ID = 3311, Rating = 5, Text = "I love this guitar"},
                        new Review{ ID = 3312, Rating = 5, Text = "Guitar is good, meh, i like cherry"}
                    },
                    ProductImages =
                    {
                        new ProductImage{ ID = 33111, Url = "/images/es355blackSM.png", AltText="Gibson ES-355 Black"}
                    }
                }
            } }
    };
    }
}
