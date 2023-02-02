namespace FORM_PERSONEL_SAMPLE
{
    partial class PersonelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.nUpYas = new System.Windows.Forms.NumericUpDown();
            this.grpBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.grpBoxEgitim = new System.Windows.Forms.GroupBox();
            this.btnEgitimTemizle = new System.Windows.Forms.Button();
            this.rdDoktora = new System.Windows.Forms.RadioButton();
            this.rdYuksekLisans = new System.Windows.Forms.RadioButton();
            this.rdUniversite = new System.Windows.Forms.RadioButton();
            this.rdYuksekOkul = new System.Windows.Forms.RadioButton();
            this.rdLise = new System.Windows.Forms.RadioButton();
            this.rdOrtaOkul = new System.Windows.Forms.RadioButton();
            this.rdIlkOkul = new System.Windows.Forms.RadioButton();
            this.grpHobi = new System.Windows.Forms.GroupBox();
            this.btnHobiTemizle = new System.Windows.Forms.Button();
            this.chkGonulluFaaliyetler = new System.Windows.Forms.CheckBox();
            this.chkGeziSeyahat = new System.Windows.Forms.CheckBox();
            this.chkFotografcilik = new System.Windows.Forms.CheckBox();
            this.chkSinema = new System.Windows.Forms.CheckBox();
            this.chkBahceIsleri = new System.Windows.Forms.CheckBox();
            this.chkSatranc = new System.Windows.Forms.CheckBox();
            this.chkSpor = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lvPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nUpYas)).BeginInit();
            this.grpBoxCinsiyet.SuspendLayout();
            this.grpBoxEgitim.SuspendLayout();
            this.grpHobi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yaş :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(174, 24);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(174, 77);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 7;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(174, 127);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpDogumTarihi.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // mTxtTelefon
            // 
            this.mTxtTelefon.Location = new System.Drawing.Point(174, 228);
            this.mTxtTelefon.Mask = "(999) 000-0000";
            this.mTxtTelefon.Name = "mTxtTelefon";
            this.mTxtTelefon.Size = new System.Drawing.Size(200, 22);
            this.mTxtTelefon.TabIndex = 10;
            // 
            // nUpYas
            // 
            this.nUpYas.Location = new System.Drawing.Point(174, 280);
            this.nUpYas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpYas.Name = "nUpYas";
            this.nUpYas.Size = new System.Drawing.Size(200, 22);
            this.nUpYas.TabIndex = 11;
            this.nUpYas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpBoxCinsiyet
            // 
            this.grpBoxCinsiyet.Controls.Add(this.label7);
            this.grpBoxCinsiyet.Controls.Add(this.rdKadin);
            this.grpBoxCinsiyet.Controls.Add(this.rdErkek);
            this.grpBoxCinsiyet.Location = new System.Drawing.Point(17, 327);
            this.grpBoxCinsiyet.Name = "grpBoxCinsiyet";
            this.grpBoxCinsiyet.Size = new System.Drawing.Size(395, 117);
            this.grpBoxCinsiyet.TabIndex = 12;
            this.grpBoxCinsiyet.TabStop = false;
            this.grpBoxCinsiyet.Tag = "0";
            this.grpBoxCinsiyet.Text = "Cinsiyet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(21, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(353, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Aşağıdaki Seçeneklerden Birisini Seçiniz";
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Location = new System.Drawing.Point(142, 74);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(68, 20);
            this.rdKadin.TabIndex = 1;
            this.rdKadin.TabStop = true;
            this.rdKadin.Text = "KADIN";
            this.rdKadin.UseVisualStyleBackColor = true;
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Location = new System.Drawing.Point(33, 74);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(72, 20);
            this.rdErkek.TabIndex = 0;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "ERKEK";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // grpBoxEgitim
            // 
            this.grpBoxEgitim.Controls.Add(this.btnEgitimTemizle);
            this.grpBoxEgitim.Controls.Add(this.rdDoktora);
            this.grpBoxEgitim.Controls.Add(this.rdYuksekLisans);
            this.grpBoxEgitim.Controls.Add(this.rdUniversite);
            this.grpBoxEgitim.Controls.Add(this.rdYuksekOkul);
            this.grpBoxEgitim.Controls.Add(this.rdLise);
            this.grpBoxEgitim.Controls.Add(this.rdOrtaOkul);
            this.grpBoxEgitim.Controls.Add(this.rdIlkOkul);
            this.grpBoxEgitim.Location = new System.Drawing.Point(420, 22);
            this.grpBoxEgitim.Name = "grpBoxEgitim";
            this.grpBoxEgitim.Size = new System.Drawing.Size(207, 422);
            this.grpBoxEgitim.TabIndex = 13;
            this.grpBoxEgitim.TabStop = false;
            this.grpBoxEgitim.Tag = "0";
            this.grpBoxEgitim.Text = "Eğitim Bilgileri";
            // 
            // btnEgitimTemizle
            // 
            this.btnEgitimTemizle.Location = new System.Drawing.Point(14, 379);
            this.btnEgitimTemizle.Name = "btnEgitimTemizle";
            this.btnEgitimTemizle.Size = new System.Drawing.Size(187, 29);
            this.btnEgitimTemizle.TabIndex = 17;
            this.btnEgitimTemizle.Text = "Temizle";
            this.btnEgitimTemizle.UseVisualStyleBackColor = true;
            this.btnEgitimTemizle.Click += new System.EventHandler(this.btnEgitimTemizle_Click);
            // 
            // rdDoktora
            // 
            this.rdDoktora.AutoSize = true;
            this.rdDoktora.Location = new System.Drawing.Point(43, 341);
            this.rdDoktora.Name = "rdDoktora";
            this.rdDoktora.Size = new System.Drawing.Size(76, 20);
            this.rdDoktora.TabIndex = 6;
            this.rdDoktora.TabStop = true;
            this.rdDoktora.Text = "Doktora";
            this.rdDoktora.UseVisualStyleBackColor = true;
            // 
            // rdYuksekLisans
            // 
            this.rdYuksekLisans.AutoSize = true;
            this.rdYuksekLisans.Location = new System.Drawing.Point(43, 292);
            this.rdYuksekLisans.Name = "rdYuksekLisans";
            this.rdYuksekLisans.Size = new System.Drawing.Size(115, 20);
            this.rdYuksekLisans.TabIndex = 5;
            this.rdYuksekLisans.TabStop = true;
            this.rdYuksekLisans.Text = "Yüksek Lisans";
            this.rdYuksekLisans.UseVisualStyleBackColor = true;
            // 
            // rdUniversite
            // 
            this.rdUniversite.AutoSize = true;
            this.rdUniversite.Location = new System.Drawing.Point(43, 243);
            this.rdUniversite.Name = "rdUniversite";
            this.rdUniversite.Size = new System.Drawing.Size(88, 20);
            this.rdUniversite.TabIndex = 4;
            this.rdUniversite.TabStop = true;
            this.rdUniversite.Text = "Üniversite";
            this.rdUniversite.UseVisualStyleBackColor = true;
            // 
            // rdYuksekOkul
            // 
            this.rdYuksekOkul.AutoSize = true;
            this.rdYuksekOkul.Location = new System.Drawing.Point(43, 194);
            this.rdYuksekOkul.Name = "rdYuksekOkul";
            this.rdYuksekOkul.Size = new System.Drawing.Size(103, 20);
            this.rdYuksekOkul.TabIndex = 3;
            this.rdYuksekOkul.TabStop = true;
            this.rdYuksekOkul.Text = "Yüksek Okul";
            this.rdYuksekOkul.UseVisualStyleBackColor = true;
            // 
            // rdLise
            // 
            this.rdLise.AutoSize = true;
            this.rdLise.Location = new System.Drawing.Point(43, 145);
            this.rdLise.Name = "rdLise";
            this.rdLise.Size = new System.Drawing.Size(53, 20);
            this.rdLise.TabIndex = 2;
            this.rdLise.TabStop = true;
            this.rdLise.Text = "Lise";
            this.rdLise.UseVisualStyleBackColor = true;
            // 
            // rdOrtaOkul
            // 
            this.rdOrtaOkul.AutoSize = true;
            this.rdOrtaOkul.Location = new System.Drawing.Point(43, 96);
            this.rdOrtaOkul.Name = "rdOrtaOkul";
            this.rdOrtaOkul.Size = new System.Drawing.Size(83, 20);
            this.rdOrtaOkul.TabIndex = 1;
            this.rdOrtaOkul.TabStop = true;
            this.rdOrtaOkul.Text = "Orta Okul";
            this.rdOrtaOkul.UseVisualStyleBackColor = true;
            // 
            // rdIlkOkul
            // 
            this.rdIlkOkul.AutoSize = true;
            this.rdIlkOkul.Location = new System.Drawing.Point(43, 47);
            this.rdIlkOkul.Name = "rdIlkOkul";
            this.rdIlkOkul.Size = new System.Drawing.Size(71, 20);
            this.rdIlkOkul.TabIndex = 0;
            this.rdIlkOkul.TabStop = true;
            this.rdIlkOkul.Text = "İlk Okul";
            this.rdIlkOkul.UseVisualStyleBackColor = true;
            // 
            // grpHobi
            // 
            this.grpHobi.Controls.Add(this.btnHobiTemizle);
            this.grpHobi.Controls.Add(this.chkGonulluFaaliyetler);
            this.grpHobi.Controls.Add(this.chkGeziSeyahat);
            this.grpHobi.Controls.Add(this.chkFotografcilik);
            this.grpHobi.Controls.Add(this.chkSinema);
            this.grpHobi.Controls.Add(this.chkBahceIsleri);
            this.grpHobi.Controls.Add(this.chkSatranc);
            this.grpHobi.Controls.Add(this.chkSpor);
            this.grpHobi.Location = new System.Drawing.Point(633, 22);
            this.grpHobi.Name = "grpHobi";
            this.grpHobi.Size = new System.Drawing.Size(251, 422);
            this.grpHobi.TabIndex = 14;
            this.grpHobi.TabStop = false;
            this.grpHobi.Tag = "1";
            this.grpHobi.Text = "Hobiler";
            // 
            // btnHobiTemizle
            // 
            this.btnHobiTemizle.Location = new System.Drawing.Point(33, 379);
            this.btnHobiTemizle.Name = "btnHobiTemizle";
            this.btnHobiTemizle.Size = new System.Drawing.Size(187, 29);
            this.btnHobiTemizle.TabIndex = 18;
            this.btnHobiTemizle.Text = "Temizle";
            this.btnHobiTemizle.UseVisualStyleBackColor = true;
            this.btnHobiTemizle.Click += new System.EventHandler(this.btnHobiTemizle_Click);
            // 
            // chkGonulluFaaliyetler
            // 
            this.chkGonulluFaaliyetler.AutoSize = true;
            this.chkGonulluFaaliyetler.Location = new System.Drawing.Point(47, 340);
            this.chkGonulluFaaliyetler.Name = "chkGonulluFaaliyetler";
            this.chkGonulluFaaliyetler.Size = new System.Drawing.Size(140, 20);
            this.chkGonulluFaaliyetler.TabIndex = 6;
            this.chkGonulluFaaliyetler.Text = "Gönüllü Faaliyetler";
            this.chkGonulluFaaliyetler.UseVisualStyleBackColor = true;
            // 
            // chkGeziSeyahat
            // 
            this.chkGeziSeyahat.AutoSize = true;
            this.chkGeziSeyahat.Location = new System.Drawing.Point(47, 293);
            this.chkGeziSeyahat.Name = "chkGeziSeyahat";
            this.chkGeziSeyahat.Size = new System.Drawing.Size(116, 20);
            this.chkGeziSeyahat.TabIndex = 5;
            this.chkGeziSeyahat.Text = "Gezi / Seyahat";
            this.chkGeziSeyahat.UseVisualStyleBackColor = true;
            // 
            // chkFotografcilik
            // 
            this.chkFotografcilik.AutoSize = true;
            this.chkFotografcilik.Location = new System.Drawing.Point(47, 243);
            this.chkFotografcilik.Name = "chkFotografcilik";
            this.chkFotografcilik.Size = new System.Drawing.Size(102, 20);
            this.chkFotografcilik.TabIndex = 4;
            this.chkFotografcilik.Text = "Fotoğrafçılık";
            this.chkFotografcilik.UseVisualStyleBackColor = true;
            // 
            // chkSinema
            // 
            this.chkSinema.AutoSize = true;
            this.chkSinema.Location = new System.Drawing.Point(47, 194);
            this.chkSinema.Name = "chkSinema";
            this.chkSinema.Size = new System.Drawing.Size(75, 20);
            this.chkSinema.TabIndex = 3;
            this.chkSinema.Text = "Sinema";
            this.chkSinema.UseVisualStyleBackColor = true;
            // 
            // chkBahceIsleri
            // 
            this.chkBahceIsleri.AutoSize = true;
            this.chkBahceIsleri.Location = new System.Drawing.Point(47, 145);
            this.chkBahceIsleri.Name = "chkBahceIsleri";
            this.chkBahceIsleri.Size = new System.Drawing.Size(99, 20);
            this.chkBahceIsleri.TabIndex = 2;
            this.chkBahceIsleri.Text = "Bahçe İşleri";
            this.chkBahceIsleri.UseVisualStyleBackColor = true;
            // 
            // chkSatranc
            // 
            this.chkSatranc.AutoSize = true;
            this.chkSatranc.Location = new System.Drawing.Point(47, 96);
            this.chkSatranc.Name = "chkSatranc";
            this.chkSatranc.Size = new System.Drawing.Size(75, 20);
            this.chkSatranc.TabIndex = 1;
            this.chkSatranc.Text = "Satranç";
            this.chkSatranc.UseVisualStyleBackColor = true;
            // 
            // chkSpor
            // 
            this.chkSpor.AutoSize = true;
            this.chkSpor.Location = new System.Drawing.Point(47, 46);
            this.chkSpor.Name = "chkSpor";
            this.chkSpor.Size = new System.Drawing.Size(58, 20);
            this.chkSpor.TabIndex = 0;
            this.chkSpor.Text = "Spor";
            this.chkSpor.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(17, 457);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(187, 29);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lvPersonel
            // 
            this.lvPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvPersonel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvPersonel.GridLines = true;
            this.lvPersonel.HideSelection = false;
            this.lvPersonel.Location = new System.Drawing.Point(0, 512);
            this.lvPersonel.Name = "lvPersonel";
            this.lvPersonel.Size = new System.Drawing.Size(1039, 214);
            this.lvPersonel.TabIndex = 16;
            this.lvPersonel.UseCompatibleStateImageBehavior = false;
            this.lvPersonel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doğum Tarihi";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yaş";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cinsiyet";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Eğitim Bilgileri";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Hobiler";
            this.columnHeader8.Width = 200;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 726);
            this.Controls.Add(this.lvPersonel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpHobi);
            this.Controls.Add(this.grpBoxEgitim);
            this.Controls.Add(this.grpBoxCinsiyet);
            this.Controls.Add(this.nUpYas);
            this.Controls.Add(this.mTxtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonelForm";
            this.Text = "Personel Veri Girişi";
            ((System.ComponentModel.ISupportInitialize)(this.nUpYas)).EndInit();
            this.grpBoxCinsiyet.ResumeLayout(false);
            this.grpBoxCinsiyet.PerformLayout();
            this.grpBoxEgitim.ResumeLayout(false);
            this.grpBoxEgitim.PerformLayout();
            this.grpHobi.ResumeLayout(false);
            this.grpHobi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mTxtTelefon;
        private System.Windows.Forms.NumericUpDown nUpYas;
        private System.Windows.Forms.GroupBox grpBoxCinsiyet;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpBoxEgitim;
        private System.Windows.Forms.RadioButton rdYuksekLisans;
        private System.Windows.Forms.RadioButton rdUniversite;
        private System.Windows.Forms.RadioButton rdYuksekOkul;
        private System.Windows.Forms.RadioButton rdLise;
        private System.Windows.Forms.RadioButton rdOrtaOkul;
        private System.Windows.Forms.RadioButton rdIlkOkul;
        private System.Windows.Forms.RadioButton rdDoktora;
        private System.Windows.Forms.GroupBox grpHobi;
        private System.Windows.Forms.CheckBox chkBahceIsleri;
        private System.Windows.Forms.CheckBox chkSatranc;
        private System.Windows.Forms.CheckBox chkSpor;
        private System.Windows.Forms.CheckBox chkGonulluFaaliyetler;
        private System.Windows.Forms.CheckBox chkGeziSeyahat;
        private System.Windows.Forms.CheckBox chkFotografcilik;
        private System.Windows.Forms.CheckBox chkSinema;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView lvPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnEgitimTemizle;
        private System.Windows.Forms.Button btnHobiTemizle;
    }
}

