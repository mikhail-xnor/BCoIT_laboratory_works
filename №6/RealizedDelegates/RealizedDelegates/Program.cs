using System;
using System.Collections;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;

namespace RealizedDelegates
{
    class Program
    {
        delegate T FirstDelegate<T, Q, W>(Q firstParam, W secondParam);
        delegate T SecondDelegate<T, Q>(params Q[] param);
        static void Main(string[] args)
        {
            FirstDelegate<string, string, int> mCopy;
            mCopy = multiCopy;
            Console.WriteLine("Hello World! " + multiCopyOrConcat(mCopy, 22, "qwerty ") + multiCopyOrConcat(mCopy, 0, "q", "w", "e", "r", "t", "y"));
            FirstDelegate<int, int, int> lmd = (i, j) => (int)Math.Pow(i, j);
            StartDelegate(lmd, 2, 10);
            Action<string, int> actionDelegate = ConsoleOutput;
            StartDelegate(actionDelegate, " Hello, world? ", 4);
            string[] str = new string[1];
            str[0] = "hallo";
            Func<FirstDelegate<string, string, int>, int, string[], string> funcDelegate = multiCopyOrConcat;
            Console.WriteLine(funcDelegate(mCopy, 22, str));
        }
        static void StartDelegate(Action<string, int> method, string str, int copyCount)
        {
            method(str, copyCount);
        }
        static void StartDelegate(FirstDelegate<int, int, int> method, int firstNum, int secondNum)
        {
            Console.WriteLine("\n{0}\n", method(firstNum, secondNum));
        }
        static void ConsoleOutput(string str, int count)
        {
            Console.WriteLine(multiCopy(str, count));
        }
        static string multiCopyOrConcat(FirstDelegate<string, string, int> method, int count = 0, params string[] str) //error
        {
            if (count > 0)
                return method(str[0], count);
            return multiConcat(str);
        }
        static string multiCopy(string strF, int count)
        {
            string strResult = "";
            for (int i = 0; i != count; ++i)
                strResult += strF;
            return strResult;
        }
        static string multiConcat(params string[] strArray)
        {
            string strResult = "";
            foreach (string i in strArray)
                strResult += i;
            return strResult;
        }
    }
}
