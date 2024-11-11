using System;

namespace ComplexityAndMaintenance
{
    public class OrderProcessor
    {
        public void ProcessOrder(int orderId, string paymentMethod, string address, string phone, bool isExpress)
        {
            // Complex processing logic
            if (orderId <= 0 || string.IsNullOrEmpty(paymentMethod))
            {
                Console.WriteLine("Invalid order data.");
                return;
            }

            switch (paymentMethod.ToLower())
            {
                case "credit":
                    Console.WriteLine("Processing credit card payment...");
                    break;
                case "debit":
                    Console.WriteLine("Processing debit card payment...");
                    break;
                case "paypal":
                    Console.WriteLine("Processing PayPal payment...");
                    break;
                default:
                    Console.WriteLine("Unknown payment method.");
                    break;
            }

            if (!string.IsNullOrEmpty(address))
            {
                if (address.Length < 10)
                {
                    Console.WriteLine("Address is too short.");
                }
                else if (address.Length > 100)
                {
                    Console.WriteLine("Address is too long.");
                }
            }

            if (!string.IsNullOrEmpty(phone) && phone.Length != 10)
            {
                Console.WriteLine("Invalid phone number.");
            }

            if (isExpress)
            {
                Console.WriteLine("Express shipping selected.");
            }
        }
    }
}
