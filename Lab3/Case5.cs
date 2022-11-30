using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Case6
    {
        public bool OutMeny()
        {
            bool cikl = false;
            bool kodDaNet = false;
            while (!kodDaNet)
            {
                Console.Clear();
                Console.WriteLine("\r\nВы точно хотите выйти?");
                Console.WriteLine("д - да\r\nн - нет");
                string h = Console.ReadLine();
                if (h == "д" || h == "l")
                {
                    cikl = true;
                    kodDaNet = true;
                }
                else if (h == "н" || h == "y")
                {
                    kodDaNet = true;
                }
                Console.WriteLine(" ");
            }
            return cikl;
        }
    }
}
