using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Timer2
{
    public partial class Form1 : Form
    {
        int saniye = 0, dakika = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value++;

            if(progressBar1.Value >= 10)
            {
                MessageBox.Show("Kapasite doldu.");
                progressBar1.Value = 0;
            }

            listBox1.Items.Add(dakika.ToString() + ".Dakika/ " + saniye.ToString() + ".Saniye");
            comboBox1.Items.Add(dakika.ToString() + ".Dakika/ " + saniye.ToString() + ".Saniye");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                this.BackColor = Color.LightBlue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                this.BackColor = Color.DarkRed;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                this.BackColor = Color.Yellow;
            else
                this.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
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
    }
}
