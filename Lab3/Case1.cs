using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case1
    {
        public void Exzample()
        {
            Console.Clear();
            Console.WriteLine("У вас 3 попытки");
            Console.WriteLine("\r\nЧему равно значение функции: (cos^7(pi)+sqrt(ln(b^4)))/(sin(pi/2 + a)^2");
            Console.WriteLine("Введите значение a and b: ");
            Console.WriteLine("Введите a");
            double a = Helper.InPutDouble();
            double b = DivisionByZero();
            double f = TheEquation(a, b);
            Happy(f);
            Console.ReadKey();
        }
        public double DivisionByZero()
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
        public void Happy(double f)
        {
            int num;
            for (num = 2; num > -1; num--)
            {
                int c = Helper.InPutInt();
                int otvet = Convert.ToInt32(f);
                if (c == otvet)
                {
                    Console.WriteLine("Ответ правильный!!! =)");
                    Console.ReadKey();
                    num = -4;
                }
                else
                {
                    Console.WriteLine("Ответ не правильный.\r\nПопытки: " + num);
                }
            }
            if (!(num == -5))
            {
                Console.WriteLine("Вы проиграли(((");
                Console.WriteLine("Правильный ответ: " + f + "\r\n");
            }
        }
        public double TheEquation(double l, double c)
        {
            double qwest = (Math.Pow(Math.Cos(Math.PI), 7.0) + Math.Sqrt(Math.Log(Math.Pow(c, 4.0))))
                / (Math.Sin(Math.Pow((Math.PI) / 2.0 + l, 2.0)));
            return qwest;
        }
    }
}
