using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_OCP
{
    public class Shape
    {
        private readonly IShape _shape;
        public Shape(IShape shape)
        {
            _shape = shape;
        }
        public string ShapeName => _shape.ShapeName;
        public double Area() => _shape.Area();
    }
}
