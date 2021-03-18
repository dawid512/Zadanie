using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie
{
   public class Towar
    {
        
        public string Nazwa { get; set; }
       
        public Decimal Cena { get; set; }


        public Opisy Opis { get; set; }

       


        public static Towar FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(';');
            Towar towar = new Towar();
            towar.Nazwa = Convert.ToString(values[0]);
            towar.Cena = Convert.ToDecimal(values[1]);
            towar.Opis = new Opisy();
            towar.Opis.A = Convert.ToString(values[2]);
            towar.Opis.B = Convert.ToString(values[3]);


            return towar;
        }

    }
}
