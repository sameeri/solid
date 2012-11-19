using System;

namespace ConformingToOpenClosedPrinciple
{
    internal interface IDiscountRule
    {
        bool Match(int itemCount);
        double Discount { get; } //Nobody should be able to set the discount!! Imagine if we could. Hehe.
    }
}