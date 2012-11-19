namespace ConformingToOpenClosedPrinciple.DiscountRulesBasedOnVolume
{
    class BetweenFiveAndTenDiscountRule : IDiscountRule
    {
        public bool Match(int itemCount)
        {
            return (itemCount > 5  && itemCount <= 10);
        }

        public double Discount
        {
            get { return 10; }
        }
    }
}