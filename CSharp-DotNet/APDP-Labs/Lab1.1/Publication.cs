using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    public class Publication
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Copies { get; set; }

        public Publication(string title, decimal price, int copies)
        {
            Title = title;
            Price = price;
            Copies = copies;
        }

        public void SellCopy()
        {
            if (Copies > 0)
            {
                Copies--;
                Console.WriteLine($"Sold a copy of '{Title}'. Remaining copies: {Copies}");
            }
            else
            {
                Console.WriteLine($"'{Title}' is out of stock.");
            }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
