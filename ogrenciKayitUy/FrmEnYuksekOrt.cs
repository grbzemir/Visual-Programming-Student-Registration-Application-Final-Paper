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
    public partial class FrmEnYuksekOrt : Form
    {
        public FrmEnYuksekOrt()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server =  EMIR\SQLEXPRESS ; initial catalog= dbOgrenciKayit; integrated security = true  ");

        public void listele()
        {
            SqlCommand komut = new SqlCommand("select ogrNo as 'Numara', ad as 'Ad', soyad as'Soyad', dogumTarih as 'Doğum Tarihi ', adres as 'Adres ', telefon as 'Telefon', dersID as 'Ders Kodu' , Ortalama as 'Ortalama' from tblOgrenci", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmEnYuksekOrt_Load(object sender, EventArgs e)
        {
            listele(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select TOP(1) ogrNo as 'Numara', ad as 'Ad', soyad as'Soyad', dogumTarih as 'Doğum Tarihi ', adres as 'Adres ', telefon as 'Telefon', dersID as 'Ders Kodu', Ortalama as 'Ortalama'  from tblOgrenci order by Ortalama DESC   ", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
