using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConformingToOpenClosedPrinciple.DiscountRulesBasedOnVolume;

namespace ConformingToOpenClosedPrinciple
{
    class OcpConformingProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, this program conforms to the Open/Closed Principle..");
            Console.WriteLine();

            var cart = new SimulateAShoppingCart().Get();

            Console.WriteLine("# of Items in the cart: {0}", cart.GetItemCount());
            foreach (var item in cart.GetItems())
            {
                Console.WriteLine("Item: {0}", item);
            }
            
            Console.WriteLine();

            //Note that Cart Now doesnt know how to calculate all this stuff.
            //Its just a container for products to checked out.
            //We have successfully identified what varies and seperated that into a new class
                    //            Console.WriteLine("Actual Price: {0}", cart.GetTotalAmount());
                    //            Console.WriteLine("Your discount today: {0}%", cart.GetDiscountPercentage());
                    //            Console.WriteLine("Price After discount: {0}", cart.GetPriceAfterDiscount());
                    //            Console.WriteLine("You've Saved: {0}", cart.GetSavings());


            //Note that we can supply this set of rules via configuration at runtime
            //Strategy can be configured through IoC

            var discountStrategy = new DiscountStrategyBasedOnVolume(new List<IDiscountRule>
                                                                         {
                                                                             new LessThanFiveDiscountRule(),
                                                                             new BetweenFiveAndTenDiscountRule(),
                                                                             new BetweenTenAndFiveteenDiscountRule(),
                                                                             new MoreThanFiveteenDiscountRule()
                                                                         });
            var pricingCalculator = new PricingCalculator(cart, discountStrategy);

            Console.WriteLine("Actual Price: {0}", pricingCalculator.GetTotalAmount());
            Console.WriteLine("Your discount today: {0}%", pricingCalculator.GetDiscountPercentage());
            Console.WriteLine("Price After discount: {0}", pricingCalculator.GetPriceAfterDiscount());
            Console.WriteLine("You've Saved: {0}", pricingCalculator.GetSavings());
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
