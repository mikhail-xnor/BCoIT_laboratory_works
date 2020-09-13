using System;
using System.Linq;
using System.Numerics;
namespace BiquadrateEquationSolver
{
    class Program
    {
        static void Enter(out double coeff, char sym)
        {
            bool validValue = false;
            coeff = 0;
            while (!validValue)
            {
                Console.Write("Enter coefficient " + sym + ": ");
                string coefficient = Console.ReadLine();
                validValue = Double.TryParse(coefficient, out coeff);
            }
        }
        static void StringToCoefficients(string[] args, out double A, out double B, out double C)
        {
            A = B = C = 0;
            if (!Double.TryParse(args[0], out A))
                Enter(out A, 'A');
            while (A == 0)
                Enter(out A, 'A');
            if (args.Length > 1)
            {
                if (!Double.TryParse(args[1], out B))
                    Enter(out B, 'B');
            }
            else
                Enter(out B, 'B');
            if (args.Length > 2)
            {
                if (!Double.TryParse(args[2], out C))
                    Enter(out C, 'C');
            }
            else
                Enter(out C, 'C');
        }
        static int BiEquationSolver(in double A, in double B, in double C, ref double[] solutions)
        {
            double discriminant = B * B - 4 * A * C;
            if (discriminant >= 0)
            {
                discriminant = Math.Sqrt(discriminant);
                double x1 = (-B + discriminant) / 2 / A, x2 = (-B - discriminant) / 2 / A;
                if (x1 < 0 && x2 < 0)
                    return 0;
                else
                {
                    int numOfSolutions = 0;
                    if (x1 > 0)
                    {
                        solutions[numOfSolutions] = Math.Sqrt(x1);
                        solutions[numOfSolutions + 1] = -Math.Sqrt(x1);
                        numOfSolutions += 2;
                    }
                    if (x2 > 0)
                    {
                        solutions[numOfSolutions] = Math.Sqrt(x2);
                        solutions[numOfSolutions + 1] = -Math.Sqrt(x2);
                        numOfSolutions += 2;
                    }
                    if (x1 == 0 || x2 == 0)
                    {
                        solutions[numOfSolutions] = 0;
                        numOfSolutions += 1;
                    }
                    return numOfSolutions;
                }
            }
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Барышников Михаил Игоревич, группа ИУ5-32Б");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            double A = 0, B, C;
            double[] solutions = new double[] { 0, 0, 0, 0 };
            if (args.Length == 0)
            {
                while (A == 0)
                    Enter(out A, 'A');
                Enter(out B, 'B');
                Enter(out C, 'C');
            }
            else
                StringToCoefficients(args, out A, out B, out C);
            int numOfSolutions = BiEquationSolver(in A, in B, in C, ref solutions);
            if (numOfSolutions > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Array.Resize<double>(ref solutions, numOfSolutions);
                Console.WriteLine("Корни уравнения: {0}", String.Join("; ", solutions));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Корней нет!");
            }
            Console.ReadKey();
        }
    }
}
