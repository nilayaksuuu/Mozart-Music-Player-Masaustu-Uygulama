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
    public partial class Frm_unuttum : Form
    {
        public Frm_unuttum()
        {
            InitializeComponent();
        }
        Kullanıcı_Formu k = new Kullanıcı_Formu();
        private void btnyenisifre_Click(object sender, EventArgs e)
        {
            k.sifre(adsoyadtxt, kullaniciaditxt, sifretxt, sifretekrartxt, sorutxt, cevaptxt, groupBox2);
        }

        private void Frm_unuttum_Load(object sender, EventArgs e)
        {
           
        }
    }
}
