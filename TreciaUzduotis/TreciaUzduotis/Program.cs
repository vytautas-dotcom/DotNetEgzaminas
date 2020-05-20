using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonuKnyga knyga = new TelefonuKnyga();
            knyga.Irasas();
            //knyga.Paieska();
            knyga.Trynimas();



            Console.ReadKey();

        }
    }
}
