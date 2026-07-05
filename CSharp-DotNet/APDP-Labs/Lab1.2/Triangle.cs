namespace Lab1._2
{
    public class Triangle : Figure
    {
        private double baseLength;
        private double height;

        public Triangle(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        // The area of a triangle
        public override double Area()
        {
            return 0.5 * baseLength * height;
        }
    }
}