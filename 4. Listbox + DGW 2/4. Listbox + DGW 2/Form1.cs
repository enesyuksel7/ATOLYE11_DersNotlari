using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Listbox___DGW_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye, dakika = 0;

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
            timer1.Stop();
            label2.Text = saniye.ToString();
            label1.Text = dakika.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value++;

            listBox1.Items.Add(dakika.ToString() + ".Dk " + saniye.ToString() + ".Sn");

            if(progressBar1.Value == 10)
            {
                MessageBox.Show("Kapasite doldu.");
                button4.Enabled = false;
                progressBar1.Value = 0;
            }

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
