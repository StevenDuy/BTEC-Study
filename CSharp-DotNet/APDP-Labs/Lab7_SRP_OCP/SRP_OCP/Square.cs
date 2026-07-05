using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP
{
    public class Square: IShape
    {
        public string ShapeName => "Square";
        public double SideLength { get; set; }
        public Square(double sideLength)
        {
            SideLength = sideLength;
        }
        public double Area()
        {
            return SideLength * SideLength;
        }
    }
}
