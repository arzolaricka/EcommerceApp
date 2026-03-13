using System;
using PaymentShippingService;

class Program
{
    static void Main()
    {
        PaymentShippingService.PaymentShippingService service =
            new PaymentShippingService.PaymentShippingService();

        while (true)
        {
            Console.Clear();

            Console.WriteLine("==== PAYMENT & SHIPPING SYSTEM ====\n");

            Console.WriteLine("1. Add Payment");
            Console.WriteLine("2. View Payments");
            Console.WriteLine("3. Update Payment");
            Console.WriteLine("4. Delete Payment");

            Console.WriteLine("\n5. Add Shipping");
            Console.WriteLine("6. View Shipping");
            Console.WriteLine("7. Update Shipping");
            Console.WriteLine("8. Delete Shipping");

            Console.WriteLine("\n9. Exit");

            Console.Write("\nChoice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddPayment();
                    break;

                case 2:
                    service.ViewPayments();
                    break;

                case 3:
                    service.UpdatePayment();
                    break;

                case 4:
                    service.DeletePayment();
                    break;

                case 5:
                    service.AddShipping();
                    break;

                case 6:
                    service.ViewShipping();
                    break;

                case 7:
                    service.UpdateShipping();
                    break;

                case 8:
                    service.DeleteShipping();
                    break;

                case 9:
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    Console.ReadKey(true);
                    break;
            }
        }

    }
}
