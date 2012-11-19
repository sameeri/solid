using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConformingToOpenClosedPrinciple
{
    class ShoppingCart
    {
        private List<Product> _items;

        public ShoppingCart()
        {
            _items = new List<Product>();
        }

        public void Add(Product product)
        {
            _items.Add(product);
        }

        public void Delete(int id)
        {
            _items.Remove(_items.FirstOrDefault(x => x.Id == id));
        }

        public IEnumerable<Product> GetItems()
        {
            return _items;
        }

        public int GetItemCount()
        {
            return _items.Count();
        }

        //We have refactored this into PricingCalculator
        //We have also successfully identified whose responsibility it is to calculate the final price.
                //        public double GetTotalAmount()
                //        {
                //            return _items.Sum(cartItem => cartItem.Price);
                //        }
        
        //We have refactored this into VolumeDiscountStrategy
        //We have further forseen that changes might occur in how we calculate discounts.
        //Today this is by volume, tomorrow it might be something else.

            //        public decimal GetDiscountPercentage()
            //        {
            //            decimal ammount = 0;
            //
                        // Red flag!
            //            if (_items.Count >= 5 && _items.Count <= 10)
            //            {
            //                ammount = 10;
            //            }
            //            else if (_items.Count >= 11 && _items.Count <= 15)
            //            {
            //                ammount = 12;
            //            }
            //
                        //Iteration 3
            //            else if (_items.Count >= 16)
            //            {
            //                ammount = 25;
            //            }
            //
            //            return ammount;
            //        }
    }
}