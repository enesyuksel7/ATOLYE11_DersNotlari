using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Class_and_Tools_Example
{
    public class Kisi
    {
        public int ID { get; set; }
        public string Adsoyad { get; set; }
        public string Sinif { get; set; }
        public string Cinsiyet { get; set; }
        public bool KVKK { get; set; }

        private static int sayac = 0;

        public Kisi()
        {
            sayac++;
            ID = sayac;
        }
    }
}
