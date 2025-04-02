using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }

        public virtual void Draw(int x)
        {
            Console.WriteLine($"Drawing a Shape with size {x} units");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }

        public override void Draw(int x)
        {
            Console.WriteLine($"Drawing a Circle with radius {x}cm");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle");
        }
    }
}
