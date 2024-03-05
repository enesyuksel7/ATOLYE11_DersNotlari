using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Timer2
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            progressBar1.Value++;
            listBox1.Items.Add(dakika.ToString() + ".Dk " + saniye.ToString() + ".Sn " + dateTimePicker1.Value.ToString());
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                pictureBox1.Visible = true;
                listBox1.Items.Add("Resim gösterildi: " + monthCalendar1.SelectionStart.ToLongDateString());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.Visible = false;
                listBox1.Items.Add("Resim gizlendi: " + monthCalendar1.SelectionStart.ToLongDateString());
            }
        }
    }
}
