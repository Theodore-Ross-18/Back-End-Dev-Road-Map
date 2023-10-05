using System.Security.Cryptography.X509Certificates;
 
public class Shape
{
    protected Location c;
 
    public string ToString()
    {
        return string.Empty;
    }
 
    public double Area()
    {
        return 0.000;
    }
 
    public double Perimeter()
    {
        return 0.000;
    }
}
 
public class Location
{
    private double x, y;
    public double X { get { return x; } set { x = value; } }
    public double Y
    {
        get { return y; }
        set { y = value; }
    }
}
 
    public class Rectangle : Shape
    {
        protected double side1, side2;
 
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Side1 { get { return side1; } set { side1 = value; } }
        public double Side2 { get { return side2; } set { side2 = value; } }
        public double Area()
        {
            return this.side1 * this.side2;
        }
        public double Perimeter()
        {
            return 2 + (this.side1 + this.side2);
        }
        public void ToString()
        {
        Console.WriteLine("RECTANGLE PROPERTIES");
            Console.WriteLine($"Area is {Area()}");
            Console.WriteLine($"Perimeter is {Perimeter()}");
        }
 
    }
 
    public class Circle : Shape
    {
        protected double radius;
        public Circle(double radius)
        {
            this.radius = radius;
 
        }
        public double Radius { get { return radius; } set { radius = value; } }
 
        public double Area()
        {
            return Math.PI * (radius * radius);
        }
        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public void ToString()
        {
        Console.WriteLine("CIRCLE PROPERTIES:");
            Console.WriteLine($"Area is {Area()}");
            Console.WriteLine($"Perimeter is {Perimeter()}");
        }
    }
 
    public class ShapeTest
    {
        public static void Main(string[] args)
        {
            Circle c1 = new Circle(3.45);
            c1.ToString();
            Rectangle r1 = new Rectangle(5.67, 10.5);
            r1.ToString();
        Console.ReadKey();
        }
    }
