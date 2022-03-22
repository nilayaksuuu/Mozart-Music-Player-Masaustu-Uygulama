namespace Mozart_Music_Player
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.btn_durdur = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_indir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_rastgele = new System.Windows.Forms.Button();
            this.list_music_Liste = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_list_temizle = new System.Windows.Forms.Button();
            this.tck_music_durum = new System.Windows.Forms.TrackBar();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_duraklat = new System.Windows.Forms.Button();
            this.grp_music = new System.Windows.Forms.GroupBox();
            this.lbl_toplam_sn = new System.Windows.Forms.Label();
            this.lbl_pozisyon_sn = new System.Windows.Forms.Label();
            this.tck_tiz_ses = new System.Windows.Forms.TrackBar();
            this.tck_ana_ses = new System.Windows.Forms.TrackBar();
            this.tck_bas_ses = new System.Windows.Forms.TrackBar();
            this.tck_sag_ses = new System.Windows.Forms.TrackBar();
            this.tck_sol_ses = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_sag_ses = new System.Windows.Forms.Label();
            this.lbl_sol_ses = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ana_ses = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_tiz_ses = new System.Windows.Forms.Label();
            this.lbl_bas_ses = new System.Windows.Forms.Label();
            this.chk_karistir = new System.Windows.Forms.CheckBox();
            this.chk_tekrarla = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_yada = new System.Windows.Forms.Label();
            this.rdb_lightmode = new System.Windows.Forms.RadioButton();
            this.rdb_darkmod = new System.Windows.Forms.RadioButton();
            this.app_close = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_music_durum)).BeginInit();
            this.ContextMenuStrip.SuspendLayout();
            this.grp_music.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(9, 55);
            this.progressBar1.Maximum = 250;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(692, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 0;
            this.progressBar1.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Lavender;
            this.radioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radioButton1.BackgroundImage")));
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Location = new System.Drawing.Point(149, -62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(13, 12);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // btn_baslat
            // 
            this.btn_baslat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_baslat.BackgroundImage")));
            this.btn_baslat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_baslat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_baslat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_baslat.FlatAppearance.BorderSize = 0;
            this.btn_baslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_baslat.Location = new System.Drawing.Point(350, 247);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(45, 38);
            this.btn_baslat.TabIndex = 4;
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // btn_durdur
            // 
            this.btn_durdur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_durdur.BackgroundImage")));
            this.btn_durdur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_durdur.FlatAppearance.BorderSize = 0;
            this.btn_durdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_durdur.Location = new System.Drawing.Point(445, 245);
            this.btn_durdur.Name = "btn_durdur";
            this.btn_durdur.Size = new System.Drawing.Size(33, 40);
            this.btn_durdur.TabIndex = 5;
            this.btn_durdur.UseVisualStyleBackColor = true;
            this.btn_durdur.Click += new System.EventHandler(this.btn_durdur_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_onceki.BackgroundImage")));
            this.btn_onceki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_onceki.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_onceki.FlatAppearance.BorderSize = 0;
            this.btn_onceki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onceki.Location = new System.Drawing.Point(269, 254);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(30, 23);
            this.btn_onceki.TabIndex = 6;
            this.btn_onceki.UseVisualStyleBackColor = true;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sonraki.BackgroundImage")));
            this.btn_sonraki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sonraki.FlatAppearance.BorderSize = 0;
            this.btn_sonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sonraki.Location = new System.Drawing.Point(541, 254);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(27, 23);
            this.btn_sonraki.TabIndex = 7;
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_indir
            // 
            this.btn_indir.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_indir.Location = new System.Drawing.Point(70, 320);
            this.btn_indir.Name = "btn_indir";
            this.btn_indir.Size = new System.Drawing.Size(75, 33);
            this.btn_indir.TabIndex = 12;
            this.btn_indir.Text = "İndir";
            this.btn_indir.UseVisualStyleBackColor = true;
            this.btn_indir.Click += new System.EventHandler(this.btn_indir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_rastgele
            // 
            this.btn_rastgele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rastgele.BackgroundImage")));
            this.btn_rastgele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rastgele.FlatAppearance.BorderSize = 0;
            this.btn_rastgele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rastgele.Location = new System.Drawing.Point(718, 245);
            this.btn_rastgele.Name = "btn_rastgele";
            this.btn_rastgele.Size = new System.Drawing.Size(30, 23);
            this.btn_rastgele.TabIndex = 14;
            this.btn_rastgele.UseVisualStyleBackColor = true;
            this.btn_rastgele.Click += new System.EventHandler(this.btn_rastgele_Click);
            // 
            // list_music_Liste
            // 
            this.list_music_Liste.BackColor = System.Drawing.SystemColors.ControlLight;
            this.list_music_Liste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_music_Liste.ContextMenuStrip = this.contextMenuStrip1;
            this.list_music_Liste.FormattingEnabled = true;
            this.list_music_Liste.ItemHeight = 14;
            this.list_music_Liste.Location = new System.Drawing.Point(70, 380);
            this.list_music_Liste.Name = "list_music_Liste";
            this.list_music_Liste.Size = new System.Drawing.Size(325, 140);
            this.list_music_Liste.TabIndex = 15;
            this.list_music_Liste.SelectedIndexChanged += new System.EventHandler(this.list_music_Liste_SelectedIndexChanged);
            this.list_music_Liste.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_music_Liste_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // btn_list_temizle
            // 
            this.btn_list_temizle.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_list_temizle.Location = new System.Drawing.Point(151, 320);
            this.btn_list_temizle.Name = "btn_list_temizle";
            this.btn_list_temizle.Size = new System.Drawing.Size(68, 33);
            this.btn_list_temizle.TabIndex = 16;
            this.btn_list_temizle.Text = "Temizle";
            this.btn_list_temizle.UseVisualStyleBackColor = true;
            this.btn_list_temizle.Click += new System.EventHandler(this.btn_list_temizle_Click);
            // 
            // tck_music_durum
            // 
            this.tck_music_durum.AutoSize = false;
            this.tck_music_durum.CausesValidation = false;
            this.tck_music_durum.ContextMenuStrip = this.contextMenuStrip1;
            this.tck_music_durum.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.tck_music_durum.Location = new System.Drawing.Point(9, 30);
            this.tck_music_durum.Maximum = 128;
            this.tck_music_durum.Name = "tck_music_durum";
            this.tck_music_durum.Size = new System.Drawing.Size(692, 19);
            this.tck_music_durum.TabIndex = 17;
            this.tck_music_durum.TickFrequency = 0;
            this.tck_music_durum.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tck_music_durum.Scroll += new System.EventHandler(this.tck_music_durum_Scroll);
            this.tck_music_durum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.list_music_Liste_MouseDown);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.ContextMenuStrip.Name = "contextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // btn_duraklat
            // 
            this.btn_duraklat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_duraklat.BackgroundImage")));
            this.btn_duraklat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_duraklat.FlatAppearance.BorderSize = 0;
            this.btn_duraklat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_duraklat.Location = new System.Drawing.Point(401, 249);
            this.btn_duraklat.Name = "btn_duraklat";
            this.btn_duraklat.Size = new System.Drawing.Size(38, 32);
            this.btn_duraklat.TabIndex = 18;
            this.btn_duraklat.UseVisualStyleBackColor = true;
            this.btn_duraklat.Click += new System.EventHandler(this.btn_duraklat_Click);
            // 
            // grp_music
            // 
            this.grp_music.Controls.Add(this.lbl_toplam_sn);
            this.grp_music.Controls.Add(this.lbl_pozisyon_sn);
            this.grp_music.Controls.Add(this.tck_music_durum);
            this.grp_music.Controls.Add(this.progressBar1);
            this.grp_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_music.Location = new System.Drawing.Point(44, 153);
            this.grp_music.Name = "grp_music";
            this.grp_music.Size = new System.Drawing.Size(707, 86);
            this.grp_music.TabIndex = 19;
            this.grp_music.TabStop = false;
            // 
            // lbl_toplam_sn
            // 
            this.lbl_toplam_sn.AutoSize = true;
            this.lbl_toplam_sn.Location = new System.Drawing.Point(652, 68);
            this.lbl_toplam_sn.Name = "lbl_toplam_sn";
            this.lbl_toplam_sn.Size = new System.Drawing.Size(0, 14);
            this.lbl_toplam_sn.TabIndex = 21;
            // 
            // lbl_pozisyon_sn
            // 
            this.lbl_pozisyon_sn.AutoSize = true;
            this.lbl_pozisyon_sn.Location = new System.Drawing.Point(6, 68);
            this.lbl_pozisyon_sn.Name = "lbl_pozisyon_sn";
            this.lbl_pozisyon_sn.Size = new System.Drawing.Size(0, 14);
            this.lbl_pozisyon_sn.TabIndex = 20;
            // 
            // tck_tiz_ses
            // 
            this.tck_tiz_ses.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.tck_tiz_ses.Location = new System.Drawing.Point(58, 28);
            this.tck_tiz_ses.Name = "tck_tiz_ses";
            this.tck_tiz_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_tiz_ses.Size = new System.Drawing.Size(45, 123);
            this.tck_tiz_ses.SmallChange = 0;
            this.tck_tiz_ses.TabIndex = 22;
            this.tck_tiz_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_tiz_ses.Scroll += new System.EventHandler(this.tck_tiz_ses_Scroll);
            // 
            // tck_ana_ses
            // 
            this.tck_ana_ses.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.tck_ana_ses.Location = new System.Drawing.Point(6, 28);
            this.tck_ana_ses.Name = "tck_ana_ses";
            this.tck_ana_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_ana_ses.Size = new System.Drawing.Size(45, 123);
            this.tck_ana_ses.TabIndex = 23;
            this.tck_ana_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_ana_ses.Scroll += new System.EventHandler(this.tck_ana_ses_Scroll);
            // 
            // tck_bas_ses
            // 
            this.tck_bas_ses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tck_bas_ses.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.tck_bas_ses.Location = new System.Drawing.Point(7, 28);
            this.tck_bas_ses.Name = "tck_bas_ses";
            this.tck_bas_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_bas_ses.Size = new System.Drawing.Size(45, 123);
            this.tck_bas_ses.TabIndex = 24;
            this.tck_bas_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_bas_ses.Scroll += new System.EventHandler(this.tck_bas_ses_Scroll);
            // 
            // tck_sag_ses
            // 
            this.tck_sag_ses.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.tck_sag_ses.Location = new System.Drawing.Point(59, 28);
            this.tck_sag_ses.Name = "tck_sag_ses";
            this.tck_sag_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sag_ses.Size = new System.Drawing.Size(45, 123);
            this.tck_sag_ses.TabIndex = 25;
            this.tck_sag_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sag_ses.Scroll += new System.EventHandler(this.tck_sag_ses_Scroll);
            // 
            // tck_sol_ses
            // 
            this.tck_sol_ses.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.tck_sol_ses.Location = new System.Drawing.Point(8, 28);
            this.tck_sol_ses.Name = "tck_sol_ses";
            this.tck_sol_ses.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tck_sol_ses.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tck_sol_ses.Size = new System.Drawing.Size(45, 123);
            this.tck_sol_ses.TabIndex = 26;
            this.tck_sol_ses.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tck_sol_ses.Scroll += new System.EventHandler(this.tck_sol_ses_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_sag_ses);
            this.groupBox1.Controls.Add(this.lbl_sol_ses);
            this.groupBox1.Controls.Add(this.tck_sol_ses);
            this.groupBox1.Controls.Add(this.tck_sag_ses);
            this.groupBox1.Location = new System.Drawing.Point(464, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 183);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sol/Sağ Ses";
            // 
            // lbl_sag_ses
            // 
            this.lbl_sag_ses.AutoSize = true;
            this.lbl_sag_ses.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sag_ses.Location = new System.Drawing.Point(65, 154);
            this.lbl_sag_ses.Name = "lbl_sag_ses";
            this.lbl_sag_ses.Size = new System.Drawing.Size(26, 14);
            this.lbl_sag_ses.TabIndex = 28;
            this.lbl_sag_ses.Text = "Sağ";
            // 
            // lbl_sol_ses
            // 
            this.lbl_sol_ses.AutoSize = true;
            this.lbl_sol_ses.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sol_ses.Location = new System.Drawing.Point(17, 154);
            this.lbl_sol_ses.Name = "lbl_sol_ses";
            this.lbl_sol_ses.Size = new System.Drawing.Size(22, 14);
            this.lbl_sol_ses.TabIndex = 27;
            this.lbl_sol_ses.Text = "Sol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ana_ses);
            this.groupBox2.Controls.Add(this.tck_ana_ses);
            this.groupBox2.Location = new System.Drawing.Point(580, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(56, 183);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ana Ses";
            // 
            // lbl_ana_ses
            // 
            this.lbl_ana_ses.AutoSize = true;
            this.lbl_ana_ses.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ana_ses.Location = new System.Drawing.Point(15, 154);
            this.lbl_ana_ses.Name = "lbl_ana_ses";
            this.lbl_ana_ses.Size = new System.Drawing.Size(27, 14);
            this.lbl_ana_ses.TabIndex = 24;
            this.lbl_ana_ses.Text = "Ana";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_tiz_ses);
            this.groupBox3.Controls.Add(this.lbl_bas_ses);
            this.groupBox3.Controls.Add(this.tck_bas_ses);
            this.groupBox3.Controls.Add(this.tck_tiz_ses);
            this.groupBox3.Location = new System.Drawing.Point(642, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(109, 183);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ses Efekt";
            // 
            // lbl_tiz_ses
            // 
            this.lbl_tiz_ses.AutoSize = true;
            this.lbl_tiz_ses.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tiz_ses.Location = new System.Drawing.Point(69, 154);
            this.lbl_tiz_ses.Name = "lbl_tiz_ses";
            this.lbl_tiz_ses.Size = new System.Drawing.Size(21, 14);
            this.lbl_tiz_ses.TabIndex = 26;
            this.lbl_tiz_ses.Text = "Tiz";
            // 
            // lbl_bas_ses
            // 
            this.lbl_bas_ses.AutoSize = true;
            this.lbl_bas_ses.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bas_ses.Location = new System.Drawing.Point(9, 154);
            this.lbl_bas_ses.Name = "lbl_bas_ses";
            this.lbl_bas_ses.Size = new System.Drawing.Size(26, 14);
            this.lbl_bas_ses.TabIndex = 25;
            this.lbl_bas_ses.Text = "Bas";
            // 
            // chk_karistir
            // 
            this.chk_karistir.AutoSize = true;
            this.chk_karistir.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_karistir.FlatAppearance.BorderSize = 0;
            this.chk_karistir.Location = new System.Drawing.Point(679, 274);
            this.chk_karistir.Name = "chk_karistir";
            this.chk_karistir.Size = new System.Drawing.Size(66, 18);
            this.chk_karistir.TabIndex = 30;
            this.chk_karistir.Text = "Karıştır";
            this.chk_karistir.UseVisualStyleBackColor = true;
            // 
            // chk_tekrarla
            // 
            this.chk_tekrarla.AutoSize = true;
            this.chk_tekrarla.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_tekrarla.Location = new System.Drawing.Point(674, 298);
            this.chk_tekrarla.Name = "chk_tekrarla";
            this.chk_tekrarla.Size = new System.Drawing.Size(71, 18);
            this.chk_tekrarla.TabIndex = 31;
            this.chk_tekrarla.Text = "Tekrarla";
            this.chk_tekrarla.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_yada
            // 
            this.lbl_yada.AutoSize = true;
            this.lbl_yada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_yada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_yada.Location = new System.Drawing.Point(152, 356);
            this.lbl_yada.Name = "lbl_yada";
            this.lbl_yada.Size = new System.Drawing.Size(35, 15);
            this.lbl_yada.TabIndex = 35;
            this.lbl_yada.Text = "ya da";
            // 
            // rdb_lightmode
            // 
            this.rdb_lightmode.AutoSize = true;
            this.rdb_lightmode.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdb_lightmode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdb_lightmode.Location = new System.Drawing.Point(193, 356);
            this.rdb_lightmode.Name = "rdb_lightmode";
            this.rdb_lightmode.Size = new System.Drawing.Size(78, 17);
            this.rdb_lightmode.TabIndex = 34;
            this.rdb_lightmode.TabStop = true;
            this.rdb_lightmode.Text = "Light Mode";
            this.rdb_lightmode.UseVisualStyleBackColor = true;
            this.rdb_lightmode.CheckedChanged += new System.EventHandler(this.rdb_lightmode_CheckedChanged);
            // 
            // rdb_darkmod
            // 
            this.rdb_darkmod.AutoSize = true;
            this.rdb_darkmod.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
            this.rdb_darkmod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdb_darkmod.Location = new System.Drawing.Point(70, 357);
            this.rdb_darkmod.Name = "rdb_darkmod";
            this.rdb_darkmod.Size = new System.Drawing.Size(76, 17);
            this.rdb_darkmod.TabIndex = 33;
            this.rdb_darkmod.TabStop = true;
            this.rdb_darkmod.Text = "Dark Mode";
            this.rdb_darkmod.UseVisualStyleBackColor = true;
            this.rdb_darkmod.CheckedChanged += new System.EventHandler(this.rdb_darkmod_CheckedChanged);
            // 
            // app_close
            // 
            this.app_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("app_close.BackgroundImage")));
            this.app_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.app_close.FlatAppearance.BorderSize = 0;
            this.app_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.app_close.Location = new System.Drawing.Point(752, 12);
            this.app_close.Name = "app_close";
            this.app_close.Size = new System.Drawing.Size(20, 19);
            this.app_close.TabIndex = 36;
            this.app_close.UseVisualStyleBackColor = true;
            this.app_close.Click += new System.EventHandler(this.app_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 536);
            this.Controls.Add(this.app_close);
            this.Controls.Add(this.lbl_yada);
            this.Controls.Add(this.rdb_lightmode);
            this.Controls.Add(this.rdb_darkmod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_tekrarla);
            this.Controls.Add(this.chk_karistir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_music);
            this.Controls.Add(this.btn_duraklat);
            this.Controls.Add(this.btn_list_temizle);
            this.Controls.Add(this.list_music_Liste);
            this.Controls.Add(this.btn_rastgele);
            this.Controls.Add(this.btn_indir);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.btn_onceki);
            this.Controls.Add(this.btn_durdur);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.radioButton1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MOZART MUSİC PLAYER";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tck_music_durum)).EndInit();
            this.ContextMenuStrip.ResumeLayout(false);
            this.grp_music.ResumeLayout(false);
            this.grp_music.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tck_tiz_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_ana_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_bas_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sag_ses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tck_sol_ses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.Button btn_durdur;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.Button btn_sonraki;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_indir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_rastgele;
        private System.Windows.Forms.ListBox list_music_Liste;
        private System.Windows.Forms.Button btn_list_temizle;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btn_duraklat;
        private System.Windows.Forms.GroupBox grp_music;
        private System.Windows.Forms.Label lbl_pozisyon_sn;
        private System.Windows.Forms.Label lbl_toplam_sn;
        private System.Windows.Forms.TrackBar tck_tiz_ses;
        private System.Windows.Forms.TrackBar tck_ana_ses;
        private System.Windows.Forms.TrackBar tck_bas_ses;
        private System.Windows.Forms.TrackBar tck_sag_ses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_sag_ses;
        private System.Windows.Forms.Label lbl_sol_ses;
        private System.Windows.Forms.Label lbl_ana_ses;
        private System.Windows.Forms.Label lbl_tiz_ses;
        private System.Windows.Forms.Label lbl_bas_ses;
        private System.Windows.Forms.CheckBox chk_karistir;
        private System.Windows.Forms.CheckBox chk_tekrarla;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TrackBar tck_music_durum;
        private System.Windows.Forms.TrackBar tck_sol_ses;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_yada;
        private System.Windows.Forms.RadioButton rdb_lightmode;
        private System.Windows.Forms.RadioButton rdb_darkmod;
        private System.Windows.Forms.Button app_close;
    }
}

