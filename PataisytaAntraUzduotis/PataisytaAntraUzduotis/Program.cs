using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PataisytaAntraUzduotis
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

                    //----------------------------------
                    //Reikia situ, kad matricos gautu dimencijas
                    //Turbut del to, kad turiu atskirai dar kreiptis i indeksatorius??
                    //Noreciau, kad paaiskintumet sita vieta, nes uzkomentavus, nebepersiduoda n ir m reiksmes i matricas
                    //----------------------------------
                    var matrica01 = new Matrica1(m1, n1);
                    var matrica02 = new Matrica2(m2, n2);
                    //----------------------------------

                    var matrica1 = new Matrica1(m1, n1).matrica;
                    var matrica2 = new Matrica2(m2, n2).matrica;
                        AutomatinisMatricuUzpildymas(m1, n1, matrica1, m2, n2, matrica2);
                        MatricuSudetis(m1, n1, matrica1, m2, n2, matrica2);
                        MatricuAtimtis(m1, n1, matrica1, m2, n2, matrica2);


                    }
                }

                Console.ReadKey();

            }
            static void AutomatinisMatricuUzpildymas(int m1, int n1, int[,] A, int m2, int n2, int[,] B)
            {
            int rows1 = m1;
            int columns1 = n1;
            int rows2 = m2;
            int columns2 = n2;

            if (m1 == m2 && n1 == n2)
            {
                //Pirmos uzpildymas
                for (int i = 0; i < m1; i++)
                {
                    for (int j = 0; j < n1; j++)
                    {
                        A[i, j] = i + j;
                    }
                }

                //Antros uzpildymas
                for (int i = 0; i < m2; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        B[i, j] = i + j + 5;
                    }
                }
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Norint atliktu numatytus veiksmus su matricomis, turi sutapti ju dimencijos");
                Console.WriteLine("---------------------------------------------------------------------------");
            }
                

        }

            static void MatricuSudetis(int m1, int n1, int[,] A, int m2, int n2, int[,] B)
            {
                int[,] C = new int[m1, n1];

                if ((m1 == m2) && n1 == n2)
                {
                    for (int i = 0; i < m1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {
                            C[i, j] = A[i, j] + B[i, j];
                        }
                    }
                }

                Console.WriteLine("\n-----------------------------------------\n");
                Console.WriteLine("Nauja matrica C sudejus A ir B matricas:\n");

                for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < C.Length / (C.GetUpperBound(0) + 1); j++)
                    {
                        Console.Write(C[i, j]+"\t");
                    }
                    Console.WriteLine();
                }
            }

            static void MatricuAtimtis(int m1, int n1, int[,] A, int m2, int n2, int[,] B)
            {
                int[,] C = new int[m1, n1];

                if ((m1 == m2) && n1 == n2)
                {
                    for (int i = 0; i < m1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {
                            C[i, j] = A[i, j] - B[i, j];
                        }
                    }
                }

                Console.WriteLine("\n-----------------------------------------\n");
                Console.WriteLine("Nauja matrica C atemus A ir B matricas:\n");

                for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < C.Length / (C.GetUpperBound(0) + 1); j++)
                    {
                        Console.Write(C[i, j]+"\t");
                    }
                    Console.WriteLine();
                }
            }


        }
    }


    

