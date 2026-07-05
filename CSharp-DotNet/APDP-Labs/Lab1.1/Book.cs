using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    public class Book : Publication
    {
        public string Author { get; set; }

        public Book(string title, decimal price, int copies, string author)
            : base(title, price, copies)
        {
            Author = author;
        }

        public void OrderCopies(int quantity)
        {
            Copies += quantity;
            Console.WriteLine($"Ordered {quantity} copies of '{Title}'. Total copies: {Copies}");
        }

        public override string ToString()
        {
            return base.ToString() + " by " + Author;
        }
    }
}
