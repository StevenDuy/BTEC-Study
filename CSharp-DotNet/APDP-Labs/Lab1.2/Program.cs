namespace Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[]
            {
                new Triangle(5, 4),
                new Circle(3),
                new Rectangle(6, 4)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Area of {figure.GetType().Name}: {figure.Area()}");
            }
        }
    }
}