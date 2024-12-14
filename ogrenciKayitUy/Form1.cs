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
    public partial class Form1 : Form
        //Emircan Gürbüz - Görsel Programlama
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"server = EMIR\SQLEXPRESS ; initial catalog= dbOgrenciKayit; integrated security = true  "); 

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string parola = textBox2.Text;
            SqlCommand komut = new SqlCommand("Select * from login where kullaniciAdi ='"+kullaniciAdi+"' and parola= '"+parola+"' ", con );
            con.Open();

            //komut.Parameters.AddWithValue("@p1", kullaniciAdi);
            //komut.Parameters.AddWithValue("@p2", parola );
    
            SqlDataReader dr=  komut.ExecuteReader();
            
             
            if( dr.Read() )
            {
                Form2 f2 = new Form2();
                f2.Show(); 
            }
            else
                MessageBox.Show("Hatalı Kullanıcı adı ve parola ", "Giriş Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Warning );

            textBox1.Text = "";
            textBox2.Text = "";
            con.Close();

        }
    }
}
