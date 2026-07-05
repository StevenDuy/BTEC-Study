namespace LSPISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod payment = new CreditCardPayment();
            ILogger logger = new FileLogger();
            INotifier notifier = new EmailNotifier();

            PaymentService service = new PaymentService(payment, logger, notifier);
            service.ProcessPayment(150);
        }

    }
}
