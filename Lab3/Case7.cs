using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case7
    {
        static int[,] GenerateGrid()
        {
            int[,] grid = new int[10, 10];
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
        static string[,] MaskGrid()
        {
            string[,] grid = new string[10, 10];
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    grid[x, y] = "*";
                }
            }
            return grid;
        }
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
        static bool GameProcess(string[,] mask, int[,] grid, bool gameOver)
        {
            for (int i = 0; i < mask.GetLength(0); i++)
            {
                for (int j = 0; j < mask.GetLength(1); j++)
                {
                    Console.Write(" " + mask[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            while (!gameOver)
            {
                Console.Write("Введите номер клетки (Строка, столбец): ");
                string[] coords = Console.ReadLine().Split();
                int x = int.Parse(coords[0]);
                int y = int.Parse(coords[1]);
                if (grid[x - 1, y - 1] != 9)
                {
                    Console.Clear();
                    mask[x - 1, y - 1] = grid[x - 1, y - 1].ToString();
                    for (int i = 0; i < mask.GetLength(0); i++)
                    {
                        for (int j = 0; j < mask.GetLength(1); j++)
                        {
                            Console.Write(" " + mask[i, j]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Clear();
                    mask[x - 1, y - 1] = grid[x - 1, y - 1].ToString();
                    for (int i = 0; i < mask.GetLength(0); i++)
                    {
                        for (int j = 0; j < mask.GetLength(1); j++)
                        {
                            Console.Write(" " + mask[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Вы попали на клетку с миной! Попробуйте снова!");
                    gameOver = true;
                }
            }
            return gameOver;
        }
        public void Game()
        {
            Console.Clear ();
            int[,] grid = GenerateGrid();
            string[,] mask = MaskGrid();
            grid = FormatGrid(grid);
            bool game = false;
            game = GameProcess(mask, grid, game);
            Console.ReadKey();
        }
    }
}
