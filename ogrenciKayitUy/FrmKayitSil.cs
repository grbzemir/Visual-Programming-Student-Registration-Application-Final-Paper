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
    public partial class FrmKayitSil : Form
    {
        public FrmKayitSil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"server = EMIR\SQLEXPRESS ; initial catalog= dbOgrenciKayit; integrated security = true  ");

        private void button1_Click(object sender, EventArgs e)
        {
            int numara = Convert.ToInt32(textBox1.Text);

            con.Open();
            SqlCommand komut = new SqlCommand("delete  tblOgrenci where ogrNo = @p1 ", con );
            komut.Parameters.AddWithValue("@p1", numara);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc>0)
            {
                MessageBox.Show("Kayıt Silindi ", "kayıt silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
                MessageBox.Show("Kayıt Silinemedi ", "kayıt silme", MessageBoxButtons.OK, MessageBoxIcon.Warning );

            con.Close();
            listele();


        }
        public void listele()
        {
            SqlCommand komut = new SqlCommand("select ogrNo as 'Numara', ad as 'Ad', soyad as'Soyad', dogumTarih as 'Doğum Tarihi ', adres as 'Adres ', telefon as 'Telefon', dersID as 'Ders Kodu'  , Ortalama as 'Ortalama' from tblOgrenci", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void FrmKayitSil_Load(object sender, EventArgs e)
        {
            listele();   

        }
    }
}
