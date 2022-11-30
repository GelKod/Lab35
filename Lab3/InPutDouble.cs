using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal static class Helper
    {
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
        public static int InPutInt()
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
