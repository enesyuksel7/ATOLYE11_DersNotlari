using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.DGW___Class
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

        private void button1_Click(object sender, EventArgs e)
        {
            Araba yeniAraba = new Araba();
            yeniAraba.marka = textBox1.Text;
            yeniAraba.model = textBox2.Text;
            yeniAraba.renk = textBox3.Text;
            yeniAraba.yas = Convert.ToInt32(textBox4.Text);

            dataGridView1.Rows.Add(yeniAraba.marka, yeniAraba.model, yeniAraba.renk, yeniAraba.yas);
        }

        private int secilenIndex;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenIndex = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araba yeniAraba = new Araba();
            dataGridView1.Rows[secilenIndex].Cells[0].Value = yeniAraba.marka = textBox1.Text;
            dataGridView1.Rows[secilenIndex].Cells[1].Value = yeniAraba.model = textBox2.Text;
            dataGridView1.Rows[secilenIndex].Cells[2].Value = yeniAraba.renk = textBox3.Text;
            dataGridView1.Rows[secilenIndex].Cells[3].Value = textBox4.Text;
            yeniAraba.yas = Convert.ToInt32(textBox4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secilenIndex >= 0)
                dataGridView1.Rows.RemoveAt(secilenIndex);
            else
                MessageBox.Show("Seçim Yapınız!");
        }
    }
}
