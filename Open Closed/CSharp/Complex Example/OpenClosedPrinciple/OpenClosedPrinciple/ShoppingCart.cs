using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VoilatingOpenClosedPrinciple
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

        public int GetItemCount()
        {
            return _items.Count();
        }

        //Right now, this looks good, a shopping cart knows about its items and can calculate the items price.
        //What is a new requirement comes in and then does it still adhere to SRP
        //Is the Shopping cart in our application a data object or anything more?
        public double GetTotalAmount()
        {
            return _items.Sum(cartItem => cartItem.Price);
        }

        public IEnumerable GetItems()
        {
            return _items;
        }

        //Respond to requirement in iteration 2. Add the CalculateDiscount method here.
        //OCP voilation

        public double GetDiscountPercentage()
        {
            var discount = 0;

            // Red flag!
            if (_items.Count >= 5 && _items.Count <= 10)
            {
                discount = 10;
            }
            else if (_items.Count > 10 && _items.Count <= 15)
            {
                discount = 12;
            }

            //Iteration 3
            else if (_items.Count > 15)
            {
                discount = 25;
            }

            return discount;
        }

        //Iteration 2
        public double GetPriceAfterDiscount()
        {
            var total = _items.Sum(cartItem => cartItem.Price);
            if (GetDiscountPercentage() > 0)//Total will be 0 if this check is not implemented on discount
                total -= total*(GetDiscountPercentage() * 0.01);
            return total;
        }

        //Iteration 4
        public double GetSavings()
        {
            return GetTotalAmount() - GetPriceAfterDiscount();
        }
    }
}