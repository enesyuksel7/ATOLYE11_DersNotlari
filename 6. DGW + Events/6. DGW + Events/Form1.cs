using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.DGW___Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] arabalar = new string[4];
        int[] fiyatlar = new int[4];
        double[] motorgucleri = new double[4];

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arabalar = { "TOGG", "Audi", "Mercedes", "BMW" };
            int[] fiyatlar = {500,400,300,200};
            double[] motorgucleri = { 4.5, 3.5, 2.5, 1.5 };

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 20, GraphicsUnit.Pixel);
            dataGridView1.DefaultCellStyle.BackColor = Color.DarkOrange;
            
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Arabalar";
            dataGridView1.Columns[1].Name = "Fiyatlar";
            dataGridView1.Columns[2].Name = "Motor Gücü";
            dataGridView1.Columns[0].Width = dataGridView1.Columns[1].Width = dataGridView1.Columns[2].Width = 150;

            for (int i = 0; i < arabalar.Length; i++)
            {
                dataGridView1.Rows.Add(arabalar[i], fiyatlar[i], motorgucleri[i]);
            }
            listBox1.Items.Add(DateTime.Now);
            button1.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }
}
