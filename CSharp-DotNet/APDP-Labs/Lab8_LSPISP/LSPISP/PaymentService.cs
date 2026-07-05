using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPISP
{
    public class PaymentService
    {
        private readonly IPaymentMethod _paymentMethod;
        private readonly ILogger _logger;
        private readonly INotifier _notifier;

        public PaymentService(IPaymentMethod paymentMethod, ILogger logger, INotifier notifier)
        {
            _paymentMethod = paymentMethod;
            _logger = logger;
            _notifier = notifier;
        }
        public void ProcessPayment(decimal amount)
        {
            _paymentMethod.Pay(amount);
            _logger.Log($"Payment completed successfully. ");
            _notifier.Notify("Payment confirmation sent to user. ");
        }
    }
}
