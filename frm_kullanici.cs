using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mozart_Music_Player
{
   
    public partial class frm_kullanici : Form
    {
        public frm_kullanici()
        {
            InitializeComponent();

        }
        
     
        private void rdb_darkmod_CheckedChanged(object sender, EventArgs e)
        {
            
            this.BackColor = Color.DimGray;
            
            

        }
        private void rdb_lightmode_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;


        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_unuttum sifre = new Frm_unuttum();
            sifre.ShowDialog();

        }
        Kullanıcı_Formu k = new Kullanıcı_Formu();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 yeni = new Form1();
            yeni.FormClosing += yeni_FormClosing;
            
            k.kullanici(txtKullanici_adi, txtKullanici_sifre);
            

        }

        private void yeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();


        }
       
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            k.yenikullanici(adsoyadtxt, kullaniciaditxt, sifretxt, sifretekrartxt, sorutxt, cevaptxt, groupBox2);
        }

        
    }
}
