using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PataisytaAntraUzduotis
{
    class Matrica1
    {
        static public int Rows { get; set; }
        static public int Columns { get; set; }
        public int[,] matrica = new int[Rows, Columns];
        public Matrica1(int pirmaDimencija, int antraDimencija)
        {
            Rows = pirmaDimencija;
            Columns = antraDimencija;
            Console.WriteLine("Sukurta I-oji matrica");
        }

        public int this[int row, int column]
        {
            get { return matrica[row, column]; }
            set { matrica[row, column] = value; }
        }
    }
}
