using System;
using System.Collections.Generic;

namespace Ecommerceapp
{
    internal class Program
    {
        static List<string> payment = new List<string>();

        static string[] shipping = new string[5];
        static int shipCount = 0;
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 7)
            {
                Console.WriteLine("\n ======PAYMENT AND SHIPPING MANAGEMENT======");
                Console.WriteLine("1. Add Payment Method");
                Console.WriteLine("2. View Payment Method");
                Console.WriteLine("3. Update Payment Method");
                Console.WriteLine("4. Add Shipping Info");
                Console.WriteLine("5. View Shipping Info");
                Console.WriteLine("6. Update shipping Info");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddPayment(); break;
                    case 2: ViewPayment(); break;
                    case 3: UpdatePayment(); break;
                    case 4: AddShipping(); break;
                    case 5: ViewShipping(); break;
                    case 6: UpdateShipping(); break;
                }
            }
            
        }
         

        static void AddPayment()
        {
            
            Console.Write("Enter Payment method: ");
            string input = Console.ReadLine();
            payment.Add(input);
            Console.WriteLine("Payment method added successfully. ");
        }

        static void ViewPayment()
        {
            Console.Write("\n Payment method: ");
            if (payment.Count == 0)
            {
                Console.WriteLine("No payment method added yet.");
            }
            else
            {
                for (int i = 0; i < payment.Count; i++)
                {
                    Console.WriteLine(i + " - " + payment[i]);
                }
            }
        }

        static void UpdatePayment()
        {
            ViewPayment();
            if (payment.Count > 0)
            {
                Console.Write("Enter the index of the payment method to update: ");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new payment method: ");
                payment[index] = Console.ReadLine();

                Console.WriteLine("Payment method updated successfully.");
            }
        }

        static void AddShipping()
        {
           if(shipCount < shipping.Length)
            {
                Console.Write("Enter shipping info: ");
                shipping[shipCount] = Console.ReadLine();
                shipCount++;
                Console.WriteLine("Shipping info added successfully.");
            }
            else
            {
                Console.WriteLine("Shipping info limit reached. Cannot add more.");
            }
        }

        static void ViewShipping()
        {
            Console.WriteLine("\n ---SHIPPING INFO---");
            if(shipCount == 0)
            {
                Console.WriteLine("No shipping info added yet.");
            }
            else
            {
                for (int i = 0; i < shipCount; i++)
                {
                    Console.WriteLine(i + " - " + shipping[i]);  
                }
                
            }
        }

        static void UpdateShipping()
        {
            ViewShipping();
            if (shipCount > 0)
            {
                Console.Write("Enter the index of the shipping info to update: ");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new shipping info: ");
                shipping[index] = Console.ReadLine();

                Console.WriteLine("Shipping Info updated successfully.");
            }
        }

    }
}
