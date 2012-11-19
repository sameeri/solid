using System;
using System.Collections.Generic;
using System.Linq;

namespace ConformingToOpenClosedPrinciple
{
    internal class SimulateAShoppingCart
    {
        private readonly List<Product> _products;

        public SimulateAShoppingCart()
        {
            _products = new List<Product>()
                            {
                                new Product(){Name = "Toothpase", Manufacturer = "Colgate", Id = 1, Price = 3.42},
                                new Product(){Name = "Toothbrush", Manufacturer = "Colgate", Id = 2, Price = 2.90},
                                new Product(){Name = "Soap", Manufacturer = "Dove", Id = 3, Price = 4.20},
                                new Product(){Name = "Shaving Gel", Manufacturer = "Gillete", Id = 4, Price = 7.00},
                                new Product(){Name = "Razor", Manufacturer = "Gillete", Id = 5, Price = 6.50},
                            };
        }
        public ShoppingCart Get()
        {
            var cart = new ShoppingCart();

            var itemrandomizer = new Random();
            var randomizer = new Random();
            var random = randomizer.Next(0,20);

            for (var i = 0; i < random; i++)
            {
                var itemId = itemrandomizer.Next(1, 5);
                cart.Add(_products.FirstOrDefault(x => x.Id == itemId));
            }

            return cart;
        }
    }
}