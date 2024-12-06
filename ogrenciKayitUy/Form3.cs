using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ogrenciKayitUy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server = EMIR\SQLEXPRESS ; initial catalog= dbOgrenciKayit; integrated security = true  ");

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("select * from tblDers ", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            comboBox1.DisplayMember = "dersAdi";
            comboBox1.ValueMember = "dersKodu";
            comboBox1.DataSource = tablo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand komut = new SqlCommand(" insert into tblOgrenci (ad, soyad, dogumTarih, adres, telefon, dersID, Ortalama ) values (@p1,@p2,@p3,@p4,@p5,@p6, @p7 ) ", con);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtdTarih.Text);
            komut.Parameters.AddWithValue("@p4", txtAdres.Text);
            komut.Parameters.AddWithValue("@p5", txtTel.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p7", txtOrtalama.Text);

            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yeni Kayıt Tamam ", "Kayıt Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
