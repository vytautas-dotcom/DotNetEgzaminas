using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmaUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trikampio ploto skaiciavimo programa");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Iveskite pirmaja trikampio krastine");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Turite vesti skaicius");
            }
            else
            {
                Console.WriteLine("Iveskite antraja trikampio krastine");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {

                }
                else
                {
                    Console.WriteLine("Iveskite kampa tarp krastiniu");
                    if (!double.TryParse(Console.ReadLine(), out double C))
                    {
                        Console.WriteLine("Turite vesti skaicius");
                    }
                    else
                        TrikampioPlotas(a, b, C);
                }
            } 
            

            Console.ReadKey();
        }
        static void TrikampioPlotas(double krastine1, double krastine2, double kampas)
        {
            double angle = Math.PI * kampas / 180.0;
            double S = 0.5 * krastine1 * krastine2 * Math.Sin(angle);
            Console.WriteLine($"Trikampio plotas: {Math.Round(S, 2)}");
        }
    }
}
