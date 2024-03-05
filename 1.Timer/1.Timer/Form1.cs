using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Timer
{
    public partial class Form1 : Form
    {
        int saniye = 0;
        int dakika = 0;
        Form1 form1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelSaniye.Text = "Süreniz";
            timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            labelSaniye.Text = saniye.ToString();
            button1.Enabled = false;
            button1.Text = "Pasif";
            progressBar1.Value += 1;

            if (saniye == 60)
            {
                labelSaniye.Text = "0";
                saniye = 0;
                dakika++;
                labelDakika.Text = dakika.ToString();
                richTextBox1.Text = "Aşağıdakilerden hangisi UCL 2022 şampiyonudur?\nA) Real Madrid \nB) Arsenal \nC) Barcelona \nD) BVB";
            }

            if (progressBar1.Value == 60)
            {
                progressBar1.Value = 0;
            }

            if (dakika == 2)
            {
                MessageBox.Show("Süre bitti");
                progressBar1.Value = 0;
                saniye = 0;
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            timer1.Start();
            checkBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saniye = 0;
            labelSaniye.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Aşağıdakilerden hangisi UCL 2022 şampiyonudur?\nA) Real Madrid \nB) Arsenal \nC) Barcelona \nD) BVB";
            progressBar1.Value = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                button1.Visible = true;
            }
        }
    }
}
