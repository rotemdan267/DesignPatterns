using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public static class Store
    {
        public static void StartShoping(IPayment paymentMethod)
        {
            Console.WriteLine("\n\nWelcome to Anazome! What would you like to buy? (type number between 1-4 and press Enter to confirm)\n" +
    "1. Shirt.        5.00$\n" +
    "2. Pants.        6.50$\n" +
    "3. Laptop.     199.99$\n" +
    "4. iPhone.    1549.25$");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    paymentMethod.Pay(5);
                    break;

                case "2":
                    paymentMethod.Pay(6.5);
                    break;

                case "3":
                    paymentMethod.Pay(199.99);
                    break;

                case "4":
                    paymentMethod.Pay(1549.25);
                    break;

                default:
                    Console.WriteLine("Invalid input. Try again\n\n\n");
                    Store.StartShoping(paymentMethod);
                    break;
            }
        }
    }

   
}
