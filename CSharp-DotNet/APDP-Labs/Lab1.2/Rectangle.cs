namespace Lab1._2
{
    public class Rectangle : Figure
    {
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        // The area of a rectangle
        public override double Area()
        {
            return width * length;
        }
    }
}