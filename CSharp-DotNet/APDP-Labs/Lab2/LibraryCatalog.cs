using System.Collections.Generic;
using System.Linq;
using System;

namespace Lab2._1;

public class LibraryCatalog
{
    private List<LibraryItem> items = new List<LibraryItem>();

    public void AddItem(LibraryItem item)
    {
        items.Add(item);
    }

    public List<LibraryItem> FindItem(string query)
    {
        return items.Where(item => item.title.Contains(query, StringComparison.OrdinalIgnoreCase) || item.author.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("\nLibrary Catalog:");
        foreach (var item in items)
        {
            string type = item.GetType().Name;
            Console.WriteLine($"Type: {type}, Title: {item.title}, Author: {item.author}, Available: {item.available}");
        }
    }

    public List<LibraryItem> Items => items;
}
