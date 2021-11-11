using System;

namespace Homework_5._5_Task_2
{
    class Program
    {
        /// <summary>
        /// Метод разделения предложения по словам
        /// </summary>
        /// <param name="Arg">строка для разделения</param>
        /// <returns></returns>
        static string[] SplitArray(string Arg)
        {

            string[] arrSplited = Arg.Split(' ');
            return arrSplited;
        }

        /// <summary>
        /// Метод перестановки слов в предложении
        /// </summary>
        /// <param name="Arg">входной массив для разделения</param>
        static string[] ArrayReverse(string[] Arg)
        {
            Array.Reverse(Arg);
            return (Arg);
        }

        /// <summary>
        /// Метод вывода содержимого массива на экран
        /// </summary>
        /// <param name="Arg">входной массив для вывода</param>
        static void DisplayArray(string[] Arg)
        {
            for (int i = 0; i < Arg.Length; i++)
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
            DisplayArray(ArrayReverse(SplitArray(str)));


            Console.ReadKey();
        }
    }
}
