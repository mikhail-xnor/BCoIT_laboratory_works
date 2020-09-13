using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    interface IPrint
    {
        void Print();
    }
    abstract class GeometryFigure : IComparable
    {
        public abstract double CalcArea();
        public int CompareTo(object obj)
        {
            GeometryFigure next = obj as GeometryFigure;
            if (CalcArea() < next.CalcArea())
                return -1;
            if (CalcArea() > next.CalcArea())
                return 1;
            return 0;
        }
    }
    class Rectangle : GeometryFigure, IPrint
    {
        public double height { set; get; }
        public double width { set; get; }
        public Rectangle(double _height, double _width)
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
}
