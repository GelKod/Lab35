using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case4
    {
        public void NoughtsAndCrosses()
        {
            string[,] arr2 = CreateMas();
            TicTacToe(arr2);
            Console.ReadKey();
        }
        public string[,] CreateMas()
        {
            string[,] array = new string[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ".";
                }
            }
            return array;
        }
        public void TicTacToe(string[,] arr)
        {
            int game = 0;
            for (game = 2; game < 11; game++)
            {
                Console.Clear();
                string sign;
                if (game % 2 == 0)
                {
                    sign = "x";
                }
                else
                {
                    sign = "o";
                }
                Pole(arr);
                arr = Move(sign, arr);
                game = ProvPob(arr, sign, game);
            }
            if (game != 13)
            {
                Console.WriteLine("Победила дружба!!!");
            }
        }
        public string[,] Move(string gin, string[,] mas)
        {
            int vvodX1 = 0, vvodY1 = 0;
            bool proverka = false;
            Console.WriteLine("Ход для "+gin);
            while (!proverka)
            {
                proverka = true;
                vvodX1 = InPutCoordinate();
                vvodY1 = InPutCoordinate();
                if (!(mas[vvodX1 - 1, vvodY1 - 1] == "."))
                {
                    Console.WriteLine("Эта ячейка занята");
                    proverka = false;
                }
            }
            mas[vvodX1 - 1, vvodY1 - 1] = gin;
            return mas;
        }
        public void Pole(string[,] arr)
        {
            Console.WriteLine("  1 2 3 <- x");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("^\r\n|\r\ny");
        }
        public int InPutCoordinate()
        {
            int inputx = 0;
            bool enterY = false;
            while (!enterY)
            {
                Console.Write("Введите расположение по (1)Y (2)X: ");
                enterY = int.TryParse(Console.ReadLine(), out inputx);
                if (!enterY)
                {
                    Console.WriteLine("Вы ввели неверное значение");
                }
                if (inputx > 3 || inputx < 1)
                {
                    Console.WriteLine("Введите значение от 1 до 3");
                    enterY = false;
                }
            }
            return inputx;
        }
        public int ProvPob(string[,] arr, string gid, int game)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, 0] == arr[i, 1] && arr[i, 0] == arr[i, 2] && !(arr[i, 0] == "."))
                {

                    Console.WriteLine("Победа за " + gid);
                    game = 13;
                }
                if (arr[0, i] == arr[1, i] && arr[0, i] == arr[2, i] && !(arr[0, i] == "."))
                {
                    Console.WriteLine("Победа за " + gid);
                    game = 13;
                }
            }
            if (arr[0, 0] == arr[1, 1] && arr[0, 0] == arr[2, 2] && !(arr[1, 1] == "."))
            {
                Console.WriteLine("Победа за " + gid);
                game = 13;
            }
            if (arr[0, 2] == arr[1, 1] && arr[0, 2] == arr[2, 0] && !(arr[1, 1] == "."))
            {
                Console.WriteLine("Победа за " + gid);
                game = 13;
            }
            return game;
        }
    }
}
