using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.Class___Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class OtobusKarti
        {
            public string Ad { get; set; }
            public int Yas { get; set; }
            public bool OgrenciDurumu { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<OtobusKarti> kart = new List<OtobusKarti>
            {
                new OtobusKarti { Ad = "Ali", Yas = 30, OgrenciDurumu = false },
                new OtobusKarti { Ad = "Ahmet", Yas = 25, OgrenciDurumu = true },
                new OtobusKarti { Ad = "Bob", Yas = 35, OgrenciDurumu = false }
            };
            dataGridView1.DataSource = kart;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                OtobusKarti kisi = (OtobusKarti)row.DataBoundItem;
                listBox1.Items.Add(kisi.Ad + Environment.NewLine);

                if (kisi.OgrenciDurumu)
                {
                    ((DataGridViewCheckBoxCell)row.Cells["OgrenciDurumu"]).Value = true;
                }
            }
        }
    }
}
