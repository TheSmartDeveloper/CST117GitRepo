using System;
using System.Collections.Generic;
using System.IO;

abstract class TriangleAbs
{
	protected double _perimeter;
	protected double _area;
}

class Triangle : TriangleAbs
{
	public Triangle()
	{
		
	}
	public Triangle(double length, double width, double side3)
	{
		_perimeter = length + width + side3;
		_area = (length * width) / 2;
		Console.WriteLine("If the length is: " + length + " and the width is: " + width + " and the third side is: " + side3 + ". The perimeter of a Triangle is: " + _perimeter + ", and the area of a triangle is: " + _area);
	}
}

abstract class CircleAbs
{
	protected double _circumference;
	protected double _area;
	protected const double PI = 3.141592654;
}

class Circle : CircleAbs
{
	public Circle()
	{
		
	}
	public Circle(int radius)
	{
		_area = PI * Math.Pow(radius,2);
		_circumference = (2 * PI) * radius;
		Console.WriteLine("If the radius is: " + radius + ". Then the area is: " + _area + " and the circumference is: " + _circumference);
	}
}

abstract class SquareAbs
{
	protected double _perimeter;
    protected double _area;
}

class Square : SquareAbs
{
	public Square()
	{
		
	}
    public Square(double length)
	{
		_area = length * length;
		_perimeter = length * 4;
		Console.WriteLine("If the length is: " + length + ". Then the area is: " + _area + " and the perimeter is: " + _perimeter);
	}
}

abstract class RectangleAbs
{
	protected double _perimeter;
    protected double _area;
}

class Rectangle : RectangleAbs
{
	public Rectangle()
	{
		
	}
	public Rectangle(double length, double width)
	{
		_area = length * width;
		_perimeter = (length * 2) + (width * 2);
		Console.WriteLine("If the length is: " + length + " and the width is: " + width + ". Then the area is: " + _area + " and the perimeter is: " + _perimeter);
	}
}

abstract class PentagonAbs
{
	protected double _perimeter;
    protected double _area;
}

class Pentagon : PentagonAbs
{
	public Pentagon()
	{
		
	}

	public Pentagon(int sideLength)
	{
		_area = (Math.Pow(sideLength, 2) * 5) / (4 * Math.Tan(180 / 5));
		_perimeter = sideLength * 5;
		Console.WriteLine("If the side length is: " + sideLength + ". Then the area is: " + _area + " and the perimeter is: " + _perimeter);
	}
}

abstract class SeptagonAbs
{
	public abstract void perimeter(double width, double height);
    public abstract void area(double width, double height);
}

class Septagon : SeptagonAbs
{
	public override void area(double width, double height)
    {
        throw new NotImplementedException();
    }

	public override void perimeter(double width, double height)
    {
        throw new NotImplementedException();
    }
}

class MainController
{
	public static void Main(string[] args)
	{
		Triangle Tri1 = new Triangle(10, 20, 30);
		Circle Circ1 = new Circle(6);
		//Circle PizzaSize18 = new Circle(9);
		Square Squ1 = new Square(7);
		Rectangle Rect1 = new Rectangle(2, 4);
		Pentagon pent1 = new Pentagon(7);
		Console.ReadKey();  //keeps the terminal open until a button is pressed
	}
}