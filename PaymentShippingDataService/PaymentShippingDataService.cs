using System.Collections.Generic;
using PaymentShippingModel;

namespace PaymentShippingDataService
{
    public class PaymentShippingDataService
    {
        private List<Payment> payments = new List<Payment>();
        private List<Shipping> shippings = new List<Shipping>();

        // ================= PAYMENT METHODS =================

        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
        }

      
        public List<Payment> GetPayments()
        {
            return payments;
        }

        
        public bool UpdatePayment(int index, Payment updatedPayment)
        {
            if (index >= 0 && index < payments.Count)
            {
                payments[index] = updatedPayment;
                return true;
            }

            return false;
        }

        public bool DeletePayment(int index)
        {
            if (index >= 0 && index < payments.Count)
            {
                payments.RemoveAt(index);
                return true;
            }

            return false;
        }


        // ================= SHIPPING METHODS =================

        public void AddShipping(Shipping shipping)
        {
            shippings.Add(shipping);
        }

        public List<Shipping> GetShippings()
        {
            return shippings;
        }

        public bool UpdateShipping(int index, Shipping updatedShipping)
        {
            if (index >= 0 && index < shippings.Count)
            {
                shippings[index] = updatedShipping;
                return true;
            }

            return false;
        }

        public bool DeleteShipping(int index)
        {
            if (index >= 0 && index < shippings.Count)
            {
                shippings.RemoveAt(index);
                return true;
            }

            return false;
        }
    }
}