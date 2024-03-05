using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.DGW___Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] arabalar = new string[3];
        int[] fiyatlar = new int[3];
        double[] motorgucleri = new double[3];
        float[] kilometre = new float[3];

        private void button1_Click(object sender, EventArgs e)
        {
            String[] arabalar = { "TOGG", "Mclaren", "Lamborghini" };
            int[] fiyatlar = { 15245, 68754, 87542 };
            double[] motorgucleri = { 500.6, 1528.7, 2357.1 };
            float[] kilometreler = { 1578.5F, 8596.9F, 4568.7F };

            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 18, GraphicsUnit.Pixel);
            dataGridView1.DefaultCellStyle.BackColor = Color.DeepPink;

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Araba";
            dataGridView1.Columns[1].Name = "Fiyatı";
            dataGridView1.Columns[2].Name = "Motor Gücü";
            dataGridView1.Columns[3].Name = "KM";

            for (int i = 0; i < arabalar.Length; i++)
            {
                dataGridView1.Rows.Add(arabalar[i], fiyatlar[i], motorgucleri[i], kilometreler[i]);
                listBox1.Items.Add(DateTime.Now);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }
}
