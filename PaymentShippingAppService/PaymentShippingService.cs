using System;
using PaymentShippingDataService;
using PaymentShippingModel;

namespace PaymentShippingService
{
    public class PaymentShippingService
    {
        PaymentShippingDataService.PaymentShippingDataService data =
            new PaymentShippingDataService.PaymentShippingDataService();

        string[] paymentOptions = { "Cash", "GCash", "Credit Card", "PayPal" };

        public void AddPayment()
        {
            Console.Clear();
            Console.WriteLine("==== ADD PAYMENT ====\n");

            for (int i = 0; i < paymentOptions.Length; i++)
            {
                Console.WriteLine(i + " - " + paymentOptions[i]);
            }

            Console.Write("\nEnter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 0 && choice < paymentOptions.Length)
            {
                string method = paymentOptions[choice];
                string name = "";
                string number = "";

                Console.WriteLine("\nSelected: " + method);

                if (method == "GCash")
                {
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();

                    Console.Write("Enter GCash Number: ");
                    number = Console.ReadLine();
                }
                else if (method == "Credit Card")
                {
                    Console.Write("Enter Card Holder Name: ");
                    name = Console.ReadLine();

                    Console.Write("Enter Card Number: ");
                    number = Console.ReadLine();
                }
                else if (method == "PayPal")
                {
                    Console.Write("Enter PayPal Email: ");
                    number = Console.ReadLine();
                    name = "PayPal User";
                }
                else
                {
                    name = "N/A";
                    number = "N/A";
                }

                data.AddPayment(new Payment(method, name, number));

                Console.WriteLine("\nPayment added successfully!");
            }

            Console.ReadKey(true);
        }

        public void ViewPayments()
        {
            Console.Clear();
            Console.WriteLine("==== PAYMENT LIST ====\n");

            var payments = data.GetPayments();

            if (payments.Count == 0)
            {
                Console.WriteLine("No payment records.");
                Console.ReadKey(true);
                return;
            }

            for (int i = 0; i < payments.Count; i++)
            {
                Console.WriteLine(i + " | " +
                    payments[i].Method + " | " +
                    payments[i].AccountName + " | " +
                    payments[i].AccountNumber);
            }

            Console.ReadKey(true);
        }

        public void UpdatePayment()
        {
            Console.Clear();
            Console.WriteLine("==== UPDATE PAYMENT ====\n");

            var payments = data.GetPayments();

            if (payments.Count == 0)
            {
                Console.WriteLine("No payment records.");
                Console.ReadKey(true);
                return;
            }

            for (int i = 0; i < payments.Count; i++)
            {
                Console.WriteLine(i + " - " + payments[i].Method);
            }

            Console.Write("\nEnter index to update: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSelect new payment method:");

            for (int i = 0; i < paymentOptions.Length; i++)
            {
                Console.WriteLine(i + " - " + paymentOptions[i]);
            }

            Console.Write("\nEnter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 0 && choice < paymentOptions.Length)
            {
                string method = paymentOptions[choice];
                string name = "";
                string number = "";

                if (method == "GCash")
                {
                    Console.Write("Enter Name: ");
                    name = Console.ReadLine();

                    Console.Write("Enter GCash Number: ");
                    number = Console.ReadLine();
                }
                else if (method == "Credit Card")
                {
                    Console.Write("Enter Card Holder Name: ");
                    name = Console.ReadLine();

                    Console.Write("Enter Card Number: ");
                    number = Console.ReadLine();
                }
                else if (method == "PayPal")
                {
                    Console.Write("Enter PayPal Email: ");
                    number = Console.ReadLine();
                    name = "PayPal User";
                }
                else
                {
                    name = "N/A";
                    number = "N/A";
                }

                data.UpdatePayment(index, new Payment(method, name, number));

                Console.WriteLine("\nPayment updated.");
            }

            Console.ReadKey(true);
        }

        public void DeletePayment()
        {
            Console.Clear();
            Console.WriteLine("==== DELETE PAYMENT ====\n");

            var payments = data.GetPayments();

            if (payments.Count == 0)
            {
                Console.WriteLine("No payment records.");
                Console.ReadKey(true);
                return;
            }

            for (int i = 0; i < payments.Count; i++)
            {
                Console.WriteLine(i + " - " + payments[i].Method);
            }

            Console.Write("\nEnter index to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());

            data.DeletePayment(index);

            Console.WriteLine("\nPayment deleted.");
            Console.ReadKey(true);
        }

        public void AddShipping()
        {
            Console.Clear();
            Console.WriteLine("==== ADD SHIPPING ====\n");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            data.AddShipping(new Shipping(name, address));

            Console.WriteLine("\nShipping added successfully!");
            Console.ReadKey(true);
        }

        public void ViewShipping()
        {
            Console.Clear();
            Console.WriteLine("==== SHIPPING LIST ====\n");

            var list = data.GetShippings();

            if (list.Count == 0)
            {
                Console.WriteLine("No shipping records.");
                Console.ReadKey(true);
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + " | " + list[i].Name + " | " + list[i].Address);
            }

            Console.ReadKey(true);
        }

        public void UpdateShipping()
        {
            Console.Clear();
            Console.WriteLine("==== UPDATE SHIPPING ====\n");

            var list = data.GetShippings();

            if (list.Count == 0)
            {
                Console.WriteLine("No shipping records.");
                Console.ReadKey(true);
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + " | " + list[i].Name + " | " + list[i].Address);
            }

            Console.Write("\nEnter index to update: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new name: ");
            string name = Console.ReadLine();

            Console.Write("Enter new address: ");
            string address = Console.ReadLine();

            data.UpdateShipping(index, new Shipping(name, address));

            Console.WriteLine("\nShipping updated.");
            Console.ReadKey(true);
        }

        public void DeleteShipping()
        {
            Console.Clear();
            Console.WriteLine("==== DELETE SHIPPING ====\n");

            var list = data.GetShippings();

            if (list.Count == 0)
            {
                Console.WriteLine("No shipping records.");
                Console.ReadKey(true);
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i + " | " + list[i].Name + " | " + list[i].Address);
            }

            Console.Write("\nEnter index to delete: ");
            int index = Convert.ToInt32(Console.ReadLine());

            data.DeleteShipping(index);

            Console.WriteLine("\nShipping deleted.");
            Console.ReadKey(true);
        }
    }
}