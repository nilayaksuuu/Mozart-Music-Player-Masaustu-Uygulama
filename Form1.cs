using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        MMPlayer pl = new MMPlayer();
        OpenFileDialog openfiledialog1 = new OpenFileDialog();
        bool musicYuklendi = false, musicCaliyor = false, karistir = false, tekrarla = false;
        List<string> OynatmaListesi = new List<string>();
        int musicDegisti = 0;



       



        private void btn_indir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Media File(*.mpg,*.dat,*.avi,*.wmv,*.wav,*.mp3)|*.wav;*.mp3;*.mpg;*.dat;*.avi;*.wmv";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Count(); i++)
                {
                    list_music_Liste.Items.Add(openFileDialog1.SafeFileNames[i]);
                    OynatmaListesi.Add(openFileDialog1.FileNames[i]);
                }
                btn_baslat.Enabled = true;
                btn_durdur.Enabled = true;
                btn_duraklat.Enabled = true;
                btn_onceki.Enabled = true;
                btn_sonraki.Enabled = true;
                btn_rastgele.Enabled = true;



            }
        }
        private void btn_list_temizle_Click(object sender, EventArgs e)
        {
            list_music_Liste.Items.Clear();
            OynatmaListesi.Clear();
            pl.MMp_Duraklat();
            if (MessageBox.Show("MEVCUT LİSTE TEMİZLENDİ! YENİ LİSTE OLUŞTURMAK İSTER MİSİNİZ?", "YENİ LİSTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btn_indir.PerformClick();
            }



        }
        private void btn_baslat_Click(object sender, EventArgs e)
        {


            musicDegistirTemizle();
            if (pl.musicDuraklatildi == true)
            {
                pl.MMp_Oynat(tekrarla);
                pl.musicDuraklatildi = false;
            }
            else
            {
                if (musicCaliyor)
                {
                    pl.MMp_Kapat();
                    musicCaliyor = false;


                }
                if (list_music_Liste.SelectedIndex < 0)
                    list_music_Liste.SelectedIndex = 0;

                pl.MMp_Ac(OynatmaListesi[list_music_Liste.SelectedIndex].ToString());
                pl.MMp_Oynat(tekrarla);
                musicCaliyor = true;

                grp_music.Text = "Çalan Müzik: " + list_music_Liste.SelectedItem.ToString();
                pl.ToplamSure();

                lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
                tck_music_durum.Maximum = pl._sn_ToplamSure;

                this.Text = "Çalan Müzik..." + list_music_Liste.SelectedItem.ToString();

            }
            musicDegisti = 0;

        }
        private void btn_duraklat_Click(object sender, EventArgs e)
        {
            pl.MMp_Duraklat();
            pl.musicDuraklatildi = true;

        }
        private void btn_durdur_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lbl_pozisyon_sn.Text = "00:00:00";
            pl.MMp_Kapat();
            list_music_Liste.SelectedIndex = 0;
            musicDegistirTemizle();

        }
        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            musicDegistirTemizle();
            pl.MMp_Kapat();
            if (karistir)
            {
                Karisik_Oynat();
            }
            else
            {
                try
                {
                    list_music_Liste.SelectedIndex += 1;
                    pl.MMp_Ac(OynatmaListesi[list_music_Liste.SelectedIndex].ToString());
                    grp_music.Text = "Çalan Müzik..." + list_music_Liste.SelectedItem.ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Müzik Listenin Sonu...");
                }
            }
            pl.MMp_Oynat(tekrarla);
            pl.ToplamSure();
            lbl_toplam_sn.Text = pl._sn_ToplamSure.ToString();
            tck_music_durum.Maximum = pl._sn_ToplamSure;


        }
        private void btn_onceki_Click(object sender, EventArgs e)
        {
            musicDegistirTemizle();
            pl.MMp_Kapat();
            if (karistir)
            {
                Karisik_Oynat();
            }
            else
            {
                try
                {
                    list_music_Liste.SelectedIndex -= 1;
                    pl.MMp_Ac(OynatmaListesi[list_music_Liste.SelectedIndex].ToString());
                    grp_music.Text = "Çalan Müzik..." + list_music_Liste.SelectedItem.ToString();
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Listenin Başı...");
                }
            }
            pl.MMp_Oynat(tekrarla);
            pl.ToplamSure();
            lbl_toplam_sn.Text = pl._st_ToplamSure.ToString();
            tck_music_durum.Maximum = pl._sn_ToplamSure;





        }
        private void list_music_Liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            musicDegistirTemizle();
            try
            {

                grp_music.Text = "Çalan Müzik..." + list_music_Liste.SelectedItem.ToString();
                btn_baslat.PerformClick();
            }
            catch (NullReferenceException)
            {
            }


        }
        private void list_music_Liste_MouseDoubleClick(object sender, EventArgs e)
        {
            if (list_music_Liste.SelectedIndex >= 0)
                if (musicYuklendi)
                    if (pl.musicDuraklatildi == true)
                    {
                        pl.MMp_Oynat(tekrarla);
                        pl.musicDuraklatildi = false;
                    }
                    else
                        btn_baslat.PerformClick();

        }
        private void tck_ana_ses_Scroll(object sender, EventArgs e)
        {
            pl.AnaSes = tck_ana_ses.Value;
        }
        private void tck_bas_ses_Scroll(object sender, EventArgs e)
        {
            pl.Bass = tck_bas_ses.Value;
        }

        private void tck_tiz_ses_Scroll(object sender, EventArgs e)
        {
            pl.Tiz = tck_tiz_ses.Value;
        }

        private void tck_sol_ses_Scroll(object sender, EventArgs e)
        {
            pl.SolSes = tck_sol_ses.Value;
        }
        private void tck_sag_ses_Scroll(object sender, EventArgs e)
        {
            pl.SagSes = tck_sag_ses.Value;
        }
        private void tck_music_durum_Scroll(object sender, EventArgs e)
        {
            IleriGeriSar();
            progressBar1.Value = tck_music_durum.Value;
        }

        void IleriGeriSar()
        {
            pl.MMp_Duraklat();
            double d = TimeSpan.FromSeconds(tck_music_durum.Value).TotalMilliseconds;
            pl.IleriGeriSar(d);
            pl.MMp_Oynat(tekrarla);
        }
        private void OtoMusicDegistir()
        {
            if (pl._sn_Pozisyon == pl._sn_ToplamSure & musicDegisti == 0 & tekrarla == false)
            {
                try
                {
                    if (karistir)
                    {
                        Karisik_Oynat();
                    }
                    else
                    {
                        list_music_Liste.SelectedIndex += 1;
                    }
                    musicDegisti = 1;
                    btn_baslat.PerformClick();
                }
                catch (ArgumentOutOfRangeException) { }

            }
        }


        void musicDegistirTemizle()
        {
            grp_music.Text = "Çalan Müzik...";
            lbl_pozisyon_sn.Text = "00:00:00";
            lbl_toplam_sn.Text = "00:00:00";
            tck_music_durum.Value = 0;
        }
        private void list_music_Liste_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
                list_music_Liste.SelectedIndex = list_music_Liste.IndexFromPoint(e.X, e.Y);

        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i = list_music_Liste.SelectedIndex;
            list_music_Liste.Items.RemoveAt(i);
            OynatmaListesi.RemoveAt(i);
            list_music_Liste.Refresh();
            if (musicCaliyor == true)
            {
                pl.MMp_Duraklat();
                MessageBox.Show("LİSTE DEĞİŞTİ! MÜZİĞİ YENİDEN BAŞLATIN");
                musicDegistirTemizle();
                musicCaliyor = true;
            }

        }

        private void rdb_darkmod_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
        }

        private void rdb_lightmode_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (chk_tekrarla.CheckState == CheckState.Checked)
                tekrarla = true;
            else
                tekrarla = false;
            if (chk_karistir.CheckState == CheckState.Checked)
                karistir = true;
            else
                karistir = false;

            if (musicCaliyor)
            {
                if (list_music_Liste.Items.Count > 0)
                {
                    if (musicYuklendi & musicCaliyor)
                    {
                        pl.Pozisyon();
                        lbl_pozisyon_sn.Text = pl._sn_Pozisyon.ToString();
                        tck_music_durum.Value = pl._sn_Pozisyon;

                        OtoMusicDegistir();
                    }
                }
            }
        }

        private void app_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       

        private void btn_rastgele_Click(object sender, EventArgs e)
        {
            Karisik_Oynat();

        }
        void Karisik_Oynat()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, OynatmaListesi.Count() - 1);
            list_music_Liste.SelectedIndex = i;
            btn_baslat.PerformClick();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }


        
    }
    

    
}
