using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matricu sudetis atimtis. Matricu dimensijos turi sutapti");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Pirmosios matricos dimencijos");
            if (!int.TryParse(Console.ReadLine(), out int m1) || !int.TryParse(Console.ReadLine(), out int n1))
            {
                Console.WriteLine("Turite vesti skaicius");
            }
            else
            {
                Console.WriteLine("Iveskite antraja trikampio krastine");
                if (!int.TryParse(Console.ReadLine(), out int m2) || !int.TryParse(Console.ReadLine(), out int n2))
                {
                    Console.WriteLine("Turite vesti skaicius");
                }
                else
                {
                    Matrica1 matrica1 = new Matrica1(m1, n1);
                    Matrica2 matrica2 = new Matrica2(m2, n2);
                    AutomatinisMatricuUzpildymas(m1, n1, matrica1, m2, n2, matrica2);
                    MatricuSudetis(matrica1, matrica2);
                    MatricuAtimtis(matrica1, matrica2);

                    
                }
            }

            



            Console.ReadKey();

        }
        static void AutomatinisMatricuUzpildymas(int m1, int n1, Matrica1 A, int m2, int n2, Matrica2 B)
        {
            //Pirmos uzpildymas
                int rows1 = m1;
                int columns1 = n1;

                for (int i = 0; i < m1; i++)
                {
                    for (int j = 0; j < n1; j++)
                    {
                        A[i, j] = i + j;
                    }
                }
            
           //Antros uzpildymas
                int rows2 = m2;
                int columns2 = n2;

                for (int i = 0; i < m2; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        B[i, j] = i + j + 5;
                    }
                }
            
        }

        static void MatricuSudetis(Matrica1 A, Matrica2 B)
        {
            int[,] C = new int[A.matrica.GetUpperBound(0) + 1, A.matrica.Length / A.matrica.GetUpperBound(0) + 1];

            if((A.matrica.GetUpperBound(0) + 1 == B.matrica.GetUpperBound(0) + 1) &&
                A.matrica.Length / A.matrica.GetUpperBound(0) + 1 == B.matrica.Length / B.matrica.GetUpperBound(0) + 1)
            {
                for (int i = 0; i < A.matrica.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < A.matrica.Length / A.matrica.GetUpperBound(0) + 1; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nauja matrica C sudejus A ir B matricas:\n");

            for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < C.Length / C.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(C[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void MatricuAtimtis(Matrica1 A, Matrica2 B)
        {
            int[,] C = new int[A.matrica.GetUpperBound(0) + 1, A.matrica.Length / A.matrica.GetUpperBound(0) + 1];

            if ((A.matrica.GetUpperBound(0) + 1 == B.matrica.GetUpperBound(0) + 1) &&
                A.matrica.Length / A.matrica.GetUpperBound(0) + 1 == B.matrica.Length / B.matrica.GetUpperBound(0) + 1)
            {
                for (int i = 0; i < A.matrica.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < A.matrica.Length / A.matrica.GetUpperBound(0) + 1; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nauja matrica C atemus A ir B matricas:\n");

            for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < C.Length / C.GetUpperBound(0) + 1; j++)
                {
                    Console.Write(C[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
