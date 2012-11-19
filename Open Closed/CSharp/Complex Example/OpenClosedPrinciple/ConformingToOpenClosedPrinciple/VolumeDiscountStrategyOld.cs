using System;
using System.Collections.Generic;

namespace ConformingToOpenClosedPrinciple
{
    internal class VolumeDiscountStrategyOld : IDiscountStrategy
    {
        private readonly ShoppingCart _cart;

        public VolumeDiscountStrategyOld(ShoppingCart cart)
        {
            _cart = cart;
        }

        public double Calculate()
        {
            var discount = 0;
            var itemCount = _cart.GetItemCount();

            // Red flag!
            if (itemCount >= 5 && itemCount <= 10)
            {
                discount = 10;
            }
            else if (itemCount >= 11 && itemCount <= 15)
            {
                discount = 12;
            }

            //Iteration 3
            else if (itemCount >= 16)
            {
                discount = 25;
            }

            return discount;
        }

        public double Calculate(IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}