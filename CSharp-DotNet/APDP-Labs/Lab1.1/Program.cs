namespace Lab1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("C# Programing", 2.99m, 10, "John doe");
            book.SellCopy();
            book.OrderCopies(5);
            Console.WriteLine(book.ToString());

            Magazine magazine = new Magazine("National Geographic", 5.99m, 20, 15, 42);
            magazine.SellCopy();
            magazine.AdjustQty(10);
            magazine.RecNewIssue();
            Console.WriteLine(magazine.ToString());
        }
    }
}