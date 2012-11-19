using System.Collections.Generic;
using System.Linq;

namespace ConformingToOpenClosedPrinciple
{
    class DiscountStrategyBasedOnVolume : IDiscountStrategy
    {
        private readonly List<IDiscountRule> _discountRules;

        public DiscountStrategyBasedOnVolume(List<IDiscountRule>  discountRules)
        {
            _discountRules = discountRules;
        }

        public double Calculate(IEnumerable<Product> products)
        {
           var matchedRule = _discountRules.FirstOrDefault(rule => rule.Match(products.Count()));
            return matchedRule.Discount;
        }
    }
}