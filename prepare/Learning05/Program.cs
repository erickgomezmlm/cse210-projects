using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square01 = new Square("blue", 4);
        shapes.Add(square01);

        Rectangle rectangle01 = new Rectangle("green", 2, 6);
        shapes.Add(rectangle01);

        Circle circle01 = new Circle("yellow", 6);
        shapes.Add(circle01);

        foreach(Shape shape in shapes)
        {
            double area = shape.CalcArea();
            string color = shape.Getcolor();
            
            Console.WriteLine($"The {color} shape has an area of {area}");
        }

        
    }
}
