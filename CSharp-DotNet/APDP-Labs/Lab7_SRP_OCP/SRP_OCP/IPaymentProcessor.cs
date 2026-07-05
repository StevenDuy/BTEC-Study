using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP
{
    public interface IPaymentProcessor
    {
        string PaymentMethod { get; }
        void ProcessPayment(decimal amount);
    }
}
