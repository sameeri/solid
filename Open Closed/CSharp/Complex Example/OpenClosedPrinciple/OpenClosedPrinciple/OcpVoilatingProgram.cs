using System;

namespace VoilatingOpenClosedPrinciple
{
    class OcpVoilatingProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, this program voilates the Open/Closed Principle..");
            Console.WriteLine();
            var cart = new SimulateAShoppingCart().Get();
            Console.WriteLine("# of Items in the cart: {0}", cart.GetItemCount());
            foreach (var item in cart.GetItems())
            {
                Console.WriteLine("Item: {0}", item);
            }
            Console.WriteLine();
            Console.WriteLine("Actual Price: {0}",cart.GetTotalAmount());
            Console.WriteLine("Your discount today: {0}%", cart.GetDiscountPercentage());
            Console.WriteLine("Price After discount: {0}", cart.GetPriceAfterDiscount());
            Console.WriteLine("You've Saved: {0}", cart.GetSavings());
            Console.ReadKey();


        }

    }
}
