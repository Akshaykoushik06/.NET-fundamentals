using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public abstract class Shape : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine($"Disposing object {this}");
        }
        public string Name { get; set; }

        public virtual float CalArea()
        {
            return 0f;
        }

        public abstract void Draw();
        public static Shape DecideShape(string input, Shape sh)
        {
            switch (input)
            {
                case "circle":
                    sh = new Circle() { Radius = 5 };
                    break;
                case "rectangle":
                    sh = new Rectangle(10, 5);
                        break;
                case "square":
                    sh = new Square(5);
                    break;
                case "diamond":
                    sh = new Diamond(10, 7, 45);
                    break;
                default:
                    break;
            }
            return sh;
        }
    }

    public class Circle: Shape
    {
        public float Radius { get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Circle drawn with radius: {this.Radius}");
        }
    }

    public class Diamond : Rectangle
    {
        public int Angle { get; set; }
        public Diamond(float length, float breadth, int angle): base(length, breadth)
        {
            this.Angle = angle;
        }
    }

    public class Rectangle: Shape
    {
        public Rectangle(float length, float breadth)
        {
            this.Length = length;
            this.Breadth = breadth;
        }
        public float Length { get; set; }
        public float Breadth { get; set; }
        public override void Draw()
        {
            Console.WriteLine($"Length and Breadth are {this.Length} X {this.Breadth}");
        }
    }

    public class Square : Rectangle
    {
        // calling a specific base class constructor
        public Square(float side): base(side, side)
        {

        }

        // calling another constructor of the same class
        public Square(string name, float side): this(side)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"Side of square is {this.Length}");
        }
    }
}
