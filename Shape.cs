using System;
namespace CSharp_intermediate
	// Polymorphism (Method overriding) creates loosely coupled design -
	// we can create diff. shapes by simply creatinga new derived class
	// that has absolutely zero impact in our existing classes
{
	public class Circle : Shape
	{
        public override void Draw()
        {
			Console.WriteLine("Draw a circle.");        }
    }

	public class Rectangle : Shape
	{
        public override void Draw()
        {
			Console.WriteLine("Draw a rectangle.");
        }

    }

	public class Triangle : Shape
	{
        public override void Draw()
        {
			Console.WriteLine("Draw a triangle.");
        }
    }

	public class Shape
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public int X { get; set; }
		public int Y { get; set; }

		public virtual void Draw()
		{
		}

	}
}

