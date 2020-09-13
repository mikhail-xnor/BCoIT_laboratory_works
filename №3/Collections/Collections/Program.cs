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

            Console.WriteLine("----------------------------------\n");

            ArrayList figureArray = new ArrayList();
            for (int i = 0; i != 20; ++i)
                figureArray.Add(new Square(a.Next()));
            figureArray.Sort();
            for (int i = 0; i != 20; ++i)
                Console.WriteLine(figureArray[i].ToString());

            Console.WriteLine("\n----------------------------------\n");

            List<GeometryFigure> figureList = new List<GeometryFigure>();
            for (int i = 0; i != 20; ++i)
                figureList.Add(new Square(a.Next()));
            figureList.Sort();
            for (int i = 0; i != 20; ++i)
                Console.WriteLine(figureList[i].ToString());

            Console.WriteLine("\n----------------------------------\n");

            SparseMatrix.Matrix<int> x = new SparseMatrix.Matrix<int>(5, 5, 5, 9);
            Console.WriteLine(x.ToString());

            Console.WriteLine("\n----------------------------------\n");

            SimpleStack<GeometryFigure> figureSimpleStack = new SimpleStack<GeometryFigure>();
            for (int i = 0; i != 20; ++i)
                figureSimpleStack.Push(new Square(a.Next()));
            figureSimpleStack.Sort();
            for (int i = 0; i != 20; ++i)
                Console.WriteLine(figureSimpleStack.Pop().ToString());
        }
    }
}
