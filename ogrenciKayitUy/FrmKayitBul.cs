using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenciKayitUy
{
    public partial class FrmKayitBul : Form
    {
   SqlConnection con = new SqlConnection(@"server = EMIR\SQLEXPRESS ; initial catalog= dbOgrenciKayit; integrated security = true  ");

        public FrmKayitBul()
        {
            InitializeComponent();
        }
        public void listele()
        {
            SqlCommand komut = new SqlCommand("select ogrNo as 'Numara', ad as 'Ad', soyad as'Soyad', dogumTarih as 'Doğum Tarihi ', adres as 'Adres ', telefon as 'Telefon', dersID as 'Ders Kodu' , Ortalama as 'Ortalama'  from tblOgrenci", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKayitBul_Load(object sender, EventArgs e)
        {
            listele(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open(); 
            int numara = Convert.ToInt32(textBox1.Text); 
            SqlCommand komut = new SqlCommand("select ogrNo as 'Numara', ad as 'Ad', soyad as'Soyad', dogumTarih as 'Doğum Tarihi ', adres as 'Adres ', telefon as 'Telefon', dersID as 'Ders Kodu' , Ortalama as 'Ortalama'  from tblOgrenci where ogrNo ='" + numara +"'  ", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close(); 

        }
    }
}
