namespace Lab2._1;

class Program
{
    static void Main(string[] args)
    {
        LibraryCatalog catalog = new LibraryCatalog();
        catalog.AddItem(new Book("The Great Gatsby", "F. Scott Fitzgerald", "1925", "Fiction"));
        catalog.AddItem(new Book("1984", "George Orwell", "1949", "Dystopian"));
        catalog.AddItem(new DVD("Inception", "Christopher Nolan", "2010", 148));
        catalog.AddItem(new DVD("The Matrix", "Wachowski Sisters", "1999", 136));

        while (true)
        {
            catalog.DisplayCatalog();
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Find item");
            Console.WriteLine("2. Check out item");
            Console.WriteLine("3. Return item");
            Console.WriteLine("4. Exit");
            Console.Write("Select option: ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Enter title or author to search: ");
                string query = Console.ReadLine();
                var found = catalog.FindItem(query);
                if (found.Count == 0)
                    Console.WriteLine("No items found.");
                else
                    foreach (var item in found)
                        Console.WriteLine($"Found: {item.GetType().Name} - {item.title} by {item.author}, Available: {item.available}");
            }
            else if (option == "2" || option == "3")
            {
                Console.Write("Enter exact title of item: ");
                string title = Console.ReadLine();
                var item = catalog.Items.Find(i => i.title.Equals(title, StringComparison.OrdinalIgnoreCase));
                if (item == null)
                {
                    Console.WriteLine("Item not found.");
                    continue;
                }
                bool result = option == "2" ? item.checkout() : item.return_item();
                Console.WriteLine(result ? "Operation successful." : "Operation failed (maybe already checked out/returned).");
            }
            else if (option == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}