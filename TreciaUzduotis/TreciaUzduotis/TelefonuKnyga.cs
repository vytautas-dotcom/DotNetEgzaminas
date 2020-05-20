using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciaUzduotis
{
    class TelefonuKnyga
    {
        Dictionary<int, PersonInfo> knyga = new Dictionary<int, PersonInfo>();
        ConsoleKeyInfo status;
        bool isTrue = true;

        public void Irasas()
        {
            while (isTrue)
            {

                Console.WriteLine("\nIveskite varda");
                string vardas = Console.ReadLine();
                Console.WriteLine("\nIveskite elpasta");
                string pastas = Console.ReadLine();
                Console.WriteLine("\nIveskite tel.nr.formatu(0000)");
                int tel = Convert.ToInt32(Console.ReadLine());
                knyga.Add(tel, new PersonInfo() { Vardas = vardas, ElPastas = pastas });

                Console.WriteLine("\n\n Baigti? (Y/y)\t\t Testi(N/n)\n");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    isTrue = false;
                }
                else if (status.Key == ConsoleKey.N)
                    isTrue = true;
            }

        }

        public void Paieska()
        {
            Console.WriteLine("\nIveskite varda arba pavarde arba dali is kazkurio is ju\n");
            string paieska = Console.ReadLine();


            foreach (KeyValuePair<int, PersonInfo> keyValue in knyga)
            {
                if (keyValue.Value.Vardas.IndexOf(paieska) >= 0 || keyValue.Value.ElPastas.IndexOf(paieska) >= 0)
                {
                    Console.WriteLine(keyValue.Value.Vardas + " " + keyValue.Value.ElPastas + " - " + keyValue.Key);
                }

            }
        }

        public void Trynimas()
        {
            foreach (KeyValuePair<int, PersonInfo> keyValue in knyga)
            {
                Console.WriteLine(keyValue.Value.Vardas + " " + keyValue.Value.ElPastas + " - " + keyValue.Key);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\nIveskite tel. nr. pagal kuri norite istrinti irasa\n");
            int trintNr = Convert.ToInt32(Console.ReadLine());


            foreach (KeyValuePair<int, PersonInfo> keyValue in knyga)
            {
                if (keyValue.Key == trintNr)
                {
                    knyga.Remove(trintNr);
                    break;
                }

            }

            foreach (KeyValuePair<int, PersonInfo> keyValue in knyga)
            {
                Console.WriteLine(keyValue.Value.Vardas + " " + keyValue.Value.ElPastas + " - " + keyValue.Key);
            }
        }
    }
}
