using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Kod
    {
        public void Programm()
        {
            bool cikl = false;

            while (!cikl)
            {
                Console.Clear();
                Console.WriteLine("1 – Отгадай ответ\r\n2 – Об авторе (Фамилия И.О., группа)\r\n" +
                    "3 - Сортировка\r\n4 - Крестики нолики\r\n5 - Сапёр \r\n6 - Чаровские строчки\r\n7 – Выход");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Case1.Exzample();
                        break;

                    case ConsoleKey.D2:
                        Case2 c2 = new Case2();
                        c2.Info();
                        break;

                    case ConsoleKey.D3:
                        Case3 c3 = new Case3();
                        c3.Sort();
                        break;

                    case ConsoleKey.D4:
                        Case4 c4 = new Case4();
                        c4.NoughtsAndCrosses();
                        break;

                    case ConsoleKey.D5:
                        Case7 c7 = new Case7();
                        c7.Game();
                        break;

                    case ConsoleKey.D6:
                        Case8 c8 = new Case8();
                        c8.CharNumber();
                        break;

                    case ConsoleKey.D7:
                        Case6 c6 = new Case6();
                        cikl = c6.OutMeny();
                        break;

                    default:
                        Err er = new Err();
                        er.Error();
                        break;

                }
            }
        }
    }
}
