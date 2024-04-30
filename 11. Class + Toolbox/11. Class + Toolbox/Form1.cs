using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.Class___Toolbox
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
            public string model;
            public string renk;
            public int yas;
        }
        void button1_Click(object sender, EventArgs e)
        {
            Araba araba1 = new Araba();

            araba1.marka = textBox1.Text;
            araba1.model = textBox2.Text;
            araba1.renk = textBox3.Text;
            araba1.yas = int.Parse(textBox4.Text);

            listBox1.Items.Add(araba1.marka);
            listBox1.Items.Add(araba1.model);
            listBox1.Items.Add(araba1.renk);
            listBox1.Items.Add(araba1.yas);
        }
    }
}
