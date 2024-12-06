using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciKayitUy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmListele fl = new FrmListele();
            fl.Show(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKayitSil fks = new FrmKayitSil();
            fks.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKayitBul frm = new FrmKayitBul();
            frm.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmEnYuksekOrt frm = new FrmEnYuksekOrt();
            frm.Show(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
