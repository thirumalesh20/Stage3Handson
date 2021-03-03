using System;
using System.Runtime.InteropServices;

namespace OptionalParameters
{
   
    class Program
    {
        static void OrderDetails(string Seller, string Product, int Order = 1, bool IsReturnable = true)
        {
            Console.WriteLine($"Here is the order detail – {Order} number of {Product} by {Seller} is ordered. It’s returnable status is {IsReturnable}");
        }
        static void Main(string[] args)
        {
            OrderDetails("Amazon", "Apple Mobile");
            OrderDetails("Flipkart", "Samsung Mobile", 2, true);
            OrderDetails("Ajio", "Otto Shirt", 3, false);
            Console.ReadLine();
        }
    }
}
