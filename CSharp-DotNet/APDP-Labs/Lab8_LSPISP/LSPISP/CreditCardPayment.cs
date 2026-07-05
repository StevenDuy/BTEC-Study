using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPISP
{
    public class CreditCardPayment: IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            // Logic to process credit card payment
            Console.WriteLine($"Paid {amount} via CreditCardPayment");
        }
    }
}
