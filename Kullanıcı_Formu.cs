using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mozart_Music_Player
{
    class Kullanıcı_Formu
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5ROLLFP\SQLEXPRESS;Initial Catalog=kullanici_girisi;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        Form1 yeni = new Form1();
        public SqlDataReader kullanici(TextBox kullaniciadi, TextBox sifre)
        {
          
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from kullanici_tbl where kullaniciadi='" + kullaniciadi.Text + "'and sifre='" + sifre.Text +"' ";
            read = komut.ExecuteReader();

            if (read.Read() == true)
            {
                
                yeni.ShowDialog();
               
                

            }
            else
            {
               MessageBox.Show("Kullanıcı adı ya da parola hatalı", "Hata1");
            }

            baglanti.Close();
                return read;
        


        }
        public void yenikullanici(TextBox adsoyad, TextBox kullaniciadi,TextBox sifre,TextBox sifretekrar,TextBox soru,TextBox cevap,GroupBox grup)
        {
            if(sifre.Text==sifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "Insert into kullanici_tbl values ('" + adsoyad.Text + "','" + kullaniciadi.Text + "','" + sifre.Text + "','" + soru.Text + "','" + cevap.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(" TEBRİKLER! Üyeliğiniz Başarıyla Tamamlanmıştır");
                foreach (Control item in grup.Controls) if (item is TextBox) item.Text = "";
            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor!", "Hata");
            }
        }
        public void sifre (TextBox adsoyad,TextBox kullaniciadi,TextBox sifre,TextBox sifretekrar, TextBox soru,TextBox cevap, GroupBox grup)
        {
            if (sifre.Text==sifretekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select * from kullanici_tbl where kullaniciadi='" + kullaniciadi.Text + "'", baglanti);
               
                if (read.Read() == true)
                {
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşti");
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi Kontrol Ediniz", "Hata2");
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor", "Hata3");
            }
          
        }
       
    }
}
