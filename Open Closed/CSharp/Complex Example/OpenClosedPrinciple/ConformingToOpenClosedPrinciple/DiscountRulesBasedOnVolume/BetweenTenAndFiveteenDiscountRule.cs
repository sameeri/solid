namespace ConformingToOpenClosedPrinciple.DiscountRulesBasedOnVolume
{
    class BetweenTenAndFiveteenDiscountRule : IDiscountRule
    {
        public bool Match(int itemCount)
        {
            return (itemCount >10 && itemCount <= 15);
        }

        public double Discount
        {
            get { return 12; }
        }
    }
}