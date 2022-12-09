using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case3
    {
        private int _kol;
        public void Sort()
        {
            Console.Clear();
            Console.WriteLine("Введите сколько чисел в массиве arr: ");
            _kol = InPutQuantityMas();
            int[] array = MasRand(_kol);
            OutPutMas(array);
            int[] arr2 = Transfer(array);
            DateTime dateTime = DateTime.Now;
            Bubble(array);
            TimeSpan sp = DateTime.Now - dateTime;
            DateTime dateTime2 = DateTime.Now;
            Shell(arr2);
            TimeSpan sp2 = DateTime.Now - dateTime2;
            Console.WriteLine("Сортированный массив");
            OutPutMas(array);
            Console.WriteLine("Время сортировки пузырьком: " + sp);
            Console.WriteLine("Время выполнения сортировки Шелла: " + sp2);
            Console.ReadKey();
        }
        public int[] MasRand(int a)
        {
            int[] c = new int[a];
            Random rnd = new Random();
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = rnd.Next(-10, 10);
            }
            return c;
        }
        public int InPutQuantityMas()
        {
            int a = 0;
            bool chek = false;
            while (!chek)
            {
                Console.Write("Ввод: ");
                chek = int.TryParse(Console.ReadLine(), out a);
                if (a < 1)
                {
                    chek = false;
                }
            }
            return a;
        }
        public int[] Bubble(int[] a)
        {
            int low;
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i + 1] < a[i])
                    {
                        low = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = low;
                    }
                }
            }
            return a;
        }
        public int[] Shell(int[] b)
        {
            int t;
            int d = b.Length / 2;
            while (d >= 1)
            {
                for (int i = d; i < b.Length; i++)
                {
                    int j = i;
                    while ((j >= d) && (b[j - d] > b[j]))
                    {
                        t = b[j];
                        b[j] = b[j - d];
                        b[j - d] = t;
                        j -= d;
                    }
                }

                d /= 2;
            }
            return b;
        }
        public void OutPutMas(int[] d)
        {
            if (d.Length < 100)
            {
                for (int i = 0; i < d.Length; i++)
                {
                    Console.Write(d[i] + ", ");
                }
                Console.WriteLine();
            }
        }
        public int[] Transfer(int[] mas)
        {
            int[] mas2 = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                mas2[i] = mas[i];
            }
            return mas2;
        }
    }
}
