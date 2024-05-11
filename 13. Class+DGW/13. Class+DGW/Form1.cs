using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.Class_DGW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Ogrenci
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string Sinif { get; set; }
        }

        private List<Ogrenci> yeniogrenci = new List<Ogrenci>();

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new Form2())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    yeniogrenci.Add(form.YeniOgrenci);
                    YenileDataGridView();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void YenileDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = yeniogrenci;
        }
    }
}
