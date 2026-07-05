namespace SRP_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Shape(new Square(5));
            Console.WriteLine($"Shape: {square.ShapeName}, Area: {square.Area()}");
            Shape circle = new Shape(new Circle(3));
            Console.WriteLine($"Shape: {circle.ShapeName}, Area: {circle.Area()}");
            ILogger fileLogger = new FileLogger();
            ILogger databaseLogger = new DatabaseLogger();

            Logger fileLoggerClient = new Logger(fileLogger);
            Logger databaseLoggerClient = new Logger(databaseLogger);

            fileLoggerClient.Log("This is a log message to a file.");
            databaseLoggerClient.Log("This is a log message to a database.");
            PaymentGateway paymentGateway = new PaymentGateway(new PayPalPayment());
            paymentGateway.MakePayment(100);
        }
    }
}
