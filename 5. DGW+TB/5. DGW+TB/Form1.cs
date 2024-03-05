using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.DGW_TB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "K.Adı";
            dataGridView1.Columns[1].Name = "Parola";
            dataGridView1.Columns[2].Name = "Maç Tarihi";
            dataGridView1.Columns[3].Name = "Log";

            dataGridView1.Columns[0].Width = dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = dataGridView1.Columns[3].Width = 250;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Tüm bilgileri doldurunuz.");
            }
            else if(textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Parolalar aynı değildir!");
            }
            else if(dateTimePicker1.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmiş tarih seçilemez!");
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Value, DateTime.Now);
                label5.Visible = true;
            }
        }

    }
}
