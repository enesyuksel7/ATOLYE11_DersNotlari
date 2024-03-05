using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Timer___DateTime
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
            panel1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label2.Text = saniye.ToString();

            if(saniye == 60)
            {
                saniye = 0;
                dakika++;
                label1.Text = dakika.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value++;
            panel1.Visible = true;
            listBox1.Items.Add(dakika.ToString() + ".Dakika " + saniye.ToString() + ".Saniye " + dateTimePicker1.Value.ToString());

            if(progressBar1.Value >= 3)
            {
                progressBar1.Value = 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                listBox1.Items.Add("Resim gösterildi, Tarih: " + monthCalendar1.SelectionStart.ToLongDateString());
                pictureBox1.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                listBox1.Items.Add("Resim gizlendi, Tarih: " + monthCalendar1.SelectionStart.ToLongDateString());
                pictureBox1.Visible = false;
            }
        }
    }
}
