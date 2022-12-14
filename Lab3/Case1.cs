using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class Case1
    {
        /// <summary>
        /// Выполнение задания из Лабораторной работы 1
        /// </summary>
        public static void Exzample()
        {
            Console.Clear();
            Console.WriteLine("У вас 3 попытки");
            Console.WriteLine("\r\nЧему равно значение функции: (cos^7(pi)+sqrt(ln(b^4)))/(sin(pi/2 + a)^2");
            Console.WriteLine("Введите значение a and b: ");
            Console.WriteLine("Введите a");
            double a = Helper.InPutDouble();
            double b = Helper.DivisionByZero();
            double f = TheEquation(a, b);
            Happy(f);
            Console.ReadKey();
        }
        /// <summary>
        /// Игра с угадыванием
        /// </summary>
        /// <param name="f">Ответ задания к 1 лабе</param>
        static void Happy(double f)
        {
            int num;
            for (num = 2; num > -1; num--)
            {
                int c = Helper.InputInt();
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
        /// <summary>
        /// Вычисление примера к 1 лабораторной
        /// </summary>
        /// <param name="l">Переменная а</param>
        /// <param name="c">Переменная б</param>
        /// <returns></returns>
        static double TheEquation(double l, double c)
        {
            double qwest = (Math.Pow(Math.Cos(Math.PI), 7.0) + Math.Sqrt(Math.Log(Math.Pow(c, 4.0))))
                / (Math.Sin(Math.Pow((Math.PI) / 2.0 + l, 2.0)));
            return qwest;
        }
    }
}
