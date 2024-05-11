using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _13.Class_DGW.Form1;

namespace _13.Class_DGW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Ogrenci YeniOgrenci { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            YeniOgrenci = new Ogrenci
            {
                Id = int.Parse(textBox1.Text),
                Ad = textBox2.Text,
                Soyad = textBox3.Text,
                Sinif = textBox4.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
