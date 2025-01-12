namespace _16_Circle_are_and_radius
{
    /// <summary>
    /// A circle class
    /// </summary>
    public class Circle
    {
        int radius;
        float area;
        /// <summary>
        /// Constructor to initialize the radius and calculate the area
        /// </summary>
        /// <param name="radius"></param>
        public Circle(int radius)
        {
            this.radius = radius;
            area = MathF.PI * MathF.Pow(radius, 2);
        }
        /// <summary>
        /// Method to get radius of the circle
        /// </summary>
        public int Radius
        {
            get { return radius; }
        }
        /// <summary>
        /// Method to get area of the circle
        /// </summary>
        public float Area
        {
            get { return area; }
        }
        static void Main(string[] args)
        {
            // create circle objects
            Circle circle0 = new Circle(0);
            Circle circle1 = new Circle(1);
            Circle circle2 = new Circle(2);
            Circle circle3 = new Circle(3);
            Circle circle4 = new Circle(4);
            Circle circle5 = new Circle(5);

            // print object info
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle0.Radius, circle0.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle1.Radius, circle1.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle2.Radius, circle2.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle3.Radius, circle3.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle4.Radius, circle4.Area);
            Console.WriteLine("Radius: {0}, Area: {1,5:N2}",
            circle5.Radius, circle5.Area);
        }
    }
}
