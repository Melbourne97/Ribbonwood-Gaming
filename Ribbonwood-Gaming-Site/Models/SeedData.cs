using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Ribbonwood_Gaming_Site.Data;
using System;
using System.Linq;

namespace Ribbonwood_Gaming_Site.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RibbonwoodContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RibbonwoodContext>>()))
            {
                // Look for any movies.
                if (context.Products.Any())
                {
                    return;   // DB has been seeded
                }

                context.Products.AddRange(
                    new Product
                    {
                        Name = "Dungeon Master",
                        Price = 235.0F,
                        Quantity = 75,
                        Vendor = "Bundles",
                        Description = "Dungeon Master's Guide, Player's Handbook, Monster Manual, 1 Random Campaign Book, A DM Screen, A DM Cloak, 5 Sets of Resin Dice w/ Dice Bag, Grid paper(1in. Squares) 30” x 6’ roll, and an Initiative Tracker pdf."
                    },
                    new Product
                    {
                        Name = "Player Bundle",
                        Price = 55.0F,
                        Quantity = 0,
                        Vendor = "Bundles",
                        Description = "The Player Bundle is the perfect bundle for either beginners to Dungeons and Dragons or if you just want to be a player in a campaign for now. It includes a Player’s Handbook, 5 sets of dice in a carrying bag, and a generic mini!"
                    },
                    new Product
                    {
                        Name = "Fan Bundle",
                        Price = 45.0F,
                        Quantity = 250,
                        Vendor = "Bundles",
                        Description = "The Fan Bundle is the perfect bundle for players who want to start to collect Dungeons and Dragons or Ribbonwood products. It includes 5 sets of dice in a carrying bag, 1 shirt from either Dungeons and Dragons or Ribbonwood, 1 keychain from either Dungeons and Dragons or Ribbonwood, and 1 $25 Heroforge Gift Card!"
                    },
                    new Product
                    {
                        Name = "Dice Dragon",
                        Price = 20.0F,
                        Quantity = 370,
                        Vendor = "Bundles",
                        Description = "The Dice Dragon Bundle is the perfect purchase if you want to get your hands on a bunch of dice for a low price! It includes 20 sets of dice in a carrying bag!"
                    },
                    new Product
                    {
                        Name = "The Accessorizer",
                        Price = 75.0F,
                        Quantity = 180,
                        Vendor = "Bundles",
                        Description = "The Accessorizer Bundle is the perfect bundle for collectors of merch and products of Dungeons and Dragons or Ribbonwood. It includes 1 shirt from either Dungeons and Dragons or Ribbonwood, 1 keychain from either Dungeons and Dragons or Ribbonwood, a magnet set from either Dungeons and Dragons or Ribbonwood, 5 sets of dice in a carrying bag, 1 playmat from either Dungeons and Dragons or Ribbonwood, and 1 $25 Heroforge Gift Card!"
                    },
                    new Product
                    {
                        Name = "Ribbonwood T-Shirt",
                        Price = 20.0F,
                        Quantity = 312,
                        Vendor = "Merch",
                        Description = "A Unisex Cotton T-Shirt with the Ribbonwood Games Logo Printed on the Front."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons T-Shirt",
                        Price = 25.0F,
                        Quantity = 245,
                        Vendor = "Merch",
                        Description = "A Unisex Cotton T-Shirt with the Dungeons and Dragons Logo Printed on the Pocket."
                    },
                    new Product
                    {
                        Name = "Wyrmwood T-Shirt",
                        Price = 23.99F,
                        Quantity = 365,
                        Vendor = "Merch",
                        Description = "Male and Female Polyester T-Shirt with the Wyrmwood Logo Embroidered on the Pocket."
                    },
                    new Product
                    {
                        Name = "Ribbonwood Magnet Set",
                        Price = 10.0F,
                        Quantity = 675,
                        Vendor = "Merch",
                        Description = "A Magnet set including the Ribbonwood Logo, a Realistic Stick, and our Motto."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Magnet Set",
                        Price = 12.99F,
                        Quantity = 452,
                        Vendor = "Merch",
                        Description = "A Magnet set including the Dungeons and Dragons Logo, and a Random Logo from a premade campaign."
                    },
                    new Product
                    {
                        Name = "Ribbonwood Keychain",
                        Price = 5.0F,
                        Quantity = 895,
                        Vendor = "Merch",
                        Description = "A Keychain of the Ribbonwood Logo."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Keychain",
                        Price = 7.99F,
                        Quantity = 425,
                        Vendor = "Merch",
                        Description = "A Keychain of the Dungeons and Dragons Logo."
                    },
                    new Product
                    {
                        Name = "Ribbonwood Sticker Set",
                        Price = 1.0F,
                        Quantity = 754,
                        Vendor = "Merch",
                        Description = "A Sticker Set of the Ribbonwood Logo."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Sticker Set",
                        Price = 1.5F,
                        Quantity = 214,
                        Vendor = "Merch",
                        Description = "A Sticker Set including the Dungeons and Dragons Logo, and a Random Logo from a premade campaign."
                    },
                    
                    new Product
                    {
                        Name = "Wyrmwood Sticker Set",
                        Price = 1.25F,
                        Quantity = 364,
                        Vendor = "Merch",
                        Description = "A Sticker Set of the Wyrmwood Logo."
                    },
                    new Product
                    {
                        Name = "Wizards of the Coast Playmat",
                        Price = 15.0F,
                        Quantity = 250,
                        Vendor = "Wizards of the Coast",
                        Description = "A playmat that was designed with your table in mind. It will be the protective barrier for your table from all the terrible dice rolls."
                    },
                    new Product
                    {
                        Name = "Hero Forge Mini",
                        Price = 2.0F,
                        Quantity = 550,
                        Vendor = "Hero Forge",
                        Description = "This is a purchase of a random generic mini made by us."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Dice Vault - Cherry",
                        Price = 40.0F,
                        Quantity = 60,
                        Vendor = "Wyrmwood",
                        Description = "This classic Cherry Dice Vault with engraving is a perfect choice for your favorite halfling.  Keep your dice close at hand, and represent the world’s greatest role-playing game."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Dice Vault - Padauk",
                        Price = 70.0F,
                        Quantity = 50,
                        Vendor = "Wyrmwood",
                        Description = "This classic Padauk Dice Vault with engraving is a perfect choice for your favorite halfling.  Keep your dice close at hand, and represent the world’s greatest role-playing game."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Dice Vault - Wenge",
                        Price = 100.0F,
                        Quantity = 45,
                        Vendor = "Wyrmwood",
                        Description = "This classic Wenge Dice Vault with engraving is a perfect choice for your favorite halfling.  Keep your dice close at hand, and represent the world’s greatest role-playing game."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Tabletop Tray - Cherry",
                        Price = 125.0F,
                        Quantity = 40,
                        Vendor = "Wyrmwood",
                        Description = "This breathtaking, officially licensed Cherry Tabletop Dice Tray features the iconic Dungeons & Dragons Ampersand, printed on Vegan synthetic leather.  How do you make playing the World’s Greatest Roleplaying Game even better?  With the world’s finest tabletop gaming accessories."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Tabletop Tray - Padauk",
                        Price = 165.0F,
                        Quantity = 35,
                        Vendor = "Wyrmwood",
                        Description = "This breathtaking, officially licensed Padauk Tabletop Dice Tray features the iconic Dungeons & Dragons Ampersand, printed on Vegan synthetic leather.  How do you make playing the World’s Greatest Roleplaying Game even better?  With the world’s finest tabletop gaming accessories."
                    },
                    new Product
                    {
                        Name = "Dungeons and Dragons Tabletop Tray - Wenge",
                        Price = 195.0F,
                        Quantity = 30,
                        Vendor = "Wyrmwood",
                        Description = "This breathtaking, officially licensed Wenge Tabletop Dice Tray features the iconic Dungeons & Dragons Ampersand, printed on Vegan synthetic leather.  How do you make playing the World’s Greatest Roleplaying Game even better?  With the world’s finest tabletop gaming accessories."
                    },
                    new Product
                    {
                        Name = "Ribbonwood Dice",
                        Price = 25.0F,
                        Quantity = 500,
                        Vendor = "Level Up Dice",
                        Description = "Custom Ribbonwood Games dice designed by Level Up Dice."
                    },
                    new Product
                    {
                        Name = "Reject Dice",
                        Price = 10.0F,
                        Quantity = 200,
                        Vendor = "Level Up Dice",
                        Description = "The reject pile is a bunch of dice that are not to code to sell full price. They are lonely and are in need of adoption."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}