
namespace Mimari
{
    partial class SeyahatBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeyahatBilgileri));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.pnl_tumsayfa = new System.Windows.Forms.Panel();
            this.pnl_bilgiler = new System.Windows.Forms.Panel();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_Tutar = new System.Windows.Forms.Label();
            this.lbl_ktutar = new System.Windows.Forms.Label();
            this.lbl_ututar = new System.Windows.Forms.Label();
            this.cmb_otel = new System.Windows.Forms.ComboBox();
            this.cmb_ucak = new System.Windows.Forms.ComboBox();
            this.pic_ulasim = new System.Windows.Forms.Button();
            this.pic_konaklama = new System.Windows.Forms.Button();
            this.pic_tutar = new System.Windows.Forms.Button();
            this.cmb_otobus = new System.Windows.Forms.ComboBox();
            this.cmb_ulasim = new System.Windows.Forms.ComboBox();
            this.cmb_kamp = new System.Windows.Forms.ComboBox();
            this.cmb_konaklama = new System.Windows.Forms.ComboBox();
            this.lbl_ucak = new System.Windows.Forms.Label();
            this.lbl_otel = new System.Windows.Forms.Label();
            this.lbl_otobus = new System.Windows.Forms.Label();
            this.lbl_kamp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ara = new System.Windows.Forms.Button();
            this.pic_change = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_donus = new System.Windows.Forms.DateTimePicker();
            this.date_kalkis = new System.Windows.Forms.DateTimePicker();
            this.radio_tek = new System.Windows.Forms.RadioButton();
            this.radio_cift = new System.Windows.Forms.RadioButton();
            this.cmb_kalkis = new System.Windows.Forms.ComboBox();
            this.cmb_kisi = new System.Windows.Forms.ComboBox();
            this.cmb_varis = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.data_seyahat = new System.Windows.Forms.DataGridView();
            this.cmb_cikti = new System.Windows.Forms.ComboBox();
            this.btn_cikti = new System.Windows.Forms.Button();
            this.btn_tamamla = new System.Windows.Forms.Button();
            this.data_bilgiler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_KimlikBilgileri = new System.Windows.Forms.GroupBox();
            this.msked_telefon = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.lbl_KimlikNo = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_KimlikNo = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.kalkis_yeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalkis_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulasim_araci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konaklama_turu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mekan_konum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mekan_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisi_sayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabpage1.SuspendLayout();
            this.pnl_tumsayfa.SuspendLayout();
            this.pnl_bilgiler.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_seyahat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bilgiler)).BeginInit();
            this.group_KimlikBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 400);
            this.tabControl1.TabIndex = 39;
            // 
            // tabpage1
            // 
            this.tabpage1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabpage1.Controls.Add(this.pnl_tumsayfa);
            this.tabpage1.Location = new System.Drawing.Point(4, 22);
            this.tabpage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabpage1.Name = "tabpage1";
            this.tabpage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabpage1.Size = new System.Drawing.Size(873, 374);
            this.tabpage1.TabIndex = 0;
            this.tabpage1.Text = "Seyahat Bilgileri";
            // 
            // pnl_tumsayfa
            // 
            this.pnl_tumsayfa.BackColor = System.Drawing.Color.Transparent;
            this.pnl_tumsayfa.Controls.Add(this.pnl_bilgiler);
            this.pnl_tumsayfa.Controls.Add(this.btn_ara);
            this.pnl_tumsayfa.Controls.Add(this.pic_change);
            this.pnl_tumsayfa.Controls.Add(this.label8);
            this.pnl_tumsayfa.Controls.Add(this.label5);
            this.pnl_tumsayfa.Controls.Add(this.label4);
            this.pnl_tumsayfa.Controls.Add(this.label3);
            this.pnl_tumsayfa.Controls.Add(this.label1);
            this.pnl_tumsayfa.Controls.Add(this.date_donus);
            this.pnl_tumsayfa.Controls.Add(this.date_kalkis);
            this.pnl_tumsayfa.Controls.Add(this.radio_tek);
            this.pnl_tumsayfa.Controls.Add(this.radio_cift);
            this.pnl_tumsayfa.Controls.Add(this.cmb_kalkis);
            this.pnl_tumsayfa.Controls.Add(this.cmb_kisi);
            this.pnl_tumsayfa.Controls.Add(this.cmb_varis);
            this.pnl_tumsayfa.Location = new System.Drawing.Point(8, 5);
            this.pnl_tumsayfa.Name = "pnl_tumsayfa";
            this.pnl_tumsayfa.Size = new System.Drawing.Size(857, 364);
            this.pnl_tumsayfa.TabIndex = 64;
            // 
            // pnl_bilgiler
            // 
            this.pnl_bilgiler.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bilgiler.Controls.Add(this.btn_onayla);
            this.pnl_bilgiler.Controls.Add(this.txt_tutar);
            this.pnl_bilgiler.Controls.Add(this.btn_hesapla);
            this.pnl_bilgiler.Controls.Add(this.lbl_Tutar);
            this.pnl_bilgiler.Controls.Add(this.lbl_ktutar);
            this.pnl_bilgiler.Controls.Add(this.lbl_ututar);
            this.pnl_bilgiler.Controls.Add(this.cmb_otel);
            this.pnl_bilgiler.Controls.Add(this.cmb_ucak);
            this.pnl_bilgiler.Controls.Add(this.pic_ulasim);
            this.pnl_bilgiler.Controls.Add(this.pic_konaklama);
            this.pnl_bilgiler.Controls.Add(this.pic_tutar);
            this.pnl_bilgiler.Controls.Add(this.cmb_otobus);
            this.pnl_bilgiler.Controls.Add(this.cmb_ulasim);
            this.pnl_bilgiler.Controls.Add(this.cmb_kamp);
            this.pnl_bilgiler.Controls.Add(this.cmb_konaklama);
            this.pnl_bilgiler.Controls.Add(this.lbl_ucak);
            this.pnl_bilgiler.Controls.Add(this.lbl_otel);
            this.pnl_bilgiler.Controls.Add(this.lbl_otobus);
            this.pnl_bilgiler.Controls.Add(this.lbl_kamp);
            this.pnl_bilgiler.Controls.Add(this.label7);
            this.pnl_bilgiler.Controls.Add(this.label6);
            this.pnl_bilgiler.Location = new System.Drawing.Point(0, 140);
            this.pnl_bilgiler.Name = "pnl_bilgiler";
            this.pnl_bilgiler.Size = new System.Drawing.Size(857, 221);
            this.pnl_bilgiler.TabIndex = 8;
            this.pnl_bilgiler.Visible = false;
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_onayla.FlatAppearance.BorderSize = 0;
            this.btn_onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onayla.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onayla.Location = new System.Drawing.Point(764, 182);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(82, 33);
            this.btn_onayla.TabIndex = 66;
            this.btn_onayla.Text = "ONAYLA";
            this.btn_onayla.UseVisualStyleBackColor = false;
            this.btn_onayla.Visible = false;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // txt_tutar
            // 
            this.txt_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Location = new System.Drawing.Point(764, 140);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.ReadOnly = true;
            this.txt_tutar.Size = new System.Drawing.Size(82, 30);
            this.txt_tutar.TabIndex = 63;
            this.txt_tutar.Text = "0TL";
            this.txt_tutar.Visible = false;
            this.txt_tutar.WordWrap = false;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_hesapla.FlatAppearance.BorderSize = 0;
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesapla.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.ForeColor = System.Drawing.Color.White;
            this.btn_hesapla.Location = new System.Drawing.Point(666, 182);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(82, 33);
            this.btn_hesapla.TabIndex = 64;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Visible = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_Tutar
            // 
            this.lbl_Tutar.AutoSize = true;
            this.lbl_Tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tutar.ForeColor = System.Drawing.Color.Black;
            this.lbl_Tutar.Location = new System.Drawing.Point(693, 145);
            this.lbl_Tutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tutar.Name = "lbl_Tutar";
            this.lbl_Tutar.Size = new System.Drawing.Size(64, 25);
            this.lbl_Tutar.TabIndex = 65;
            this.lbl_Tutar.Text = "Tutar:";
            this.lbl_Tutar.Visible = false;
            // 
            // lbl_ktutar
            // 
            this.lbl_ktutar.AutoSize = true;
            this.lbl_ktutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ktutar.Location = new System.Drawing.Point(671, 31);
            this.lbl_ktutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ktutar.Name = "lbl_ktutar";
            this.lbl_ktutar.Size = new System.Drawing.Size(19, 25);
            this.lbl_ktutar.TabIndex = 7;
            this.lbl_ktutar.Text = "-";
            this.lbl_ktutar.Visible = false;
            // 
            // lbl_ututar
            // 
            this.lbl_ututar.AutoSize = true;
            this.lbl_ututar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ututar.Location = new System.Drawing.Point(671, 90);
            this.lbl_ututar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ututar.Name = "lbl_ututar";
            this.lbl_ututar.Size = new System.Drawing.Size(19, 25);
            this.lbl_ututar.TabIndex = 7;
            this.lbl_ututar.Text = "-";
            this.lbl_ututar.Visible = false;
            // 
            // cmb_otel
            // 
            this.cmb_otel.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_otel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_otel.FormattingEnabled = true;
            this.cmb_otel.Location = new System.Drawing.Point(310, 27);
            this.cmb_otel.Name = "cmb_otel";
            this.cmb_otel.Size = new System.Drawing.Size(196, 33);
            this.cmb_otel.TabIndex = 1;
            this.cmb_otel.Text = "-Otel Seçiniz-";
            this.cmb_otel.Visible = false;
            this.cmb_otel.SelectedIndexChanged += new System.EventHandler(this.cmb_otel_SelectedIndexChanged);
            // 
            // cmb_ucak
            // 
            this.cmb_ucak.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_ucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ucak.FormattingEnabled = true;
            this.cmb_ucak.Location = new System.Drawing.Point(311, 88);
            this.cmb_ucak.Name = "cmb_ucak";
            this.cmb_ucak.Size = new System.Drawing.Size(196, 33);
            this.cmb_ucak.TabIndex = 1;
            this.cmb_ucak.Text = "-Uçak Seçiniz-";
            this.cmb_ucak.Visible = false;
            this.cmb_ucak.SelectedIndexChanged += new System.EventHandler(this.cmb_ucak_SelectedIndexChanged);
            // 
            // pic_ulasim
            // 
            this.pic_ulasim.BackColor = System.Drawing.Color.Transparent;
            this.pic_ulasim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_ulasim.BackgroundImage")));
            this.pic_ulasim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_ulasim.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pic_ulasim.FlatAppearance.BorderSize = 0;
            this.pic_ulasim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_ulasim.Location = new System.Drawing.Point(213, 91);
            this.pic_ulasim.Name = "pic_ulasim";
            this.pic_ulasim.Size = new System.Drawing.Size(80, 30);
            this.pic_ulasim.TabIndex = 6;
            this.pic_ulasim.UseVisualStyleBackColor = false;
            this.pic_ulasim.Visible = false;
            this.pic_ulasim.Click += new System.EventHandler(this.pic_change_Click);
            // 
            // pic_konaklama
            // 
            this.pic_konaklama.BackColor = System.Drawing.Color.Transparent;
            this.pic_konaklama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_konaklama.BackgroundImage")));
            this.pic_konaklama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_konaklama.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pic_konaklama.FlatAppearance.BorderSize = 0;
            this.pic_konaklama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_konaklama.Location = new System.Drawing.Point(213, 27);
            this.pic_konaklama.Name = "pic_konaklama";
            this.pic_konaklama.Size = new System.Drawing.Size(80, 30);
            this.pic_konaklama.TabIndex = 6;
            this.pic_konaklama.UseVisualStyleBackColor = false;
            this.pic_konaklama.Visible = false;
            this.pic_konaklama.Click += new System.EventHandler(this.pic_change_Click);
            // 
            // pic_tutar
            // 
            this.pic_tutar.BackColor = System.Drawing.Color.Transparent;
            this.pic_tutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_tutar.BackgroundImage")));
            this.pic_tutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_tutar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pic_tutar.FlatAppearance.BorderSize = 0;
            this.pic_tutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_tutar.Location = new System.Drawing.Point(560, 57);
            this.pic_tutar.Name = "pic_tutar";
            this.pic_tutar.Size = new System.Drawing.Size(80, 30);
            this.pic_tutar.TabIndex = 6;
            this.pic_tutar.UseVisualStyleBackColor = false;
            this.pic_tutar.Visible = false;
            this.pic_tutar.Click += new System.EventHandler(this.pic_change_Click);
            // 
            // cmb_otobus
            // 
            this.cmb_otobus.BackColor = System.Drawing.Color.White;
            this.cmb_otobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_otobus.FormattingEnabled = true;
            this.cmb_otobus.Location = new System.Drawing.Point(311, 88);
            this.cmb_otobus.Name = "cmb_otobus";
            this.cmb_otobus.Size = new System.Drawing.Size(195, 33);
            this.cmb_otobus.TabIndex = 1;
            this.cmb_otobus.Text = "-Otobüs Seçiniz-";
            this.cmb_otobus.Visible = false;
            this.cmb_otobus.SelectedIndexChanged += new System.EventHandler(this.cmb_otobus_SelectedIndexChanged);
            // 
            // cmb_ulasim
            // 
            this.cmb_ulasim.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_ulasim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_ulasim.FormattingEnabled = true;
            this.cmb_ulasim.Items.AddRange(new object[] {
            "UÇAK",
            "OTOBÜS"});
            this.cmb_ulasim.Location = new System.Drawing.Point(14, 88);
            this.cmb_ulasim.Name = "cmb_ulasim";
            this.cmb_ulasim.Size = new System.Drawing.Size(180, 33);
            this.cmb_ulasim.TabIndex = 1;
            this.cmb_ulasim.SelectedIndexChanged += new System.EventHandler(this.cmb_ulasim_SelectedIndexChanged);
            // 
            // cmb_kamp
            // 
            this.cmb_kamp.BackColor = System.Drawing.Color.White;
            this.cmb_kamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kamp.FormattingEnabled = true;
            this.cmb_kamp.Location = new System.Drawing.Point(311, 27);
            this.cmb_kamp.Name = "cmb_kamp";
            this.cmb_kamp.Size = new System.Drawing.Size(195, 33);
            this.cmb_kamp.TabIndex = 1;
            this.cmb_kamp.Text = "-Kamp Seçiniz-";
            this.cmb_kamp.Visible = false;
            this.cmb_kamp.SelectedIndexChanged += new System.EventHandler(this.cmb_kamp_SelectedIndexChanged);
            // 
            // cmb_konaklama
            // 
            this.cmb_konaklama.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_konaklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_konaklama.FormattingEnabled = true;
            this.cmb_konaklama.Items.AddRange(new object[] {
            "OTEL",
            "KAMP"});
            this.cmb_konaklama.Location = new System.Drawing.Point(14, 27);
            this.cmb_konaklama.Name = "cmb_konaklama";
            this.cmb_konaklama.Size = new System.Drawing.Size(180, 33);
            this.cmb_konaklama.TabIndex = 1;
            this.cmb_konaklama.SelectedIndexChanged += new System.EventHandler(this.cmb_konaklama_SelectedIndexChanged);
            // 
            // lbl_ucak
            // 
            this.lbl_ucak.AutoSize = true;
            this.lbl_ucak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ucak.ForeColor = System.Drawing.Color.Black;
            this.lbl_ucak.Location = new System.Drawing.Point(308, 73);
            this.lbl_ucak.Name = "lbl_ucak";
            this.lbl_ucak.Size = new System.Drawing.Size(37, 13);
            this.lbl_ucak.TabIndex = 3;
            this.lbl_ucak.Text = "Uçak";
            this.lbl_ucak.Visible = false;
            // 
            // lbl_otel
            // 
            this.lbl_otel.AutoSize = true;
            this.lbl_otel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_otel.ForeColor = System.Drawing.Color.Black;
            this.lbl_otel.Location = new System.Drawing.Point(308, 11);
            this.lbl_otel.Name = "lbl_otel";
            this.lbl_otel.Size = new System.Drawing.Size(30, 13);
            this.lbl_otel.TabIndex = 3;
            this.lbl_otel.Text = "Otel";
            this.lbl_otel.Visible = false;
            // 
            // lbl_otobus
            // 
            this.lbl_otobus.AutoSize = true;
            this.lbl_otobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_otobus.ForeColor = System.Drawing.Color.Black;
            this.lbl_otobus.Location = new System.Drawing.Point(308, 73);
            this.lbl_otobus.Name = "lbl_otobus";
            this.lbl_otobus.Size = new System.Drawing.Size(47, 13);
            this.lbl_otobus.TabIndex = 3;
            this.lbl_otobus.Text = "Otobüs";
            this.lbl_otobus.Visible = false;
            // 
            // lbl_kamp
            // 
            this.lbl_kamp.AutoSize = true;
            this.lbl_kamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kamp.ForeColor = System.Drawing.Color.Black;
            this.lbl_kamp.Location = new System.Drawing.Point(308, 11);
            this.lbl_kamp.Name = "lbl_kamp";
            this.lbl_kamp.Size = new System.Drawing.Size(38, 13);
            this.lbl_kamp.TabIndex = 3;
            this.lbl_kamp.Text = "Kamp";
            this.lbl_kamp.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Konaklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ulaşım";
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ara.FlatAppearance.BorderSize = 0;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ForeColor = System.Drawing.Color.White;
            this.btn_ara.Location = new System.Drawing.Point(763, 101);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(82, 33);
            this.btn_ara.TabIndex = 7;
            this.btn_ara.Text = "İLERLE";
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // pic_change
            // 
            this.pic_change.BackColor = System.Drawing.Color.Transparent;
            this.pic_change.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_change.BackgroundImage")));
            this.pic_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_change.FlatAppearance.BorderSize = 0;
            this.pic_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_change.Location = new System.Drawing.Point(194, 65);
            this.pic_change.Name = "pic_change";
            this.pic_change.Size = new System.Drawing.Size(28, 28);
            this.pic_change.TabIndex = 6;
            this.pic_change.UseVisualStyleBackColor = false;
            this.pic_change.Click += new System.EventHandler(this.pic_change_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(662, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kişi Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(537, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dönüş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(410, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kalkış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(220, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Varış";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kalkış";
            // 
            // date_donus
            // 
            this.date_donus.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.date_donus.CustomFormat = "dd/MM/yyyy";
            this.date_donus.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_donus.Location = new System.Drawing.Point(538, 62);
            this.date_donus.Name = "date_donus";
            this.date_donus.Size = new System.Drawing.Size(120, 33);
            this.date_donus.TabIndex = 2;
            this.date_donus.Value = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            // 
            // date_kalkis
            // 
            this.date_kalkis.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.date_kalkis.CustomFormat = "dd/MM/yyyy";
            this.date_kalkis.Font = new System.Drawing.Font("Bebas Neue", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_kalkis.Location = new System.Drawing.Point(412, 62);
            this.date_kalkis.Name = "date_kalkis";
            this.date_kalkis.Size = new System.Drawing.Size(120, 33);
            this.date_kalkis.TabIndex = 2;
            this.date_kalkis.Value = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            // 
            // radio_tek
            // 
            this.radio_tek.AutoSize = true;
            this.radio_tek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_tek.ForeColor = System.Drawing.Color.Black;
            this.radio_tek.Location = new System.Drawing.Point(145, 16);
            this.radio_tek.Name = "radio_tek";
            this.radio_tek.Size = new System.Drawing.Size(84, 21);
            this.radio_tek.TabIndex = 0;
            this.radio_tek.TabStop = true;
            this.radio_tek.Text = "Tek yön";
            this.radio_tek.UseVisualStyleBackColor = true;
            this.radio_tek.CheckedChanged += new System.EventHandler(this.radio_tek_CheckedChanged);
            // 
            // radio_cift
            // 
            this.radio_cift.AutoSize = true;
            this.radio_cift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_cift.ForeColor = System.Drawing.Color.Black;
            this.radio_cift.Location = new System.Drawing.Point(14, 16);
            this.radio_cift.Name = "radio_cift";
            this.radio_cift.Size = new System.Drawing.Size(125, 21);
            this.radio_cift.TabIndex = 0;
            this.radio_cift.TabStop = true;
            this.radio_cift.Text = "Gidiş - Dönüş";
            this.radio_cift.UseVisualStyleBackColor = true;
            this.radio_cift.CheckedChanged += new System.EventHandler(this.radio_cift_CheckedChanged);
            // 
            // cmb_kalkis
            // 
            this.cmb_kalkis.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_kalkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kalkis.FormattingEnabled = true;
            this.cmb_kalkis.Items.AddRange(new object[] {
            "Antalya",
            "Muğla",
            "İzmir"});
            this.cmb_kalkis.Location = new System.Drawing.Point(14, 62);
            this.cmb_kalkis.Name = "cmb_kalkis";
            this.cmb_kalkis.Size = new System.Drawing.Size(180, 33);
            this.cmb_kalkis.TabIndex = 1;
            // 
            // cmb_kisi
            // 
            this.cmb_kisi.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_kisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_kisi.FormattingEnabled = true;
            this.cmb_kisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10+"});
            this.cmb_kisi.Location = new System.Drawing.Point(665, 62);
            this.cmb_kisi.Name = "cmb_kisi";
            this.cmb_kisi.Size = new System.Drawing.Size(180, 33);
            this.cmb_kisi.TabIndex = 1;
            // 
            // cmb_varis
            // 
            this.cmb_varis.BackColor = System.Drawing.SystemColors.Control;
            this.cmb_varis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_varis.FormattingEnabled = true;
            this.cmb_varis.Items.AddRange(new object[] {
            "Antalya",
            "Muğla",
            "İzmir"});
            this.cmb_varis.Location = new System.Drawing.Point(222, 62);
            this.cmb_varis.Name = "cmb_varis";
            this.cmb_varis.Size = new System.Drawing.Size(180, 33);
            this.cmb_varis.TabIndex = 1;
            this.cmb_varis.SelectedIndexChanged += new System.EventHandler(this.cmb_varis_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.data_seyahat);
            this.tabPage2.Controls.Add(this.cmb_cikti);
            this.tabPage2.Controls.Add(this.btn_cikti);
            this.tabPage2.Controls.Add(this.btn_tamamla);
            this.tabPage2.Controls.Add(this.data_bilgiler);
            this.tabPage2.Controls.Add(this.group_KimlikBilgileri);
            this.tabPage2.Controls.Add(this.btn_Gonder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(873, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kimlik Bilgileri";
            // 
            // data_seyahat
            // 
            this.data_seyahat.AllowUserToAddRows = false;
            this.data_seyahat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_seyahat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kalkis_yeri,
            this.kalkis_tarihi,
            this.ulasim_araci,
            this.konaklama_turu,
            this.mekan_konum,
            this.mekan_adi,
            this.kisi_sayi,
            this.gun,
            this.tutar});
            this.data_seyahat.Location = new System.Drawing.Point(10, 160);
            this.data_seyahat.Name = "data_seyahat";
            this.data_seyahat.RowHeadersVisible = false;
            this.data_seyahat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_seyahat.Size = new System.Drawing.Size(856, 167);
            this.data_seyahat.TabIndex = 11;
            this.data_seyahat.Visible = false;
            // 
            // cmb_cikti
            // 
            this.cmb_cikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_cikti.FormattingEnabled = true;
            this.cmb_cikti.Items.AddRange(new object[] {
            "JSON",
            "XML",
            "HTML"});
            this.cmb_cikti.Location = new System.Drawing.Point(532, 335);
            this.cmb_cikti.Name = "cmb_cikti";
            this.cmb_cikti.Size = new System.Drawing.Size(132, 33);
            this.cmb_cikti.TabIndex = 10;
            this.cmb_cikti.Text = "-Tür seçiniz-";
            this.cmb_cikti.Visible = false;
            // 
            // btn_cikti
            // 
            this.btn_cikti.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_cikti.FlatAppearance.BorderSize = 0;
            this.btn_cikti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikti.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikti.ForeColor = System.Drawing.Color.White;
            this.btn_cikti.Location = new System.Drawing.Point(670, 334);
            this.btn_cikti.Name = "btn_cikti";
            this.btn_cikti.Size = new System.Drawing.Size(196, 35);
            this.btn_cikti.TabIndex = 8;
            this.btn_cikti.Text = "ÇIKTI AL";
            this.btn_cikti.UseVisualStyleBackColor = false;
            this.btn_cikti.Visible = false;
            this.btn_cikti.Click += new System.EventHandler(this.btn_cikti_Click);
            // 
            // btn_tamamla
            // 
            this.btn_tamamla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_tamamla.FlatAppearance.BorderSize = 0;
            this.btn_tamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tamamla.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tamamla.ForeColor = System.Drawing.Color.White;
            this.btn_tamamla.Location = new System.Drawing.Point(670, 161);
            this.btn_tamamla.Name = "btn_tamamla";
            this.btn_tamamla.Size = new System.Drawing.Size(196, 35);
            this.btn_tamamla.TabIndex = 8;
            this.btn_tamamla.Text = "Rezervasyonu tamamla";
            this.btn_tamamla.UseVisualStyleBackColor = false;
            this.btn_tamamla.Click += new System.EventHandler(this.btn_tamamla_Click);
            // 
            // data_bilgiler
            // 
            this.data_bilgiler.AllowUserToAddRows = false;
            this.data_bilgiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_bilgiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.data_bilgiler.Location = new System.Drawing.Point(252, 11);
            this.data_bilgiler.Margin = new System.Windows.Forms.Padding(2);
            this.data_bilgiler.Name = "data_bilgiler";
            this.data_bilgiler.RowHeadersWidth = 51;
            this.data_bilgiler.RowTemplate.Height = 24;
            this.data_bilgiler.Size = new System.Drawing.Size(614, 144);
            this.data_bilgiler.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mail";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cinsiyet";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 75;
            // 
            // group_KimlikBilgileri
            // 
            this.group_KimlikBilgileri.Controls.Add(this.msked_telefon);
            this.group_KimlikBilgileri.Controls.Add(this.cmb_Cinsiyet);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Cinsiyet);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_KimlikNo);
            this.group_KimlikBilgileri.Controls.Add(this.txt_Mail);
            this.group_KimlikBilgileri.Controls.Add(this.txt_KimlikNo);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Mail);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Ad);
            this.group_KimlikBilgileri.Controls.Add(this.txt_Ad);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Telefon);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Soyad);
            this.group_KimlikBilgileri.Controls.Add(this.txt_Soyad);
            this.group_KimlikBilgileri.Location = new System.Drawing.Point(7, 15);
            this.group_KimlikBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.group_KimlikBilgileri.Name = "group_KimlikBilgileri";
            this.group_KimlikBilgileri.Padding = new System.Windows.Forms.Padding(2);
            this.group_KimlikBilgileri.Size = new System.Drawing.Size(241, 176);
            this.group_KimlikBilgileri.TabIndex = 5;
            this.group_KimlikBilgileri.TabStop = false;
            this.group_KimlikBilgileri.Text = "1.Kişinin Bilgileri";
            // 
            // msked_telefon
            // 
            this.msked_telefon.BeepOnError = true;
            this.msked_telefon.Location = new System.Drawing.Point(84, 94);
            this.msked_telefon.Margin = new System.Windows.Forms.Padding(2);
            this.msked_telefon.Mask = "(999) 000-0000";
            this.msked_telefon.Name = "msked_telefon";
            this.msked_telefon.Size = new System.Drawing.Size(136, 20);
            this.msked_telefon.TabIndex = 4;
            // 
            // cmb_Cinsiyet
            // 
            this.cmb_Cinsiyet.FormattingEnabled = true;
            this.cmb_Cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmb_Cinsiyet.Location = new System.Drawing.Point(84, 144);
            this.cmb_Cinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Cinsiyet.Name = "cmb_Cinsiyet";
            this.cmb_Cinsiyet.Size = new System.Drawing.Size(136, 21);
            this.cmb_Cinsiyet.TabIndex = 6;
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(34, 146);
            this.lbl_Cinsiyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(46, 13);
            this.lbl_Cinsiyet.TabIndex = 2;
            this.lbl_Cinsiyet.Text = "Cinsiyet:";
            // 
            // lbl_KimlikNo
            // 
            this.lbl_KimlikNo.AutoSize = true;
            this.lbl_KimlikNo.Location = new System.Drawing.Point(8, 20);
            this.lbl_KimlikNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_KimlikNo.Name = "lbl_KimlikNo";
            this.lbl_KimlikNo.Size = new System.Drawing.Size(74, 13);
            this.lbl_KimlikNo.TabIndex = 0;
            this.lbl_KimlikNo.Text = "T.C Kimlik No:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(84, 120);
            this.txt_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(136, 20);
            this.txt_Mail.TabIndex = 5;
            // 
            // txt_KimlikNo
            // 
            this.txt_KimlikNo.Location = new System.Drawing.Point(84, 20);
            this.txt_KimlikNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_KimlikNo.MaxLength = 11;
            this.txt_KimlikNo.Name = "txt_KimlikNo";
            this.txt_KimlikNo.Size = new System.Drawing.Size(136, 20);
            this.txt_KimlikNo.TabIndex = 1;
            this.txt_KimlikNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KimlikNo_KeyPress);
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(52, 122);
            this.lbl_Mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(29, 13);
            this.lbl_Mail.TabIndex = 0;
            this.lbl_Mail.Text = "Mail:";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(58, 46);
            this.lbl_Ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(23, 13);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "Ad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(84, 45);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(136, 20);
            this.txt_Ad.TabIndex = 2;
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(34, 97);
            this.lbl_Telefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(46, 13);
            this.lbl_Telefon.TabIndex = 0;
            this.lbl_Telefon.Text = "Telefon:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(40, 71);
            this.lbl_Soyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(40, 13);
            this.lbl_Soyad.TabIndex = 0;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(84, 70);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(136, 20);
            this.txt_Soyad.TabIndex = 3;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Gonder.FlatAppearance.BorderSize = 0;
            this.btn_Gonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gonder.ForeColor = System.Drawing.Color.White;
            this.btn_Gonder.Location = new System.Drawing.Point(31, 195);
            this.btn_Gonder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(196, 35);
            this.btn_Gonder.TabIndex = 7;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = false;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // kalkis_yeri
            // 
            this.kalkis_yeri.HeaderText = "KALKIŞ YERİ";
            this.kalkis_yeri.Name = "kalkis_yeri";
            this.kalkis_yeri.ReadOnly = true;
            // 
            // kalkis_tarihi
            // 
            this.kalkis_tarihi.HeaderText = "TARİH";
            this.kalkis_tarihi.Name = "kalkis_tarihi";
            this.kalkis_tarihi.ReadOnly = true;
            // 
            // ulasim_araci
            // 
            this.ulasim_araci.HeaderText = "ULAŞIM ARACI";
            this.ulasim_araci.Name = "ulasim_araci";
            this.ulasim_araci.ReadOnly = true;
            // 
            // konaklama_turu
            // 
            this.konaklama_turu.HeaderText = "KONAKLAMA";
            this.konaklama_turu.Name = "konaklama_turu";
            this.konaklama_turu.ReadOnly = true;
            // 
            // mekan_konum
            // 
            this.mekan_konum.HeaderText = "KONUM";
            this.mekan_konum.Name = "mekan_konum";
            this.mekan_konum.ReadOnly = true;
            // 
            // mekan_adi
            // 
            this.mekan_adi.HeaderText = "MEKAN ADI";
            this.mekan_adi.Name = "mekan_adi";
            this.mekan_adi.ReadOnly = true;
            // 
            // kisi_sayi
            // 
            this.kisi_sayi.HeaderText = "KİŞİ SAYISI";
            this.kisi_sayi.Name = "kisi_sayi";
            this.kisi_sayi.ReadOnly = true;
            // 
            // gun
            // 
            this.gun.HeaderText = "GÜN";
            this.gun.Name = "gun";
            this.gun.ReadOnly = true;
            // 
            // tutar
            // 
            this.tutar.HeaderText = "TOPLAM TUTAR";
            this.tutar.Name = "tutar";
            this.tutar.ReadOnly = true;
            // 
            // SeyahatBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 400);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeyahatBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabpage1.ResumeLayout(false);
            this.pnl_tumsayfa.ResumeLayout(false);
            this.pnl_tumsayfa.PerformLayout();
            this.pnl_bilgiler.ResumeLayout(false);
            this.pnl_bilgiler.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_seyahat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_bilgiler)).EndInit();
            this.group_KimlikBilgileri.ResumeLayout(false);
            this.group_KimlikBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.Panel pnl_tumsayfa;
        private System.Windows.Forms.RadioButton radio_cift;
        private System.Windows.Forms.ComboBox cmb_kalkis;
        private System.Windows.Forms.ComboBox cmb_varis;
        private System.Windows.Forms.DateTimePicker date_kalkis;
        private System.Windows.Forms.ComboBox cmb_kisi;
        private System.Windows.Forms.Button pic_change;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_tek;
        private System.Windows.Forms.Panel pnl_bilgiler;
        private System.Windows.Forms.ComboBox cmb_otobus;
        private System.Windows.Forms.ComboBox cmb_ulasim;
        private System.Windows.Forms.ComboBox cmb_kamp;
        private System.Windows.Forms.ComboBox cmb_konaklama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.ComboBox cmb_otel;
        private System.Windows.Forms.ComboBox cmb_ucak;
        private System.Windows.Forms.Button pic_konaklama;
        private System.Windows.Forms.Button pic_tutar;
        private System.Windows.Forms.Label lbl_ucak;
        private System.Windows.Forms.Label lbl_otel;
        private System.Windows.Forms.Label lbl_otobus;
        private System.Windows.Forms.Label lbl_kamp;
        private System.Windows.Forms.Button pic_ulasim;
        private System.Windows.Forms.DateTimePicker date_donus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox group_KimlikBilgileri;
        private System.Windows.Forms.MaskedTextBox msked_telefon;
        private System.Windows.Forms.ComboBox cmb_Cinsiyet;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        private System.Windows.Forms.Label lbl_KimlikNo;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.TextBox txt_KimlikNo;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.DataGridView data_bilgiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btn_tamamla;
        private System.Windows.Forms.Button btn_cikti;
        private System.Windows.Forms.ComboBox cmb_cikti;
        private System.Windows.Forms.Label lbl_ktutar;
        private System.Windows.Forms.Label lbl_ututar;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_Tutar;
        private System.Windows.Forms.DataGridView data_seyahat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkis_yeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalkis_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulasim_araci;
        private System.Windows.Forms.DataGridViewTextBoxColumn konaklama_turu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mekan_konum;
        private System.Windows.Forms.DataGridViewTextBoxColumn mekan_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisi_sayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gun;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
    }
}

