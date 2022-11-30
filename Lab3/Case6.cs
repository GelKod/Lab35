using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Err
    {
        public void Error()
        {
            Console.WriteLine("\r\nОшибка...\r\n");
            Console.WriteLine("Введено не то число!!!");
            Console.ReadKey();
        }
    }
}
