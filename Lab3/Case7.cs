using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case7
    {
        const int _x = 10;
        const string _xx = "   1 2 3 4 5 6 7 8 9 10 <- x";
        /// <summary>
        /// Создание поля с рандомными числами
        /// </summary>
        /// <returns></returns>
        static int[,] GenerateGrid()
        {
            int[,] grid = new int[_x, _x];
            Random rng = new Random();
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    grid[x, y] = rng.Next(0, 10);
                }
            }
            return grid;
        }
        /// <summary>
        /// Создание поля которое видит пользователь
        /// </summary>
        /// <returns></returns>
        static string[,] MaskGrid()
        {
            string[,] grid = new string[_x, _x];
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    grid[x, y] = "*";
                }
            }
            return grid;
        }
        /// <summary>
        /// Замена лишних цифр на пустые клетки поля или цифр
        /// </summary>
        /// <param name="grid">Поле с бомбами</param>
        /// <returns></returns>
        static int[,] FormatGrid(int[,] grid)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    if (grid[x, y] == 9)
                    {
                        continue;
                    }
                    int mineCount = 0;
                    bool up = false;
                    bool down = false;
                    bool left = false;
                    bool right = false;

                    if (x - 1 >= 0)
                    {
                        up = true;
                    }
                    if (x + 1 < grid.GetLength(0))
                    {
                        down = true;
                    }
                    if (y - 1 >= 0)
                    {
                        left = true;
                    }
                    if (y + 1 < grid.GetLength(1))
                    {
                        right = true;
                    }

                    if (up)
                    {
                        if (grid[x - 1, y] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (down)
                    {
                        if (grid[x + 1, y] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (left)
                    {
                        if (grid[x, y - 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (right)
                    {
                        if (grid[x, y + 1] == 9)
                        {
                            mineCount++;
                        }
                    }

                    if (up && left)
                    {
                        if (grid[x - 1, y - 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (up && right)
                    {
                        if (grid[x - 1, y + 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (down && right)
                    {
                        if (grid[x + 1, y + 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    if (down && left)
                    {
                        if (grid[x + 1, y - 1] == 9)
                        {
                            mineCount++;
                        }
                    }
                    grid[x, y] = mineCount;
                }
            }
            return grid;
        }
        /// <summary>
        /// Процесс игры
        /// </summary>
        /// <param name="mask">Поле которое видит пользователь</param>
        /// <param name="grid">Поле с расположением мин</param>
        /// <param name="gameOver">Цикл вайл</param>
        /// <returns></returns>
        public bool GameProcess(string[,] mask, int[,] grid, bool gameOver)
        {
            FieldMin(mask);
            Console.WriteLine();
            while (!gameOver)
            {
                int x = 0, y = 0;
                bool chek = false;
                bool proverka = false;
                while (!proverka)
                {
                    proverka = true;
                    int schet = 0;
                    if (schet % 2 == 0)
                    {
                        Console.WriteLine("Введите номер строки");
                    }
                    else
                    {
                        Console.WriteLine("Введите номер столбца");
                    }
                    x = Helper.InputInt(1,10);
                    schet++;
                    if (schet % 2 == 0)
                    {
                        Console.WriteLine("Введите номер строки");
                    }
                    else
                    {
                        Console.WriteLine("Введите номер столбца");
                    }
                    y = Helper.InputInt(1,10);
                    if (!(mask[x - 1, y - 1] == "*"))
                    {
                        Console.WriteLine("Эта ячейка занята");
                        proverka = false;
                    }
                }
                if (grid[x - 1, y - 1] != 9)
                {
                    Console.Clear();
                    mask[x - 1, y - 1] = grid[x - 1, y - 1].ToString();
                    FieldMin(mask);
                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();
                    mask[x - 1, y - 1] = grid[x - 1, y - 1].ToString();
                    FieldMin(mask);
                    Console.WriteLine("Вы попали на клетку с миной! Попробуйте снова!");
                    gameOver = true;
                }
                chek = true;
            }
            return gameOver;
        }
        /// <summary>
        /// Игра сапер её основной код
        /// </summary>
        public void Game()
        {
            Console.Clear();
            int[,] grid = GenerateGrid();
            string[,] mask = MaskGrid();
            grid = FormatGrid(grid);
            bool game = false;
            game = GameProcess(mask, grid, game);
            Console.ReadKey();
        }
        /// <summary>
        /// Вывод поля игры
        /// </summary>
        /// <param name="arr">Поле с игрой</param>
        public void FieldMin(string[,] arr)
        {
            Console.WriteLine(_xx);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write(i + 1);
                if (!(i + 1 == 10))
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("^\r\n|\r\ny");
        }
    }
}
