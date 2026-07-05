using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPISP
{
    public class PayPalPayment: IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            // Implementation for PayPal payment processing
            Console.WriteLine($"Paid {amount} via PayPalPayment");
        }
    }
}
