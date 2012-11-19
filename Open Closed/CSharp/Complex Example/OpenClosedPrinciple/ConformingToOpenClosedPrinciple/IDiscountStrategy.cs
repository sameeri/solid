using System;
using System.Collections.Generic;

namespace ConformingToOpenClosedPrinciple
{
    internal interface IDiscountStrategy
    {
        double Calculate(IEnumerable<Product> products);
    }
}