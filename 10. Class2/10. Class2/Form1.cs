using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Class2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Araba
        {
            public string marka;
            public string renk;
            public string model;
            public int yas;
        }

        class Bilgisayar
        {
            public string Marka;
            public int Ram;
            public string EkranKarti;
            public string Islemci;
            public double IslemciFrekansi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilgisayar msi37 = new Bilgisayar();

            Araba araba1 = new Araba();
            araba1.marka = "Renault";
            araba1.renk = "Siyah";
            araba1.model = "Megane";
            araba1.yas = 5;

            Araba araba2 = new Araba();
            araba2.marka = "Fiat";
            araba2.renk = "Beyaz";
            araba2.model = "EGEA";
            araba2.yas = 3;

            label1.Text = araba2.model;
        }

        class Canli
        {
            // Sadece Ortak Özelliklerin tanımlanması (Encapsulation)
            public int Yas { get; set; }

            // Yapıcı metot (constructor)
            public Canli(int yas)
            {
                Yas = yas;
            }
        }

        // Bitki sınıfı (Canli sınıfından kalıtım)
        class Bitki : Canli
        {
            // Bitkiye özgü özelliklerin tanımlanması
            public string Cins { get; set; }
            public int YaprakSayisi { get; set; }
            public string Renk { get; set; }

            // Bitki sınıfının yapıcı metodu(constructor)
            public Bitki(string cins, int yas, int yaprakSayisi, string renk) : base(yas)
            {
                Cins = cins;
                YaprakSayisi = yaprakSayisi;
                Renk = renk;
            }
        }

        // Hayvan sınıfı (Canli sınıfından kalıtım)
        class Hayvan : Canli
        {
            // Hayvana özgü özelliklerin tanımlanması
            public string Tur { get; set; }
            public int AyakSayisi { get; set; }
            public double Boy { get; set; }

            // Hayvan sınıfının yapıcı metodu(constructor)
            public Hayvan(string cins, int yas, string tur, int ayakSayisi, double boy) : base(cins, yas)
            {
                Tur = tur;
                AyakSayisi = ayakSayisi;
                Boy = boy;
            }
        }
    }
}
