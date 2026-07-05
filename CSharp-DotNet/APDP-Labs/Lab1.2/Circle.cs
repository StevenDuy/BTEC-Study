using System;

namespace Lab1._2
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // The area of a circle
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}