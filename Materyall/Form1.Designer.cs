﻿namespace Materyall
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_yili = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.linklbl_talep_defterekle = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_defterler = new System.Windows.Forms.DataGridView();
            this.cb_talep_defter = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.linklbl_talep_nobetyeri_temizle = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_nobetsablonlari = new System.Windows.Forms.DataGridView();
            this.lbl_talep_nobet_secilensablon = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgv_talep_nobetyerleri = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbl_talep_sosyalkulupbasimtarihi = new System.Windows.Forms.Label();
            this.lbl_talep_sosyalkuluptaleptatihi = new System.Windows.Forms.Label();
            this.tb_talep_sosyalkulupikinciogretmen = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_talep_sosyalkulupadi = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_talep_digerzumreogretmenleri = new System.Windows.Forms.TextBox();
            this.linklbl_talep_digerzumreogretmeniekle = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_digerzumreogretmenleri = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linklbl_talep_tumdersleriekle_serbest_yillik = new System.Windows.Forms.LinkLabel();
            this.linklbl_talep_secimiekle_serbest_yillik = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_serbestdersler_yillik = new System.Windows.Forms.DataGridView();
            this.cb_talep_serbestdersler_yillik = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linklbl_talep_tumanadersleriekle_gunluk = new System.Windows.Forms.LinkLabel();
            this.linklbl_talep_secimiekle_anadersler_gunluk = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_anadersler_gunluk = new System.Windows.Forms.DataGridView();
            this.cb_talep_anadersler_gunluk = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_talep_pdf = new System.Windows.Forms.CheckBox();
            this.cb_talep_CD = new System.Windows.Forms.CheckBox();
            this.linklabel_talep_tumanadersleriekle_yillik = new System.Windows.Forms.LinkLabel();
            this.linklbl_talep_anadersler_secimiekle_yillik = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_anadersler_yillik = new System.Windows.Forms.DataGridView();
            this.cb_talep_anadersler_yillik = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_taleplerial_excelden = new System.Windows.Forms.Button();
            this.lbl_bekleyin = new System.Windows.Forms.Label();
            this.datagridSunucuTalepleri = new System.Windows.Forms.DataGridView();
            this.btn_taleplerial_sunucudan = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tb_sablon_nobetyeri_sablonadi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.linklbl_sablon_nobetyeri_ekle = new System.Windows.Forms.LinkLabel();
            this.tb_sablon_nobetyeri = new System.Windows.Forms.TextBox();
            this.dgv_sablon_nobetyeri = new System.Windows.Forms.DataGridView();
            this.linklbl_sablon_nobetyeri_sablonukaydet = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_bilgi_bayikodu = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.cb_bilgi_sinifi = new System.Windows.Forms.ComboBox();
            this.tb_bilgi_okulkodu = new System.Windows.Forms.TextBox();
            this.lbl_bilgi_kayittarihi = new System.Windows.Forms.Label();
            this.cb_bilgi_bayiadi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_bilgi_mudurunvani = new System.Windows.Forms.ComboBox();
            this.tb_bilgi_subesi = new System.Windows.Forms.TextBox();
            this.cb_bilgi_ili = new System.Windows.Forms.ComboBox();
            this.cb_bilgi_bransi = new System.Windows.Forms.ComboBox();
            this.tb_bilgi_aciklama = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_bilgi_adres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_bilgi_telefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_bilgi_eposta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bilgi_muduradi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_bilgi_okulu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctb_bilgi_ilcesi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_bilgi_adisoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_yenikayit = new System.Windows.Forms.Button();
            this.bt_guncelle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_varsayilanlariguncelle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_defterler)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_nobetsablonlari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_nobetyerleri)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_digerzumreogretmenleri)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_serbestdersler_yillik)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_anadersler_gunluk)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_anadersler_yillik)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSunucuTalepleri)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sablon_nobetyeri)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_yili);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eğitim Öğretim Yılı";
            // 
            // cb_yili
            // 
            this.cb_yili.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_yili.FormattingEnabled = true;
            this.cb_yili.Location = new System.Drawing.Point(13, 24);
            this.cb_yili.Name = "cb_yili";
            this.cb_yili.Size = new System.Drawing.Size(121, 32);
            this.cb_yili.TabIndex = 99;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(393, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1212, 810);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1204, 784);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Talep Girişleri";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.linklbl_talep_defterekle);
            this.groupBox9.Controls.Add(this.dgv_talep_defterler);
            this.groupBox9.Controls.Add(this.cb_talep_defter);
            this.groupBox9.Location = new System.Drawing.Point(488, 239);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(470, 210);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Defter Talep Girişleri";
            // 
            // linklbl_talep_defterekle
            // 
            this.linklbl_talep_defterekle.AutoSize = true;
            this.linklbl_talep_defterekle.Location = new System.Drawing.Point(397, 32);
            this.linklbl_talep_defterekle.Name = "linklbl_talep_defterekle";
            this.linklbl_talep_defterekle.Size = new System.Drawing.Size(62, 13);
            this.linklbl_talep_defterekle.TabIndex = 30;
            this.linklbl_talep_defterekle.TabStop = true;
            this.linklbl_talep_defterekle.Text = "Seçimi Ekle";
            // 
            // dgv_talep_defterler
            // 
            this.dgv_talep_defterler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_defterler.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_defterler.Name = "dgv_talep_defterler";
            this.dgv_talep_defterler.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_defterler.TabIndex = 29;
            // 
            // cb_talep_defter
            // 
            this.cb_talep_defter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_defter.FormattingEnabled = true;
            this.cb_talep_defter.Location = new System.Drawing.Point(6, 22);
            this.cb_talep_defter.Name = "cb_talep_defter";
            this.cb_talep_defter.Size = new System.Drawing.Size(374, 33);
            this.cb_talep_defter.TabIndex = 28;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.linklbl_talep_nobetyeri_temizle);
            this.groupBox8.Controls.Add(this.dgv_talep_nobetsablonlari);
            this.groupBox8.Controls.Add(this.lbl_talep_nobet_secilensablon);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.dgv_talep_nobetyerleri);
            this.groupBox8.Location = new System.Drawing.Point(964, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(227, 529);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nöbet Yerleri (Nöbet Defteri İçin)";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // linklbl_talep_nobetyeri_temizle
            // 
            this.linklbl_talep_nobetyeri_temizle.AutoSize = true;
            this.linklbl_talep_nobetyeri_temizle.Location = new System.Drawing.Point(167, 506);
            this.linklbl_talep_nobetyeri_temizle.Name = "linklbl_talep_nobetyeri_temizle";
            this.linklbl_talep_nobetyeri_temizle.Size = new System.Drawing.Size(53, 13);
            this.linklbl_talep_nobetyeri_temizle.TabIndex = 54;
            this.linklbl_talep_nobetyeri_temizle.TabStop = true;
            this.linklbl_talep_nobetyeri_temizle.Text = "TEMİZLE";
            // 
            // dgv_talep_nobetsablonlari
            // 
            this.dgv_talep_nobetsablonlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_nobetsablonlari.Location = new System.Drawing.Point(9, 365);
            this.dgv_talep_nobetsablonlari.Name = "dgv_talep_nobetsablonlari";
            this.dgv_talep_nobetsablonlari.Size = new System.Drawing.Size(212, 132);
            this.dgv_talep_nobetsablonlari.TabIndex = 53;
            // 
            // lbl_talep_nobet_secilensablon
            // 
            this.lbl_talep_nobet_secilensablon.AutoSize = true;
            this.lbl_talep_nobet_secilensablon.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_talep_nobet_secilensablon.Location = new System.Drawing.Point(6, 19);
            this.lbl_talep_nobet_secilensablon.Name = "lbl_talep_nobet_secilensablon";
            this.lbl_talep_nobet_secilensablon.Size = new System.Drawing.Size(29, 13);
            this.lbl_talep_nobet_secilensablon.TabIndex = 52;
            this.lbl_talep_nobet_secilensablon.Text = "YOK";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label17.Location = new System.Drawing.Point(6, 349);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "Nöbet yeri şablonu seçin.";
            // 
            // dgv_talep_nobetyerleri
            // 
            this.dgv_talep_nobetyerleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_nobetyerleri.Location = new System.Drawing.Point(6, 38);
            this.dgv_talep_nobetyerleri.Name = "dgv_talep_nobetyerleri";
            this.dgv_talep_nobetyerleri.Size = new System.Drawing.Size(214, 308);
            this.dgv_talep_nobetyerleri.TabIndex = 48;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbl_talep_sosyalkulupbasimtarihi);
            this.groupBox7.Controls.Add(this.lbl_talep_sosyalkuluptaleptatihi);
            this.groupBox7.Controls.Add(this.tb_talep_sosyalkulupikinciogretmen);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.cb_talep_sosyalkulupadi);
            this.groupBox7.Location = new System.Drawing.Point(5, 666);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(476, 115);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sosyal Kulüp";
            // 
            // lbl_talep_sosyalkulupbasimtarihi
            // 
            this.lbl_talep_sosyalkulupbasimtarihi.AutoSize = true;
            this.lbl_talep_sosyalkulupbasimtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_talep_sosyalkulupbasimtarihi.Location = new System.Drawing.Point(395, 99);
            this.lbl_talep_sosyalkulupbasimtarihi.Name = "lbl_talep_sosyalkulupbasimtarihi";
            this.lbl_talep_sosyalkulupbasimtarihi.Size = new System.Drawing.Size(64, 13);
            this.lbl_talep_sosyalkulupbasimtarihi.TabIndex = 34;
            this.lbl_talep_sosyalkulupbasimtarihi.Text = "Basım Tarihi";
            // 
            // lbl_talep_sosyalkuluptaleptatihi
            // 
            this.lbl_talep_sosyalkuluptaleptatihi.AutoSize = true;
            this.lbl_talep_sosyalkuluptaleptatihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_talep_sosyalkuluptaleptatihi.Location = new System.Drawing.Point(83, 99);
            this.lbl_talep_sosyalkuluptaleptatihi.Name = "lbl_talep_sosyalkuluptaleptatihi";
            this.lbl_talep_sosyalkuluptaleptatihi.Size = new System.Drawing.Size(63, 13);
            this.lbl_talep_sosyalkuluptaleptatihi.TabIndex = 33;
            this.lbl_talep_sosyalkuluptaleptatihi.Text = "Talep Tarihi";
            // 
            // tb_talep_sosyalkulupikinciogretmen
            // 
            this.tb_talep_sosyalkulupikinciogretmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_talep_sosyalkulupikinciogretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_talep_sosyalkulupikinciogretmen.Location = new System.Drawing.Point(86, 59);
            this.tb_talep_sosyalkulupikinciogretmen.Name = "tb_talep_sosyalkulupikinciogretmen";
            this.tb_talep_sosyalkulupikinciogretmen.Size = new System.Drawing.Size(380, 32);
            this.tb_talep_sosyalkulupikinciogretmen.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "2. Öğretmen:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Adı:";
            // 
            // cb_talep_sosyalkulupadi
            // 
            this.cb_talep_sosyalkulupadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_sosyalkulupadi.FormattingEnabled = true;
            this.cb_talep_sosyalkulupadi.Location = new System.Drawing.Point(86, 16);
            this.cb_talep_sosyalkulupadi.Name = "cb_talep_sosyalkulupadi";
            this.cb_talep_sosyalkulupadi.Size = new System.Drawing.Size(380, 33);
            this.cb_talep_sosyalkulupadi.TabIndex = 29;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_talep_digerzumreogretmenleri);
            this.groupBox6.Controls.Add(this.linklbl_talep_digerzumreogretmeniekle);
            this.groupBox6.Controls.Add(this.dgv_talep_digerzumreogretmenleri);
            this.groupBox6.Location = new System.Drawing.Point(488, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(470, 210);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Diğer Zümre Öğretmenleri";
            // 
            // tb_talep_digerzumreogretmenleri
            // 
            this.tb_talep_digerzumreogretmenleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_talep_digerzumreogretmenleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_talep_digerzumreogretmenleri.Location = new System.Drawing.Point(6, 26);
            this.tb_talep_digerzumreogretmenleri.Name = "tb_talep_digerzumreogretmenleri";
            this.tb_talep_digerzumreogretmenleri.Size = new System.Drawing.Size(374, 32);
            this.tb_talep_digerzumreogretmenleri.TabIndex = 20;
            // 
            // linklbl_talep_digerzumreogretmeniekle
            // 
            this.linklbl_talep_digerzumreogretmeniekle.AutoSize = true;
            this.linklbl_talep_digerzumreogretmeniekle.Location = new System.Drawing.Point(400, 25);
            this.linklbl_talep_digerzumreogretmeniekle.Name = "linklbl_talep_digerzumreogretmeniekle";
            this.linklbl_talep_digerzumreogretmeniekle.Size = new System.Drawing.Size(53, 26);
            this.linklbl_talep_digerzumreogretmeniekle.TabIndex = 30;
            this.linklbl_talep_digerzumreogretmeniekle.TabStop = true;
            this.linklbl_talep_digerzumreogretmeniekle.Text = "Öğretmen\r\nEkle";
            this.linklbl_talep_digerzumreogretmeniekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklbl_talep_digerzumreogretmeniekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
            // 
            // dgv_talep_digerzumreogretmenleri
            // 
            this.dgv_talep_digerzumreogretmenleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_digerzumreogretmenleri.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_digerzumreogretmenleri.Name = "dgv_talep_digerzumreogretmenleri";
            this.dgv_talep_digerzumreogretmenleri.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_digerzumreogretmenleri.TabIndex = 29;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linklbl_talep_tumdersleriekle_serbest_yillik);
            this.groupBox5.Controls.Add(this.linklbl_talep_secimiekle_serbest_yillik);
            this.groupBox5.Controls.Add(this.dgv_talep_serbestdersler_yillik);
            this.groupBox5.Controls.Add(this.cb_talep_serbestdersler_yillik);
            this.groupBox5.Location = new System.Drawing.Point(11, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(470, 210);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Serbest Etkinlik Dersleri (Yıllık Plan)";
            // 
            // linklbl_talep_tumdersleriekle_serbest_yillik
            // 
            this.linklbl_talep_tumdersleriekle_serbest_yillik.AutoSize = true;
            this.linklbl_talep_tumdersleriekle_serbest_yillik.Location = new System.Drawing.Point(394, 77);
            this.linklbl_talep_tumdersleriekle_serbest_yillik.Name = "linklbl_talep_tumdersleriekle_serbest_yillik";
            this.linklbl_talep_tumdersleriekle_serbest_yillik.Size = new System.Drawing.Size(70, 13);
            this.linklbl_talep_tumdersleriekle_serbest_yillik.TabIndex = 31;
            this.linklbl_talep_tumdersleriekle_serbest_yillik.TabStop = true;
            this.linklbl_talep_tumdersleriekle_serbest_yillik.Text = "Tümünü Ekle";
            this.linklbl_talep_tumdersleriekle_serbest_yillik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklbl_talep_secimiekle_serbest_yillik
            // 
            this.linklbl_talep_secimiekle_serbest_yillik.AutoSize = true;
            this.linklbl_talep_secimiekle_serbest_yillik.Location = new System.Drawing.Point(397, 32);
            this.linklbl_talep_secimiekle_serbest_yillik.Name = "linklbl_talep_secimiekle_serbest_yillik";
            this.linklbl_talep_secimiekle_serbest_yillik.Size = new System.Drawing.Size(62, 13);
            this.linklbl_talep_secimiekle_serbest_yillik.TabIndex = 30;
            this.linklbl_talep_secimiekle_serbest_yillik.TabStop = true;
            this.linklbl_talep_secimiekle_serbest_yillik.Text = "Seçimi Ekle";
            // 
            // dgv_talep_serbestdersler_yillik
            // 
            this.dgv_talep_serbestdersler_yillik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_serbestdersler_yillik.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_serbestdersler_yillik.Name = "dgv_talep_serbestdersler_yillik";
            this.dgv_talep_serbestdersler_yillik.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_serbestdersler_yillik.TabIndex = 29;
            // 
            // cb_talep_serbestdersler_yillik
            // 
            this.cb_talep_serbestdersler_yillik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_serbestdersler_yillik.FormattingEnabled = true;
            this.cb_talep_serbestdersler_yillik.Location = new System.Drawing.Point(6, 22);
            this.cb_talep_serbestdersler_yillik.Name = "cb_talep_serbestdersler_yillik";
            this.cb_talep_serbestdersler_yillik.Size = new System.Drawing.Size(374, 33);
            this.cb_talep_serbestdersler_yillik.TabIndex = 28;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linklbl_talep_tumanadersleriekle_gunluk);
            this.groupBox4.Controls.Add(this.linklbl_talep_secimiekle_anadersler_gunluk);
            this.groupBox4.Controls.Add(this.dgv_talep_anadersler_gunluk);
            this.groupBox4.Controls.Add(this.cb_talep_anadersler_gunluk);
            this.groupBox4.Location = new System.Drawing.Point(11, 450);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(470, 210);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ana Dersler Günlük Plan";
            // 
            // linklbl_talep_tumanadersleriekle_gunluk
            // 
            this.linklbl_talep_tumanadersleriekle_gunluk.AutoSize = true;
            this.linklbl_talep_tumanadersleriekle_gunluk.Location = new System.Drawing.Point(397, 67);
            this.linklbl_talep_tumanadersleriekle_gunluk.Name = "linklbl_talep_tumanadersleriekle_gunluk";
            this.linklbl_talep_tumanadersleriekle_gunluk.Size = new System.Drawing.Size(66, 26);
            this.linklbl_talep_tumanadersleriekle_gunluk.TabIndex = 31;
            this.linklbl_talep_tumanadersleriekle_gunluk.TabStop = true;
            this.linklbl_talep_tumanadersleriekle_gunluk.Text = "Tüm Ana\r\nDersleri Ekle";
            this.linklbl_talep_tumanadersleriekle_gunluk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklbl_talep_secimiekle_anadersler_gunluk
            // 
            this.linklbl_talep_secimiekle_anadersler_gunluk.AutoSize = true;
            this.linklbl_talep_secimiekle_anadersler_gunluk.Location = new System.Drawing.Point(397, 32);
            this.linklbl_talep_secimiekle_anadersler_gunluk.Name = "linklbl_talep_secimiekle_anadersler_gunluk";
            this.linklbl_talep_secimiekle_anadersler_gunluk.Size = new System.Drawing.Size(62, 13);
            this.linklbl_talep_secimiekle_anadersler_gunluk.TabIndex = 30;
            this.linklbl_talep_secimiekle_anadersler_gunluk.TabStop = true;
            this.linklbl_talep_secimiekle_anadersler_gunluk.Text = "Seçimi Ekle";
            // 
            // dgv_talep_anadersler_gunluk
            // 
            this.dgv_talep_anadersler_gunluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_anadersler_gunluk.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_anadersler_gunluk.Name = "dgv_talep_anadersler_gunluk";
            this.dgv_talep_anadersler_gunluk.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_anadersler_gunluk.TabIndex = 29;
            // 
            // cb_talep_anadersler_gunluk
            // 
            this.cb_talep_anadersler_gunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_anadersler_gunluk.FormattingEnabled = true;
            this.cb_talep_anadersler_gunluk.Location = new System.Drawing.Point(6, 22);
            this.cb_talep_anadersler_gunluk.Name = "cb_talep_anadersler_gunluk";
            this.cb_talep_anadersler_gunluk.Size = new System.Drawing.Size(374, 33);
            this.cb_talep_anadersler_gunluk.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_talep_pdf);
            this.groupBox3.Controls.Add(this.cb_talep_CD);
            this.groupBox3.Controls.Add(this.linklabel_talep_tumanadersleriekle_yillik);
            this.groupBox3.Controls.Add(this.linklbl_talep_anadersler_secimiekle_yillik);
            this.groupBox3.Controls.Add(this.dgv_talep_anadersler_yillik);
            this.groupBox3.Controls.Add(this.cb_talep_anadersler_yillik);
            this.groupBox3.Location = new System.Drawing.Point(12, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 210);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ana Dersler Yıllık Plan";
            // 
            // cb_talep_pdf
            // 
            this.cb_talep_pdf.AutoSize = true;
            this.cb_talep_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_pdf.Location = new System.Drawing.Point(384, 142);
            this.cb_talep_pdf.Name = "cb_talep_pdf";
            this.cb_talep_pdf.Size = new System.Drawing.Size(75, 30);
            this.cb_talep_pdf.TabIndex = 33;
            this.cb_talep_pdf.Text = "PDF";
            this.cb_talep_pdf.UseVisualStyleBackColor = true;
            // 
            // cb_talep_CD
            // 
            this.cb_talep_CD.AutoSize = true;
            this.cb_talep_CD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_CD.Location = new System.Drawing.Point(386, 104);
            this.cb_talep_CD.Name = "cb_talep_CD";
            this.cb_talep_CD.Size = new System.Drawing.Size(63, 30);
            this.cb_talep_CD.TabIndex = 32;
            this.cb_talep_CD.Text = "CD";
            this.cb_talep_CD.UseVisualStyleBackColor = true;
            // 
            // linklabel_talep_tumanadersleriekle_yillik
            // 
            this.linklabel_talep_tumanadersleriekle_yillik.AutoSize = true;
            this.linklabel_talep_tumanadersleriekle_yillik.Location = new System.Drawing.Point(397, 67);
            this.linklabel_talep_tumanadersleriekle_yillik.Name = "linklabel_talep_tumanadersleriekle_yillik";
            this.linklabel_talep_tumanadersleriekle_yillik.Size = new System.Drawing.Size(66, 26);
            this.linklabel_talep_tumanadersleriekle_yillik.TabIndex = 31;
            this.linklabel_talep_tumanadersleriekle_yillik.TabStop = true;
            this.linklabel_talep_tumanadersleriekle_yillik.Text = "Tüm Ana\r\nDersleri Ekle";
            this.linklabel_talep_tumanadersleriekle_yillik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklbl_talep_anadersler_secimiekle_yillik
            // 
            this.linklbl_talep_anadersler_secimiekle_yillik.AutoSize = true;
            this.linklbl_talep_anadersler_secimiekle_yillik.Location = new System.Drawing.Point(397, 32);
            this.linklbl_talep_anadersler_secimiekle_yillik.Name = "linklbl_talep_anadersler_secimiekle_yillik";
            this.linklbl_talep_anadersler_secimiekle_yillik.Size = new System.Drawing.Size(62, 13);
            this.linklbl_talep_anadersler_secimiekle_yillik.TabIndex = 30;
            this.linklbl_talep_anadersler_secimiekle_yillik.TabStop = true;
            this.linklbl_talep_anadersler_secimiekle_yillik.Text = "Seçimi Ekle";
            // 
            // dgv_talep_anadersler_yillik
            // 
            this.dgv_talep_anadersler_yillik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_anadersler_yillik.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_anadersler_yillik.Name = "dgv_talep_anadersler_yillik";
            this.dgv_talep_anadersler_yillik.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_anadersler_yillik.TabIndex = 29;
            // 
            // cb_talep_anadersler_yillik
            // 
            this.cb_talep_anadersler_yillik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_anadersler_yillik.FormattingEnabled = true;
            this.cb_talep_anadersler_yillik.Location = new System.Drawing.Point(6, 22);
            this.cb_talep_anadersler_yillik.Name = "cb_talep_anadersler_yillik";
            this.cb_talep_anadersler_yillik.Size = new System.Drawing.Size(374, 33);
            this.cb_talep_anadersler_yillik.TabIndex = 28;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_taleplerial_excelden);
            this.tabPage4.Controls.Add(this.lbl_bekleyin);
            this.tabPage4.Controls.Add(this.datagridSunucuTalepleri);
            this.tabPage4.Controls.Add(this.btn_taleplerial_sunucudan);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1204, 784);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hızlı Talep";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_taleplerial_excelden
            // 
            this.btn_taleplerial_excelden.Location = new System.Drawing.Point(978, 22);
            this.btn_taleplerial_excelden.Name = "btn_taleplerial_excelden";
            this.btn_taleplerial_excelden.Size = new System.Drawing.Size(220, 37);
            this.btn_taleplerial_excelden.TabIndex = 3;
            this.btn_taleplerial_excelden.Text = "Talepleri Excelden Al";
            this.btn_taleplerial_excelden.UseVisualStyleBackColor = true;
            // 
            // lbl_bekleyin
            // 
            this.lbl_bekleyin.AutoSize = true;
            this.lbl_bekleyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bekleyin.ForeColor = System.Drawing.Color.Red;
            this.lbl_bekleyin.Location = new System.Drawing.Point(263, 25);
            this.lbl_bekleyin.Name = "lbl_bekleyin";
            this.lbl_bekleyin.Size = new System.Drawing.Size(18, 25);
            this.lbl_bekleyin.TabIndex = 2;
            this.lbl_bekleyin.Text = ".";
            // 
            // datagridSunucuTalepleri
            // 
            this.datagridSunucuTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSunucuTalepleri.Location = new System.Drawing.Point(16, 72);
            this.datagridSunucuTalepleri.Name = "datagridSunucuTalepleri";
            this.datagridSunucuTalepleri.Size = new System.Drawing.Size(1182, 270);
            this.datagridSunucuTalepleri.TabIndex = 1;
            // 
            // btn_taleplerial_sunucudan
            // 
            this.btn_taleplerial_sunucudan.Location = new System.Drawing.Point(16, 19);
            this.btn_taleplerial_sunucudan.Name = "btn_taleplerial_sunucudan";
            this.btn_taleplerial_sunucudan.Size = new System.Drawing.Size(220, 37);
            this.btn_taleplerial_sunucudan.TabIndex = 0;
            this.btn_taleplerial_sunucudan.Text = "Talepleri Sunucudan Al";
            this.btn_taleplerial_sunucudan.UseVisualStyleBackColor = true;
            this.btn_taleplerial_sunucudan.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1204, 784);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plan Basım İşlemleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1204, 784);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Defter Basım İşlemleri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox10);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1204, 784);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Diğer İşlemler";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_sablonadi);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.linklbl_sablon_nobetyeri_ekle);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri);
            this.groupBox10.Controls.Add(this.dgv_sablon_nobetyeri);
            this.groupBox10.Controls.Add(this.linklbl_sablon_nobetyeri_sablonukaydet);
            this.groupBox10.Location = new System.Drawing.Point(6, 11);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(227, 529);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Nöbet Yerleri Şablonu Oluştur";
            // 
            // tb_sablon_nobetyeri_sablonadi
            // 
            this.tb_sablon_nobetyeri_sablonadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_sablonadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_sablonadi.Location = new System.Drawing.Point(7, 469);
            this.tb_sablon_nobetyeri_sablonadi.Name = "tb_sablon_nobetyeri_sablonadi";
            this.tb_sablon_nobetyeri_sablonadi.Size = new System.Drawing.Size(210, 32);
            this.tb_sablon_nobetyeri_sablonadi.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 453);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "Şablon Adı:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label18.Location = new System.Drawing.Point(6, 402);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(209, 39);
            this.label18.TabIndex = 51;
            this.label18.Text = "*En fazla 12 tane nöbet yeri ekleyebilirsiniz.\r\nTalepler şablon adıyla yapılmakta" +
    "dır.\r\nDeğişiklikler önceki kayıtları etkiler.";
            // 
            // linklbl_sablon_nobetyeri_ekle
            // 
            this.linklbl_sablon_nobetyeri_ekle.AutoSize = true;
            this.linklbl_sablon_nobetyeri_ekle.Location = new System.Drawing.Point(71, 66);
            this.linklbl_sablon_nobetyeri_ekle.Name = "linklbl_sablon_nobetyeri_ekle";
            this.linklbl_sablon_nobetyeri_ekle.Size = new System.Drawing.Size(81, 13);
            this.linklbl_sablon_nobetyeri_ekle.TabIndex = 50;
            this.linklbl_sablon_nobetyeri_ekle.TabStop = true;
            this.linklbl_sablon_nobetyeri_ekle.Text = "Nöbet Yeri Ekle";
            this.linklbl_sablon_nobetyeri_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri
            // 
            this.tb_sablon_nobetyeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri.Location = new System.Drawing.Point(7, 23);
            this.tb_sablon_nobetyeri.Name = "tb_sablon_nobetyeri";
            this.tb_sablon_nobetyeri.Size = new System.Drawing.Size(210, 32);
            this.tb_sablon_nobetyeri.TabIndex = 49;
            // 
            // dgv_sablon_nobetyeri
            // 
            this.dgv_sablon_nobetyeri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sablon_nobetyeri.Location = new System.Drawing.Point(7, 94);
            this.dgv_sablon_nobetyeri.Name = "dgv_sablon_nobetyeri";
            this.dgv_sablon_nobetyeri.Size = new System.Drawing.Size(214, 305);
            this.dgv_sablon_nobetyeri.TabIndex = 48;
            // 
            // linklbl_sablon_nobetyeri_sablonukaydet
            // 
            this.linklbl_sablon_nobetyeri_sablonukaydet.AutoSize = true;
            this.linklbl_sablon_nobetyeri_sablonukaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_sablon_nobetyeri_sablonukaydet.LinkColor = System.Drawing.Color.Red;
            this.linklbl_sablon_nobetyeri_sablonukaydet.Location = new System.Drawing.Point(25, 502);
            this.linklbl_sablon_nobetyeri_sablonukaydet.Name = "linklbl_sablon_nobetyeri_sablonukaydet";
            this.linklbl_sablon_nobetyeri_sablonukaydet.Size = new System.Drawing.Size(179, 24);
            this.linklbl_sablon_nobetyeri_sablonukaydet.TabIndex = 47;
            this.linklbl_sablon_nobetyeri_sablonukaydet.TabStop = true;
            this.linklbl_sablon_nobetyeri_sablonukaydet.Text = "ŞABLONU KAYDET";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_bilgi_bayikodu);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.linkLabel12);
            this.groupBox2.Controls.Add(this.cb_bilgi_sinifi);
            this.groupBox2.Controls.Add(this.tb_bilgi_okulkodu);
            this.groupBox2.Controls.Add(this.lbl_bilgi_kayittarihi);
            this.groupBox2.Controls.Add(this.cb_bilgi_bayiadi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cb_bilgi_mudurunvani);
            this.groupBox2.Controls.Add(this.tb_bilgi_subesi);
            this.groupBox2.Controls.Add(this.cb_bilgi_ili);
            this.groupBox2.Controls.Add(this.cb_bilgi_bransi);
            this.groupBox2.Controls.Add(this.tb_bilgi_aciklama);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_bilgi_adres);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_bilgi_telefon);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_bilgi_eposta);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_bilgi_muduradi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_bilgi_okulu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ctb_bilgi_ilcesi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_bilgi_adisoyadi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 732);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // tb_bilgi_bayikodu
            // 
            this.tb_bilgi_bayikodu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_bayikodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_bayikodu.Location = new System.Drawing.Point(87, 600);
            this.tb_bilgi_bayikodu.Name = "tb_bilgi_bayikodu";
            this.tb_bilgi_bayikodu.Size = new System.Drawing.Size(143, 32);
            this.tb_bilgi_bayikodu.TabIndex = 35;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 612);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 13);
            this.label29.TabIndex = 36;
            this.label29.Text = "Bayi Koduı:";
            // 
            // linkLabel12
            // 
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Location = new System.Drawing.Point(344, 249);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(28, 13);
            this.linkLabel12.TabIndex = 34;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "BUL";
            this.toolTip1.SetToolTip(this.linkLabel12, "Okul kodundan il, ilçe, kurum adı bilgilerini getirir.");
            // 
            // cb_bilgi_sinifi
            // 
            this.cb_bilgi_sinifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_sinifi.FormattingEnabled = true;
            this.cb_bilgi_sinifi.Location = new System.Drawing.Point(87, 237);
            this.cb_bilgi_sinifi.Name = "cb_bilgi_sinifi";
            this.cb_bilgi_sinifi.Size = new System.Drawing.Size(66, 33);
            this.cb_bilgi_sinifi.TabIndex = 6;
            // 
            // tb_bilgi_okulkodu
            // 
            this.tb_bilgi_okulkodu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_okulkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_okulkodu.Location = new System.Drawing.Point(236, 238);
            this.tb_bilgi_okulkodu.Name = "tb_bilgi_okulkodu";
            this.tb_bilgi_okulkodu.Size = new System.Drawing.Size(108, 32);
            this.tb_bilgi_okulkodu.TabIndex = 8;
            // 
            // lbl_bilgi_kayittarihi
            // 
            this.lbl_bilgi_kayittarihi.AutoSize = true;
            this.lbl_bilgi_kayittarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilgi_kayittarihi.Location = new System.Drawing.Point(5, 712);
            this.lbl_bilgi_kayittarihi.Name = "lbl_bilgi_kayittarihi";
            this.lbl_bilgi_kayittarihi.Size = new System.Drawing.Size(59, 13);
            this.lbl_bilgi_kayittarihi.TabIndex = 31;
            this.lbl_bilgi_kayittarihi.Text = "Kayıt Tarihi";
            // 
            // cb_bilgi_bayiadi
            // 
            this.cb_bilgi_bayiadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_bayiadi.FormattingEnabled = true;
            this.cb_bilgi_bayiadi.Location = new System.Drawing.Point(87, 638);
            this.cb_bilgi_bayiadi.Name = "cb_bilgi_bayiadi";
            this.cb_bilgi_bayiadi.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_bayiadi.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 650);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Bayi Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(152, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "-";
            // 
            // cb_bilgi_mudurunvani
            // 
            this.cb_bilgi_mudurunvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_mudurunvani.FormattingEnabled = true;
            this.cb_bilgi_mudurunvani.Location = new System.Drawing.Point(87, 313);
            this.cb_bilgi_mudurunvani.Name = "cb_bilgi_mudurunvani";
            this.cb_bilgi_mudurunvani.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_mudurunvani.TabIndex = 10;
            // 
            // tb_bilgi_subesi
            // 
            this.tb_bilgi_subesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_subesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_subesi.Location = new System.Drawing.Point(162, 237);
            this.tb_bilgi_subesi.Name = "tb_bilgi_subesi";
            this.tb_bilgi_subesi.Size = new System.Drawing.Size(68, 32);
            this.tb_bilgi_subesi.TabIndex = 7;
            // 
            // cb_bilgi_ili
            // 
            this.cb_bilgi_ili.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_ili.FormattingEnabled = true;
            this.cb_bilgi_ili.Location = new System.Drawing.Point(87, 90);
            this.cb_bilgi_ili.Name = "cb_bilgi_ili";
            this.cb_bilgi_ili.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_ili.TabIndex = 3;
            // 
            // cb_bilgi_bransi
            // 
            this.cb_bilgi_bransi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_bransi.FormattingEnabled = true;
            this.cb_bilgi_bransi.Location = new System.Drawing.Point(87, 54);
            this.cb_bilgi_bransi.Name = "cb_bilgi_bransi";
            this.cb_bilgi_bransi.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_bransi.TabIndex = 2;
            // 
            // tb_bilgi_aciklama
            // 
            this.tb_bilgi_aciklama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_aciklama.Location = new System.Drawing.Point(87, 495);
            this.tb_bilgi_aciklama.Multiline = true;
            this.tb_bilgi_aciklama.Name = "tb_bilgi_aciklama";
            this.tb_bilgi_aciklama.Size = new System.Drawing.Size(285, 99);
            this.tb_bilgi_aciklama.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Açıklama:";
            // 
            // tb_bilgi_adres
            // 
            this.tb_bilgi_adres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_adres.Location = new System.Drawing.Point(87, 428);
            this.tb_bilgi_adres.Multiline = true;
            this.tb_bilgi_adres.Name = "tb_bilgi_adres";
            this.tb_bilgi_adres.Size = new System.Drawing.Size(285, 56);
            this.tb_bilgi_adres.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres:";
            // 
            // tb_bilgi_telefon
            // 
            this.tb_bilgi_telefon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_telefon.Location = new System.Drawing.Point(87, 390);
            this.tb_bilgi_telefon.Name = "tb_bilgi_telefon";
            this.tb_bilgi_telefon.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_telefon.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Telefon:";
            // 
            // tb_bilgi_eposta
            // 
            this.tb_bilgi_eposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_eposta.Location = new System.Drawing.Point(87, 352);
            this.tb_bilgi_eposta.Name = "tb_bilgi_eposta";
            this.tb_bilgi_eposta.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_eposta.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "E-posta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mdr Unvanı:";
            // 
            // tb_bilgi_muduradi
            // 
            this.tb_bilgi_muduradi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_muduradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_muduradi.Location = new System.Drawing.Point(87, 276);
            this.tb_bilgi_muduradi.Name = "tb_bilgi_muduradi";
            this.tb_bilgi_muduradi.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_muduradi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Müdür Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sınıf-Şube\r\nKurum Kodu";
            // 
            // tb_bilgi_okulu
            // 
            this.tb_bilgi_okulu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_okulu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_okulu.Location = new System.Drawing.Point(87, 169);
            this.tb_bilgi_okulu.Multiline = true;
            this.tb_bilgi_okulu.Name = "tb_bilgi_okulu";
            this.tb_bilgi_okulu.Size = new System.Drawing.Size(285, 63);
            this.tb_bilgi_okulu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Okulu:";
            // 
            // ctb_bilgi_ilcesi
            // 
            this.ctb_bilgi_ilcesi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ctb_bilgi_ilcesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ctb_bilgi_ilcesi.Location = new System.Drawing.Point(87, 130);
            this.ctb_bilgi_ilcesi.Name = "ctb_bilgi_ilcesi";
            this.ctb_bilgi_ilcesi.Size = new System.Drawing.Size(285, 32);
            this.ctb_bilgi_ilcesi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İlçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branşı:";
            // 
            // tb_bilgi_adisoyadi
            // 
            this.tb_bilgi_adisoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_bilgi_adisoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_adisoyadi.Location = new System.Drawing.Point(87, 16);
            this.tb_bilgi_adisoyadi.Name = "tb_bilgi_adisoyadi";
            this.tb_bilgi_adisoyadi.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_adisoyadi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_yenikayit
            // 
            this.bt_yenikayit.Location = new System.Drawing.Point(171, 45);
            this.bt_yenikayit.Name = "bt_yenikayit";
            this.bt_yenikayit.Size = new System.Drawing.Size(125, 40);
            this.bt_yenikayit.TabIndex = 29;
            this.bt_yenikayit.Text = "Yeni Kayıt";
            this.bt_yenikayit.UseVisualStyleBackColor = true;
            // 
            // bt_guncelle
            // 
            this.bt_guncelle.Location = new System.Drawing.Point(171, 12);
            this.bt_guncelle.Name = "bt_guncelle";
            this.bt_guncelle.Size = new System.Drawing.Size(125, 27);
            this.bt_guncelle.TabIndex = 30;
            this.bt_guncelle.Text = "Güncelle";
            this.bt_guncelle.UseVisualStyleBackColor = true;
            // 
            // btn_varsayilanlariguncelle
            // 
            this.btn_varsayilanlariguncelle.Location = new System.Drawing.Point(322, 28);
            this.btn_varsayilanlariguncelle.Name = "btn_varsayilanlariguncelle";
            this.btn_varsayilanlariguncelle.Size = new System.Drawing.Size(65, 41);
            this.btn_varsayilanlariguncelle.TabIndex = 31;
            this.btn_varsayilanlariguncelle.Text = "Varsayılan Yenile";
            this.toolTip1.SetToolTip(this.btn_varsayilanlariguncelle, "Yıl, branşlar, sınıflar, nöbet şablonları gibi otomatik gelen bilgileri yeni kayı" +
        "tlara göre günceller.");
            this.btn_varsayilanlariguncelle.UseVisualStyleBackColor = true;
            this.btn_varsayilanlariguncelle.Click += new System.EventHandler(this.btn_varsayilanlariguncelle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 845);
            this.Controls.Add(this.btn_varsayilanlariguncelle);
            this.Controls.Add(this.bt_yenikayit);
            this.Controls.Add(this.bt_guncelle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materyall 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_defterler)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_nobetsablonlari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_nobetyerleri)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_digerzumreogretmenleri)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_serbestdersler_yillik)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_anadersler_gunluk)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_anadersler_yillik)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSunucuTalepleri)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sablon_nobetyeri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_yili;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_bilgi_adisoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_bilgi_aciklama;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_bilgi_adres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_bilgi_telefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_bilgi_eposta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_bilgi_muduradi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_bilgi_okulu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctb_bilgi_ilcesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_guncelle;
        private System.Windows.Forms.Button bt_yenikayit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_bilgi_mudurunvani;
        private System.Windows.Forms.TextBox tb_bilgi_subesi;
        private System.Windows.Forms.ComboBox cb_bilgi_ili;
        private System.Windows.Forms.ComboBox cb_bilgi_bransi;
        private System.Windows.Forms.ComboBox cb_bilgi_bayiadi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_bilgi_kayittarihi;
        private System.Windows.Forms.ComboBox cb_bilgi_sinifi;
        private System.Windows.Forms.TextBox tb_bilgi_okulkodu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_talep_anadersler_yillik;
        private System.Windows.Forms.ComboBox cb_talep_anadersler_yillik;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linklbl_talep_tumdersleriekle_serbest_yillik;
        private System.Windows.Forms.LinkLabel linklbl_talep_secimiekle_serbest_yillik;
        private System.Windows.Forms.DataGridView dgv_talep_serbestdersler_yillik;
        private System.Windows.Forms.ComboBox cb_talep_serbestdersler_yillik;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linklbl_talep_tumanadersleriekle_gunluk;
        private System.Windows.Forms.LinkLabel linklbl_talep_secimiekle_anadersler_gunluk;
        private System.Windows.Forms.DataGridView dgv_talep_anadersler_gunluk;
        private System.Windows.Forms.ComboBox cb_talep_anadersler_gunluk;
        private System.Windows.Forms.LinkLabel linklabel_talep_tumanadersleriekle_yillik;
        private System.Windows.Forms.LinkLabel linklbl_talep_anadersler_secimiekle_yillik;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_talep_digerzumreogretmenleri;
        private System.Windows.Forms.LinkLabel linklbl_talep_digerzumreogretmeniekle;
        private System.Windows.Forms.DataGridView dgv_talep_digerzumreogretmenleri;
        private System.Windows.Forms.CheckBox cb_talep_CD;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_talep_sosyalkulupikinciogretmen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_talep_sosyalkulupadi;
        private System.Windows.Forms.Label lbl_talep_sosyalkulupbasimtarihi;
        private System.Windows.Forms.Label lbl_talep_sosyalkuluptaleptatihi;
        private System.Windows.Forms.CheckBox cb_talep_pdf;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.LinkLabel linkLabel12;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.LinkLabel linklbl_talep_defterekle;
        private System.Windows.Forms.DataGridView dgv_talep_defterler;
        private System.Windows.Forms.ComboBox cb_talep_defter;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_taleplerial_sunucudan;
        private System.Windows.Forms.DataGridView datagridSunucuTalepleri;
        private System.Windows.Forms.TextBox tb_bilgi_bayikodu;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dgv_talep_nobetyerleri;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_bekleyin;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel linklbl_sablon_nobetyeri_ekle;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri;
        private System.Windows.Forms.DataGridView dgv_sablon_nobetyeri;
        private System.Windows.Forms.LinkLabel linklbl_sablon_nobetyeri_sablonukaydet;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_sablonadi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_talep_nobet_secilensablon;
        private System.Windows.Forms.DataGridView dgv_talep_nobetsablonlari;
        private System.Windows.Forms.LinkLabel linklbl_talep_nobetyeri_temizle;
        private System.Windows.Forms.Button btn_taleplerial_excelden;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_varsayilanlariguncelle;
    }
}

