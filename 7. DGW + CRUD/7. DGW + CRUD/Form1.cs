using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.DGW___CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private int secilenIndex;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenIndex = e.RowIndex;

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[secilenIndex].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[secilenIndex].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[secilenIndex].Cells[2].Value = textBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secilenIndex > 0)
                dataGridView1.Rows.RemoveAt(secilenIndex);
            if (secilenIndex < 1)
                button3.Enabled = false;
        }
    }
}
