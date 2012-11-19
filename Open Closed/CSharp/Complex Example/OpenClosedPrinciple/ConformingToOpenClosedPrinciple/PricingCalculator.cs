using System;
using System.Linq;

namespace ConformingToOpenClosedPrinciple
{
    internal class PricingCalculator
    {
        private readonly ShoppingCart _cart;
        private readonly IDiscountStrategy _discountStrategy;

        public PricingCalculator(ShoppingCart cart, IDiscountStrategy discountStrategy)
        {
            _cart = cart;
            _discountStrategy = discountStrategy;
        }

        public double GetTotalAmount()
        {
            var items = _cart.GetItems();
            return items.Sum(item => item.Price);
        }

        public double GetPriceAfterDiscount()
        {
            var total = GetTotalAmount();
            var discount = GetDiscountPercentage();
            if (discount > 0)//Total will be 0 if this check is not implemented on discount
                total -= total * (discount * 0.01);
            return total;
        }

        public double GetDiscountPercentage()
        {
            return _discountStrategy.Calculate(_cart.GetItems());
        }


        //Iteration 4
        public double GetSavings()
        {
            return GetTotalAmount() - GetPriceAfterDiscount();
        }
    }
}