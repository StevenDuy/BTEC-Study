using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    public class Magazine : Publication
    {
        public int OrderQty { get; set; }
        public int CurrentIssue { get; set; }

        public Magazine(string title, decimal price, int copies, int orderQty, int currentIssue)
            : base(title, price, copies)
        {
            OrderQty = orderQty;
            CurrentIssue = currentIssue;
        }

        public void AdjustQty(int adjustment)
        {
            Copies += adjustment;
            Console.WriteLine($"Adjusted quantity of '{Title}' by {adjustment}. Total copies: {Copies}");
        }

        public void RecNewIssue()
        {
            CurrentIssue++;
            Console.WriteLine($"Recorded a new issue of '{Title}'. Current issue: {CurrentIssue}");
        }

        public override string ToString()
        {
            return base.ToString() + " (" + CurrentIssue + ")";
        }
    }
}
