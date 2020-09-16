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
            return "Высота: " + height.ToString() + "; ширина: " + width.ToString() + "; площадь: " + CalcArea().ToString();
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
            return "Сторона: " + height.ToString() + "; площадь: " + CalcArea().ToString();
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
            return "Радиус: " + radius.ToString() + "; площадь: " + CalcArea().ToString();
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
            Rectangle rect = new Rectangle(2, 512);
            Console.WriteLine("Прямоугольник с параметрами: {0}", rect.ToString());
            rect = new Rectangle(8, 256);
            Console.WriteLine("Прямоугольник с параметрами: {0}", rect.ToString());
            rect = new Rectangle(128, 64);
            Console.WriteLine("Прямоугольник с параметрами: {0}\n", rect.ToString());
            Square sq = new Square(32);
            Console.WriteLine("Квадарт с параметрами: {0}", sq.ToString());
            sq = new Square(256);
            Console.WriteLine("Квадарт с параметрами: {0}", sq.ToString());
            sq = new Square(1024);
            Console.WriteLine("Квадарт с параметрами: {0}\n", sq.ToString());
            Circle cir = new Circle(16);
            Console.WriteLine("Круг с параметрами: {0}", cir.ToString());
            cir = new Circle(256);
            Console.WriteLine("Круг с параметрами: {0}", cir.ToString());
            cir = new Circle(1024);
            Console.WriteLine("Круг с параметрами: {0}", cir.ToString());
            cir = new Circle(25.5323059456916913);
            Console.WriteLine("Круг с параметрами: {0}", cir.ToString());
            Console.ReadKey();
        }
    }
}
