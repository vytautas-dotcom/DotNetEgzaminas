using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraUzduotis
{
    class Matrica2
    {
        static public int Rows { get; set; }
        static public int Columns { get; set; }
        public int[,] matrica = new int[Rows, Columns];
        public Matrica2(int pirmaDimencija, int antraDimencija)
        {
            Rows = pirmaDimencija;
            Columns = antraDimencija;
            Console.WriteLine("Sukurta II-oji matrica");
        }
       
        public int this[int row, int column]
        {
            get { return matrica[row, column]; }
            set { matrica[row, column] = value; }
        }
    }
}
