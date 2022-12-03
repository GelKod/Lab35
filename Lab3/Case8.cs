using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case8
    {
        public void CharNumber()
        {
            Console.Clear();
            Console.WriteLine("1 - Посчитать количество строчных и прописных букв в строке (отдельно).\r\n" +
                "2 - Посчитать количество знаков препинания в строке.\r\n" +
                "3 - Вывести на экран, сколько первых символов этих строк совпадают.");
            int choose = 0;
            while (choose>3||choose<1)
            {
                choose = Helper.InPutInt();
            }
            switch (choose)
            {
                case 1:
                    N1();
                    break;
                case 2:
                    N2();
                    break;
                case 3:
                    N3();
                    break;
                default:
                    Err er1 = new Err();
                    er1.Error();
                    break;
            }
            Console.ReadKey();
        }
        public int Number3(string stroka, string stroka2)
        {
            int shodstva = 0;
            char[] mas2 = stroka.ToCharArray();
            char[] mas3 = stroka2.ToCharArray();
            if (mas2.Length <= mas3.Length)
            {
                Count(mas2, mas3);
            }
            else
            {
                Count(mas3, mas2);
            }
            return shodstva;
        }
        public int Number2(string stroka)
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
            return prepinaniya;
        }
        public int[] Number1(string stroka)
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
            int[] mas2 = new int[2];
            mas2[0] = propis;
            mas2[1] = stroch;
            return mas2;
        }
        public void N1()
        {
            Console.Clear();
            int[] arr = { 0, 0 };
            int choos = 0;
            Console.WriteLine("1 - Использовать текст из методички\r\n2 - Ввести свой текст");
            while (choos > 2 || choos < 1)
            {
                choos = Helper.InPutInt();
            }
            switch (choos)
            {
                case 1:
                    string oneNumber = Txt();
                    arr = Number1(oneNumber);
                    break;
                case 2:
                    oneNumber = Console.ReadLine();
                    arr = Number1(oneNumber);
                    break;
            }
            Console.WriteLine("Заглавных: " + arr[1] + "\r\nПрописных" + arr[0]);
        }
        public void N2()
        {
            Console.Clear();
            int prepinaniya = 0;
            Console.WriteLine("1 - Использовать текст из методички\r\n2 - Ввести свой текст");
            int choos = 0;
            while (choos > 2 || choos < 1)
            {
                choos = Helper.InPutInt();
            }
            switch (choos)
            {
                case 1:
                    string oneNumber = Txt();
                    prepinaniya = Number2(oneNumber);
                    break;
                case 2:
                    oneNumber = Console.ReadLine();
                    prepinaniya = Number2(oneNumber);
                    break;
            }
            Console.WriteLine("Oтвет: " + prepinaniya);
        }
        public void N3()
        {
            Console.Clear();
            Console.WriteLine("1 - Использовать текст из методички\r\n2 - Ввести свой текст");
            int choos = 0;
            while (choos > 2 || choos < 1)
            {
                choos = Helper.InPutInt();
            }
            int shodstva = 0;
            switch (choos)
            {
                case 1:
                    string firstTwoNumber = "Быть может, вся Природа\r\n– мозаика цветов?";
                    string secondTwoNumber = "Быть может, вся Природа\r\n– различность голосов?";
                    shodstva = Number3(firstTwoNumber, secondTwoNumber);
                    break;
                case 2:
                    firstTwoNumber = Console.ReadLine();
                    secondTwoNumber = Console.ReadLine();
                    shodstva = Number3(firstTwoNumber, secondTwoNumber);
                    break;
            }
            Console.WriteLine("Oтвет: " + shodstva);
        }
        public string Txt()
        {
            string text = "Строка 1:\r\nВаркалось. Хливкие шорьки\r\nПырялись по наве,\r\n" +
                "И хрюкотали зелюки,\r\nКак мюмзики в мове.\r\nО бойся Бармаглота, сын!\r\n" +
                "Он так свирлеп и дик,\r\nА в глуще рымит исполин - Злопастный Брандашмыг.";
            return text;
        }
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
                    i = 100;
                }
            }
            return count;
        }
    }
}
