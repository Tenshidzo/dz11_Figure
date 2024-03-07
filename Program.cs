namespace dz11_Figure
{
    internal class Program
    {
        abstract class GeometricFigure
        {
            public abstract double Area { get; }
            public abstract double Perimeter { get; }
        }
        class Triangle : GeometricFigure
        {
            public double Side1 { get; }
            public double Side2 { get; }
            public double Side3 { get; }
            public double Height { get; }
            public double AngleBetweenBaseAndAdjacentSide { get; }

            public Triangle(double side1, double side2, double side3, double height, double angle)
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
                Height = height;
                AngleBetweenBaseAndAdjacentSide = angle;
            }

            public override double Area
            {
                get
                {
                    return 0.5 * Height * Side1; // Assuming the height is given
                }
            }

            public override double Perimeter
            {
                get
                {
                    return Side1 + Side2 + Side3;
                }
            }
        }

        class Square : GeometricFigure
        {
            public double Side { get; }

            public Square(double side)
            {
                Side = side;
            }

            public override double Area
            {
                get
                {
                    return Side * Side;
                }
            }

            public override double Perimeter
            {
                get
                {
                    return 4 * Side;
                }
            }
        }
        class Rhombus : GeometricFigure
        {
            public double Side { get; }
            public double Diagonal1 { get; }
            public double Diagonal2 { get; }

            public Rhombus(double side, double diagonal1, double diagonal2)
            {
                Side = side;
                Diagonal1 = diagonal1;
                Diagonal2 = diagonal2;
            }

            public override double Area
            {
                get
                {
                    return 0.5 * Diagonal1 * Diagonal2;
                }
            }

            public override double Perimeter
            {
                get
                {
                    return 4 * Side;
                }
            }
        }

        class Rectangle : GeometricFigure
        {
            public double Width { get; }
            public double Height { get; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double Area
            {
                get
                {
                    return Width * Height;
                }
            }

            public override double Perimeter
            {
                get
                {
                    return 2 * (Width + Height);
                }
            }
        }

        class Parallelogram : GeometricFigure
        {
            public double Base { get; }
            public double Height { get; }
            public double Side { get; }

            public Parallelogram(double baseLength, double height, double side)
            {
                Base = baseLength;
                Height = height;
                Side = side;
            }

            public override double Area
            {
                get
                {
                    return Base * Height;
                }
            }

            public override double Perimeter
            {
                get
                {
                    return 2 * (Base + Side);
                }
            }
        }

        class Trapezoid : GeometricFigure
        {
            public double Base1 { get; }
            public double Base2 { get; }
            public double Height { get; }
            public double Side1 { get; }
            public double Side2 { get; }

            public Trapezoid(double base1, double base2, double height, double side1, double side2)
            {
                Base1 = base1;
                Base2 = base2;
                Height = height;
                Side1 = side1;
                Side2 = side2;
            }

            public override double Area
            {
                get
                {
                    return 0.5 * (Base1 + Base2) * Height;
                }
            }

            public override double Perimeter
            {
                get
                {
                    return Base1 + Base2 + Side1 + Side2;
                }
            }
        }

        class Circle : GeometricFigure
        {
            public double Radius { get; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double Area
            {
                get
                {
                    return Math.PI * Radius * Radius;
                }
            }

            public override double Perimeter
            {
                get
                {
                    return 2 * Math.PI * Radius;
                }
            }
        }

        class Ellipse : GeometricFigure
        {
            public double SemiMajorAxis { get; }
            public double SemiMinorAxis { get; }

            public Ellipse(double semiMajorAxis, double semiMinorAxis)
            {
                SemiMajorAxis = semiMajorAxis;
                SemiMinorAxis = semiMinorAxis;
            }

            public override double Area
            {
                get
                {
                    return Math.PI * SemiMajorAxis * SemiMinorAxis;
                }
            }

            public override double Perimeter
            {
                get
                {
                    return 2 * Math.PI * Math.Sqrt((SemiMajorAxis * SemiMajorAxis + SemiMinorAxis * SemiMinorAxis) / 2);
                }
            }
        }
        interface SimpleNPolygon
        {
            double Height { get; }
            double Base { get; }
            double AngleBetweenBaseAndAdjacentSide { get; }
            int NumberOfSides { get; }
            double[] SideLengths { get; }
            double Area { get; }
            double Perimeter { get; }
        }
        class CompositeFigure
        {
            private List<SimpleNPolygon> figures = new List<SimpleNPolygon>();

            public void AddFigure(SimpleNPolygon figure)
            {
                figures.Add(figure);
            }

            public double CalculateArea()
            {
                double area = 0;
                foreach (var figure in figures)
                {
                    area += figure.Area;
                }
                return area;
            }
        }
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5, 3, 90);
            Console.WriteLine("Triangle:");
            Console.WriteLine("Area: " + triangle.Area);
            Console.WriteLine("Perimeter: " + triangle.Perimeter);

            Square square = new Square(5);
            Console.WriteLine("\nSquare:");
            Console.WriteLine("Area: " + square.Area);
            Console.WriteLine("Perimeter: " + square.Perimeter);

            Rhombus rhombus = new Rhombus(6, 8, 5);
            Console.WriteLine("\nRhombus:");
            Console.WriteLine("Area: " + rhombus.Area);
            Console.WriteLine("Perimeter: " + rhombus.Perimeter);

            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine("\nRectangle:");
            Console.WriteLine("Area: " + rectangle.Area);
            Console.WriteLine("Perimeter: " + rectangle.Perimeter);

            Parallelogram parallelogram = new Parallelogram(5, 7, 4);
            Console.WriteLine("\nParallelogram:");
            Console.WriteLine("Area: " + parallelogram.Area);
            Console.WriteLine("Perimeter: " + parallelogram.Perimeter);

            Trapezoid trapezoid = new Trapezoid(3, 7, 4, 5, 6);
            Console.WriteLine("\nTrapezoid:");
            Console.WriteLine("Area: " + trapezoid.Area);
            Console.WriteLine("Perimeter: " + trapezoid.Perimeter);

            Circle circle = new Circle(4);
            Console.WriteLine("\nCircle:");
            Console.WriteLine("Area: " + circle.Area);
            Console.WriteLine("Perimeter: " + circle.Perimeter);

            Ellipse ellipse = new Ellipse(5, 3);
            Console.WriteLine("\nEllipse:");
            Console.WriteLine("Area: " + ellipse.Area);
            Console.WriteLine("Perimeter: " + ellipse.Perimeter);
        }
    }
}
