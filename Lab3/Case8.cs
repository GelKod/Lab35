using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case8
    {
        const string line = "1 - Посчитать количество строчных и прописных букв в строке (отдельно).\r\n" +
                    "4 - Посчитать количество знаков препинания в строке.\r\n" +
                    "8 - Вывести на экран, сколько первых символов этих строк совпадают.";
        const string line2 = "1 - Использовать текст из методички\r\n2 - Ввести свой текст";
        /// <summary>
        /// Задиние для 6 лабораторной работы
        /// </summary>
        public void CharNumber()
        {
            
            bool reload = false;
            while (!reload)
            {
                Console.Clear();
                reload = true;
                Console.WriteLine(line);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        N1();
                        break;
                    case ConsoleKey.D4:
                        N2();
                        break;
                    case ConsoleKey.D8:
                        N3();
                        break;
                    default:
                        Err er1 = new Err();
                        er1.Error();
                        reload = false;
                        break;
                }
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Выполнение 8 номера
        /// </summary>
        /// <param name="stroka">Первая строчка</param>
        /// <param name="stroka2">Вторая строчка</param>
        public void Number3(string stroka, string stroka2)
        {
            int shodstva = 0;
            char[] mas2 = stroka.ToCharArray();
            char[] mas3 = stroka2.ToCharArray();
            if (mas2.Length <= mas3.Length)
            {
                shodstva=Count(mas2, mas3);
            }
            else
            {
                shodstva=Count(mas3, mas2);
            }
            Console.WriteLine();
            Console.WriteLine("Oтвет: " + shodstva);

        }
        /// <summary>
        /// Выполнение 4 номера
        /// </summary>
        /// <param name="stroka">Строчка с текстом</param>
        public void Number2(string stroka)
        {
            int prepinaniya = 0;
            char[] mas = stroka.ToCharArray();
            for (int i = 0; i < mas.Length; i++)
            {   
                if (char.IsPunctuation(mas[i]))
                {
                    prepinaniya++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Oтвет: " + prepinaniya);
        }
        /// <summary>
        /// Выполнение 1 номера
        /// </summary>
        /// <param name="stroka">Строчка с текстом</param>
        public void Number1(string stroka)
        {
            int propis = 0, stroch = 0;
            char[]mas = stroka.ToCharArray();
            for (int i = 0; i < mas.Length; i++)
            {
                if (char.IsLower(mas[i]))
                {
                    propis++;
                }
                else if (char.IsUpper(mas[i]))
                {
                    stroch++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Заглавных: " +stroch + "\r\nПрописных: " + propis);
        }
        /// <summary>
        /// Задание 1 для 6 лабораторной работы
        /// </summary>
        public void N1()
        {
            Console.Clear();
            int[] arr = { 0, 0 };
            Console.WriteLine(line2);
            string oneNumber = Txt();
            Console.WriteLine("Текст из методички: ");
            Console.WriteLine(oneNumber);
            bool choos = false;
            while (!choos)
            {
                choos = true;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Number1(oneNumber);
                        break;
                    case ConsoleKey.D2:
                        oneNumber = Console.ReadLine();
                        Number1(oneNumber);
                        break;
                    default:
                        choos = false;
                        break;
                }
            }
        }
        /// <summary>
        /// Задание 4 для 6 лабораторной работы
        /// </summary>
        public void N2()
        {
            Console.Clear();
            int prepinaniya = 0;
            Console.WriteLine(line2);
            bool choos = false;
            string oneNumber = Txt();
            Console.WriteLine("Текст из методички: ");
            Console.WriteLine(oneNumber);
            while (!choos)
            {
                choos = true;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Number2(oneNumber);
                        break;
                    case ConsoleKey.D2:
                        oneNumber = Console.ReadLine();
                        Number2(oneNumber);
                        break;
                    default:
                        choos = false;
                        break;
                }
            }
        }
        /// <summary>
        /// Задание 8 для 6 лабораторной работы
        /// </summary>
        public void N3()
        {
            Console.Clear();
            Console.WriteLine(line2);
            int shodstva = 0;
            string firstTwoNumber = "Быть может, вся Природа\r\n– мозаика цветов?";
            string secondTwoNumber = "Быть может, вся Природа\r\n– различность голосов?";
            Console.WriteLine("Текст из методички: ");
            Console.WriteLine(firstTwoNumber);
            Console.WriteLine(secondTwoNumber);
            bool choos = false;
            while (!choos)
            {
                choos = true;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Number3(firstTwoNumber, secondTwoNumber);
                        break;
                    case ConsoleKey.D2:
                        firstTwoNumber = Console.ReadLine();
                        secondTwoNumber = Console.ReadLine();
                        Number3(firstTwoNumber, secondTwoNumber);
                        break;
                    default :
                        choos = false;
                        break;
                }
            }
        }
        /// <summary>
        /// Текст для первого задания
        /// </summary>
        /// <returns></returns>
        public string Txt()
        {
            string text = "Варкалось. Хливкие шорьки\r\nПырялись по наве,\r\n" +
                "И хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\n" +
                "Он так свирлеп и дик,\r\nА в глуще рымит исполин - Злопастный Брандашмыг.";
            return text;
        }
        /// <summary>
        /// Нахождение количества одинаковых символов в 2 строках
        /// </summary>
        /// <param name="arr">первая строчка</param>
        /// <param name="arr2">Вторая строчка</param>
        /// <returns></returns>
        public int Count(char[] arr, char[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr2[i])
                {
                    count++;
                }
                else
                {
                    i=arr.Length;
                }
            }
            return count;
        }
    }
}
