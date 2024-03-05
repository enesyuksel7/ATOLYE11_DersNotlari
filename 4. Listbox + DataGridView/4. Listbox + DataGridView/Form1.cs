using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Listbox___DataGridView
{
    public partial class Form1 : Form
    {
        int saniye = 0, dakika = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label2.Text = saniye.ToString();

            if(saniye == 60)
            {
                dakika++;
                label1.Text = dakika.ToString();
                saniye = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saniye = dakika = 0;
            label1.Text = label2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dakika.ToString() + ".Dk " + saniye.ToString() + ".Sn");

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);

            progressBar1.Value++;

            if (progressBar1.Value == 10)
            {
                MessageBox.Show("Kayıt doldu!");
                progressBar1.Value = 0;
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }


    }
}
