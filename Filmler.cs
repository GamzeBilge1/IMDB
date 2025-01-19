using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    public class Filmler
    { 
        //propertyler
        public double Puan { get; set; }
        public string Isim { get; set; }

       public Filmler(string isim, double puan) //parametreli Constructor
        {
            Puan = puan;
            Isim = isim;
        }
    }
}
