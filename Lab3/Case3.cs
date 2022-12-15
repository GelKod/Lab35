using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case3
    {
        private int _n;

        public Case3()
        {
            _n = 15;
        }
        public Case3(int a)
        {
            _n = a;
        }
        /// <summary>
        /// Задание для 4 лабораторной работы
        /// </summary>
        public void Sort()
        {
            Console.Clear();
            int[] array = MasRand(_n);
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
        /// <summary>
        /// Рандомное заполнение массива
        /// </summary>
        /// <param name="a">Количество элементов массива</param>
        /// <returns></returns>
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
        /// <summary>
        /// Сортировка пузырьком
        /// </summary>
        /// <param name="a">Массив для сортировки</param>
        /// <returns></returns>
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
        /// <summary>
        /// Сортировка шелла
        /// </summary>
        /// <param name="b">Массив для сортировки</param>
        /// <returns></returns>
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
        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param name="d">Массив для вывода</param>
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
        /// <summary>
        /// Копирование массива
        /// </summary>
        /// <param name="mas">Массив для копирования</param>
        /// <returns></returns>
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
