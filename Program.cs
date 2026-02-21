using System;
using System.Collections.Generic;

namespace Ecommerceapp
{
    internal class Program
    {
        static List<string> payment = new List<string>();

        static string[] shipping = new string[2];
        static void Main(string[] args)
        {

            AddPayment();
            AddShipping();

            ShowPayment();
            ShowShipping();
        }

        static void AddPayment()
        {
            
            Console.Write("Enter Payment method: ");
            string pay = Console.ReadLine();
            payment.Add(pay);
        }

        static void ShowPayment()
        {
            Console.Write("\n Payment method: ");
            foreach (string p in payment)
            {
                Console.WriteLine(p);
            }
        }

        static void AddShipping()
        {
            for (int i = 0; i < shipping.Length; i++)
            {
                Console.Write("Enter shipping info: ");
                shipping[i] = Console.ReadLine();
            }
        }

        static void ShowShipping()
        {
            Console.WriteLine("\n SHIPPING INFO");
            for (int i = 0; i < shipping.Length; i++)
            {
                Console.WriteLine(shipping[i]);
            }
        }

    }
}
