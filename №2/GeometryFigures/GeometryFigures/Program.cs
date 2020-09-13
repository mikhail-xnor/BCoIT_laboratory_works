using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace GeometryFigures
{
    interface IPrint
    {
        void Print();
    }
    abstract class GeometryFigure
    {
        public abstract double CalcArea();
    }
    class Rectangle : GeometryFigure, IPrint
    {
        protected double height;
        protected double width;
        virtual public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        virtual public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public Rectangle (double _height, double _width)
        {
            height = _height;
            width = _width;
        }
        public override double CalcArea()
        {
            return height * width;
        }
        public override string ToString()
        {
            return "Высота: " + height.ToString() + "; ширина: " + width.ToString();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
    class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }
        public override double Width
        {
            get
            {
                return width;
            }
            set
            {
                height = value;
                width = value;
            }
        }
        public override double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                width = value;
            }
        }
        public double side 
        { 
            get
            { 
                return height; 
            } 
            set 
            {
                height = value;
                width = value;
            } 
        }
        public override string ToString()
        {
            return "Сторона: " + height.ToString();
        }
    }
    class Circle : GeometryFigure, IPrint
    {
        public double radius { set; get; }
        public Circle(double _radius)
        {
            radius = _radius;
        }
        public override double CalcArea()
        {
            return Math.PI * radius * radius;
        }
        public override string ToString()
        {
            return "Радиус: " + radius.ToString();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(1, 2);
            Square sq = new Square(10);
            Circle cir = new Circle(22);

            sq.Width = 22;
            sq.Height = 1;
            sq.side = 14;

            Console.WriteLine("Hello World!" + sq.CalcArea().ToString());
            rect.Print();
            sq.Print();
            cir.Print();
            rect = sq;
            rect.Print();
        }
    }
}
