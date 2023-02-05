namespace UILayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblYoneticiGirisi = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.grpCreateNewAccount = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtSifreTekrari = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdii = new System.Windows.Forms.TextBox();
            this.lblSifreTekrari = new System.Windows.Forms.Label();
            this.lblKullaniciAdii = new System.Windows.Forms.Label();
            this.txtSifree = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedList = new System.Windows.Forms.DataGridView();
            this.cmbAlbumListeleri = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblAlbumListeleri = new System.Windows.Forms.Label();
            this.rdbHayır = new System.Windows.Forms.RadioButton();
            this.rdbEvet = new System.Windows.Forms.RadioButton();
            this.lblSatisiDevamEdiyorMu = new System.Windows.Forms.Label();
            this.rdbYok = new System.Windows.Forms.RadioButton();
            this.rdbVar = new System.Windows.Forms.RadioButton();
            this.lblIndirimOranı = new System.Windows.Forms.Label();
            this.dTPAlbumCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblAlbumCikisTarihi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAlbumFiyatı = new System.Windows.Forms.TextBox();
            this.txtAlbumAdi = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblAlbumFiyatı = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSanatci = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpCreateNewAccount.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.lblYoneticiGirisi);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.lblKullaniciAdi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(324, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(455, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giris Ekrani";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnGiris.Location = new System.Drawing.Point(122, 136);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(298, 33);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(122, 64);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(298, 31);
            this.txtSifre.TabIndex = 2;
            // 
            // lblYoneticiGirisi
            // 
            this.lblYoneticiGirisi.AutoSize = true;
            this.lblYoneticiGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblYoneticiGirisi.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblYoneticiGirisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.lblYoneticiGirisi.Location = new System.Drawing.Point(122, 101);
            this.lblYoneticiGirisi.Name = "lblYoneticiGirisi";
            this.lblYoneticiGirisi.Size = new System.Drawing.Size(151, 25);
            this.lblYoneticiGirisi.TabIndex = 4;
            this.lblYoneticiGirisi.Text = "Yeni Yonetici Girisi";
            this.lblYoneticiGirisi.Click += new System.EventHandler(this.lblYoneticiGirisi_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(63, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 25);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(122, 30);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(298, 31);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(0, 34);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(111, 25);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanici Adi:";
            // 
            // grpCreateNewAccount
            // 
            this.grpCreateNewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.grpCreateNewAccount.Controls.Add(this.btnExit);
            this.grpCreateNewAccount.Controls.Add(this.btnOlustur);
            this.grpCreateNewAccount.Controls.Add(this.txtSifreTekrari);
            this.grpCreateNewAccount.Controls.Add(this.txtKullaniciAdii);
            this.grpCreateNewAccount.Controls.Add(this.lblSifreTekrari);
            this.grpCreateNewAccount.Controls.Add(this.lblKullaniciAdii);
            this.grpCreateNewAccount.Controls.Add(this.txtSifree);
            this.grpCreateNewAccount.Controls.Add(this.lblSifre);
            this.grpCreateNewAccount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpCreateNewAccount.Location = new System.Drawing.Point(301, 151);
            this.grpCreateNewAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCreateNewAccount.Name = "grpCreateNewAccount";
            this.grpCreateNewAccount.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCreateNewAccount.Size = new System.Drawing.Size(472, 213);
            this.grpCreateNewAccount.TabIndex = 2;
            this.grpCreateNewAccount.TabStop = false;
            this.grpCreateNewAccount.Text = "Yeni Yönetici Olusturma Ekrani";
            this.grpCreateNewAccount.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(953, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnOlustur.Location = new System.Drawing.Point(139, 148);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(293, 29);
            this.btnOlustur.TabIndex = 15;
            this.btnOlustur.Text = "Olustur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtSifreTekrari
            // 
            this.txtSifreTekrari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtSifreTekrari.Location = new System.Drawing.Point(139, 110);
            this.txtSifreTekrari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifreTekrari.Name = "txtSifreTekrari";
            this.txtSifreTekrari.PasswordChar = '*';
            this.txtSifreTekrari.Size = new System.Drawing.Size(294, 32);
            this.txtSifreTekrari.TabIndex = 6;
            // 
            // txtKullaniciAdii
            // 
            this.txtKullaniciAdii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtKullaniciAdii.Location = new System.Drawing.Point(139, 29);
            this.txtKullaniciAdii.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKullaniciAdii.Name = "txtKullaniciAdii";
            this.txtKullaniciAdii.Size = new System.Drawing.Size(294, 32);
            this.txtKullaniciAdii.TabIndex = 4;
            // 
            // lblSifreTekrari
            // 
            this.lblSifreTekrari.AutoSize = true;
            this.lblSifreTekrari.Location = new System.Drawing.Point(21, 109);
            this.lblSifreTekrari.Name = "lblSifreTekrari";
            this.lblSifreTekrari.Size = new System.Drawing.Size(115, 25);
            this.lblSifreTekrari.TabIndex = 0;
            this.lblSifreTekrari.Text = "Sifre Tekrari:";
            // 
            // lblKullaniciAdii
            // 
            this.lblKullaniciAdii.AutoSize = true;
            this.lblKullaniciAdii.Location = new System.Drawing.Point(13, 28);
            this.lblKullaniciAdii.Name = "lblKullaniciAdii";
            this.lblKullaniciAdii.Size = new System.Drawing.Size(121, 25);
            this.lblKullaniciAdii.TabIndex = 0;
            this.lblKullaniciAdii.Text = "Kullanici Adi:";
            // 
            // txtSifree
            // 
            this.txtSifree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtSifree.Location = new System.Drawing.Point(139, 71);
            this.txtSifree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSifree.Name = "txtSifree";
            this.txtSifree.PasswordChar = '*';
            this.txtSifree.Size = new System.Drawing.Size(294, 32);
            this.txtSifree.TabIndex = 5;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(82, 70);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(54, 25);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Sifre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.groupBox2.Controls.Add(this.dgvSelectedList);
            this.groupBox2.Controls.Add(this.cmbAlbumListeleri);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.lblAlbumListeleri);
            this.groupBox2.Controls.Add(this.rdbHayır);
            this.groupBox2.Controls.Add(this.rdbEvet);
            this.groupBox2.Controls.Add(this.lblSatisiDevamEdiyorMu);
            this.groupBox2.Controls.Add(this.rdbYok);
            this.groupBox2.Controls.Add(this.rdbVar);
            this.groupBox2.Controls.Add(this.lblIndirimOranı);
            this.groupBox2.Controls.Add(this.dTPAlbumCikisTarihi);
            this.groupBox2.Controls.Add(this.lblAlbumCikisTarihi);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtAlbumFiyatı);
            this.groupBox2.Controls.Add(this.txtAlbumAdi);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.lblAlbumFiyatı);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lblSanatci);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1078, 284);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Album Ekle/Guncelle/Sil";
            this.groupBox2.Visible = false;
            // 
            // dgvSelectedList
            // 
            this.dgvSelectedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedList.Location = new System.Drawing.Point(558, 68);
            this.dgvSelectedList.Name = "dgvSelectedList";
            this.dgvSelectedList.RowTemplate.Height = 25;
            this.dgvSelectedList.Size = new System.Drawing.Size(509, 204);
            this.dgvSelectedList.TabIndex = 34;
            // 
            // cmbAlbumListeleri
            // 
            this.cmbAlbumListeleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.cmbAlbumListeleri.FormattingEnabled = true;
            this.cmbAlbumListeleri.Location = new System.Drawing.Point(709, 30);
            this.cmbAlbumListeleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAlbumListeleri.Name = "cmbAlbumListeleri";
            this.cmbAlbumListeleri.Size = new System.Drawing.Size(251, 33);
            this.cmbAlbumListeleri.TabIndex = 33;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnListele.Location = new System.Drawing.Point(987, 29);
            this.btnListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(85, 29);
            this.btnListele.TabIndex = 32;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            // 
            // lblAlbumListeleri
            // 
            this.lblAlbumListeleri.AutoSize = true;
            this.lblAlbumListeleri.Location = new System.Drawing.Point(558, 30);
            this.lblAlbumListeleri.Name = "lblAlbumListeleri";
            this.lblAlbumListeleri.Size = new System.Drawing.Size(141, 25);
            this.lblAlbumListeleri.TabIndex = 30;
            this.lblAlbumListeleri.Text = "Album Listeleri:";
            // 
            // rdbHayır
            // 
            this.rdbHayır.AutoSize = true;
            this.rdbHayır.Location = new System.Drawing.Point(383, 196);
            this.rdbHayır.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbHayır.Name = "rdbHayır";
            this.rdbHayır.Size = new System.Drawing.Size(74, 29);
            this.rdbHayır.TabIndex = 25;
            this.rdbHayır.TabStop = true;
            this.rdbHayır.Text = "Hayır";
            this.rdbHayır.UseVisualStyleBackColor = true;
            // 
            // rdbEvet
            // 
            this.rdbEvet.AutoSize = true;
            this.rdbEvet.Location = new System.Drawing.Point(276, 196);
            this.rdbEvet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbEvet.Name = "rdbEvet";
            this.rdbEvet.Size = new System.Drawing.Size(65, 29);
            this.rdbEvet.TabIndex = 24;
            this.rdbEvet.TabStop = true;
            this.rdbEvet.Text = "Evet";
            this.rdbEvet.UseVisualStyleBackColor = true;
            // 
            // lblSatisiDevamEdiyorMu
            // 
            this.lblSatisiDevamEdiyorMu.AutoSize = true;
            this.lblSatisiDevamEdiyorMu.Location = new System.Drawing.Point(-1, 198);
            this.lblSatisiDevamEdiyorMu.Name = "lblSatisiDevamEdiyorMu";
            this.lblSatisiDevamEdiyorMu.Size = new System.Drawing.Size(223, 25);
            this.lblSatisiDevamEdiyorMu.TabIndex = 23;
            this.lblSatisiDevamEdiyorMu.Text = "Satisi Devam Ediyor Mu?:";
            // 
            // rdbYok
            // 
            this.rdbYok.AutoSize = true;
            this.rdbYok.Location = new System.Drawing.Point(383, 166);
            this.rdbYok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbYok.Name = "rdbYok";
            this.rdbYok.Size = new System.Drawing.Size(59, 29);
            this.rdbYok.TabIndex = 22;
            this.rdbYok.TabStop = true;
            this.rdbYok.Text = "Yok";
            this.rdbYok.UseVisualStyleBackColor = true;
            // 
            // rdbVar
            // 
            this.rdbVar.AutoSize = true;
            this.rdbVar.Location = new System.Drawing.Point(276, 166);
            this.rdbVar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbVar.Name = "rdbVar";
            this.rdbVar.Size = new System.Drawing.Size(58, 29);
            this.rdbVar.TabIndex = 21;
            this.rdbVar.TabStop = true;
            this.rdbVar.Text = "Var";
            this.rdbVar.UseVisualStyleBackColor = true;
            // 
            // lblIndirimOranı
            // 
            this.lblIndirimOranı.AutoSize = true;
            this.lblIndirimOranı.Location = new System.Drawing.Point(84, 168);
            this.lblIndirimOranı.Name = "lblIndirimOranı";
            this.lblIndirimOranı.Size = new System.Drawing.Size(145, 25);
            this.lblIndirimOranı.TabIndex = 20;
            this.lblIndirimOranı.Text = "Indirim Var Mı?:";
            // 
            // dTPAlbumCikisTarihi
            // 
            this.dTPAlbumCikisTarihi.Location = new System.Drawing.Point(242, 100);
            this.dTPAlbumCikisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTPAlbumCikisTarihi.Name = "dTPAlbumCikisTarihi";
            this.dTPAlbumCikisTarihi.Size = new System.Drawing.Size(294, 32);
            this.dTPAlbumCikisTarihi.TabIndex = 19;
            // 
            // lblAlbumCikisTarihi
            // 
            this.lblAlbumCikisTarihi.AutoSize = true;
            this.lblAlbumCikisTarihi.Location = new System.Drawing.Point(61, 100);
            this.lblAlbumCikisTarihi.Name = "lblAlbumCikisTarihi";
            this.lblAlbumCikisTarihi.Size = new System.Drawing.Size(166, 25);
            this.lblAlbumCikisTarihi.TabIndex = 18;
            this.lblAlbumCikisTarihi.Text = "Album Cikis Tarihi:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnEkle.Location = new System.Drawing.Point(242, 238);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 29);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // txtAlbumFiyatı
            // 
            this.txtAlbumFiyatı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtAlbumFiyatı.Location = new System.Drawing.Point(242, 134);
            this.txtAlbumFiyatı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlbumFiyatı.Name = "txtAlbumFiyatı";
            this.txtAlbumFiyatı.PasswordChar = '*';
            this.txtAlbumFiyatı.Size = new System.Drawing.Size(294, 32);
            this.txtAlbumFiyatı.TabIndex = 6;
            // 
            // txtAlbumAdi
            // 
            this.txtAlbumAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.txtAlbumAdi.Location = new System.Drawing.Point(242, 28);
            this.txtAlbumAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAlbumAdi.Name = "txtAlbumAdi";
            this.txtAlbumAdi.Size = new System.Drawing.Size(294, 32);
            this.txtAlbumAdi.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnSil.Location = new System.Drawing.Point(474, 238);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 29);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnGuncelle.Location = new System.Drawing.Point(352, 238);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 29);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // lblAlbumFiyatı
            // 
            this.lblAlbumFiyatı.AutoSize = true;
            this.lblAlbumFiyatı.Location = new System.Drawing.Point(108, 136);
            this.lblAlbumFiyatı.Name = "lblAlbumFiyatı";
            this.lblAlbumFiyatı.Size = new System.Drawing.Size(120, 25);
            this.lblAlbumFiyatı.TabIndex = 0;
            this.lblAlbumFiyatı.Text = "Album Fiyati:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Album Adi:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.textBox3.Location = new System.Drawing.Point(242, 62);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(294, 32);
            this.textBox3.TabIndex = 5;
            // 
            // lblSanatci
            // 
            this.lblSanatci.AutoSize = true;
            this.lblSanatci.Location = new System.Drawing.Point(21, 62);
            this.lblSanatci.Name = "lblSanatci";
            this.lblSanatci.Size = new System.Drawing.Size(203, 25);
            this.lblSanatci.TabIndex = 0;
            this.lblSanatci.Text = "Sanatci/Sanatci Grubu:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1081, 496);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpCreateNewAccount);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Yonetici Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCreateNewAccount.ResumeLayout(false);
            this.grpCreateNewAccount.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGiris;
        private TextBox txtSifre;
        private Label lblYoneticiGirisi;
        private Label lblPassword;
        private TextBox txtKullaniciAdi;
        private Label lblKullaniciAdi;
        private GroupBox grpCreateNewAccount;
        private Button btnExit;
        private Button btnOlustur;
        private TextBox txtSifreTekrari;
        private TextBox txtKullaniciAdii;
        private Label lblSifreTekrari;
        private Label lblKullaniciAdii;
        private TextBox txtSifree;
        private Label lblSifre;
        private GroupBox groupBox2;
        private RadioButton rdbHayır;
        private RadioButton rdbEvet;
        private Label lblSatisiDevamEdiyorMu;
        private RadioButton rdbYok;
        private RadioButton rdbVar;
        private Label lblIndirimOranı;
        private DateTimePicker dTPAlbumCikisTarihi;
        private Label lblAlbumCikisTarihi;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtAlbumFiyatı;
        private TextBox txtAlbumAdi;
        private Label lblAlbumFiyatı;
        private Label label2;
        private TextBox textBox3;
        private Label lblSanatci;
        private ComboBox cmbAlbumListeleri;
        private Button btnListele;
        private Label lblAlbumListeleri;
        private DataGridView dgvSelectedList;
    }


    }
