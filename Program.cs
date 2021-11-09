using System;

namespace Homework_5._5_Task_1
{
    class Program
    {
        static string[] SplitArray(string Arg)
        {

            string[] arrSplited = Arg.Split(' ');
            return arrSplited;
        }

        static void ArrayReverse(string[] Arg)
        {
            int i = Arg.Length;
            for (i = Arg.Length - 1; i > -1; i--)
            {
                Console.Write($"{Arg[i]} ");
            }
        }

        static void Main(string[] args)
        {

            string str;

            Console.WriteLine("Введите несколько слов, разделённых пробелом");
            str = Console.ReadLine();

            Console.WriteLine();
            ArrayReverse(SplitArray(str));


            Console.ReadKey();
        }
    }
}
