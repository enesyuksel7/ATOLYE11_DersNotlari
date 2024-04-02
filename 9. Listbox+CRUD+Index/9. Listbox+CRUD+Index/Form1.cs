using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.Listbox_CRUD_Index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add("Eklendi: " + DateTime.Now);
            tbTemizle();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = -1;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seciliIndex1 = listBox1.SelectedIndex;
            int seciliIndex2 = listBox2.SelectedIndex;
            if (seciliIndex1 > -1)
            {
                listBox1.Items[seciliIndex1] = textBox1.Text;
                listBox2.Items[seciliIndex1] = textBox2.Text;
            }
            if(seciliIndex2 > -1)
            {
                listBox1.Items[seciliIndex2] = textBox1.Text;
                listBox2.Items[seciliIndex2] = textBox2.Text;
            }
            listBox3.Items.Add("Güncellendi: " + DateTime.Now);
            tbTemizle();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int seciliIndex = listBox1.SelectedIndex;
            textBox1.Text = listBox1.Items[seciliIndex].ToString();
            textBox2.Text = listBox2.Items[seciliIndex].ToString();
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            int seciliIndex = listBox2.SelectedIndex;
            textBox1.Text = listBox1.Items[seciliIndex].ToString();
            textBox2.Text = listBox2.Items[seciliIndex].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilenIndex1 = listBox1.SelectedIndex;
            int secilenIndex2 = listBox2.SelectedIndex;
            if (secilenIndex1 > -1)
            {
                listBox1.Items.RemoveAt(secilenIndex1);
                listBox2.Items.RemoveAt(secilenIndex1);
            }
            if(secilenIndex2 > -1)
            {
                listBox1.Items.RemoveAt(secilenIndex2);
                listBox2.Items.RemoveAt(secilenIndex2);
            }
            listBox3.Items.Add("Silindi: " + DateTime.Now);
            tbTemizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Add("Temizlendi: " + DateTime.Now);
            tbTemizle();
        }
    }
}
