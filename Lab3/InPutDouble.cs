using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal static class Helper
    {
        /// <summary>
        /// Ввод числа типа double
        /// </summary>
        /// <returns></returns>
        public static double InPutDouble()
        {
            double a = 0;
            bool chek = false;
            while (!chek)
            {
                Console.Write("Ввод: ");
                chek = double.TryParse(Console.ReadLine(), out a);
                if (!chek)
                {
                    Console.WriteLine("Вы ввели не число!!!");
                }
            }
            return a;
        }

        /// <summary>
        /// Ввод числа с проверкой (без 0, не символ)
        /// </summary>
        /// <returns></returns>
        public static double DivisionByZero()
        {
            double b = 0;
            bool chek = false;
            while (!chek)
            {
                try
                {
                    chek = true;
                    Console.WriteLine("Введите б не равное 0");
                    b = Helper.InPutDouble();
                    int perevod = Convert.ToInt32(b);
                    int result = 5 / perevod;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Вы ввели 0 что делать нельзя!!!");
                    chek = false;
                }
            }
            return b;
        }
        /// <summary>
        /// Ввод числа типа int с ограничением влево и вправо
        /// </summary>
        /// <param name="left">Ограничение влево</param>
        /// <param name="right">Ограничение вправо</param>
        /// <returns></returns>
        public static int InputInt(int left, int right)
        {
            int a = 0;
            bool chek = false;
            while (!chek)
            {
                Console.Write("Ввод: ");
                chek = int.TryParse(Console.ReadLine(), out a);
                if (!chek)
                {
                    Console.WriteLine("Вы ввели не число!!!");
                }
                else if (a>right||a<left)
                {
                    chek = false;
                }
            }
            return a;
        }
        /// <summary>
        /// Ввод числа типа int с ограничением влево
        /// </summary>
        /// <param name="left">Ограничение влево</param>
        /// <returns></returns>
        public static int InputInt(int left)
        {
            int a = 0;
            bool chek = false;
            while (!chek)
            {
                Console.Write("Ввод: ");
                chek = int.TryParse(Console.ReadLine(), out a);
                if (!chek)
                {
                    Console.WriteLine("Вы ввели не число!!!");
                }
                else if (a < left)
                {
                    chek = false;
                }
            }
            return a;
        }
        /// <summary>
        /// Ввод числа типа int с ограничением вправо
        /// </summary>
        /// <param name="right">Ограничение вправо</param>
        /// <returns></returns>
        public static int InputIntR(int right)
        {
            int a = 0;
            bool chek = false;
            while (!chek)
            {
                Console.Write("Ввод: ");
                chek = int.TryParse(Console.ReadLine(), out a);
                if (!chek)
                {
                    Console.WriteLine("Вы ввели не число!!!");
                }
                else if (a > right)
                {
                    chek = false;
                }
            }
            return a;
        }
        /// <summary>
        /// Ввод числа типа int без ограничений
        /// </summary>
        /// <returns></returns>
        public static int InputInt()
        {
            int a = 0;
            bool chek = false;
            while (!chek)
            {
                Console.Write("Ввод: ");
                chek = int.TryParse(Console.ReadLine(), out a);
                if (!chek)
                {
                    Console.WriteLine("Вы ввели не число!!!");
                }
            }
            return a;
        }
    }
}
