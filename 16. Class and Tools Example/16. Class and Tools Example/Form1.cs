using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16.Class_and_Tools_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("10.Sınıf");
            comboBox1.Items.Add("11.Sınıf");
            comboBox1.Items.Add("12.Sınıf");

            radioButton1.Checked = true;
            checkBox1.Checked = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("AdSoyad", "AdSoyad");
            dataGridView1.Columns.Add("Sinif", "Sinif");
            dataGridView1.Columns.Add("Cinsiyet", "Cinsiyet");
            dataGridView1.Columns.Add("KVKK", "KVKK");
        }
        List<Kisi> kisiler = new List<Kisi>();
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string seciliSinif = comboBox1.SelectedItem.ToString();
            string seciliCinsiyet = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            bool seciliKVKK = checkBox1.Checked;

            kisiler.Add(new Kisi { Adsoyad = ad, Sinif = seciliSinif, Cinsiyet = seciliCinsiyet, KVKK = seciliKVKK });
            DataGridViewGuncelle();
        }

        private void DataGridViewGuncelle()
        {
            dataGridView1.Rows.Clear();
            foreach (Kisi kisi in kisiler)
            {
                dataGridView1.Rows.Add(kisi.ID, kisi.Adsoyad, kisi.Sinif, kisi.Cinsiyet, kisi.KVKK);
            }
        }
    }
}
