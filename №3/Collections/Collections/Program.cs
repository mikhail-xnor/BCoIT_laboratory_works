using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();

            Console.WriteLine("ArrayList заполненый Square с стороной выбранной случайно");
            Console.WriteLine("----------------------------------\n");

            ArrayList figureArray = new ArrayList();
            for (int i = 0; i != 20; ++i)
                figureArray.Add(new Square(a.Next(10, 500)));
            figureArray.Sort();
            for (int i = 0; i != 20; ++i)
                Console.WriteLine(figureArray[i].ToString());

            Console.WriteLine("\nList заполненый Square с стороной выбранной случайно");
            Console.WriteLine("----------------------------------\n");

            List<GeometryFigure> figureList = new List<GeometryFigure>();
            for (int i = 0; i != 20; ++i)
                figureList.Add(new Square(a.Next(100, 200)));
            figureList.Sort();
            for (int i = 0; i != 20; ++i)
                Console.WriteLine(figureList[i].ToString());

            Console.WriteLine("\nMatrix заполненая");
            Console.WriteLine("----------------------------------\n");

            SparseMatrix.Matrix<GeometryFigure> x = new SparseMatrix.Matrix<GeometryFigure>(5, 5, 5, new Square(5));
            Console.WriteLine(x.ToString());

            Console.WriteLine("\nSimpleStack заполненый Square с стороной выбранной случайно");
            Console.WriteLine("----------------------------------\n");

            SimpleStack<GeometryFigure> figureSimpleStack = new SimpleStack<GeometryFigure>();
            for (int i = 0; i != 20; ++i)
                figureSimpleStack.Push(new Square(a.Next(700, 10000)));
            figureSimpleStack.Sort();
            for (int i = 0; i != 20; ++i)
                Console.WriteLine(figureSimpleStack.Pop().ToString());
        }
    }
}
