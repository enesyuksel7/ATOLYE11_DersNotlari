using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Araba
        {
            String Marka;
            String Model;
            int MotorHacmi;
            int Yil;
            int Kilometre;
        }

        class Kus
        {
            String Tur;
            String Cins;
            String Sinif;
            int Boy;
            float KanatGenisligi;
            float KanatUzunlugu;
        }

        class Telefon
        {
            String Marka;
            String Model;
            String IslemciAdi;
            float IslemciFrekansi;
            int Ram;
            int Depolama;
            int Kamera;
            int Hertz;
            int Ppi;
            double EkranBoyutu;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
