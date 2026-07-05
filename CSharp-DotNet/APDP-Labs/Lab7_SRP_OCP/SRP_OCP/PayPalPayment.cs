using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP
{
    public class PayPalPayment: IPaymentProcessor
    {
        public string PaymentMethod => "PayPal";
        public void ProcessPayment(decimal amount)
        {
            // Simulate PayPal payment processing
            Console.WriteLine($"Processing PayPal payment of {amount:C}");
        }
    }
}
