namespace ConformingToOpenClosedPrinciple.DiscountRulesBasedOnVolume
{
    class MoreThanFiveteenDiscountRule : IDiscountRule
    {
        public bool Match(int itemCount)
        {
            return (itemCount > 15);
        }

        public double Discount
        {
            get { return 25; }
        }
    }
}