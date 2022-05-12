namespace Materyall
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_yili = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_talepgiris = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tb_hesapozeti_toplambakiye = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tb_hesapozeti_toplamodeme = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tb_hesapozeti_toplamborc = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.linklbl_talep_defterekle = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_defterler = new System.Windows.Forms.DataGridView();
            this.cb_talep_defter = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.linklbl_talep_nobetyeri_ekle = new System.Windows.Forms.LinkLabel();
            this.cb_talep_nobetyerisablon = new System.Windows.Forms.ComboBox();
            this.linklbl_talep_nobetyeri_sil = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_nobetyerleri = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.linklbl_talep_kulup = new System.Windows.Forms.LinkLabel();
            this.linklbl_talep_kulup_sil = new System.Windows.Forms.LinkLabel();
            this.lbl_talep_sosyalkulupbasimtarihi = new System.Windows.Forms.Label();
            this.lbl_talep_sosyalkuluptaleptatihi = new System.Windows.Forms.Label();
            this.tb_talep_sosyalkulupikinciogretmen = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_talep_sosyalkulupadi = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linklbl_zumre_otomatikgetir = new System.Windows.Forms.LinkLabel();
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
            this.linklabel_talep_tumanadersleriekle_yillik = new System.Windows.Forms.LinkLabel();
            this.linklbl_talep_anadersler_secimiekle_yillik = new System.Windows.Forms.LinkLabel();
            this.dgv_talep_anadersler_yillik = new System.Windows.Forms.DataGridView();
            this.cb_talep_anadersler_yillik = new System.Windows.Forms.ComboBox();
            this.tab_hizlitalep = new System.Windows.Forms.TabPage();
            this.pb_defterhizlikayit = new System.Windows.Forms.ProgressBar();
            this.bt_mukerrerkayit_izni_cb_bilgi = new System.Windows.Forms.Button();
            this.cb_defter_mukerrerkayit_izin_ver = new System.Windows.Forms.CheckBox();
            this.btn_defter_talepleriniHizliAl = new System.Windows.Forms.Button();
            this.btn_taleplerial_excelden = new System.Windows.Forms.Button();
            this.lbl_bekleyin = new System.Windows.Forms.Label();
            this.datagridSunucuTalepleri = new System.Windows.Forms.DataGridView();
            this.btn_taleplerial_sunucudan = new System.Windows.Forms.Button();
            this.tab_planbasim = new System.Windows.Forms.TabPage();
            this.tab_defterbasim = new System.Windows.Forms.TabPage();
            this.groupBox39 = new System.Windows.Forms.GroupBox();
            this.dgv_talep_defterler_baski = new System.Windows.Forms.DataGridView();
            this.groupBox38 = new System.Windows.Forms.GroupBox();
            this.cb_baski_basilacak_defterturu = new System.Windows.Forms.ComboBox();
            this.bt_defterbas_baskiyabasla = new System.Windows.Forms.Button();
            this.groupBox37 = new System.Windows.Forms.GroupBox();
            this.bt_bilgi_defterbas_sonislem = new System.Windows.Forms.Button();
            this.rb_defterbas_sonislem_yaziciyagonder = new System.Windows.Forms.RadioButton();
            this.rb_defterbas_sonislem_pdftut = new System.Windows.Forms.RadioButton();
            this.groupBox35 = new System.Windows.Forms.GroupBox();
            this.bt_bilgi_defterbaskisecenek_1 = new System.Windows.Forms.Button();
            this.rb_defterbas_secenek_kapakvedefter = new System.Windows.Forms.RadioButton();
            this.rb_defterbas_secenek_defter = new System.Windows.Forms.RadioButton();
            this.rb_defterbas_secenek_kapak = new System.Windows.Forms.RadioButton();
            this.groupBox36 = new System.Windows.Forms.GroupBox();
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu = new System.Windows.Forms.Button();
            this.rb_defterbas_tektoplu_toplu = new System.Windows.Forms.RadioButton();
            this.rb_defterbas_tektoplu_tek = new System.Windows.Forms.RadioButton();
            this.groupBox34 = new System.Windows.Forms.GroupBox();
            this.bt_defterbas_rb_secenekleri_bilgi = new System.Windows.Forms.Button();
            this.rb_defter_bas_listedesecilikayitlaricinislemyap = new System.Windows.Forms.RadioButton();
            this.rb_defter_bas_ekrandakikayiticinislemyap = new System.Windows.Forms.RadioButton();
            this.tab_muhasebe = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.btn_muhasebe_miktar_uyari_bilgi = new System.Windows.Forms.Button();
            this.linklbl_muhasebe_odemeal_odeme_kaydet = new System.Windows.Forms.LinkLabel();
            this.cb_muhasebe_odemeal_odeme_turu = new System.Windows.Forms.ComboBox();
            this.tb_muhasebe_odemeal_aciklama = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tb_muhasebe_odemeal_odeme_tarihi = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tb_muhasebe_odemeal_odenen_miktar = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.dgv_muhasebe_odemeler = new System.Windows.Forms.DataGridView();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dgv_muhasebe_borclanmalar = new System.Windows.Forms.DataGridView();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tb_muhasebe_toplam_bakiye = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tb_muhasebe_toplam_odeme = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tb_muhasebe_toplam_borc = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tab_digerislemler = new System.Windows.Forms.TabPage();
            this.groupBox41 = new System.Windows.Forms.GroupBox();
            this.tb_varsayilan_defterkapakyolu = new System.Windows.Forms.TextBox();
            this.bt_varsayilan_degistir_defterkapakyolu = new System.Windows.Forms.Button();
            this.bt_varsayilan_kayit_konumu_pdf_degistir = new System.Windows.Forms.Button();
            this.label58 = new System.Windows.Forms.Label();
            this.tb_varsayilan_defteryolu = new System.Windows.Forms.TextBox();
            this.tb_varsayilan_kayit_konumu_pdf = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.bt_varsayilan_degistir_defteryolu = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox40 = new System.Windows.Forms.GroupBox();
            this.tb_varsayilan_kayit_planyolu_pdf = new System.Windows.Forms.TextBox();
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.tb_varsayilan_plankapakyolu = new System.Windows.Forms.TextBox();
            this.bt_varsayilan_degistir_plankapakyolu = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.tb_varsayilan_gunlukplanyolu = new System.Windows.Forms.TextBox();
            this.bt_varsayilan_degistir_gunlukplanyolu = new System.Windows.Forms.Button();
            this.label54 = new System.Windows.Forms.Label();
            this.tb_varsayilan_yillikplanyolu = new System.Windows.Forms.TextBox();
            this.bt_varsayilan_degistir_yillikplanyolu = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label47 = new System.Windows.Forms.Label();
            this.tb_sil_sifre = new System.Windows.Forms.TextBox();
            this.bt_sil_seciliveriler = new System.Windows.Forms.Button();
            this.cb_sil_bilgidisinda_hersey = new System.Windows.Forms.CheckBox();
            this.cb_sil_odemeler = new System.Windows.Forms.CheckBox();
            this.cb_sil_cdpdf = new System.Windows.Forms.CheckBox();
            this.cb_sil_kuluptalebi = new System.Windows.Forms.CheckBox();
            this.cb_sil_ogrencilistesi = new System.Windows.Forms.CheckBox();
            this.cb_sil_zumreler = new System.Windows.Forms.CheckBox();
            this.cb_sil_defterler = new System.Windows.Forms.CheckBox();
            this.cb_sil_serbestetkinlikler = new System.Windows.Forms.CheckBox();
            this.cb_sil_gunlukplanlar = new System.Windows.Forms.CheckBox();
            this.cb_sil_yillikplanlar = new System.Windows.Forms.CheckBox();
            this.cb_sil_hersey = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.lbl_ogrencilistesikaydedildi = new System.Windows.Forms.Label();
            this.btn_bilgi_ogrencilistesi = new System.Windows.Forms.Button();
            this.linklbl_ogrencilistesikaydet = new System.Windows.Forms.LinkLabel();
            this.tb_ogrencilistesi_multiline = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_11 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_10 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_9 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_8 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_7 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_6 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_yeni_sablonadi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_sablon_nobetyeri_1 = new System.Windows.Forms.TextBox();
            this.linklbl_sablon_nobetyeri_sablonukaydet = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.linklbl_logo_gozat = new System.Windows.Forms.LinkLabel();
            this.tb_bilgi_logo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.linklbl_musteri_no_ogrt_bilgisi_getir = new System.Windows.Forms.LinkLabel();
            this.cb_bilgi_musterinokilitli = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_bilgi_musterino = new System.Windows.Forms.TextBox();
            this.cb_bilgi_ilcesi = new System.Windows.Forms.ComboBox();
            this.tb_bilgi_bayikodu = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.linklbl_kurumkodundanbul = new System.Windows.Forms.LinkLabel();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_bilgi_adisoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_yenikayit = new System.Windows.Forms.Button();
            this.bt_guncelle = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_varsayilanlariguncelle = new System.Windows.Forms.Button();
            this.btn_ikaz_lambasi = new System.Windows.Forms.Button();
            this.cb_yil_ara = new System.Windows.Forms.ComboBox();
            this.rb_ara_okumadefteri = new System.Windows.Forms.RadioButton();
            this.cb_yil_ara_defter = new System.Windows.Forms.ComboBox();
            this.cb_ara_defterturu = new System.Windows.Forms.ComboBox();
            this.cb_yil_ara_bilgileregore = new System.Windows.Forms.ComboBox();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_alt_arama = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.rb_ara_plangunluk = new System.Windows.Forms.RadioButton();
            this.rb_ara_planyillik = new System.Windows.Forms.RadioButton();
            this.rb_ara_plantumu = new System.Windows.Forms.RadioButton();
            this.lnklbl_ara_plan = new System.Windows.Forms.LinkLabel();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.rb_ara_durum_basilmamis = new System.Windows.Forms.RadioButton();
            this.rb_ara_durum_basilmis = new System.Windows.Forms.RadioButton();
            this.rb_ara_durum_tumu = new System.Windows.Forms.RadioButton();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.lnklbl_ara_ekurunler = new System.Windows.Forms.LinkLabel();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.rb_ara_ekurun_durum_basilmamis = new System.Windows.Forms.RadioButton();
            this.rb_ara_ekurun_durum_basilmis = new System.Windows.Forms.RadioButton();
            this.rb_ara_ekurun_durum_tumu = new System.Windows.Forms.RadioButton();
            this.rb_ara_sosyalkulup = new System.Windows.Forms.RadioButton();
            this.rb_ara_pdf = new System.Windows.Forms.RadioButton();
            this.rb_ara_cd = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox28 = new System.Windows.Forms.GroupBox();
            this.groupBox30 = new System.Windows.Forms.GroupBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox29 = new System.Windows.Forms.GroupBox();
            this.rb_ara_defter_durum_basilmamis = new System.Windows.Forms.RadioButton();
            this.rb_ara_defter_durum_basilmis = new System.Windows.Forms.RadioButton();
            this.rb_ara_defter_durum_tumu = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lnklbl_ara_bilgilerle_listele = new System.Windows.Forms.LinkLabel();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.tb_yil_ara_bilgileregore_bayiadi = new System.Windows.Forms.TextBox();
            this.groupBox32 = new System.Windows.Forms.GroupBox();
            this.tb_yil_ara_musteriadi = new System.Windows.Forms.TextBox();
            this.groupBox31 = new System.Windows.Forms.GroupBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tb_yil_ara_bilgileregore_okul = new System.Windows.Forms.TextBox();
            this.tb_yil_ara_bilgileregore_ilce = new System.Windows.Forms.TextBox();
            this.tb_yil_ara_bilgileregore_il = new System.Windows.Forms.TextBox();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lbl_ara_bulunankayit_sayisi = new System.Windows.Forms.Label();
            this.dgv_alt_aramavelisteleme = new System.Windows.Forms.DataGridView();
            this.label48 = new System.Windows.Forms.Label();
            this.tab_alt_loglar = new System.Windows.Forms.TabPage();
            this.tb_logkayitlari = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_talepgiris.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_defterler)).BeginInit();
            this.groupBox8.SuspendLayout();
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
            this.tab_hizlitalep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSunucuTalepleri)).BeginInit();
            this.tab_defterbasim.SuspendLayout();
            this.groupBox39.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_defterler_baski)).BeginInit();
            this.groupBox38.SuspendLayout();
            this.groupBox37.SuspendLayout();
            this.groupBox35.SuspendLayout();
            this.groupBox36.SuspendLayout();
            this.groupBox34.SuspendLayout();
            this.tab_muhasebe.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muhasebe_odemeler)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muhasebe_borclanmalar)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.tab_digerislemler.SuspendLayout();
            this.groupBox41.SuspendLayout();
            this.groupBox40.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tab_alt_arama.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox28.SuspendLayout();
            this.groupBox30.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.groupBox29.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.groupBox32.SuspendLayout();
            this.groupBox31.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alt_aramavelisteleme)).BeginInit();
            this.tab_alt_loglar.SuspendLayout();
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
            this.toolTip1.SetToolTip(this.cb_yili, "Yeni kayıt veya Güncelleme yaparken boş bırakılırsa varsayılan değeri alır. (Bayi" +
        " de aynı şekilde varsayılan değeri alır.)");
            this.cb_yili.SelectedIndexChanged += new System.EventHandler(this.cb_yili_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_talepgiris);
            this.tabControl1.Controls.Add(this.tab_hizlitalep);
            this.tabControl1.Controls.Add(this.tab_planbasim);
            this.tabControl1.Controls.Add(this.tab_defterbasim);
            this.tabControl1.Controls.Add(this.tab_muhasebe);
            this.tabControl1.Controls.Add(this.tab_digerislemler);
            this.tabControl1.Location = new System.Drawing.Point(393, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1368, 570);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_talepgiris
            // 
            this.tab_talepgiris.Controls.Add(this.groupBox12);
            this.tab_talepgiris.Controls.Add(this.groupBox9);
            this.tab_talepgiris.Controls.Add(this.groupBox8);
            this.tab_talepgiris.Controls.Add(this.groupBox7);
            this.tab_talepgiris.Controls.Add(this.groupBox6);
            this.tab_talepgiris.Controls.Add(this.groupBox5);
            this.tab_talepgiris.Controls.Add(this.groupBox4);
            this.tab_talepgiris.Controls.Add(this.groupBox3);
            this.tab_talepgiris.Location = new System.Drawing.Point(4, 22);
            this.tab_talepgiris.Name = "tab_talepgiris";
            this.tab_talepgiris.Size = new System.Drawing.Size(1360, 544);
            this.tab_talepgiris.TabIndex = 2;
            this.tab_talepgiris.Text = "Talep Girişleri";
            this.tab_talepgiris.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tb_hesapozeti_toplambakiye);
            this.groupBox12.Controls.Add(this.label45);
            this.groupBox12.Controls.Add(this.tb_hesapozeti_toplamodeme);
            this.groupBox12.Controls.Add(this.label44);
            this.groupBox12.Controls.Add(this.tb_hesapozeti_toplamborc);
            this.groupBox12.Controls.Add(this.label43);
            this.groupBox12.Location = new System.Drawing.Point(974, 450);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(379, 88);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Hesap Özeti";
            // 
            // tb_hesapozeti_toplambakiye
            // 
            this.tb_hesapozeti_toplambakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_hesapozeti_toplambakiye.Location = new System.Drawing.Point(243, 47);
            this.tb_hesapozeti_toplambakiye.Name = "tb_hesapozeti_toplambakiye";
            this.tb_hesapozeti_toplambakiye.Size = new System.Drawing.Size(130, 32);
            this.tb_hesapozeti_toplambakiye.TabIndex = 7;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(286, 26);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(39, 13);
            this.label45.TabIndex = 6;
            this.label45.Text = "Bakiye";
            // 
            // tb_hesapozeti_toplamodeme
            // 
            this.tb_hesapozeti_toplamodeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_hesapozeti_toplamodeme.Location = new System.Drawing.Point(89, 54);
            this.tb_hesapozeti_toplamodeme.Name = "tb_hesapozeti_toplamodeme";
            this.tb_hesapozeti_toplamodeme.Size = new System.Drawing.Size(127, 32);
            this.tb_hesapozeti_toplamodeme.TabIndex = 5;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 66);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(79, 13);
            this.label44.TabIndex = 4;
            this.label44.Text = "Toplam Ödeme";
            // 
            // tb_hesapozeti_toplamborc
            // 
            this.tb_hesapozeti_toplamborc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_hesapozeti_toplamborc.Location = new System.Drawing.Point(89, 16);
            this.tb_hesapozeti_toplamborc.Name = "tb_hesapozeti_toplamborc";
            this.tb_hesapozeti_toplamborc.Size = new System.Drawing.Size(127, 32);
            this.tb_hesapozeti_toplamborc.TabIndex = 3;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(67, 13);
            this.label43.TabIndex = 2;
            this.label43.Text = "Toplam Borç";
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
            this.linklbl_talep_defterekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_defterekle_LinkClicked);
            // 
            // dgv_talep_defterler
            // 
            this.dgv_talep_defterler.AllowUserToAddRows = false;
            this.dgv_talep_defterler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_talep_defterler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_defterler.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_defterler.Name = "dgv_talep_defterler";
            this.dgv_talep_defterler.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_defterler.TabIndex = 29;
            this.dgv_talep_defterler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_talep_defter_doubleClick);
            // 
            // cb_talep_defter
            // 
            this.cb_talep_defter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_talep_defter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_talep_defter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_talep_defter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_defter.FormattingEnabled = true;
            this.cb_talep_defter.Location = new System.Drawing.Point(6, 22);
            this.cb_talep_defter.Name = "cb_talep_defter";
            this.cb_talep_defter.Size = new System.Drawing.Size(374, 33);
            this.cb_talep_defter.TabIndex = 28;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.linklbl_talep_nobetyeri_ekle);
            this.groupBox8.Controls.Add(this.cb_talep_nobetyerisablon);
            this.groupBox8.Controls.Add(this.linklbl_talep_nobetyeri_sil);
            this.groupBox8.Controls.Add(this.dgv_talep_nobetyerleri);
            this.groupBox8.Location = new System.Drawing.Point(970, 239);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(383, 210);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nöbet Yerleri (Nöbet Defteri İçin)";
            // 
            // linklbl_talep_nobetyeri_ekle
            // 
            this.linklbl_talep_nobetyeri_ekle.AutoSize = true;
            this.linklbl_talep_nobetyeri_ekle.Location = new System.Drawing.Point(296, 28);
            this.linklbl_talep_nobetyeri_ekle.Name = "linklbl_talep_nobetyeri_ekle";
            this.linklbl_talep_nobetyeri_ekle.Size = new System.Drawing.Size(57, 26);
            this.linklbl_talep_nobetyeri_ekle.TabIndex = 56;
            this.linklbl_talep_nobetyeri_ekle.TabStop = true;
            this.linklbl_talep_nobetyeri_ekle.Text = "Nöbet Yeri\r\nKaydet";
            this.linklbl_talep_nobetyeri_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklbl_talep_nobetyeri_ekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_nobetyeri_ekle_LinkClicked);
            // 
            // cb_talep_nobetyerisablon
            // 
            this.cb_talep_nobetyerisablon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_talep_nobetyerisablon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_talep_nobetyerisablon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_talep_nobetyerisablon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_nobetyerisablon.FormattingEnabled = true;
            this.cb_talep_nobetyerisablon.Location = new System.Drawing.Point(6, 23);
            this.cb_talep_nobetyerisablon.Name = "cb_talep_nobetyerisablon";
            this.cb_talep_nobetyerisablon.Size = new System.Drawing.Size(266, 33);
            this.cb_talep_nobetyerisablon.TabIndex = 55;
            this.cb_talep_nobetyerisablon.SelectedIndexChanged += new System.EventHandler(this.cb_talep_nobetyerisablon_SelectedIndexChanged);
            // 
            // linklbl_talep_nobetyeri_sil
            // 
            this.linklbl_talep_nobetyeri_sil.AutoSize = true;
            this.linklbl_talep_nobetyeri_sil.Location = new System.Drawing.Point(314, 172);
            this.linklbl_talep_nobetyeri_sil.Name = "linklbl_talep_nobetyeri_sil";
            this.linklbl_talep_nobetyeri_sil.Size = new System.Drawing.Size(23, 13);
            this.linklbl_talep_nobetyeri_sil.TabIndex = 54;
            this.linklbl_talep_nobetyeri_sil.TabStop = true;
            this.linklbl_talep_nobetyeri_sil.Text = "SİL";
            this.linklbl_talep_nobetyeri_sil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_nobetyeri_sil_LinkClicked);
            // 
            // dgv_talep_nobetyerleri
            // 
            this.dgv_talep_nobetyerleri.AllowUserToAddRows = false;
            this.dgv_talep_nobetyerleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_talep_nobetyerleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_nobetyerleri.Location = new System.Drawing.Point(6, 62);
            this.dgv_talep_nobetyerleri.Name = "dgv_talep_nobetyerleri";
            this.dgv_talep_nobetyerleri.Size = new System.Drawing.Size(266, 138);
            this.dgv_talep_nobetyerleri.TabIndex = 48;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.linklbl_talep_kulup);
            this.groupBox7.Controls.Add(this.linklbl_talep_kulup_sil);
            this.groupBox7.Controls.Add(this.lbl_talep_sosyalkulupbasimtarihi);
            this.groupBox7.Controls.Add(this.lbl_talep_sosyalkuluptaleptatihi);
            this.groupBox7.Controls.Add(this.tb_talep_sosyalkulupikinciogretmen);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.cb_talep_sosyalkulupadi);
            this.groupBox7.Location = new System.Drawing.Point(12, 450);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(946, 89);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sosyal Kulüp";
            // 
            // linklbl_talep_kulup
            // 
            this.linklbl_talep_kulup.AutoSize = true;
            this.linklbl_talep_kulup.Location = new System.Drawing.Point(873, 28);
            this.linklbl_talep_kulup.Name = "linklbl_talep_kulup";
            this.linklbl_talep_kulup.Size = new System.Drawing.Size(50, 13);
            this.linklbl_talep_kulup.TabIndex = 36;
            this.linklbl_talep_kulup.TabStop = true;
            this.linklbl_talep_kulup.Text = "KAYDET";
            this.linklbl_talep_kulup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_kulup_LinkClicked);
            // 
            // linklbl_talep_kulup_sil
            // 
            this.linklbl_talep_kulup_sil.AutoSize = true;
            this.linklbl_talep_kulup_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_talep_kulup_sil.ForeColor = System.Drawing.Color.Red;
            this.linklbl_talep_kulup_sil.LinkColor = System.Drawing.Color.Red;
            this.linklbl_talep_kulup_sil.Location = new System.Drawing.Point(12, 48);
            this.linklbl_talep_kulup_sil.Name = "linklbl_talep_kulup_sil";
            this.linklbl_talep_kulup_sil.Size = new System.Drawing.Size(65, 18);
            this.linklbl_talep_kulup_sil.TabIndex = 35;
            this.linklbl_talep_kulup_sil.TabStop = true;
            this.linklbl_talep_kulup_sil.Text = "Kulüp Sil";
            this.toolTip1.SetToolTip(this.linklbl_talep_kulup_sil, "Kulüp talebini veritabanından siler.");
            this.linklbl_talep_kulup_sil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_kulup_sil_LinkClicked);
            // 
            // lbl_talep_sosyalkulupbasimtarihi
            // 
            this.lbl_talep_sosyalkulupbasimtarihi.AutoSize = true;
            this.lbl_talep_sosyalkulupbasimtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_talep_sosyalkulupbasimtarihi.Location = new System.Drawing.Point(550, 51);
            this.lbl_talep_sosyalkulupbasimtarihi.Name = "lbl_talep_sosyalkulupbasimtarihi";
            this.lbl_talep_sosyalkulupbasimtarihi.Size = new System.Drawing.Size(64, 13);
            this.lbl_talep_sosyalkulupbasimtarihi.TabIndex = 34;
            this.lbl_talep_sosyalkulupbasimtarihi.Text = "Basım Tarihi";
            // 
            // lbl_talep_sosyalkuluptaleptatihi
            // 
            this.lbl_talep_sosyalkuluptaleptatihi.AutoSize = true;
            this.lbl_talep_sosyalkuluptaleptatihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_talep_sosyalkuluptaleptatihi.Location = new System.Drawing.Point(83, 52);
            this.lbl_talep_sosyalkuluptaleptatihi.Name = "lbl_talep_sosyalkuluptaleptatihi";
            this.lbl_talep_sosyalkuluptaleptatihi.Size = new System.Drawing.Size(63, 13);
            this.lbl_talep_sosyalkuluptaleptatihi.TabIndex = 33;
            this.lbl_talep_sosyalkuluptaleptatihi.Text = "Talep Tarihi";
            // 
            // tb_talep_sosyalkulupikinciogretmen
            // 
            this.tb_talep_sosyalkulupikinciogretmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_talep_sosyalkulupikinciogretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_talep_sosyalkulupikinciogretmen.Location = new System.Drawing.Point(553, 17);
            this.tb_talep_sosyalkulupikinciogretmen.Name = "tb_talep_sosyalkulupikinciogretmen";
            this.tb_talep_sosyalkulupikinciogretmen.Size = new System.Drawing.Size(301, 32);
            this.tb_talep_sosyalkulupikinciogretmen.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(479, 28);
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
            this.cb_talep_sosyalkulupadi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_talep_sosyalkulupadi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_talep_sosyalkulupadi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_talep_sosyalkulupadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_sosyalkulupadi.FormattingEnabled = true;
            this.cb_talep_sosyalkulupadi.Location = new System.Drawing.Point(86, 16);
            this.cb_talep_sosyalkulupadi.Name = "cb_talep_sosyalkulupadi";
            this.cb_talep_sosyalkulupadi.Size = new System.Drawing.Size(380, 33);
            this.cb_talep_sosyalkulupadi.TabIndex = 29;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.linkLabel1);
            this.groupBox6.Controls.Add(this.linklbl_zumre_otomatikgetir);
            this.groupBox6.Controls.Add(this.tb_talep_digerzumreogretmenleri);
            this.groupBox6.Controls.Add(this.linklbl_talep_digerzumreogretmeniekle);
            this.groupBox6.Controls.Add(this.dgv_talep_digerzumreogretmenleri);
            this.groupBox6.Location = new System.Drawing.Point(964, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(389, 210);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Diğer Zümre Öğretmenleri";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(302, 147);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(71, 39);
            this.linkLabel1.TabIndex = 32;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Zumre\r\nYıllık Plan\r\nTalebi Hazırla";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linkLabel1, "Okula verilmek üzere ekrandaki öğretmen bilgileri esas alınarak plan talebi olan " +
        "öğretmen isimlerine uygun okul adına otomatik olarak yıllık plan talebi oluşturu" +
        "r.");
            // 
            // linklbl_zumre_otomatikgetir
            // 
            this.linklbl_zumre_otomatikgetir.AutoSize = true;
            this.linklbl_zumre_otomatikgetir.Location = new System.Drawing.Point(296, 87);
            this.linklbl_zumre_otomatikgetir.Name = "linklbl_zumre_otomatikgetir";
            this.linklbl_zumre_otomatikgetir.Size = new System.Drawing.Size(84, 13);
            this.linklbl_zumre_otomatikgetir.TabIndex = 31;
            this.linklbl_zumre_otomatikgetir.TabStop = true;
            this.linklbl_zumre_otomatikgetir.Text = "Kayıtlardan Getir";
            this.linklbl_zumre_otomatikgetir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.linklbl_zumre_otomatikgetir, "Daha önceki talep kayıtlarına bakarak bu okul ve sınıf seviyesindeki öğretmen isi" +
        "mlerini otomatik yazar.");
            // 
            // tb_talep_digerzumreogretmenleri
            // 
            this.tb_talep_digerzumreogretmenleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_talep_digerzumreogretmenleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_talep_digerzumreogretmenleri.Location = new System.Drawing.Point(6, 23);
            this.tb_talep_digerzumreogretmenleri.Name = "tb_talep_digerzumreogretmenleri";
            this.tb_talep_digerzumreogretmenleri.Size = new System.Drawing.Size(272, 32);
            this.tb_talep_digerzumreogretmenleri.TabIndex = 20;
            // 
            // linklbl_talep_digerzumreogretmeniekle
            // 
            this.linklbl_talep_digerzumreogretmeniekle.AutoSize = true;
            this.linklbl_talep_digerzumreogretmeniekle.Location = new System.Drawing.Point(296, 31);
            this.linklbl_talep_digerzumreogretmeniekle.Name = "linklbl_talep_digerzumreogretmeniekle";
            this.linklbl_talep_digerzumreogretmeniekle.Size = new System.Drawing.Size(77, 13);
            this.linklbl_talep_digerzumreogretmeniekle.TabIndex = 30;
            this.linklbl_talep_digerzumreogretmeniekle.TabStop = true;
            this.linklbl_talep_digerzumreogretmeniekle.Text = "Öğretmen Ekle";
            this.linklbl_talep_digerzumreogretmeniekle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklbl_talep_digerzumreogretmeniekle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_digerzumreogretmeniekle_LinkClicked);
            // 
            // dgv_talep_digerzumreogretmenleri
            // 
            this.dgv_talep_digerzumreogretmenleri.AllowUserToAddRows = false;
            this.dgv_talep_digerzumreogretmenleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_talep_digerzumreogretmenleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_digerzumreogretmenleri.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_digerzumreogretmenleri.Name = "dgv_talep_digerzumreogretmenleri";
            this.dgv_talep_digerzumreogretmenleri.Size = new System.Drawing.Size(272, 133);
            this.dgv_talep_digerzumreogretmenleri.TabIndex = 29;
            this.dgv_talep_digerzumreogretmenleri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_talep_digerzumreogretmenleri_doubleClick);
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
            this.linklbl_talep_tumdersleriekle_serbest_yillik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_tumdersleriekle_serbest_yillik_LinkClicked);
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
            this.linklbl_talep_secimiekle_serbest_yillik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_secimiekle_serbest_yillik_LinkClicked);
            // 
            // dgv_talep_serbestdersler_yillik
            // 
            this.dgv_talep_serbestdersler_yillik.AllowUserToAddRows = false;
            this.dgv_talep_serbestdersler_yillik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_talep_serbestdersler_yillik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_serbestdersler_yillik.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_serbestdersler_yillik.Name = "dgv_talep_serbestdersler_yillik";
            this.dgv_talep_serbestdersler_yillik.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_serbestdersler_yillik.TabIndex = 29;
            this.dgv_talep_serbestdersler_yillik.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_talep_serbestdersler_doubleClick);
            // 
            // cb_talep_serbestdersler_yillik
            // 
            this.cb_talep_serbestdersler_yillik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_talep_serbestdersler_yillik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_talep_serbestdersler_yillik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.groupBox4.Location = new System.Drawing.Point(488, 18);
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
            this.linklbl_talep_tumanadersleriekle_gunluk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_tumanadersleriekle_gunluk_LinkClicked);
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
            this.linklbl_talep_secimiekle_anadersler_gunluk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_secimiekle_anadersler_gunluk_LinkClicked);
            // 
            // dgv_talep_anadersler_gunluk
            // 
            this.dgv_talep_anadersler_gunluk.AllowUserToAddRows = false;
            this.dgv_talep_anadersler_gunluk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_talep_anadersler_gunluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_anadersler_gunluk.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_anadersler_gunluk.Name = "dgv_talep_anadersler_gunluk";
            this.dgv_talep_anadersler_gunluk.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_anadersler_gunluk.TabIndex = 29;
            this.dgv_talep_anadersler_gunluk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_talep_anadersler_gunluk_doubleClick);
            // 
            // cb_talep_anadersler_gunluk
            // 
            this.cb_talep_anadersler_gunluk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_talep_anadersler_gunluk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_talep_anadersler_gunluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cb_talep_pdf.Location = new System.Drawing.Point(386, 159);
            this.cb_talep_pdf.Name = "cb_talep_pdf";
            this.cb_talep_pdf.Size = new System.Drawing.Size(75, 30);
            this.cb_talep_pdf.TabIndex = 33;
            this.cb_talep_pdf.Text = "PDF";
            this.cb_talep_pdf.UseVisualStyleBackColor = true;
            this.cb_talep_pdf.Click += new System.EventHandler(this.cb_talep_pdf_CheckedChanged);
            // 
            // linklabel_talep_tumanadersleriekle_yillik
            // 
            this.linklabel_talep_tumanadersleriekle_yillik.AutoSize = true;
            this.linklabel_talep_tumanadersleriekle_yillik.Location = new System.Drawing.Point(396, 75);
            this.linklabel_talep_tumanadersleriekle_yillik.Name = "linklabel_talep_tumanadersleriekle_yillik";
            this.linklabel_talep_tumanadersleriekle_yillik.Size = new System.Drawing.Size(66, 39);
            this.linklabel_talep_tumanadersleriekle_yillik.TabIndex = 31;
            this.linklabel_talep_tumanadersleriekle_yillik.TabStop = true;
            this.linklabel_talep_tumanadersleriekle_yillik.Text = "Sınıf Düzeyi\r\nTüm Ana\r\nDersleri Ekle";
            this.linklabel_talep_tumanadersleriekle_yillik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linklabel_talep_tumanadersleriekle_yillik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_talep_tumanadersleriekle_yillik_LinkClicked);
            // 
            // linklbl_talep_anadersler_secimiekle_yillik
            // 
            this.linklbl_talep_anadersler_secimiekle_yillik.AutoSize = true;
            this.linklbl_talep_anadersler_secimiekle_yillik.Location = new System.Drawing.Point(393, 27);
            this.linklbl_talep_anadersler_secimiekle_yillik.Name = "linklbl_talep_anadersler_secimiekle_yillik";
            this.linklbl_talep_anadersler_secimiekle_yillik.Size = new System.Drawing.Size(62, 13);
            this.linklbl_talep_anadersler_secimiekle_yillik.TabIndex = 30;
            this.linklbl_talep_anadersler_secimiekle_yillik.TabStop = true;
            this.linklbl_talep_anadersler_secimiekle_yillik.Text = "Seçimi Ekle";
            this.linklbl_talep_anadersler_secimiekle_yillik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_talep_anadersler_secimiekle_yillik_LinkClicked);
            // 
            // dgv_talep_anadersler_yillik
            // 
            this.dgv_talep_anadersler_yillik.AllowUserToAddRows = false;
            this.dgv_talep_anadersler_yillik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_talep_anadersler_yillik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_anadersler_yillik.Location = new System.Drawing.Point(6, 67);
            this.dgv_talep_anadersler_yillik.Name = "dgv_talep_anadersler_yillik";
            this.dgv_talep_anadersler_yillik.ReadOnly = true;
            this.dgv_talep_anadersler_yillik.Size = new System.Drawing.Size(374, 133);
            this.dgv_talep_anadersler_yillik.TabIndex = 29;
            this.dgv_talep_anadersler_yillik.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_talep_anadersler_yillik_doubleClick);
            // 
            // cb_talep_anadersler_yillik
            // 
            this.cb_talep_anadersler_yillik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_talep_anadersler_yillik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_talep_anadersler_yillik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_talep_anadersler_yillik.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_talep_anadersler_yillik.FormattingEnabled = true;
            this.cb_talep_anadersler_yillik.Location = new System.Drawing.Point(6, 22);
            this.cb_talep_anadersler_yillik.Name = "cb_talep_anadersler_yillik";
            this.cb_talep_anadersler_yillik.Size = new System.Drawing.Size(374, 33);
            this.cb_talep_anadersler_yillik.TabIndex = 28;
            // 
            // tab_hizlitalep
            // 
            this.tab_hizlitalep.Controls.Add(this.pb_defterhizlikayit);
            this.tab_hizlitalep.Controls.Add(this.bt_mukerrerkayit_izni_cb_bilgi);
            this.tab_hizlitalep.Controls.Add(this.cb_defter_mukerrerkayit_izin_ver);
            this.tab_hizlitalep.Controls.Add(this.btn_defter_talepleriniHizliAl);
            this.tab_hizlitalep.Controls.Add(this.btn_taleplerial_excelden);
            this.tab_hizlitalep.Controls.Add(this.lbl_bekleyin);
            this.tab_hizlitalep.Controls.Add(this.datagridSunucuTalepleri);
            this.tab_hizlitalep.Controls.Add(this.btn_taleplerial_sunucudan);
            this.tab_hizlitalep.Location = new System.Drawing.Point(4, 22);
            this.tab_hizlitalep.Name = "tab_hizlitalep";
            this.tab_hizlitalep.Padding = new System.Windows.Forms.Padding(3);
            this.tab_hizlitalep.Size = new System.Drawing.Size(1360, 544);
            this.tab_hizlitalep.TabIndex = 3;
            this.tab_hizlitalep.Text = "Hızlı Talep";
            this.tab_hizlitalep.UseVisualStyleBackColor = true;
            // 
            // pb_defterhizlikayit
            // 
            this.pb_defterhizlikayit.Location = new System.Drawing.Point(737, 348);
            this.pb_defterhizlikayit.Name = "pb_defterhizlikayit";
            this.pb_defterhizlikayit.Size = new System.Drawing.Size(221, 10);
            this.pb_defterhizlikayit.TabIndex = 7;
            // 
            // bt_mukerrerkayit_izni_cb_bilgi
            // 
            this.bt_mukerrerkayit_izni_cb_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_mukerrerkayit_izni_cb_bilgi.Location = new System.Drawing.Point(258, 355);
            this.bt_mukerrerkayit_izni_cb_bilgi.Name = "bt_mukerrerkayit_izni_cb_bilgi";
            this.bt_mukerrerkayit_izni_cb_bilgi.Size = new System.Drawing.Size(24, 23);
            this.bt_mukerrerkayit_izni_cb_bilgi.TabIndex = 6;
            this.bt_mukerrerkayit_izni_cb_bilgi.Text = "!";
            this.bt_mukerrerkayit_izni_cb_bilgi.UseVisualStyleBackColor = true;
            this.bt_mukerrerkayit_izni_cb_bilgi.Click += new System.EventHandler(this.bt_mukerrerkayit_izni_cb_bilgi_Click);
            // 
            // cb_defter_mukerrerkayit_izin_ver
            // 
            this.cb_defter_mukerrerkayit_izin_ver.AutoSize = true;
            this.cb_defter_mukerrerkayit_izin_ver.Checked = true;
            this.cb_defter_mukerrerkayit_izin_ver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_defter_mukerrerkayit_izin_ver.Location = new System.Drawing.Point(288, 359);
            this.cb_defter_mukerrerkayit_izin_ver.Name = "cb_defter_mukerrerkayit_izin_ver";
            this.cb_defter_mukerrerkayit_izin_ver.Size = new System.Drawing.Size(301, 17);
            this.cb_defter_mukerrerkayit_izin_ver.TabIndex = 5;
            this.cb_defter_mukerrerkayit_izin_ver.Text = "Mükerrer Müşteri Kayıtlarına İzin Ver ( Sadece ... şubeli ise)";
            this.toolTip1.SetToolTip(this.cb_defter_mukerrerkayit_izin_ver, "Aynı okul, sınıf ve şubeye mükerrer kayıt izni verir.");
            this.cb_defter_mukerrerkayit_izin_ver.UseVisualStyleBackColor = true;
            // 
            // btn_defter_talepleriniHizliAl
            // 
            this.btn_defter_talepleriniHizliAl.Location = new System.Drawing.Point(16, 348);
            this.btn_defter_talepleriniHizliAl.Name = "btn_defter_talepleriniHizliAl";
            this.btn_defter_talepleriniHizliAl.Size = new System.Drawing.Size(220, 37);
            this.btn_defter_talepleriniHizliAl.TabIndex = 4;
            this.btn_defter_talepleriniHizliAl.Text = "Defter Taleplerini Excelden Al";
            this.btn_defter_talepleriniHizliAl.UseVisualStyleBackColor = true;
            this.btn_defter_talepleriniHizliAl.Click += new System.EventHandler(this.btn_defter_talepleriniHizliAl_Click);
            // 
            // btn_taleplerial_excelden
            // 
            this.btn_taleplerial_excelden.Location = new System.Drawing.Point(17, 29);
            this.btn_taleplerial_excelden.Name = "btn_taleplerial_excelden";
            this.btn_taleplerial_excelden.Size = new System.Drawing.Size(220, 37);
            this.btn_taleplerial_excelden.TabIndex = 3;
            this.btn_taleplerial_excelden.Text = "Plan Taleplerini Excelden Al";
            this.btn_taleplerial_excelden.UseVisualStyleBackColor = true;
            this.btn_taleplerial_excelden.Click += new System.EventHandler(this.btn_taleplerial_excelden_Click);
            // 
            // lbl_bekleyin
            // 
            this.lbl_bekleyin.AutoSize = true;
            this.lbl_bekleyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bekleyin.ForeColor = System.Drawing.Color.Red;
            this.lbl_bekleyin.Location = new System.Drawing.Point(437, 36);
            this.lbl_bekleyin.Name = "lbl_bekleyin";
            this.lbl_bekleyin.Size = new System.Drawing.Size(18, 25);
            this.lbl_bekleyin.TabIndex = 2;
            this.lbl_bekleyin.Text = ".";
            // 
            // datagridSunucuTalepleri
            // 
            this.datagridSunucuTalepleri.AllowUserToAddRows = false;
            this.datagridSunucuTalepleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridSunucuTalepleri.Location = new System.Drawing.Point(16, 72);
            this.datagridSunucuTalepleri.Name = "datagridSunucuTalepleri";
            this.datagridSunucuTalepleri.Size = new System.Drawing.Size(942, 270);
            this.datagridSunucuTalepleri.TabIndex = 1;
            // 
            // btn_taleplerial_sunucudan
            // 
            this.btn_taleplerial_sunucudan.Location = new System.Drawing.Point(738, 30);
            this.btn_taleplerial_sunucudan.Name = "btn_taleplerial_sunucudan";
            this.btn_taleplerial_sunucudan.Size = new System.Drawing.Size(220, 37);
            this.btn_taleplerial_sunucudan.TabIndex = 0;
            this.btn_taleplerial_sunucudan.Text = "Talepleri Sunucudan Al";
            this.btn_taleplerial_sunucudan.UseVisualStyleBackColor = true;
            this.btn_taleplerial_sunucudan.Click += new System.EventHandler(this.button1_Click);
            // 
            // tab_planbasim
            // 
            this.tab_planbasim.Location = new System.Drawing.Point(4, 22);
            this.tab_planbasim.Name = "tab_planbasim";
            this.tab_planbasim.Padding = new System.Windows.Forms.Padding(3);
            this.tab_planbasim.Size = new System.Drawing.Size(1360, 544);
            this.tab_planbasim.TabIndex = 0;
            this.tab_planbasim.Text = "Plan Basım İşlemleri";
            this.tab_planbasim.UseVisualStyleBackColor = true;
            // 
            // tab_defterbasim
            // 
            this.tab_defterbasim.Controls.Add(this.button1);
            this.tab_defterbasim.Controls.Add(this.groupBox39);
            this.tab_defterbasim.Controls.Add(this.groupBox38);
            this.tab_defterbasim.Controls.Add(this.bt_defterbas_baskiyabasla);
            this.tab_defterbasim.Controls.Add(this.groupBox37);
            this.tab_defterbasim.Controls.Add(this.groupBox35);
            this.tab_defterbasim.Controls.Add(this.groupBox36);
            this.tab_defterbasim.Controls.Add(this.groupBox34);
            this.tab_defterbasim.Location = new System.Drawing.Point(4, 22);
            this.tab_defterbasim.Name = "tab_defterbasim";
            this.tab_defterbasim.Padding = new System.Windows.Forms.Padding(3);
            this.tab_defterbasim.Size = new System.Drawing.Size(1360, 544);
            this.tab_defterbasim.TabIndex = 1;
            this.tab_defterbasim.Text = "Defter Basım İşlemleri";
            this.tab_defterbasim.UseVisualStyleBackColor = true;
            // 
            // groupBox39
            // 
            this.groupBox39.Controls.Add(this.dgv_talep_defterler_baski);
            this.groupBox39.Location = new System.Drawing.Point(363, 102);
            this.groupBox39.Name = "groupBox39";
            this.groupBox39.Size = new System.Drawing.Size(603, 107);
            this.groupBox39.TabIndex = 41;
            this.groupBox39.TabStop = false;
            this.groupBox39.Text = "Defter Talepleri";
            // 
            // dgv_talep_defterler_baski
            // 
            this.dgv_talep_defterler_baski.AllowUserToAddRows = false;
            this.dgv_talep_defterler_baski.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_talep_defterler_baski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_talep_defterler_baski.Location = new System.Drawing.Point(6, 19);
            this.dgv_talep_defterler_baski.Name = "dgv_talep_defterler_baski";
            this.dgv_talep_defterler_baski.Size = new System.Drawing.Size(591, 83);
            this.dgv_talep_defterler_baski.TabIndex = 29;
            // 
            // groupBox38
            // 
            this.groupBox38.Controls.Add(this.cb_baski_basilacak_defterturu);
            this.groupBox38.Location = new System.Drawing.Point(363, 24);
            this.groupBox38.Name = "groupBox38";
            this.groupBox38.Size = new System.Drawing.Size(603, 72);
            this.groupBox38.TabIndex = 40;
            this.groupBox38.TabStop = false;
            this.groupBox38.Text = "Basılacak Defter Seçimi (Tümü için boş bırakın)";
            // 
            // cb_baski_basilacak_defterturu
            // 
            this.cb_baski_basilacak_defterturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_baski_basilacak_defterturu.FormattingEnabled = true;
            this.cb_baski_basilacak_defterturu.Location = new System.Drawing.Point(6, 19);
            this.cb_baski_basilacak_defterturu.Name = "cb_baski_basilacak_defterturu";
            this.cb_baski_basilacak_defterturu.Size = new System.Drawing.Size(591, 32);
            this.cb_baski_basilacak_defterturu.TabIndex = 100;
            this.toolTip1.SetToolTip(this.cb_baski_basilacak_defterturu, "Yeni kayıt veya Güncelleme yaparken boş bırakılırsa varsayılan değeri alır. (Bayi" +
        " de aynı şekilde varsayılan değeri alır.)");
            // 
            // bt_defterbas_baskiyabasla
            // 
            this.bt_defterbas_baskiyabasla.Location = new System.Drawing.Point(22, 423);
            this.bt_defterbas_baskiyabasla.Name = "bt_defterbas_baskiyabasla";
            this.bt_defterbas_baskiyabasla.Size = new System.Drawing.Size(312, 78);
            this.bt_defterbas_baskiyabasla.TabIndex = 5;
            this.bt_defterbas_baskiyabasla.Text = "BASKIYA BAŞLA";
            this.bt_defterbas_baskiyabasla.UseVisualStyleBackColor = true;
            this.bt_defterbas_baskiyabasla.Click += new System.EventHandler(this.bt_defterbas_baskiyabasla_Click);
            // 
            // groupBox37
            // 
            this.groupBox37.Controls.Add(this.bt_bilgi_defterbas_sonislem);
            this.groupBox37.Controls.Add(this.rb_defterbas_sonislem_yaziciyagonder);
            this.groupBox37.Controls.Add(this.rb_defterbas_sonislem_pdftut);
            this.groupBox37.Location = new System.Drawing.Point(22, 305);
            this.groupBox37.Name = "groupBox37";
            this.groupBox37.Size = new System.Drawing.Size(312, 85);
            this.groupBox37.TabIndex = 4;
            this.groupBox37.TabStop = false;
            this.groupBox37.Text = "Son İşlem";
            // 
            // bt_bilgi_defterbas_sonislem
            // 
            this.bt_bilgi_defterbas_sonislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_bilgi_defterbas_sonislem.Location = new System.Drawing.Point(266, 38);
            this.bt_bilgi_defterbas_sonislem.Name = "bt_bilgi_defterbas_sonislem";
            this.bt_bilgi_defterbas_sonislem.Size = new System.Drawing.Size(29, 24);
            this.bt_bilgi_defterbas_sonislem.TabIndex = 3;
            this.bt_bilgi_defterbas_sonislem.Text = "!";
            this.bt_bilgi_defterbas_sonislem.UseVisualStyleBackColor = true;
            this.bt_bilgi_defterbas_sonislem.Click += new System.EventHandler(this.bt_bilgi_defterbas_sonislem_Click);
            // 
            // rb_defterbas_sonislem_yaziciyagonder
            // 
            this.rb_defterbas_sonislem_yaziciyagonder.AutoSize = true;
            this.rb_defterbas_sonislem_yaziciyagonder.Checked = true;
            this.rb_defterbas_sonislem_yaziciyagonder.Location = new System.Drawing.Point(6, 51);
            this.rb_defterbas_sonislem_yaziciyagonder.Name = "rb_defterbas_sonislem_yaziciyagonder";
            this.rb_defterbas_sonislem_yaziciyagonder.Size = new System.Drawing.Size(102, 17);
            this.rb_defterbas_sonislem_yaziciyagonder.TabIndex = 2;
            this.rb_defterbas_sonislem_yaziciyagonder.TabStop = true;
            this.rb_defterbas_sonislem_yaziciyagonder.Text = "Yazıcıya Gönder";
            this.rb_defterbas_sonislem_yaziciyagonder.UseVisualStyleBackColor = true;
            // 
            // rb_defterbas_sonislem_pdftut
            // 
            this.rb_defterbas_sonislem_pdftut.AutoSize = true;
            this.rb_defterbas_sonislem_pdftut.Location = new System.Drawing.Point(6, 28);
            this.rb_defterbas_sonislem_pdftut.Name = "rb_defterbas_sonislem_pdftut";
            this.rb_defterbas_sonislem_pdftut.Size = new System.Drawing.Size(93, 17);
            this.rb_defterbas_sonislem_pdftut.TabIndex = 1;
            this.rb_defterbas_sonislem_pdftut.Text = "PDF olarak tut";
            this.rb_defterbas_sonislem_pdftut.UseVisualStyleBackColor = true;
            // 
            // groupBox35
            // 
            this.groupBox35.Controls.Add(this.bt_bilgi_defterbaskisecenek_1);
            this.groupBox35.Controls.Add(this.rb_defterbas_secenek_kapakvedefter);
            this.groupBox35.Controls.Add(this.rb_defterbas_secenek_defter);
            this.groupBox35.Controls.Add(this.rb_defterbas_secenek_kapak);
            this.groupBox35.Location = new System.Drawing.Point(22, 102);
            this.groupBox35.Name = "groupBox35";
            this.groupBox35.Size = new System.Drawing.Size(312, 106);
            this.groupBox35.TabIndex = 1;
            this.groupBox35.TabStop = false;
            this.groupBox35.Text = "Baskı Seçenekleri";
            // 
            // bt_bilgi_defterbaskisecenek_1
            // 
            this.bt_bilgi_defterbaskisecenek_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_bilgi_defterbaskisecenek_1.Location = new System.Drawing.Point(266, 54);
            this.bt_bilgi_defterbaskisecenek_1.Name = "bt_bilgi_defterbaskisecenek_1";
            this.bt_bilgi_defterbaskisecenek_1.Size = new System.Drawing.Size(29, 24);
            this.bt_bilgi_defterbaskisecenek_1.TabIndex = 4;
            this.bt_bilgi_defterbaskisecenek_1.Text = "!";
            this.bt_bilgi_defterbaskisecenek_1.UseVisualStyleBackColor = true;
            this.bt_bilgi_defterbaskisecenek_1.Click += new System.EventHandler(this.bt_bilgi_defterbaskisecenek_1_Click);
            // 
            // rb_defterbas_secenek_kapakvedefter
            // 
            this.rb_defterbas_secenek_kapakvedefter.AutoSize = true;
            this.rb_defterbas_secenek_kapakvedefter.Location = new System.Drawing.Point(6, 79);
            this.rb_defterbas_secenek_kapakvedefter.Name = "rb_defterbas_secenek_kapakvedefter";
            this.rb_defterbas_secenek_kapakvedefter.Size = new System.Drawing.Size(160, 17);
            this.rb_defterbas_secenek_kapakvedefter.TabIndex = 2;
            this.rb_defterbas_secenek_kapakvedefter.Text = "KAPAK ve DEFTER art arda";
            this.rb_defterbas_secenek_kapakvedefter.UseVisualStyleBackColor = true;
            // 
            // rb_defterbas_secenek_defter
            // 
            this.rb_defterbas_secenek_defter.AutoSize = true;
            this.rb_defterbas_secenek_defter.Location = new System.Drawing.Point(6, 56);
            this.rb_defterbas_secenek_defter.Name = "rb_defterbas_secenek_defter";
            this.rb_defterbas_secenek_defter.Size = new System.Drawing.Size(108, 17);
            this.rb_defterbas_secenek_defter.TabIndex = 1;
            this.rb_defterbas_secenek_defter.Text = "Sadece DEFTER";
            this.rb_defterbas_secenek_defter.UseVisualStyleBackColor = true;
            // 
            // rb_defterbas_secenek_kapak
            // 
            this.rb_defterbas_secenek_kapak.AutoSize = true;
            this.rb_defterbas_secenek_kapak.Checked = true;
            this.rb_defterbas_secenek_kapak.Location = new System.Drawing.Point(6, 33);
            this.rb_defterbas_secenek_kapak.Name = "rb_defterbas_secenek_kapak";
            this.rb_defterbas_secenek_kapak.Size = new System.Drawing.Size(100, 17);
            this.rb_defterbas_secenek_kapak.TabIndex = 0;
            this.rb_defterbas_secenek_kapak.TabStop = true;
            this.rb_defterbas_secenek_kapak.Text = "Sadece KAPAK";
            this.rb_defterbas_secenek_kapak.UseVisualStyleBackColor = true;
            // 
            // groupBox36
            // 
            this.groupBox36.Controls.Add(this.bt_bilgi_defterbaskisecenek_2_teklitoplu);
            this.groupBox36.Controls.Add(this.rb_defterbas_tektoplu_toplu);
            this.groupBox36.Controls.Add(this.rb_defterbas_tektoplu_tek);
            this.groupBox36.Location = new System.Drawing.Point(22, 214);
            this.groupBox36.Name = "groupBox36";
            this.groupBox36.Size = new System.Drawing.Size(312, 85);
            this.groupBox36.TabIndex = 3;
            this.groupBox36.TabStop = false;
            this.groupBox36.Text = "Tek - Toplu Baskı";
            // 
            // bt_bilgi_defterbaskisecenek_2_teklitoplu
            // 
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.Location = new System.Drawing.Point(266, 38);
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.Name = "bt_bilgi_defterbaskisecenek_2_teklitoplu";
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.Size = new System.Drawing.Size(29, 24);
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.TabIndex = 3;
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.Text = "!";
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.UseVisualStyleBackColor = true;
            this.bt_bilgi_defterbaskisecenek_2_teklitoplu.Click += new System.EventHandler(this.bt_bilgi_defterbaskisecenek_2_teklitoplu_Click);
            // 
            // rb_defterbas_tektoplu_toplu
            // 
            this.rb_defterbas_tektoplu_toplu.AutoSize = true;
            this.rb_defterbas_tektoplu_toplu.Checked = true;
            this.rb_defterbas_tektoplu_toplu.Location = new System.Drawing.Point(6, 51);
            this.rb_defterbas_tektoplu_toplu.Name = "rb_defterbas_tektoplu_toplu";
            this.rb_defterbas_tektoplu_toplu.Size = new System.Drawing.Size(181, 17);
            this.rb_defterbas_tektoplu_toplu.TabIndex = 2;
            this.rb_defterbas_tektoplu_toplu.TabStop = true;
            this.rb_defterbas_tektoplu_toplu.Text = "Listede seçililerin hepsi tek dosya";
            this.rb_defterbas_tektoplu_toplu.UseVisualStyleBackColor = true;
            // 
            // rb_defterbas_tektoplu_tek
            // 
            this.rb_defterbas_tektoplu_tek.AutoSize = true;
            this.rb_defterbas_tektoplu_tek.Location = new System.Drawing.Point(6, 28);
            this.rb_defterbas_tektoplu_tek.Name = "rb_defterbas_tektoplu_tek";
            this.rb_defterbas_tektoplu_tek.Size = new System.Drawing.Size(117, 17);
            this.rb_defterbas_tektoplu_tek.TabIndex = 1;
            this.rb_defterbas_tektoplu_tek.Text = "Her kayıt ayrı dosya";
            this.rb_defterbas_tektoplu_tek.UseVisualStyleBackColor = true;
            // 
            // groupBox34
            // 
            this.groupBox34.Controls.Add(this.bt_defterbas_rb_secenekleri_bilgi);
            this.groupBox34.Controls.Add(this.rb_defter_bas_listedesecilikayitlaricinislemyap);
            this.groupBox34.Controls.Add(this.rb_defter_bas_ekrandakikayiticinislemyap);
            this.groupBox34.Location = new System.Drawing.Point(22, 24);
            this.groupBox34.Name = "groupBox34";
            this.groupBox34.Size = new System.Drawing.Size(312, 72);
            this.groupBox34.TabIndex = 0;
            this.groupBox34.TabStop = false;
            this.groupBox34.Text = "Tek Tek veya Listeden Basım Seçenekleri";
            // 
            // bt_defterbas_rb_secenekleri_bilgi
            // 
            this.bt_defterbas_rb_secenekleri_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_defterbas_rb_secenekleri_bilgi.Location = new System.Drawing.Point(266, 19);
            this.bt_defterbas_rb_secenekleri_bilgi.Name = "bt_defterbas_rb_secenekleri_bilgi";
            this.bt_defterbas_rb_secenekleri_bilgi.Size = new System.Drawing.Size(29, 24);
            this.bt_defterbas_rb_secenekleri_bilgi.TabIndex = 2;
            this.bt_defterbas_rb_secenekleri_bilgi.Text = "!";
            this.bt_defterbas_rb_secenekleri_bilgi.UseVisualStyleBackColor = true;
            this.bt_defterbas_rb_secenekleri_bilgi.Click += new System.EventHandler(this.bt_defterbas_rb_secenekleri_bilgi_Click);
            // 
            // rb_defter_bas_listedesecilikayitlaricinislemyap
            // 
            this.rb_defter_bas_listedesecilikayitlaricinislemyap.AutoSize = true;
            this.rb_defter_bas_listedesecilikayitlaricinislemyap.Location = new System.Drawing.Point(8, 44);
            this.rb_defter_bas_listedesecilikayitlaricinislemyap.Name = "rb_defter_bas_listedesecilikayitlaricinislemyap";
            this.rb_defter_bas_listedesecilikayitlaricinislemyap.Size = new System.Drawing.Size(264, 17);
            this.rb_defter_bas_listedesecilikayitlaricinislemyap.TabIndex = 1;
            this.rb_defter_bas_listedesecilikayitlaricinislemyap.Text = "Arama Listesinde Seçili Olan Kayıtlar İçin İşlem Yap";
            this.rb_defter_bas_listedesecilikayitlaricinislemyap.UseVisualStyleBackColor = true;
            // 
            // rb_defter_bas_ekrandakikayiticinislemyap
            // 
            this.rb_defter_bas_ekrandakikayiticinislemyap.AutoSize = true;
            this.rb_defter_bas_ekrandakikayiticinislemyap.Checked = true;
            this.rb_defter_bas_ekrandakikayiticinislemyap.Location = new System.Drawing.Point(8, 21);
            this.rb_defter_bas_ekrandakikayiticinislemyap.Name = "rb_defter_bas_ekrandakikayiticinislemyap";
            this.rb_defter_bas_ekrandakikayiticinislemyap.Size = new System.Drawing.Size(168, 17);
            this.rb_defter_bas_ekrandakikayiticinislemyap.TabIndex = 0;
            this.rb_defter_bas_ekrandakikayiticinislemyap.TabStop = true;
            this.rb_defter_bas_ekrandakikayiticinislemyap.Text = "Ekrandaki Kayıt İçin İşlem Yap";
            this.rb_defter_bas_ekrandakikayiticinislemyap.UseVisualStyleBackColor = true;
            // 
            // tab_muhasebe
            // 
            this.tab_muhasebe.Controls.Add(this.groupBox17);
            this.tab_muhasebe.Controls.Add(this.groupBox16);
            this.tab_muhasebe.Controls.Add(this.groupBox15);
            this.tab_muhasebe.Controls.Add(this.groupBox14);
            this.tab_muhasebe.Location = new System.Drawing.Point(4, 22);
            this.tab_muhasebe.Name = "tab_muhasebe";
            this.tab_muhasebe.Padding = new System.Windows.Forms.Padding(3);
            this.tab_muhasebe.Size = new System.Drawing.Size(1360, 544);
            this.tab_muhasebe.TabIndex = 5;
            this.tab_muhasebe.Text = "Muhasebe";
            this.tab_muhasebe.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.btn_muhasebe_miktar_uyari_bilgi);
            this.groupBox17.Controls.Add(this.linklbl_muhasebe_odemeal_odeme_kaydet);
            this.groupBox17.Controls.Add(this.cb_muhasebe_odemeal_odeme_turu);
            this.groupBox17.Controls.Add(this.tb_muhasebe_odemeal_aciklama);
            this.groupBox17.Controls.Add(this.label42);
            this.groupBox17.Controls.Add(this.tb_muhasebe_odemeal_odeme_tarihi);
            this.groupBox17.Controls.Add(this.label39);
            this.groupBox17.Controls.Add(this.label40);
            this.groupBox17.Controls.Add(this.tb_muhasebe_odemeal_odenen_miktar);
            this.groupBox17.Controls.Add(this.label41);
            this.groupBox17.Location = new System.Drawing.Point(16, 229);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(314, 272);
            this.groupBox17.TabIndex = 3;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Ödeme Al";
            // 
            // btn_muhasebe_miktar_uyari_bilgi
            // 
            this.btn_muhasebe_miktar_uyari_bilgi.Location = new System.Drawing.Point(282, 19);
            this.btn_muhasebe_miktar_uyari_bilgi.Name = "btn_muhasebe_miktar_uyari_bilgi";
            this.btn_muhasebe_miktar_uyari_bilgi.Size = new System.Drawing.Size(26, 26);
            this.btn_muhasebe_miktar_uyari_bilgi.TabIndex = 9;
            this.btn_muhasebe_miktar_uyari_bilgi.Text = "!";
            this.btn_muhasebe_miktar_uyari_bilgi.UseVisualStyleBackColor = true;
            this.btn_muhasebe_miktar_uyari_bilgi.Click += new System.EventHandler(this.btn_muhasebe_miktar_uyari_bilgi_Click);
            // 
            // linklbl_muhasebe_odemeal_odeme_kaydet
            // 
            this.linklbl_muhasebe_odemeal_odeme_kaydet.AutoSize = true;
            this.linklbl_muhasebe_odemeal_odeme_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_muhasebe_odemeal_odeme_kaydet.Location = new System.Drawing.Point(129, 221);
            this.linklbl_muhasebe_odemeal_odeme_kaydet.Name = "linklbl_muhasebe_odemeal_odeme_kaydet";
            this.linklbl_muhasebe_odemeal_odeme_kaydet.Size = new System.Drawing.Size(160, 24);
            this.linklbl_muhasebe_odemeal_odeme_kaydet.TabIndex = 8;
            this.linklbl_muhasebe_odemeal_odeme_kaydet.TabStop = true;
            this.linklbl_muhasebe_odemeal_odeme_kaydet.Text = "ÖDEME KAYDET";
            this.linklbl_muhasebe_odemeal_odeme_kaydet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_muhasebe_odemeal_odeme_kaydet_LinkClicked);
            // 
            // cb_muhasebe_odemeal_odeme_turu
            // 
            this.cb_muhasebe_odemeal_odeme_turu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_muhasebe_odemeal_odeme_turu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_muhasebe_odemeal_odeme_turu.FormattingEnabled = true;
            this.cb_muhasebe_odemeal_odeme_turu.Location = new System.Drawing.Point(102, 56);
            this.cb_muhasebe_odemeal_odeme_turu.Name = "cb_muhasebe_odemeal_odeme_turu";
            this.cb_muhasebe_odemeal_odeme_turu.Size = new System.Drawing.Size(206, 33);
            this.cb_muhasebe_odemeal_odeme_turu.TabIndex = 4;
            // 
            // tb_muhasebe_odemeal_aciklama
            // 
            this.tb_muhasebe_odemeal_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_muhasebe_odemeal_aciklama.Location = new System.Drawing.Point(102, 145);
            this.tb_muhasebe_odemeal_aciklama.Multiline = true;
            this.tb_muhasebe_odemeal_aciklama.Name = "tb_muhasebe_odemeal_aciklama";
            this.tb_muhasebe_odemeal_aciklama.Size = new System.Drawing.Size(206, 51);
            this.tb_muhasebe_odemeal_aciklama.TabIndex = 7;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(16, 157);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(50, 13);
            this.label42.TabIndex = 6;
            this.label42.Text = "Açıklama";
            // 
            // tb_muhasebe_odemeal_odeme_tarihi
            // 
            this.tb_muhasebe_odemeal_odeme_tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_muhasebe_odemeal_odeme_tarihi.Location = new System.Drawing.Point(102, 101);
            this.tb_muhasebe_odemeal_odeme_tarihi.Name = "tb_muhasebe_odemeal_odeme_tarihi";
            this.tb_muhasebe_odemeal_odeme_tarihi.Size = new System.Drawing.Size(206, 32);
            this.tb_muhasebe_odemeal_odeme_tarihi.TabIndex = 5;
            this.tb_muhasebe_odemeal_odeme_tarihi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_muhasebe_odemeal_odeme_tarihi_MouseDoubleClick);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(16, 113);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(31, 13);
            this.label39.TabIndex = 4;
            this.label39.Text = "Tarih";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 67);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(66, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "Ödeme Türü";
            // 
            // tb_muhasebe_odemeal_odenen_miktar
            // 
            this.tb_muhasebe_odemeal_odenen_miktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_muhasebe_odemeal_odenen_miktar.Location = new System.Drawing.Point(102, 13);
            this.tb_muhasebe_odemeal_odenen_miktar.Name = "tb_muhasebe_odemeal_odenen_miktar";
            this.tb_muhasebe_odemeal_odenen_miktar.Size = new System.Drawing.Size(173, 32);
            this.tb_muhasebe_odemeal_odenen_miktar.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(16, 25);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(77, 13);
            this.label41.TabIndex = 0;
            this.label41.Text = "Ödenen Miktar";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.dgv_muhasebe_odemeler);
            this.groupBox16.Location = new System.Drawing.Point(336, 229);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(488, 272);
            this.groupBox16.TabIndex = 2;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Ödemeler";
            // 
            // dgv_muhasebe_odemeler
            // 
            this.dgv_muhasebe_odemeler.AllowUserToAddRows = false;
            this.dgv_muhasebe_odemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muhasebe_odemeler.Location = new System.Drawing.Point(13, 17);
            this.dgv_muhasebe_odemeler.Name = "dgv_muhasebe_odemeler";
            this.dgv_muhasebe_odemeler.Size = new System.Drawing.Size(469, 249);
            this.dgv_muhasebe_odemeler.TabIndex = 0;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.dgv_muhasebe_borclanmalar);
            this.groupBox15.Location = new System.Drawing.Point(842, 229);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(488, 272);
            this.groupBox15.TabIndex = 1;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Borçlanmalar";
            // 
            // dgv_muhasebe_borclanmalar
            // 
            this.dgv_muhasebe_borclanmalar.AllowUserToAddRows = false;
            this.dgv_muhasebe_borclanmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muhasebe_borclanmalar.Location = new System.Drawing.Point(13, 17);
            this.dgv_muhasebe_borclanmalar.Name = "dgv_muhasebe_borclanmalar";
            this.dgv_muhasebe_borclanmalar.Size = new System.Drawing.Size(469, 249);
            this.dgv_muhasebe_borclanmalar.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.tb_muhasebe_toplam_bakiye);
            this.groupBox14.Controls.Add(this.label38);
            this.groupBox14.Controls.Add(this.tb_muhasebe_toplam_odeme);
            this.groupBox14.Controls.Add(this.label37);
            this.groupBox14.Controls.Add(this.tb_muhasebe_toplam_borc);
            this.groupBox14.Controls.Add(this.label36);
            this.groupBox14.Location = new System.Drawing.Point(16, 13);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(275, 159);
            this.groupBox14.TabIndex = 0;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Genel Durum";
            // 
            // tb_muhasebe_toplam_bakiye
            // 
            this.tb_muhasebe_toplam_bakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_muhasebe_toplam_bakiye.Location = new System.Drawing.Point(102, 101);
            this.tb_muhasebe_toplam_bakiye.Name = "tb_muhasebe_toplam_bakiye";
            this.tb_muhasebe_toplam_bakiye.Size = new System.Drawing.Size(153, 32);
            this.tb_muhasebe_toplam_bakiye.TabIndex = 5;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(16, 113);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(39, 13);
            this.label38.TabIndex = 4;
            this.label38.Text = "Bakiye";
            // 
            // tb_muhasebe_toplam_odeme
            // 
            this.tb_muhasebe_toplam_odeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_muhasebe_toplam_odeme.Location = new System.Drawing.Point(102, 55);
            this.tb_muhasebe_toplam_odeme.Name = "tb_muhasebe_toplam_odeme";
            this.tb_muhasebe_toplam_odeme.Size = new System.Drawing.Size(153, 32);
            this.tb_muhasebe_toplam_odeme.TabIndex = 3;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(16, 67);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(79, 13);
            this.label37.TabIndex = 2;
            this.label37.Text = "Toplam Ödeme";
            // 
            // tb_muhasebe_toplam_borc
            // 
            this.tb_muhasebe_toplam_borc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_muhasebe_toplam_borc.Location = new System.Drawing.Point(102, 13);
            this.tb_muhasebe_toplam_borc.Name = "tb_muhasebe_toplam_borc";
            this.tb_muhasebe_toplam_borc.Size = new System.Drawing.Size(153, 32);
            this.tb_muhasebe_toplam_borc.TabIndex = 1;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(16, 25);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(67, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "Toplam Borç";
            // 
            // tab_digerislemler
            // 
            this.tab_digerislemler.Controls.Add(this.groupBox41);
            this.tab_digerislemler.Controls.Add(this.groupBox40);
            this.tab_digerislemler.Controls.Add(this.groupBox19);
            this.tab_digerislemler.Controls.Add(this.groupBox13);
            this.tab_digerislemler.Controls.Add(this.label22);
            this.tab_digerislemler.Controls.Add(this.groupBox10);
            this.tab_digerislemler.Location = new System.Drawing.Point(4, 22);
            this.tab_digerislemler.Name = "tab_digerislemler";
            this.tab_digerislemler.Padding = new System.Windows.Forms.Padding(3);
            this.tab_digerislemler.Size = new System.Drawing.Size(1360, 544);
            this.tab_digerislemler.TabIndex = 4;
            this.tab_digerislemler.Text = "Diğer İşlemler";
            this.tab_digerislemler.UseVisualStyleBackColor = true;
            // 
            // groupBox41
            // 
            this.groupBox41.Controls.Add(this.tb_varsayilan_defterkapakyolu);
            this.groupBox41.Controls.Add(this.bt_varsayilan_degistir_defterkapakyolu);
            this.groupBox41.Controls.Add(this.bt_varsayilan_kayit_konumu_pdf_degistir);
            this.groupBox41.Controls.Add(this.label58);
            this.groupBox41.Controls.Add(this.tb_varsayilan_defteryolu);
            this.groupBox41.Controls.Add(this.tb_varsayilan_kayit_konumu_pdf);
            this.groupBox41.Controls.Add(this.label52);
            this.groupBox41.Controls.Add(this.bt_varsayilan_degistir_defteryolu);
            this.groupBox41.Controls.Add(this.label60);
            this.groupBox41.Location = new System.Drawing.Point(623, 282);
            this.groupBox41.Name = "groupBox41";
            this.groupBox41.Size = new System.Drawing.Size(339, 202);
            this.groupBox41.TabIndex = 14;
            this.groupBox41.TabStop = false;
            this.groupBox41.Text = "Defterlerin Konumları";
            // 
            // tb_varsayilan_defterkapakyolu
            // 
            this.tb_varsayilan_defterkapakyolu.Enabled = false;
            this.tb_varsayilan_defterkapakyolu.Location = new System.Drawing.Point(69, 75);
            this.tb_varsayilan_defterkapakyolu.Multiline = true;
            this.tb_varsayilan_defterkapakyolu.Name = "tb_varsayilan_defterkapakyolu";
            this.tb_varsayilan_defterkapakyolu.Size = new System.Drawing.Size(214, 50);
            this.tb_varsayilan_defterkapakyolu.TabIndex = 17;
            // 
            // bt_varsayilan_degistir_defterkapakyolu
            // 
            this.bt_varsayilan_degistir_defterkapakyolu.Location = new System.Drawing.Point(289, 86);
            this.bt_varsayilan_degistir_defterkapakyolu.Name = "bt_varsayilan_degistir_defterkapakyolu";
            this.bt_varsayilan_degistir_defterkapakyolu.Size = new System.Drawing.Size(34, 39);
            this.bt_varsayilan_degistir_defterkapakyolu.TabIndex = 18;
            this.bt_varsayilan_degistir_defterkapakyolu.Text = "Seç";
            this.bt_varsayilan_degistir_defterkapakyolu.UseVisualStyleBackColor = true;
            this.bt_varsayilan_degistir_defterkapakyolu.Click += new System.EventHandler(this.bt_varsayilan_degistir_defterkapakyolu_Click);
            // 
            // bt_varsayilan_kayit_konumu_pdf_degistir
            // 
            this.bt_varsayilan_kayit_konumu_pdf_degistir.Location = new System.Drawing.Point(289, 142);
            this.bt_varsayilan_kayit_konumu_pdf_degistir.Name = "bt_varsayilan_kayit_konumu_pdf_degistir";
            this.bt_varsayilan_kayit_konumu_pdf_degistir.Size = new System.Drawing.Size(34, 39);
            this.bt_varsayilan_kayit_konumu_pdf_degistir.TabIndex = 8;
            this.bt_varsayilan_kayit_konumu_pdf_degistir.Text = "Seç";
            this.bt_varsayilan_kayit_konumu_pdf_degistir.UseVisualStyleBackColor = true;
            this.bt_varsayilan_kayit_konumu_pdf_degistir.Click += new System.EventHandler(this.bt_varsayilan_kayit_konumu_pdf_degistir_Click);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(8, 89);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(51, 26);
            this.label58.TabIndex = 16;
            this.label58.Text = "Defter\r\nKapakları";
            // 
            // tb_varsayilan_defteryolu
            // 
            this.tb_varsayilan_defteryolu.Enabled = false;
            this.tb_varsayilan_defteryolu.Location = new System.Drawing.Point(69, 19);
            this.tb_varsayilan_defteryolu.Multiline = true;
            this.tb_varsayilan_defteryolu.Name = "tb_varsayilan_defteryolu";
            this.tb_varsayilan_defteryolu.Size = new System.Drawing.Size(214, 50);
            this.tb_varsayilan_defteryolu.TabIndex = 11;
            // 
            // tb_varsayilan_kayit_konumu_pdf
            // 
            this.tb_varsayilan_kayit_konumu_pdf.Enabled = false;
            this.tb_varsayilan_kayit_konumu_pdf.Location = new System.Drawing.Point(69, 131);
            this.tb_varsayilan_kayit_konumu_pdf.Multiline = true;
            this.tb_varsayilan_kayit_konumu_pdf.Name = "tb_varsayilan_kayit_konumu_pdf";
            this.tb_varsayilan_kayit_konumu_pdf.Size = new System.Drawing.Size(214, 50);
            this.tb_varsayilan_kayit_konumu_pdf.TabIndex = 7;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(8, 142);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(63, 39);
            this.label52.TabIndex = 6;
            this.label52.Text = "Defter\r\nBasım Sonu\r\nPDF Yolu";
            // 
            // bt_varsayilan_degistir_defteryolu
            // 
            this.bt_varsayilan_degistir_defteryolu.Location = new System.Drawing.Point(289, 30);
            this.bt_varsayilan_degistir_defteryolu.Name = "bt_varsayilan_degistir_defteryolu";
            this.bt_varsayilan_degistir_defteryolu.Size = new System.Drawing.Size(34, 39);
            this.bt_varsayilan_degistir_defteryolu.TabIndex = 12;
            this.bt_varsayilan_degistir_defteryolu.Text = "Seç";
            this.bt_varsayilan_degistir_defteryolu.UseVisualStyleBackColor = true;
            this.bt_varsayilan_degistir_defteryolu.Click += new System.EventHandler(this.bt_varsayilan_degistir_defteryolu_Click);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 33);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(47, 13);
            this.label60.TabIndex = 10;
            this.label60.Text = "Defterler";
            // 
            // groupBox40
            // 
            this.groupBox40.Controls.Add(this.tb_varsayilan_kayit_planyolu_pdf);
            this.groupBox40.Controls.Add(this.bt_varsayilan_degistir_basimsonu_planpdfyolu);
            this.groupBox40.Controls.Add(this.label56);
            this.groupBox40.Controls.Add(this.tb_varsayilan_plankapakyolu);
            this.groupBox40.Controls.Add(this.bt_varsayilan_degistir_plankapakyolu);
            this.groupBox40.Controls.Add(this.label55);
            this.groupBox40.Controls.Add(this.tb_varsayilan_gunlukplanyolu);
            this.groupBox40.Controls.Add(this.bt_varsayilan_degistir_gunlukplanyolu);
            this.groupBox40.Controls.Add(this.label54);
            this.groupBox40.Controls.Add(this.tb_varsayilan_yillikplanyolu);
            this.groupBox40.Controls.Add(this.bt_varsayilan_degistir_yillikplanyolu);
            this.groupBox40.Controls.Add(this.label53);
            this.groupBox40.Location = new System.Drawing.Point(623, 19);
            this.groupBox40.Name = "groupBox40";
            this.groupBox40.Size = new System.Drawing.Size(339, 247);
            this.groupBox40.TabIndex = 13;
            this.groupBox40.TabStop = false;
            this.groupBox40.Text = "Planların Konumları";
            // 
            // tb_varsayilan_kayit_planyolu_pdf
            // 
            this.tb_varsayilan_kayit_planyolu_pdf.Enabled = false;
            this.tb_varsayilan_kayit_planyolu_pdf.Location = new System.Drawing.Point(69, 187);
            this.tb_varsayilan_kayit_planyolu_pdf.Multiline = true;
            this.tb_varsayilan_kayit_planyolu_pdf.Name = "tb_varsayilan_kayit_planyolu_pdf";
            this.tb_varsayilan_kayit_planyolu_pdf.Size = new System.Drawing.Size(214, 50);
            this.tb_varsayilan_kayit_planyolu_pdf.TabIndex = 20;
            // 
            // bt_varsayilan_degistir_basimsonu_planpdfyolu
            // 
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu.Location = new System.Drawing.Point(289, 198);
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu.Name = "bt_varsayilan_degistir_basimsonu_planpdfyolu";
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu.Size = new System.Drawing.Size(34, 39);
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu.TabIndex = 21;
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu.Text = "Seç";
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu.UseVisualStyleBackColor = true;
            this.bt_varsayilan_degistir_basimsonu_planpdfyolu.Click += new System.EventHandler(this.bt_varsayilan_degistir_basimsonu_planpdfyolu_Click);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 198);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(63, 39);
            this.label56.TabIndex = 19;
            this.label56.Text = "Plan\r\nBasım Sonu\r\nPDF Yolu";
            // 
            // tb_varsayilan_plankapakyolu
            // 
            this.tb_varsayilan_plankapakyolu.Enabled = false;
            this.tb_varsayilan_plankapakyolu.Location = new System.Drawing.Point(69, 131);
            this.tb_varsayilan_plankapakyolu.Multiline = true;
            this.tb_varsayilan_plankapakyolu.Name = "tb_varsayilan_plankapakyolu";
            this.tb_varsayilan_plankapakyolu.Size = new System.Drawing.Size(214, 50);
            this.tb_varsayilan_plankapakyolu.TabIndex = 17;
            // 
            // bt_varsayilan_degistir_plankapakyolu
            // 
            this.bt_varsayilan_degistir_plankapakyolu.Location = new System.Drawing.Point(289, 142);
            this.bt_varsayilan_degistir_plankapakyolu.Name = "bt_varsayilan_degistir_plankapakyolu";
            this.bt_varsayilan_degistir_plankapakyolu.Size = new System.Drawing.Size(34, 39);
            this.bt_varsayilan_degistir_plankapakyolu.TabIndex = 18;
            this.bt_varsayilan_degistir_plankapakyolu.Text = "Seç";
            this.bt_varsayilan_degistir_plankapakyolu.UseVisualStyleBackColor = true;
            this.bt_varsayilan_degistir_plankapakyolu.Click += new System.EventHandler(this.bt_varsayilan_degistir_plankapakyolu_Click);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(8, 145);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(51, 26);
            this.label55.TabIndex = 16;
            this.label55.Text = "Plan\r\nKapakları";
            // 
            // tb_varsayilan_gunlukplanyolu
            // 
            this.tb_varsayilan_gunlukplanyolu.Enabled = false;
            this.tb_varsayilan_gunlukplanyolu.Location = new System.Drawing.Point(69, 75);
            this.tb_varsayilan_gunlukplanyolu.Multiline = true;
            this.tb_varsayilan_gunlukplanyolu.Name = "tb_varsayilan_gunlukplanyolu";
            this.tb_varsayilan_gunlukplanyolu.Size = new System.Drawing.Size(214, 50);
            this.tb_varsayilan_gunlukplanyolu.TabIndex = 14;
            // 
            // bt_varsayilan_degistir_gunlukplanyolu
            // 
            this.bt_varsayilan_degistir_gunlukplanyolu.Location = new System.Drawing.Point(289, 86);
            this.bt_varsayilan_degistir_gunlukplanyolu.Name = "bt_varsayilan_degistir_gunlukplanyolu";
            this.bt_varsayilan_degistir_gunlukplanyolu.Size = new System.Drawing.Size(34, 39);
            this.bt_varsayilan_degistir_gunlukplanyolu.TabIndex = 15;
            this.bt_varsayilan_degistir_gunlukplanyolu.Text = "Seç";
            this.bt_varsayilan_degistir_gunlukplanyolu.UseVisualStyleBackColor = true;
            this.bt_varsayilan_degistir_gunlukplanyolu.Click += new System.EventHandler(this.bt_varsayilan_degistir_gunlukplanyolu_Click);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(8, 89);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(41, 26);
            this.label54.TabIndex = 13;
            this.label54.Text = "Günlük\r\nPlanlar";
            // 
            // tb_varsayilan_yillikplanyolu
            // 
            this.tb_varsayilan_yillikplanyolu.Enabled = false;
            this.tb_varsayilan_yillikplanyolu.Location = new System.Drawing.Point(69, 19);
            this.tb_varsayilan_yillikplanyolu.Multiline = true;
            this.tb_varsayilan_yillikplanyolu.Name = "tb_varsayilan_yillikplanyolu";
            this.tb_varsayilan_yillikplanyolu.Size = new System.Drawing.Size(214, 50);
            this.tb_varsayilan_yillikplanyolu.TabIndex = 11;
            // 
            // bt_varsayilan_degistir_yillikplanyolu
            // 
            this.bt_varsayilan_degistir_yillikplanyolu.Location = new System.Drawing.Point(289, 30);
            this.bt_varsayilan_degistir_yillikplanyolu.Name = "bt_varsayilan_degistir_yillikplanyolu";
            this.bt_varsayilan_degistir_yillikplanyolu.Size = new System.Drawing.Size(34, 39);
            this.bt_varsayilan_degistir_yillikplanyolu.TabIndex = 12;
            this.bt_varsayilan_degistir_yillikplanyolu.Text = "Seç";
            this.bt_varsayilan_degistir_yillikplanyolu.UseVisualStyleBackColor = true;
            this.bt_varsayilan_degistir_yillikplanyolu.Click += new System.EventHandler(this.bt_varsayilan_degistir_yillikplanyolu_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(8, 33);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(39, 26);
            this.label53.TabIndex = 10;
            this.label53.Text = "Yıllık\r\nPlanlar";
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label47);
            this.groupBox19.Controls.Add(this.tb_sil_sifre);
            this.groupBox19.Controls.Add(this.bt_sil_seciliveriler);
            this.groupBox19.Controls.Add(this.cb_sil_bilgidisinda_hersey);
            this.groupBox19.Controls.Add(this.cb_sil_odemeler);
            this.groupBox19.Controls.Add(this.cb_sil_cdpdf);
            this.groupBox19.Controls.Add(this.cb_sil_kuluptalebi);
            this.groupBox19.Controls.Add(this.cb_sil_ogrencilistesi);
            this.groupBox19.Controls.Add(this.cb_sil_zumreler);
            this.groupBox19.Controls.Add(this.cb_sil_defterler);
            this.groupBox19.Controls.Add(this.cb_sil_serbestetkinlikler);
            this.groupBox19.Controls.Add(this.cb_sil_gunlukplanlar);
            this.groupBox19.Controls.Add(this.cb_sil_yillikplanlar);
            this.groupBox19.Controls.Add(this.cb_sil_hersey);
            this.groupBox19.Controls.Add(this.label46);
            this.groupBox19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox19.Location = new System.Drawing.Point(968, 9);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(377, 520);
            this.groupBox19.TabIndex = 9;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Veri Silme";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(211, 458);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(31, 13);
            this.label47.TabIndex = 14;
            this.label47.Text = "Şifre:";
            // 
            // tb_sil_sifre
            // 
            this.tb_sil_sifre.Location = new System.Drawing.Point(258, 455);
            this.tb_sil_sifre.Name = "tb_sil_sifre";
            this.tb_sil_sifre.Size = new System.Drawing.Size(100, 20);
            this.tb_sil_sifre.TabIndex = 13;
            this.tb_sil_sifre.UseSystemPasswordChar = true;
            // 
            // bt_sil_seciliveriler
            // 
            this.bt_sil_seciliveriler.BackColor = System.Drawing.Color.Red;
            this.bt_sil_seciliveriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt_sil_seciliveriler.ForeColor = System.Drawing.Color.White;
            this.bt_sil_seciliveriler.Location = new System.Drawing.Point(195, 477);
            this.bt_sil_seciliveriler.Name = "bt_sil_seciliveriler";
            this.bt_sil_seciliveriler.Size = new System.Drawing.Size(176, 37);
            this.bt_sil_seciliveriler.TabIndex = 12;
            this.bt_sil_seciliveriler.Text = "Seçili Bilgileri Sil";
            this.bt_sil_seciliveriler.UseVisualStyleBackColor = false;
            this.bt_sil_seciliveriler.Click += new System.EventHandler(this.bt_sil_seciliveriler_Click);
            // 
            // cb_sil_bilgidisinda_hersey
            // 
            this.cb_sil_bilgidisinda_hersey.AutoSize = true;
            this.cb_sil_bilgidisinda_hersey.Location = new System.Drawing.Point(22, 97);
            this.cb_sil_bilgidisinda_hersey.Name = "cb_sil_bilgidisinda_hersey";
            this.cb_sil_bilgidisinda_hersey.Size = new System.Drawing.Size(210, 17);
            this.cb_sil_bilgidisinda_hersey.TabIndex = 11;
            this.cb_sil_bilgidisinda_hersey.Text = "Öğretmen Bilgileri Dışındaki Her Şeyi Sil";
            this.cb_sil_bilgidisinda_hersey.UseVisualStyleBackColor = true;
            // 
            // cb_sil_odemeler
            // 
            this.cb_sil_odemeler.AutoSize = true;
            this.cb_sil_odemeler.Location = new System.Drawing.Point(22, 303);
            this.cb_sil_odemeler.Name = "cb_sil_odemeler";
            this.cb_sil_odemeler.Size = new System.Drawing.Size(99, 17);
            this.cb_sil_odemeler.TabIndex = 10;
            this.cb_sil_odemeler.Text = "Ödeme Kayıtları";
            this.cb_sil_odemeler.UseVisualStyleBackColor = true;
            // 
            // cb_sil_cdpdf
            // 
            this.cb_sil_cdpdf.AutoSize = true;
            this.cb_sil_cdpdf.Location = new System.Drawing.Point(22, 280);
            this.cb_sil_cdpdf.Name = "cb_sil_cdpdf";
            this.cb_sil_cdpdf.Size = new System.Drawing.Size(112, 17);
            this.cb_sil_cdpdf.TabIndex = 9;
            this.cb_sil_cdpdf.Text = "CD ve PDF Talebi";
            this.cb_sil_cdpdf.UseVisualStyleBackColor = true;
            // 
            // cb_sil_kuluptalebi
            // 
            this.cb_sil_kuluptalebi.AutoSize = true;
            this.cb_sil_kuluptalebi.Location = new System.Drawing.Point(22, 257);
            this.cb_sil_kuluptalebi.Name = "cb_sil_kuluptalebi";
            this.cb_sil_kuluptalebi.Size = new System.Drawing.Size(85, 17);
            this.cb_sil_kuluptalebi.TabIndex = 8;
            this.cb_sil_kuluptalebi.Text = "Kulüp Talebi";
            this.cb_sil_kuluptalebi.UseVisualStyleBackColor = true;
            // 
            // cb_sil_ogrencilistesi
            // 
            this.cb_sil_ogrencilistesi.AutoSize = true;
            this.cb_sil_ogrencilistesi.Location = new System.Drawing.Point(22, 234);
            this.cb_sil_ogrencilistesi.Name = "cb_sil_ogrencilistesi";
            this.cb_sil_ogrencilistesi.Size = new System.Drawing.Size(95, 17);
            this.cb_sil_ogrencilistesi.TabIndex = 7;
            this.cb_sil_ogrencilistesi.Text = "Öğrenci Listesi";
            this.cb_sil_ogrencilistesi.UseVisualStyleBackColor = true;
            // 
            // cb_sil_zumreler
            // 
            this.cb_sil_zumreler.AutoSize = true;
            this.cb_sil_zumreler.Location = new System.Drawing.Point(22, 211);
            this.cb_sil_zumreler.Name = "cb_sil_zumreler";
            this.cb_sil_zumreler.Size = new System.Drawing.Size(142, 17);
            this.cb_sil_zumreler.TabIndex = 6;
            this.cb_sil_zumreler.Text = "Zümre Öğretmeni Bilgileri";
            this.cb_sil_zumreler.UseVisualStyleBackColor = true;
            // 
            // cb_sil_defterler
            // 
            this.cb_sil_defterler.AutoSize = true;
            this.cb_sil_defterler.Location = new System.Drawing.Point(22, 188);
            this.cb_sil_defterler.Name = "cb_sil_defterler";
            this.cb_sil_defterler.Size = new System.Drawing.Size(98, 17);
            this.cb_sil_defterler.TabIndex = 5;
            this.cb_sil_defterler.Text = "Defter Talepleri";
            this.cb_sil_defterler.UseVisualStyleBackColor = true;
            // 
            // cb_sil_serbestetkinlikler
            // 
            this.cb_sil_serbestetkinlikler.AutoSize = true;
            this.cb_sil_serbestetkinlikler.Location = new System.Drawing.Point(22, 165);
            this.cb_sil_serbestetkinlikler.Name = "cb_sil_serbestetkinlikler";
            this.cb_sil_serbestetkinlikler.Size = new System.Drawing.Size(142, 17);
            this.cb_sil_serbestetkinlikler.TabIndex = 4;
            this.cb_sil_serbestetkinlikler.Text = "Serbest Etkinlik Talepleri";
            this.cb_sil_serbestetkinlikler.UseVisualStyleBackColor = true;
            // 
            // cb_sil_gunlukplanlar
            // 
            this.cb_sil_gunlukplanlar.AutoSize = true;
            this.cb_sil_gunlukplanlar.Location = new System.Drawing.Point(22, 143);
            this.cb_sil_gunlukplanlar.Name = "cb_sil_gunlukplanlar";
            this.cb_sil_gunlukplanlar.Size = new System.Drawing.Size(127, 17);
            this.cb_sil_gunlukplanlar.TabIndex = 3;
            this.cb_sil_gunlukplanlar.Text = "Günlük Plan Talepleri";
            this.cb_sil_gunlukplanlar.UseVisualStyleBackColor = true;
            // 
            // cb_sil_yillikplanlar
            // 
            this.cb_sil_yillikplanlar.AutoSize = true;
            this.cb_sil_yillikplanlar.Location = new System.Drawing.Point(22, 120);
            this.cb_sil_yillikplanlar.Name = "cb_sil_yillikplanlar";
            this.cb_sil_yillikplanlar.Size = new System.Drawing.Size(114, 17);
            this.cb_sil_yillikplanlar.TabIndex = 2;
            this.cb_sil_yillikplanlar.Text = "Yıllık Plan Talepleri";
            this.cb_sil_yillikplanlar.UseVisualStyleBackColor = true;
            // 
            // cb_sil_hersey
            // 
            this.cb_sil_hersey.AutoSize = true;
            this.cb_sil_hersey.Location = new System.Drawing.Point(22, 74);
            this.cb_sil_hersey.Name = "cb_sil_hersey";
            this.cb_sil_hersey.Size = new System.Drawing.Size(272, 17);
            this.cb_sil_hersey.TabIndex = 1;
            this.cb_sil_hersey.Text = "Öğretmen Bilgilerini Tamamen Sil (Talep, Ödeme vs.)";
            this.cb_sil_hersey.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ForeColor = System.Drawing.Color.Red;
            this.label46.Location = new System.Drawing.Point(12, 32);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(289, 13);
            this.label46.TabIndex = 0;
            this.label46.Text = "Ekrandaki Öğretmene Ait Kayıtları Sil (Müşteri No Esas Alınır)";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.lbl_ogrencilistesikaydedildi);
            this.groupBox13.Controls.Add(this.btn_bilgi_ogrencilistesi);
            this.groupBox13.Controls.Add(this.linklbl_ogrencilistesikaydet);
            this.groupBox13.Controls.Add(this.tb_ogrencilistesi_multiline);
            this.groupBox13.Controls.Add(this.label35);
            this.groupBox13.Location = new System.Drawing.Point(298, 11);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(315, 528);
            this.groupBox13.TabIndex = 8;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Öğreci Listesi (Yoklama, Okuma Defteri vb için)";
            // 
            // lbl_ogrencilistesikaydedildi
            // 
            this.lbl_ogrencilistesikaydedildi.AutoSize = true;
            this.lbl_ogrencilistesikaydedildi.Location = new System.Drawing.Point(64, 506);
            this.lbl_ogrencilistesikaydedildi.Name = "lbl_ogrencilistesikaydedildi";
            this.lbl_ogrencilistesikaydedildi.Size = new System.Drawing.Size(16, 13);
            this.lbl_ogrencilistesikaydedildi.TabIndex = 56;
            this.lbl_ogrencilistesikaydedildi.Text = "...";
            // 
            // btn_bilgi_ogrencilistesi
            // 
            this.btn_bilgi_ogrencilistesi.Location = new System.Drawing.Point(9, 500);
            this.btn_bilgi_ogrencilistesi.Name = "btn_bilgi_ogrencilistesi";
            this.btn_bilgi_ogrencilistesi.Size = new System.Drawing.Size(22, 19);
            this.btn_bilgi_ogrencilistesi.TabIndex = 55;
            this.btn_bilgi_ogrencilistesi.Text = "!";
            this.btn_bilgi_ogrencilistesi.UseVisualStyleBackColor = true;
            this.btn_bilgi_ogrencilistesi.Click += new System.EventHandler(this.btn_bilgi_ogrencilistesi_Click);
            // 
            // linklbl_ogrencilistesikaydet
            // 
            this.linklbl_ogrencilistesikaydet.AutoSize = true;
            this.linklbl_ogrencilistesikaydet.Location = new System.Drawing.Point(157, 503);
            this.linklbl_ogrencilistesikaydet.Name = "linklbl_ogrencilistesikaydet";
            this.linklbl_ogrencilistesikaydet.Size = new System.Drawing.Size(144, 13);
            this.linklbl_ogrencilistesikaydet.TabIndex = 54;
            this.linklbl_ogrencilistesikaydet.TabStop = true;
            this.linklbl_ogrencilistesikaydet.Text = "BU MÜŞTERİ İÇİN KAYDET";
            this.linklbl_ogrencilistesikaydet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_ogrencilistesikaydet_LinkClicked);
            // 
            // tb_ogrencilistesi_multiline
            // 
            this.tb_ogrencilistesi_multiline.Location = new System.Drawing.Point(6, 66);
            this.tb_ogrencilistesi_multiline.Multiline = true;
            this.tb_ogrencilistesi_multiline.Name = "tb_ogrencilistesi_multiline";
            this.tb_ogrencilistesi_multiline.Size = new System.Drawing.Size(295, 431);
            this.tb_ogrencilistesi_multiline.TabIndex = 53;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label35.Location = new System.Drawing.Point(6, 24);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(209, 39);
            this.label35.TabIndex = 52;
            this.label35.Text = "*Müşteri no esas alınır.\r\n(Excelden Numara ve AdıSoyadı sütunlarını\r\nbaşlık satır" +
    "ı olmadan kopyalayıp yapıştırın.)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 610);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(583, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Bilgi: CD vr PDF ek ürünler olarak geçmektedir. (VT\'de) Bu tabloya bakarken yılı " +
    "esas alıp ürün adını /CD ve PDF) esas alır.";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label34);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_12);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_11);
            this.groupBox10.Controls.Add(this.label32);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_10);
            this.groupBox10.Controls.Add(this.label31);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_9);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_8);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_7);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_6);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_5);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_4);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_3);
            this.groupBox10.Controls.Add(this.label23);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_2);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_yeni_sablonadi);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.tb_sablon_nobetyeri_1);
            this.groupBox10.Controls.Add(this.linklbl_sablon_nobetyeri_sablonukaydet);
            this.groupBox10.Location = new System.Drawing.Point(6, 11);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(277, 529);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Nöbet Yerleri Şablonu Oluştur";
            this.groupBox10.Enter += new System.EventHandler(this.groupBox10_Enter);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(10, 397);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 26);
            this.label34.TabIndex = 76;
            this.label34.Text = "12.\r\nNöbet Yeri";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_12
            // 
            this.tb_sablon_nobetyeri_12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_12.Location = new System.Drawing.Point(73, 392);
            this.tb_sablon_nobetyeri_12.Name = "tb_sablon_nobetyeri_12";
            this.tb_sablon_nobetyeri_12.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_12.TabIndex = 75;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label18.Location = new System.Drawing.Point(68, 427);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(209, 39);
            this.label18.TabIndex = 51;
            this.label18.Text = "*En fazla 12 tane nöbet yeri ekleyebilirsiniz.\r\nTalepler şablon adıyla yapılmakta" +
    "dır.\r\nDeğişiklikler önceki kayıtları etkiler.";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 364);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 26);
            this.label33.TabIndex = 74;
            this.label33.Text = "11.\r\nNöbet Yeri";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_11
            // 
            this.tb_sablon_nobetyeri_11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_11.Location = new System.Drawing.Point(73, 359);
            this.tb_sablon_nobetyeri_11.Name = "tb_sablon_nobetyeri_11";
            this.tb_sablon_nobetyeri_11.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_11.TabIndex = 73;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 330);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(57, 26);
            this.label32.TabIndex = 72;
            this.label32.Text = "10.\r\nNöbet Yeri";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_10
            // 
            this.tb_sablon_nobetyeri_10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_10.Location = new System.Drawing.Point(73, 325);
            this.tb_sablon_nobetyeri_10.Name = "tb_sablon_nobetyeri_10";
            this.tb_sablon_nobetyeri_10.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_10.TabIndex = 71;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 296);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(57, 26);
            this.label31.TabIndex = 70;
            this.label31.Text = "9.\r\nNöbet Yeri";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_9
            // 
            this.tb_sablon_nobetyeri_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_9.Location = new System.Drawing.Point(73, 291);
            this.tb_sablon_nobetyeri_9.Name = "tb_sablon_nobetyeri_9";
            this.tb_sablon_nobetyeri_9.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_9.TabIndex = 69;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 262);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 26);
            this.label30.TabIndex = 68;
            this.label30.Text = "8.\r\nNöbet Yeri";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_8
            // 
            this.tb_sablon_nobetyeri_8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_8.Location = new System.Drawing.Point(73, 257);
            this.tb_sablon_nobetyeri_8.Name = "tb_sablon_nobetyeri_8";
            this.tb_sablon_nobetyeri_8.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_8.TabIndex = 67;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 228);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 26);
            this.label28.TabIndex = 66;
            this.label28.Text = "7.\r\nNöbet Yeri";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_7
            // 
            this.tb_sablon_nobetyeri_7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_7.Location = new System.Drawing.Point(73, 223);
            this.tb_sablon_nobetyeri_7.Name = "tb_sablon_nobetyeri_7";
            this.tb_sablon_nobetyeri_7.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_7.TabIndex = 65;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 194);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 26);
            this.label27.TabIndex = 64;
            this.label27.Text = "6.\r\nNöbet Yeri";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_6
            // 
            this.tb_sablon_nobetyeri_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_6.Location = new System.Drawing.Point(73, 189);
            this.tb_sablon_nobetyeri_6.Name = "tb_sablon_nobetyeri_6";
            this.tb_sablon_nobetyeri_6.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_6.TabIndex = 63;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 160);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 26);
            this.label26.TabIndex = 62;
            this.label26.Text = "5.\r\nNöbet Yeri";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_5
            // 
            this.tb_sablon_nobetyeri_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_5.Location = new System.Drawing.Point(73, 155);
            this.tb_sablon_nobetyeri_5.Name = "tb_sablon_nobetyeri_5";
            this.tb_sablon_nobetyeri_5.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_5.TabIndex = 61;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 126);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 26);
            this.label25.TabIndex = 60;
            this.label25.Text = "4.\r\nNöbet Yeri";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_4
            // 
            this.tb_sablon_nobetyeri_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_4.Location = new System.Drawing.Point(73, 121);
            this.tb_sablon_nobetyeri_4.Name = "tb_sablon_nobetyeri_4";
            this.tb_sablon_nobetyeri_4.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_4.TabIndex = 59;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 92);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 26);
            this.label24.TabIndex = 58;
            this.label24.Text = "3.\r\nNöbet Yeri";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_3
            // 
            this.tb_sablon_nobetyeri_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_3.Location = new System.Drawing.Point(73, 87);
            this.tb_sablon_nobetyeri_3.Name = "tb_sablon_nobetyeri_3";
            this.tb_sablon_nobetyeri_3.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_3.TabIndex = 57;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 26);
            this.label23.TabIndex = 56;
            this.label23.Text = "2.\r\nNöbet Yeri";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_2
            // 
            this.tb_sablon_nobetyeri_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_2.Location = new System.Drawing.Point(73, 53);
            this.tb_sablon_nobetyeri_2.Name = "tb_sablon_nobetyeri_2";
            this.tb_sablon_nobetyeri_2.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_2.TabIndex = 55;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 26);
            this.label17.TabIndex = 54;
            this.label17.Text = "1.\r\nNöbet Yeri";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_sablon_nobetyeri_yeni_sablonadi
            // 
            this.tb_sablon_nobetyeri_yeni_sablonadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_yeni_sablonadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_yeni_sablonadi.Location = new System.Drawing.Point(71, 469);
            this.tb_sablon_nobetyeri_yeni_sablonadi.Name = "tb_sablon_nobetyeri_yeni_sablonadi";
            this.tb_sablon_nobetyeri_yeni_sablonadi.Size = new System.Drawing.Size(171, 32);
            this.tb_sablon_nobetyeri_yeni_sablonadi.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 477);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 52;
            this.label19.Text = "Şablon Adı:";
            // 
            // tb_sablon_nobetyeri_1
            // 
            this.tb_sablon_nobetyeri_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_sablon_nobetyeri_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sablon_nobetyeri_1.Location = new System.Drawing.Point(73, 19);
            this.tb_sablon_nobetyeri_1.Name = "tb_sablon_nobetyeri_1";
            this.tb_sablon_nobetyeri_1.Size = new System.Drawing.Size(198, 32);
            this.tb_sablon_nobetyeri_1.TabIndex = 49;
            // 
            // linklbl_sablon_nobetyeri_sablonukaydet
            // 
            this.linklbl_sablon_nobetyeri_sablonukaydet.AutoSize = true;
            this.linklbl_sablon_nobetyeri_sablonukaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_sablon_nobetyeri_sablonukaydet.LinkColor = System.Drawing.Color.Red;
            this.linklbl_sablon_nobetyeri_sablonukaydet.Location = new System.Drawing.Point(69, 502);
            this.linklbl_sablon_nobetyeri_sablonukaydet.Name = "linklbl_sablon_nobetyeri_sablonukaydet";
            this.linklbl_sablon_nobetyeri_sablonukaydet.Size = new System.Drawing.Size(179, 24);
            this.linklbl_sablon_nobetyeri_sablonukaydet.TabIndex = 47;
            this.linklbl_sablon_nobetyeri_sablonukaydet.TabStop = true;
            this.linklbl_sablon_nobetyeri_sablonukaydet.Text = "ŞABLONU KAYDET";
            this.linklbl_sablon_nobetyeri_sablonukaydet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_sablon_nobetyeri_sablonukaydet_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pb_logo);
            this.groupBox2.Controls.Add(this.linklbl_logo_gozat);
            this.groupBox2.Controls.Add(this.tb_bilgi_logo);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.linklbl_musteri_no_ogrt_bilgisi_getir);
            this.groupBox2.Controls.Add(this.cb_bilgi_musterinokilitli);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.tb_bilgi_musterino);
            this.groupBox2.Controls.Add(this.cb_bilgi_ilcesi);
            this.groupBox2.Controls.Add(this.tb_bilgi_bayikodu);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.linklbl_kurumkodundanbul);
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_bilgi_adisoyadi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 790);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgiler";
            // 
            // pb_logo
            // 
            this.pb_logo.Location = new System.Drawing.Point(281, 630);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(86, 87);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 44;
            this.pb_logo.TabStop = false;
            // 
            // linklbl_logo_gozat
            // 
            this.linklbl_logo_gozat.AutoSize = true;
            this.linklbl_logo_gozat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_logo_gozat.Location = new System.Drawing.Point(233, 633);
            this.linklbl_logo_gozat.Name = "linklbl_logo_gozat";
            this.linklbl_logo_gozat.Size = new System.Drawing.Size(46, 17);
            this.linklbl_logo_gozat.TabIndex = 43;
            this.linklbl_logo_gozat.TabStop = true;
            this.linklbl_logo_gozat.Text = "Gözat";
            this.linklbl_logo_gozat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_logo_gozat_LinkClicked);
            // 
            // tb_bilgi_logo
            // 
            this.tb_bilgi_logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_logo.Location = new System.Drawing.Point(87, 630);
            this.tb_bilgi_logo.Name = "tb_bilgi_logo";
            this.tb_bilgi_logo.Size = new System.Drawing.Size(144, 22);
            this.tb_bilgi_logo.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 638);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Logo:";
            // 
            // linklbl_musteri_no_ogrt_bilgisi_getir
            // 
            this.linklbl_musteri_no_ogrt_bilgisi_getir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linklbl_musteri_no_ogrt_bilgisi_getir.AutoSize = true;
            this.linklbl_musteri_no_ogrt_bilgisi_getir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_musteri_no_ogrt_bilgisi_getir.Location = new System.Drawing.Point(277, 16);
            this.linklbl_musteri_no_ogrt_bilgisi_getir.Name = "linklbl_musteri_no_ogrt_bilgisi_getir";
            this.linklbl_musteri_no_ogrt_bilgisi_getir.Size = new System.Drawing.Size(95, 24);
            this.linklbl_musteri_no_ogrt_bilgisi_getir.TabIndex = 40;
            this.linklbl_musteri_no_ogrt_bilgisi_getir.TabStop = true;
            this.linklbl_musteri_no_ogrt_bilgisi_getir.Text = "GÖSTER";
            this.linklbl_musteri_no_ogrt_bilgisi_getir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_musteri_no_ogrt_bilgisi_getir_LinkClicked);
            // 
            // cb_bilgi_musterinokilitli
            // 
            this.cb_bilgi_musterinokilitli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bilgi_musterinokilitli.AutoSize = true;
            this.cb_bilgi_musterinokilitli.Checked = true;
            this.cb_bilgi_musterinokilitli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_bilgi_musterinokilitli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_musterinokilitli.Location = new System.Drawing.Point(178, 16);
            this.cb_bilgi_musterinokilitli.Name = "cb_bilgi_musterinokilitli";
            this.cb_bilgi_musterinokilitli.Size = new System.Drawing.Size(56, 22);
            this.cb_bilgi_musterinokilitli.TabIndex = 39;
            this.cb_bilgi_musterinokilitli.Text = "Kilitli";
            this.cb_bilgi_musterinokilitli.UseVisualStyleBackColor = true;
            this.cb_bilgi_musterinokilitli.CheckedChanged += new System.EventHandler(this.cb_bilgi_musterinokilitli_CheckedChanged);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Müşteri No:";
            // 
            // tb_bilgi_musterino
            // 
            this.tb_bilgi_musterino.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_musterino.Enabled = false;
            this.tb_bilgi_musterino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_musterino.Location = new System.Drawing.Point(87, 9);
            this.tb_bilgi_musterino.Name = "tb_bilgi_musterino";
            this.tb_bilgi_musterino.Size = new System.Drawing.Size(85, 31);
            this.tb_bilgi_musterino.TabIndex = 37;
            // 
            // cb_bilgi_ilcesi
            // 
            this.cb_bilgi_ilcesi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bilgi_ilcesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_ilcesi.FormattingEnabled = true;
            this.cb_bilgi_ilcesi.Location = new System.Drawing.Point(87, 160);
            this.cb_bilgi_ilcesi.Name = "cb_bilgi_ilcesi";
            this.cb_bilgi_ilcesi.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_ilcesi.TabIndex = 4;
            // 
            // tb_bilgi_bayikodu
            // 
            this.tb_bilgi_bayikodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_bayikodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_bayikodu.Location = new System.Drawing.Point(88, 685);
            this.tb_bilgi_bayikodu.Name = "tb_bilgi_bayikodu";
            this.tb_bilgi_bayikodu.Size = new System.Drawing.Size(187, 32);
            this.tb_bilgi_bayikodu.TabIndex = 35;
            this.tb_bilgi_bayikodu.TextChanged += new System.EventHandler(this.tb_bilgi_bayikodu_TextChanged);
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 697);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 13);
            this.label29.TabIndex = 36;
            this.label29.Text = "Bayi Koduı:";
            // 
            // linklbl_kurumkodundanbul
            // 
            this.linklbl_kurumkodundanbul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linklbl_kurumkodundanbul.AutoSize = true;
            this.linklbl_kurumkodundanbul.Location = new System.Drawing.Point(344, 280);
            this.linklbl_kurumkodundanbul.Name = "linklbl_kurumkodundanbul";
            this.linklbl_kurumkodundanbul.Size = new System.Drawing.Size(28, 13);
            this.linklbl_kurumkodundanbul.TabIndex = 34;
            this.linklbl_kurumkodundanbul.TabStop = true;
            this.linklbl_kurumkodundanbul.Text = "BUL";
            this.toolTip1.SetToolTip(this.linklbl_kurumkodundanbul, "Okul kodundan il, ilçe, kurum adı bilgilerini getirir.");
            this.linklbl_kurumkodundanbul.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_kurumkodundanbul_LinkClicked);
            // 
            // cb_bilgi_sinifi
            // 
            this.cb_bilgi_sinifi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bilgi_sinifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_sinifi.FormattingEnabled = true;
            this.cb_bilgi_sinifi.Location = new System.Drawing.Point(87, 267);
            this.cb_bilgi_sinifi.Name = "cb_bilgi_sinifi";
            this.cb_bilgi_sinifi.Size = new System.Drawing.Size(66, 33);
            this.cb_bilgi_sinifi.TabIndex = 6;
            // 
            // tb_bilgi_okulkodu
            // 
            this.tb_bilgi_okulkodu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_okulkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_okulkodu.Location = new System.Drawing.Point(236, 268);
            this.tb_bilgi_okulkodu.Name = "tb_bilgi_okulkodu";
            this.tb_bilgi_okulkodu.Size = new System.Drawing.Size(108, 32);
            this.tb_bilgi_okulkodu.TabIndex = 8;
            // 
            // lbl_bilgi_kayittarihi
            // 
            this.lbl_bilgi_kayittarihi.AutoSize = true;
            this.lbl_bilgi_kayittarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilgi_kayittarihi.Location = new System.Drawing.Point(6, 767);
            this.lbl_bilgi_kayittarihi.Name = "lbl_bilgi_kayittarihi";
            this.lbl_bilgi_kayittarihi.Size = new System.Drawing.Size(59, 13);
            this.lbl_bilgi_kayittarihi.TabIndex = 31;
            this.lbl_bilgi_kayittarihi.Text = "Kayıt Tarihi";
            // 
            // cb_bilgi_bayiadi
            // 
            this.cb_bilgi_bayiadi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bilgi_bayiadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_bayiadi.FormattingEnabled = true;
            this.cb_bilgi_bayiadi.Location = new System.Drawing.Point(88, 723);
            this.cb_bilgi_bayiadi.Name = "cb_bilgi_bayiadi";
            this.cb_bilgi_bayiadi.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_bayiadi.TabIndex = 15;
            this.cb_bilgi_bayiadi.SelectedIndexChanged += new System.EventHandler(this.cb_bilgi_bayiadi_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 735);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Bayi Adı:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(152, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "-";
            // 
            // cb_bilgi_mudurunvani
            // 
            this.cb_bilgi_mudurunvani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bilgi_mudurunvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_mudurunvani.FormattingEnabled = true;
            this.cb_bilgi_mudurunvani.Location = new System.Drawing.Point(87, 343);
            this.cb_bilgi_mudurunvani.Name = "cb_bilgi_mudurunvani";
            this.cb_bilgi_mudurunvani.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_mudurunvani.TabIndex = 10;
            // 
            // tb_bilgi_subesi
            // 
            this.tb_bilgi_subesi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_subesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_subesi.Location = new System.Drawing.Point(162, 267);
            this.tb_bilgi_subesi.Name = "tb_bilgi_subesi";
            this.tb_bilgi_subesi.Size = new System.Drawing.Size(68, 32);
            this.tb_bilgi_subesi.TabIndex = 7;
            // 
            // cb_bilgi_ili
            // 
            this.cb_bilgi_ili.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bilgi_ili.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_ili.FormattingEnabled = true;
            this.cb_bilgi_ili.Location = new System.Drawing.Point(87, 120);
            this.cb_bilgi_ili.Name = "cb_bilgi_ili";
            this.cb_bilgi_ili.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_ili.TabIndex = 3;
            this.cb_bilgi_ili.SelectedIndexChanged += new System.EventHandler(this.cb_bilgi_ili_SelectedIndexChanged);
            // 
            // cb_bilgi_bransi
            // 
            this.cb_bilgi_bransi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_bilgi_bransi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_bilgi_bransi.FormattingEnabled = true;
            this.cb_bilgi_bransi.Location = new System.Drawing.Point(87, 84);
            this.cb_bilgi_bransi.Name = "cb_bilgi_bransi";
            this.cb_bilgi_bransi.Size = new System.Drawing.Size(285, 33);
            this.cb_bilgi_bransi.TabIndex = 2;
            // 
            // tb_bilgi_aciklama
            // 
            this.tb_bilgi_aciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_aciklama.Location = new System.Drawing.Point(87, 525);
            this.tb_bilgi_aciklama.Multiline = true;
            this.tb_bilgi_aciklama.Name = "tb_bilgi_aciklama";
            this.tb_bilgi_aciklama.Size = new System.Drawing.Size(285, 99);
            this.tb_bilgi_aciklama.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Açıklama:";
            // 
            // tb_bilgi_adres
            // 
            this.tb_bilgi_adres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_adres.Location = new System.Drawing.Point(87, 458);
            this.tb_bilgi_adres.Multiline = true;
            this.tb_bilgi_adres.Name = "tb_bilgi_adres";
            this.tb_bilgi_adres.Size = new System.Drawing.Size(285, 56);
            this.tb_bilgi_adres.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Adres:";
            // 
            // tb_bilgi_telefon
            // 
            this.tb_bilgi_telefon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_telefon.Location = new System.Drawing.Point(87, 420);
            this.tb_bilgi_telefon.Name = "tb_bilgi_telefon";
            this.tb_bilgi_telefon.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_telefon.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Telefon:";
            // 
            // tb_bilgi_eposta
            // 
            this.tb_bilgi_eposta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_eposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_eposta.Location = new System.Drawing.Point(87, 382);
            this.tb_bilgi_eposta.Name = "tb_bilgi_eposta";
            this.tb_bilgi_eposta.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_eposta.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "E-posta:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mdr Unvanı:";
            // 
            // tb_bilgi_muduradi
            // 
            this.tb_bilgi_muduradi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_muduradi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_muduradi.Location = new System.Drawing.Point(87, 306);
            this.tb_bilgi_muduradi.Name = "tb_bilgi_muduradi";
            this.tb_bilgi_muduradi.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_muduradi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Müdür Adı:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sınıf-Şube\r\nKurum Kodu";
            // 
            // tb_bilgi_okulu
            // 
            this.tb_bilgi_okulu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_okulu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_okulu.Location = new System.Drawing.Point(87, 199);
            this.tb_bilgi_okulu.Multiline = true;
            this.tb_bilgi_okulu.Name = "tb_bilgi_okulu";
            this.tb_bilgi_okulu.Size = new System.Drawing.Size(285, 63);
            this.tb_bilgi_okulu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Okulu:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "İlçe:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "İli:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Branşı:";
            // 
            // tb_bilgi_adisoyadi
            // 
            this.tb_bilgi_adisoyadi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_bilgi_adisoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_bilgi_adisoyadi.Location = new System.Drawing.Point(87, 44);
            this.tb_bilgi_adisoyadi.Name = "tb_bilgi_adisoyadi";
            this.tb_bilgi_adisoyadi.Size = new System.Drawing.Size(285, 32);
            this.tb_bilgi_adisoyadi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı:";
            // 
            // bt_yenikayit
            // 
            this.bt_yenikayit.Location = new System.Drawing.Point(171, 45);
            this.bt_yenikayit.Name = "bt_yenikayit";
            this.bt_yenikayit.Size = new System.Drawing.Size(91, 32);
            this.bt_yenikayit.TabIndex = 29;
            this.bt_yenikayit.Text = "Yeni Kayıt";
            this.bt_yenikayit.UseVisualStyleBackColor = true;
            this.bt_yenikayit.Click += new System.EventHandler(this.bt_yenikayit_Click);
            // 
            // bt_guncelle
            // 
            this.bt_guncelle.Location = new System.Drawing.Point(171, 12);
            this.bt_guncelle.Name = "bt_guncelle";
            this.bt_guncelle.Size = new System.Drawing.Size(91, 27);
            this.bt_guncelle.TabIndex = 30;
            this.bt_guncelle.Text = "Güncelle";
            this.bt_guncelle.UseVisualStyleBackColor = true;
            this.bt_guncelle.Click += new System.EventHandler(this.bt_guncelle_Click);
            // 
            // btn_varsayilanlariguncelle
            // 
            this.btn_varsayilanlariguncelle.Location = new System.Drawing.Point(268, 12);
            this.btn_varsayilanlariguncelle.Name = "btn_varsayilanlariguncelle";
            this.btn_varsayilanlariguncelle.Size = new System.Drawing.Size(119, 27);
            this.btn_varsayilanlariguncelle.TabIndex = 31;
            this.btn_varsayilanlariguncelle.Text = "Varsayılan Yenile";
            this.toolTip1.SetToolTip(this.btn_varsayilanlariguncelle, "(İsteğe Bağlı) Yıl, branşlar, sınıflar, nöbet şablonları gibi otomatik gelen bilg" +
        "ileri yeni kayıtlara göre günceller.");
            this.btn_varsayilanlariguncelle.UseVisualStyleBackColor = true;
            this.btn_varsayilanlariguncelle.Click += new System.EventHandler(this.btn_varsayilanlariguncelle_Click);
            // 
            // btn_ikaz_lambasi
            // 
            this.btn_ikaz_lambasi.Location = new System.Drawing.Point(357, 65);
            this.btn_ikaz_lambasi.Name = "btn_ikaz_lambasi";
            this.btn_ikaz_lambasi.Size = new System.Drawing.Size(25, 23);
            this.btn_ikaz_lambasi.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btn_ikaz_lambasi, "Bir ikaz yok!");
            this.btn_ikaz_lambasi.UseVisualStyleBackColor = true;
            // 
            // cb_yil_ara
            // 
            this.cb_yil_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_yil_ara.FormattingEnabled = true;
            this.cb_yil_ara.Location = new System.Drawing.Point(13, 19);
            this.cb_yil_ara.Name = "cb_yil_ara";
            this.cb_yil_ara.Size = new System.Drawing.Size(121, 32);
            this.cb_yil_ara.TabIndex = 100;
            this.toolTip1.SetToolTip(this.cb_yil_ara, "Yeni kayıt veya Güncelleme yaparken boş bırakılırsa varsayılan değeri alır. (Bayi" +
        " de aynı şekilde varsayılan değeri alır.)");
            // 
            // rb_ara_okumadefteri
            // 
            this.rb_ara_okumadefteri.AutoSize = true;
            this.rb_ara_okumadefteri.Enabled = false;
            this.rb_ara_okumadefteri.Location = new System.Drawing.Point(6, 65);
            this.rb_ara_okumadefteri.Name = "rb_ara_okumadefteri";
            this.rb_ara_okumadefteri.Size = new System.Drawing.Size(93, 17);
            this.rb_ara_okumadefteri.TabIndex = 3;
            this.rb_ara_okumadefteri.Text = "Okuma Defteri";
            this.toolTip1.SetToolTip(this.rb_ara_okumadefteri, resources.GetString("rb_ara_okumadefteri.ToolTip"));
            this.rb_ara_okumadefteri.UseVisualStyleBackColor = true;
            // 
            // cb_yil_ara_defter
            // 
            this.cb_yil_ara_defter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_yil_ara_defter.FormattingEnabled = true;
            this.cb_yil_ara_defter.Location = new System.Drawing.Point(6, 19);
            this.cb_yil_ara_defter.Name = "cb_yil_ara_defter";
            this.cb_yil_ara_defter.Size = new System.Drawing.Size(121, 32);
            this.cb_yil_ara_defter.TabIndex = 100;
            this.toolTip1.SetToolTip(this.cb_yil_ara_defter, "Yeni kayıt veya Güncelleme yaparken boş bırakılırsa varsayılan değeri alır. (Bayi" +
        " de aynı şekilde varsayılan değeri alır.)");
            // 
            // cb_ara_defterturu
            // 
            this.cb_ara_defterturu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_ara_defterturu.FormattingEnabled = true;
            this.cb_ara_defterturu.Location = new System.Drawing.Point(6, 19);
            this.cb_ara_defterturu.Name = "cb_ara_defterturu";
            this.cb_ara_defterturu.Size = new System.Drawing.Size(427, 32);
            this.cb_ara_defterturu.TabIndex = 100;
            this.toolTip1.SetToolTip(this.cb_ara_defterturu, "Yeni kayıt veya Güncelleme yaparken boş bırakılırsa varsayılan değeri alır. (Bayi" +
        " de aynı şekilde varsayılan değeri alır.)");
            // 
            // cb_yil_ara_bilgileregore
            // 
            this.cb_yil_ara_bilgileregore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_yil_ara_bilgileregore.FormattingEnabled = true;
            this.cb_yil_ara_bilgileregore.Location = new System.Drawing.Point(6, 19);
            this.cb_yil_ara_bilgileregore.Name = "cb_yil_ara_bilgileregore";
            this.cb_yil_ara_bilgileregore.Size = new System.Drawing.Size(121, 32);
            this.cb_yil_ara_bilgileregore.TabIndex = 100;
            this.toolTip1.SetToolTip(this.cb_yil_ara_bilgileregore, "Yeni kayıt veya Güncelleme yaparken boş bırakılırsa varsayılan değeri alır. (Bayi" +
        " de aynı şekilde varsayılan değeri alır.)");
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.ForeColor = System.Drawing.Color.Red;
            this.lbl_bilgi.Location = new System.Drawing.Point(93, 80);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(35, 13);
            this.lbl_bilgi.TabIndex = 32;
            this.lbl_bilgi.Text = "Bilgi...";
            this.lbl_bilgi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tab_alt_arama);
            this.tabControl2.Controls.Add(this.tab_alt_loglar);
            this.tabControl2.Location = new System.Drawing.Point(399, 588);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1362, 304);
            this.tabControl2.TabIndex = 35;
            // 
            // tab_alt_arama
            // 
            this.tab_alt_arama.Controls.Add(this.tabControl3);
            this.tab_alt_arama.Controls.Add(this.groupBox11);
            this.tab_alt_arama.Location = new System.Drawing.Point(4, 22);
            this.tab_alt_arama.Name = "tab_alt_arama";
            this.tab_alt_arama.Padding = new System.Windows.Forms.Padding(3);
            this.tab_alt_arama.Size = new System.Drawing.Size(1354, 278);
            this.tab_alt_arama.TabIndex = 0;
            this.tab_alt_arama.Text = "Arama ve Listeleme";
            this.tab_alt_arama.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(884, 10);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(464, 265);
            this.tabControl3.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox26);
            this.tabPage1.Controls.Add(this.groupBox20);
            this.tabPage1.Controls.Add(this.groupBox23);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plan ve Ek Ürünler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.cb_yil_ara);
            this.groupBox26.Location = new System.Drawing.Point(6, 12);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(152, 64);
            this.groupBox26.TabIndex = 37;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "Yıl Seçimi";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.groupBox21);
            this.groupBox20.Controls.Add(this.lnklbl_ara_plan);
            this.groupBox20.Controls.Add(this.groupBox22);
            this.groupBox20.Location = new System.Drawing.Point(164, 6);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(273, 98);
            this.groupBox20.TabIndex = 35;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Plan Türü ve Durumuna Göre Listele";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.rb_ara_plangunluk);
            this.groupBox21.Controls.Add(this.rb_ara_planyillik);
            this.groupBox21.Controls.Add(this.rb_ara_plantumu);
            this.groupBox21.Location = new System.Drawing.Point(6, 10);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(83, 82);
            this.groupBox21.TabIndex = 3;
            this.groupBox21.TabStop = false;
            // 
            // rb_ara_plangunluk
            // 
            this.rb_ara_plangunluk.AutoSize = true;
            this.rb_ara_plangunluk.Location = new System.Drawing.Point(6, 59);
            this.rb_ara_plangunluk.Name = "rb_ara_plangunluk";
            this.rb_ara_plangunluk.Size = new System.Drawing.Size(59, 17);
            this.rb_ara_plangunluk.TabIndex = 2;
            this.rb_ara_plangunluk.Text = "Günlük";
            this.rb_ara_plangunluk.UseVisualStyleBackColor = true;
            // 
            // rb_ara_planyillik
            // 
            this.rb_ara_planyillik.AutoSize = true;
            this.rb_ara_planyillik.Location = new System.Drawing.Point(6, 36);
            this.rb_ara_planyillik.Name = "rb_ara_planyillik";
            this.rb_ara_planyillik.Size = new System.Drawing.Size(46, 17);
            this.rb_ara_planyillik.TabIndex = 1;
            this.rb_ara_planyillik.Text = "Yıllık";
            this.rb_ara_planyillik.UseVisualStyleBackColor = true;
            // 
            // rb_ara_plantumu
            // 
            this.rb_ara_plantumu.AutoSize = true;
            this.rb_ara_plantumu.Checked = true;
            this.rb_ara_plantumu.Location = new System.Drawing.Point(6, 13);
            this.rb_ara_plantumu.Name = "rb_ara_plantumu";
            this.rb_ara_plantumu.Size = new System.Drawing.Size(52, 17);
            this.rb_ara_plantumu.TabIndex = 0;
            this.rb_ara_plantumu.TabStop = true;
            this.rb_ara_plantumu.Text = "Tümü";
            this.rb_ara_plantumu.UseVisualStyleBackColor = true;
            // 
            // lnklbl_ara_plan
            // 
            this.lnklbl_ara_plan.AutoSize = true;
            this.lnklbl_ara_plan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklbl_ara_plan.Location = new System.Drawing.Point(204, 46);
            this.lnklbl_ara_plan.Name = "lnklbl_ara_plan";
            this.lnklbl_ara_plan.Size = new System.Drawing.Size(63, 17);
            this.lnklbl_ara_plan.TabIndex = 2;
            this.lnklbl_ara_plan.TabStop = true;
            this.lnklbl_ara_plan.Text = "LİSTELE";
            this.lnklbl_ara_plan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_ara_plan_LinkClicked);
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.rb_ara_durum_basilmamis);
            this.groupBox22.Controls.Add(this.rb_ara_durum_basilmis);
            this.groupBox22.Controls.Add(this.rb_ara_durum_tumu);
            this.groupBox22.Location = new System.Drawing.Point(115, 10);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(83, 82);
            this.groupBox22.TabIndex = 1;
            this.groupBox22.TabStop = false;
            // 
            // rb_ara_durum_basilmamis
            // 
            this.rb_ara_durum_basilmamis.AutoSize = true;
            this.rb_ara_durum_basilmamis.Checked = true;
            this.rb_ara_durum_basilmamis.Location = new System.Drawing.Point(6, 59);
            this.rb_ara_durum_basilmamis.Name = "rb_ara_durum_basilmamis";
            this.rb_ara_durum_basilmamis.Size = new System.Drawing.Size(76, 17);
            this.rb_ara_durum_basilmamis.TabIndex = 2;
            this.rb_ara_durum_basilmamis.TabStop = true;
            this.rb_ara_durum_basilmamis.Text = "Basılmamış";
            this.rb_ara_durum_basilmamis.UseVisualStyleBackColor = true;
            // 
            // rb_ara_durum_basilmis
            // 
            this.rb_ara_durum_basilmis.AutoSize = true;
            this.rb_ara_durum_basilmis.Location = new System.Drawing.Point(6, 36);
            this.rb_ara_durum_basilmis.Name = "rb_ara_durum_basilmis";
            this.rb_ara_durum_basilmis.Size = new System.Drawing.Size(62, 17);
            this.rb_ara_durum_basilmis.TabIndex = 1;
            this.rb_ara_durum_basilmis.Text = "Basılmış";
            this.rb_ara_durum_basilmis.UseVisualStyleBackColor = true;
            // 
            // rb_ara_durum_tumu
            // 
            this.rb_ara_durum_tumu.AutoSize = true;
            this.rb_ara_durum_tumu.Location = new System.Drawing.Point(6, 13);
            this.rb_ara_durum_tumu.Name = "rb_ara_durum_tumu";
            this.rb_ara_durum_tumu.Size = new System.Drawing.Size(52, 17);
            this.rb_ara_durum_tumu.TabIndex = 0;
            this.rb_ara_durum_tumu.Text = "Tümü";
            this.rb_ara_durum_tumu.UseVisualStyleBackColor = true;
            // 
            // groupBox23
            // 
            this.groupBox23.Controls.Add(this.lnklbl_ara_ekurunler);
            this.groupBox23.Controls.Add(this.groupBox25);
            this.groupBox23.Location = new System.Drawing.Point(164, 110);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Size = new System.Drawing.Size(273, 115);
            this.groupBox23.TabIndex = 36;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Ek Ürünler ve Durumuna Göre Listele";
            // 
            // lnklbl_ara_ekurunler
            // 
            this.lnklbl_ara_ekurunler.AutoSize = true;
            this.lnklbl_ara_ekurunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklbl_ara_ekurunler.Location = new System.Drawing.Point(208, 53);
            this.lnklbl_ara_ekurunler.Name = "lnklbl_ara_ekurunler";
            this.lnklbl_ara_ekurunler.Size = new System.Drawing.Size(63, 17);
            this.lnklbl_ara_ekurunler.TabIndex = 2;
            this.lnklbl_ara_ekurunler.TabStop = true;
            this.lnklbl_ara_ekurunler.Text = "LİSTELE";
            this.lnklbl_ara_ekurunler.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // groupBox25
            // 
            this.groupBox25.Controls.Add(this.groupBox24);
            this.groupBox25.Controls.Add(this.rb_ara_okumadefteri);
            this.groupBox25.Controls.Add(this.rb_ara_sosyalkulup);
            this.groupBox25.Controls.Add(this.rb_ara_pdf);
            this.groupBox25.Controls.Add(this.rb_ara_cd);
            this.groupBox25.Location = new System.Drawing.Point(13, 16);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Size = new System.Drawing.Size(192, 93);
            this.groupBox25.TabIndex = 0;
            this.groupBox25.TabStop = false;
            // 
            // groupBox24
            // 
            this.groupBox24.Controls.Add(this.rb_ara_ekurun_durum_basilmamis);
            this.groupBox24.Controls.Add(this.rb_ara_ekurun_durum_basilmis);
            this.groupBox24.Controls.Add(this.rb_ara_ekurun_durum_tumu);
            this.groupBox24.Location = new System.Drawing.Point(105, 8);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Size = new System.Drawing.Size(83, 82);
            this.groupBox24.TabIndex = 4;
            this.groupBox24.TabStop = false;
            // 
            // rb_ara_ekurun_durum_basilmamis
            // 
            this.rb_ara_ekurun_durum_basilmamis.AutoSize = true;
            this.rb_ara_ekurun_durum_basilmamis.Checked = true;
            this.rb_ara_ekurun_durum_basilmamis.Location = new System.Drawing.Point(6, 59);
            this.rb_ara_ekurun_durum_basilmamis.Name = "rb_ara_ekurun_durum_basilmamis";
            this.rb_ara_ekurun_durum_basilmamis.Size = new System.Drawing.Size(76, 17);
            this.rb_ara_ekurun_durum_basilmamis.TabIndex = 2;
            this.rb_ara_ekurun_durum_basilmamis.TabStop = true;
            this.rb_ara_ekurun_durum_basilmamis.Text = "Basılmamış";
            this.rb_ara_ekurun_durum_basilmamis.UseVisualStyleBackColor = true;
            // 
            // rb_ara_ekurun_durum_basilmis
            // 
            this.rb_ara_ekurun_durum_basilmis.AutoSize = true;
            this.rb_ara_ekurun_durum_basilmis.Location = new System.Drawing.Point(6, 36);
            this.rb_ara_ekurun_durum_basilmis.Name = "rb_ara_ekurun_durum_basilmis";
            this.rb_ara_ekurun_durum_basilmis.Size = new System.Drawing.Size(62, 17);
            this.rb_ara_ekurun_durum_basilmis.TabIndex = 1;
            this.rb_ara_ekurun_durum_basilmis.Text = "Basılmış";
            this.rb_ara_ekurun_durum_basilmis.UseVisualStyleBackColor = true;
            // 
            // rb_ara_ekurun_durum_tumu
            // 
            this.rb_ara_ekurun_durum_tumu.AutoSize = true;
            this.rb_ara_ekurun_durum_tumu.Location = new System.Drawing.Point(6, 13);
            this.rb_ara_ekurun_durum_tumu.Name = "rb_ara_ekurun_durum_tumu";
            this.rb_ara_ekurun_durum_tumu.Size = new System.Drawing.Size(52, 17);
            this.rb_ara_ekurun_durum_tumu.TabIndex = 0;
            this.rb_ara_ekurun_durum_tumu.Text = "Tümü";
            this.rb_ara_ekurun_durum_tumu.UseVisualStyleBackColor = true;
            // 
            // rb_ara_sosyalkulup
            // 
            this.rb_ara_sosyalkulup.AutoSize = true;
            this.rb_ara_sosyalkulup.Location = new System.Drawing.Point(6, 41);
            this.rb_ara_sosyalkulup.Name = "rb_ara_sosyalkulup";
            this.rb_ara_sosyalkulup.Size = new System.Drawing.Size(86, 17);
            this.rb_ara_sosyalkulup.TabIndex = 2;
            this.rb_ara_sosyalkulup.Text = "Sosyal Kulüp";
            this.rb_ara_sosyalkulup.UseVisualStyleBackColor = true;
            // 
            // rb_ara_pdf
            // 
            this.rb_ara_pdf.AutoSize = true;
            this.rb_ara_pdf.Checked = true;
            this.rb_ara_pdf.Location = new System.Drawing.Point(53, 18);
            this.rb_ara_pdf.Name = "rb_ara_pdf";
            this.rb_ara_pdf.Size = new System.Drawing.Size(46, 17);
            this.rb_ara_pdf.TabIndex = 1;
            this.rb_ara_pdf.TabStop = true;
            this.rb_ara_pdf.Text = "PDF";
            this.rb_ara_pdf.UseVisualStyleBackColor = true;
            // 
            // rb_ara_cd
            // 
            this.rb_ara_cd.AutoSize = true;
            this.rb_ara_cd.Location = new System.Drawing.Point(6, 18);
            this.rb_ara_cd.Name = "rb_ara_cd";
            this.rb_ara_cd.Size = new System.Drawing.Size(40, 17);
            this.rb_ara_cd.TabIndex = 0;
            this.rb_ara_cd.Text = "CD";
            this.rb_ara_cd.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox28);
            this.tabPage2.Controls.Add(this.groupBox30);
            this.tabPage2.Controls.Add(this.groupBox18);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(456, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Defterler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox28
            // 
            this.groupBox28.Controls.Add(this.cb_ara_defterturu);
            this.groupBox28.Location = new System.Drawing.Point(10, 82);
            this.groupBox28.Name = "groupBox28";
            this.groupBox28.Size = new System.Drawing.Size(440, 64);
            this.groupBox28.TabIndex = 39;
            this.groupBox28.TabStop = false;
            this.groupBox28.Text = "Defter Seçimi (Tümü için boş bırakın)";
            // 
            // groupBox30
            // 
            this.groupBox30.Controls.Add(this.cb_yil_ara_defter);
            this.groupBox30.Location = new System.Drawing.Point(10, 9);
            this.groupBox30.Name = "groupBox30";
            this.groupBox30.Size = new System.Drawing.Size(140, 64);
            this.groupBox30.TabIndex = 38;
            this.groupBox30.TabStop = false;
            this.groupBox30.Text = "Yıl Seçimi";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.linkLabel2);
            this.groupBox18.Controls.Add(this.groupBox29);
            this.groupBox18.Location = new System.Drawing.Point(156, 9);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(294, 64);
            this.groupBox18.TabIndex = 36;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Defter Basım Durumuna Göre Listele";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(224, 23);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(63, 17);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "LİSTELE";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox29
            // 
            this.groupBox29.Controls.Add(this.rb_ara_defter_durum_basilmamis);
            this.groupBox29.Controls.Add(this.rb_ara_defter_durum_basilmis);
            this.groupBox29.Controls.Add(this.rb_ara_defter_durum_tumu);
            this.groupBox29.Location = new System.Drawing.Point(6, 10);
            this.groupBox29.Name = "groupBox29";
            this.groupBox29.Size = new System.Drawing.Size(212, 44);
            this.groupBox29.TabIndex = 1;
            this.groupBox29.TabStop = false;
            // 
            // rb_ara_defter_durum_basilmamis
            // 
            this.rb_ara_defter_durum_basilmamis.AutoSize = true;
            this.rb_ara_defter_durum_basilmamis.Checked = true;
            this.rb_ara_defter_durum_basilmamis.Location = new System.Drawing.Point(130, 12);
            this.rb_ara_defter_durum_basilmamis.Name = "rb_ara_defter_durum_basilmamis";
            this.rb_ara_defter_durum_basilmamis.Size = new System.Drawing.Size(76, 17);
            this.rb_ara_defter_durum_basilmamis.TabIndex = 2;
            this.rb_ara_defter_durum_basilmamis.TabStop = true;
            this.rb_ara_defter_durum_basilmamis.Text = "Basılmamış";
            this.rb_ara_defter_durum_basilmamis.UseVisualStyleBackColor = true;
            // 
            // rb_ara_defter_durum_basilmis
            // 
            this.rb_ara_defter_durum_basilmis.AutoSize = true;
            this.rb_ara_defter_durum_basilmis.Location = new System.Drawing.Point(62, 13);
            this.rb_ara_defter_durum_basilmis.Name = "rb_ara_defter_durum_basilmis";
            this.rb_ara_defter_durum_basilmis.Size = new System.Drawing.Size(62, 17);
            this.rb_ara_defter_durum_basilmis.TabIndex = 1;
            this.rb_ara_defter_durum_basilmis.Text = "Basılmış";
            this.rb_ara_defter_durum_basilmis.UseVisualStyleBackColor = true;
            // 
            // rb_ara_defter_durum_tumu
            // 
            this.rb_ara_defter_durum_tumu.AutoSize = true;
            this.rb_ara_defter_durum_tumu.Location = new System.Drawing.Point(6, 13);
            this.rb_ara_defter_durum_tumu.Name = "rb_ara_defter_durum_tumu";
            this.rb_ara_defter_durum_tumu.Size = new System.Drawing.Size(52, 17);
            this.rb_ara_defter_durum_tumu.TabIndex = 0;
            this.rb_ara_defter_durum_tumu.Text = "Tümü";
            this.rb_ara_defter_durum_tumu.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lnklbl_ara_bilgilerle_listele);
            this.tabPage3.Controls.Add(this.groupBox33);
            this.tabPage3.Controls.Add(this.groupBox32);
            this.tabPage3.Controls.Add(this.groupBox31);
            this.tabPage3.Controls.Add(this.groupBox27);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(456, 239);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bilgilerle Arama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lnklbl_ara_bilgilerle_listele
            // 
            this.lnklbl_ara_bilgilerle_listele.AutoSize = true;
            this.lnklbl_ara_bilgilerle_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklbl_ara_bilgilerle_listele.Location = new System.Drawing.Point(43, 211);
            this.lnklbl_ara_bilgilerle_listele.Name = "lnklbl_ara_bilgilerle_listele";
            this.lnklbl_ara_bilgilerle_listele.Size = new System.Drawing.Size(74, 20);
            this.lnklbl_ara_bilgilerle_listele.TabIndex = 46;
            this.lnklbl_ara_bilgilerle_listele.TabStop = true;
            this.lnklbl_ara_bilgilerle_listele.Text = "LİSTELE";
            this.lnklbl_ara_bilgilerle_listele.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_ara_bilgilerle_listele_LinkClicked);
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.tb_yil_ara_bilgileregore_bayiadi);
            this.groupBox33.Location = new System.Drawing.Point(10, 79);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(140, 64);
            this.groupBox33.TabIndex = 44;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "Bayi Adı";
            // 
            // tb_yil_ara_bilgileregore_bayiadi
            // 
            this.tb_yil_ara_bilgileregore_bayiadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yil_ara_bilgileregore_bayiadi.Location = new System.Drawing.Point(6, 19);
            this.tb_yil_ara_bilgileregore_bayiadi.Name = "tb_yil_ara_bilgileregore_bayiadi";
            this.tb_yil_ara_bilgileregore_bayiadi.Size = new System.Drawing.Size(121, 29);
            this.tb_yil_ara_bilgileregore_bayiadi.TabIndex = 1;
            // 
            // groupBox32
            // 
            this.groupBox32.Controls.Add(this.tb_yil_ara_musteriadi);
            this.groupBox32.Location = new System.Drawing.Point(163, 9);
            this.groupBox32.Name = "groupBox32";
            this.groupBox32.Size = new System.Drawing.Size(274, 64);
            this.groupBox32.TabIndex = 43;
            this.groupBox32.TabStop = false;
            this.groupBox32.Text = "Müşteri Adı";
            // 
            // tb_yil_ara_musteriadi
            // 
            this.tb_yil_ara_musteriadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yil_ara_musteriadi.Location = new System.Drawing.Point(6, 19);
            this.tb_yil_ara_musteriadi.Name = "tb_yil_ara_musteriadi";
            this.tb_yil_ara_musteriadi.Size = new System.Drawing.Size(254, 29);
            this.tb_yil_ara_musteriadi.TabIndex = 0;
            // 
            // groupBox31
            // 
            this.groupBox31.Controls.Add(this.label51);
            this.groupBox31.Controls.Add(this.label50);
            this.groupBox31.Controls.Add(this.label49);
            this.groupBox31.Controls.Add(this.tb_yil_ara_bilgileregore_okul);
            this.groupBox31.Controls.Add(this.tb_yil_ara_bilgileregore_ilce);
            this.groupBox31.Controls.Add(this.tb_yil_ara_bilgileregore_il);
            this.groupBox31.Location = new System.Drawing.Point(163, 79);
            this.groupBox31.Name = "groupBox31";
            this.groupBox31.Size = new System.Drawing.Size(274, 140);
            this.groupBox31.TabIndex = 42;
            this.groupBox31.TabStop = false;
            this.groupBox31.Text = "İl-İlçe-Okul";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(12, 108);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(35, 13);
            this.label51.TabIndex = 6;
            this.label51.Text = "Okulu";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(12, 67);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(31, 13);
            this.label50.TabIndex = 5;
            this.label50.Text = "İlçesi";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(12, 30);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(14, 13);
            this.label49.TabIndex = 4;
            this.label49.Text = "İli";
            // 
            // tb_yil_ara_bilgileregore_okul
            // 
            this.tb_yil_ara_bilgileregore_okul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yil_ara_bilgileregore_okul.Location = new System.Drawing.Point(59, 97);
            this.tb_yil_ara_bilgileregore_okul.Name = "tb_yil_ara_bilgileregore_okul";
            this.tb_yil_ara_bilgileregore_okul.Size = new System.Drawing.Size(201, 29);
            this.tb_yil_ara_bilgileregore_okul.TabIndex = 3;
            // 
            // tb_yil_ara_bilgileregore_ilce
            // 
            this.tb_yil_ara_bilgileregore_ilce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yil_ara_bilgileregore_ilce.Location = new System.Drawing.Point(59, 56);
            this.tb_yil_ara_bilgileregore_ilce.Name = "tb_yil_ara_bilgileregore_ilce";
            this.tb_yil_ara_bilgileregore_ilce.Size = new System.Drawing.Size(201, 29);
            this.tb_yil_ara_bilgileregore_ilce.TabIndex = 2;
            // 
            // tb_yil_ara_bilgileregore_il
            // 
            this.tb_yil_ara_bilgileregore_il.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yil_ara_bilgileregore_il.Location = new System.Drawing.Point(59, 19);
            this.tb_yil_ara_bilgileregore_il.Name = "tb_yil_ara_bilgileregore_il";
            this.tb_yil_ara_bilgileregore_il.Size = new System.Drawing.Size(201, 29);
            this.tb_yil_ara_bilgileregore_il.TabIndex = 1;
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.cb_yil_ara_bilgileregore);
            this.groupBox27.Location = new System.Drawing.Point(10, 9);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(140, 64);
            this.groupBox27.TabIndex = 39;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "Yıl Seçimi";
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox11.Controls.Add(this.lbl_ara_bulunankayit_sayisi);
            this.groupBox11.Controls.Add(this.dgv_alt_aramavelisteleme);
            this.groupBox11.Controls.Add(this.label48);
            this.groupBox11.Location = new System.Drawing.Point(6, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(872, 265);
            this.groupBox11.TabIndex = 34;
            this.groupBox11.TabStop = false;
            // 
            // lbl_ara_bulunankayit_sayisi
            // 
            this.lbl_ara_bulunankayit_sayisi.AutoSize = true;
            this.lbl_ara_bulunankayit_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ara_bulunankayit_sayisi.Location = new System.Drawing.Point(87, 247);
            this.lbl_ara_bulunankayit_sayisi.Name = "lbl_ara_bulunankayit_sayisi";
            this.lbl_ara_bulunankayit_sayisi.Size = new System.Drawing.Size(16, 17);
            this.lbl_ara_bulunankayit_sayisi.TabIndex = 1;
            this.lbl_ara_bulunankayit_sayisi.Text = "0";
            // 
            // dgv_alt_aramavelisteleme
            // 
            this.dgv_alt_aramavelisteleme.AllowUserToAddRows = false;
            this.dgv_alt_aramavelisteleme.AllowUserToDeleteRows = false;
            this.dgv_alt_aramavelisteleme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_alt_aramavelisteleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alt_aramavelisteleme.Location = new System.Drawing.Point(7, 12);
            this.dgv_alt_aramavelisteleme.Name = "dgv_alt_aramavelisteleme";
            this.dgv_alt_aramavelisteleme.Size = new System.Drawing.Size(859, 233);
            this.dgv_alt_aramavelisteleme.TabIndex = 0;
            this.dgv_alt_aramavelisteleme.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ara_alttaki_cellDoubleClick);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(6, 249);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(75, 13);
            this.label48.TabIndex = 0;
            this.label48.Text = "Bulunan Kayıt:";
            // 
            // tab_alt_loglar
            // 
            this.tab_alt_loglar.Controls.Add(this.tb_logkayitlari);
            this.tab_alt_loglar.Location = new System.Drawing.Point(4, 22);
            this.tab_alt_loglar.Name = "tab_alt_loglar";
            this.tab_alt_loglar.Padding = new System.Windows.Forms.Padding(3);
            this.tab_alt_loglar.Size = new System.Drawing.Size(1354, 278);
            this.tab_alt_loglar.TabIndex = 1;
            this.tab_alt_loglar.Text = "İşlem kayıtları";
            this.tab_alt_loglar.UseVisualStyleBackColor = true;
            // 
            // tb_logkayitlari
            // 
            this.tb_logkayitlari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_logkayitlari.Location = new System.Drawing.Point(6, 7);
            this.tb_logkayitlari.Multiline = true;
            this.tb_logkayitlari.Name = "tb_logkayitlari";
            this.tb_logkayitlari.Size = new System.Drawing.Size(1230, 264);
            this.tb_logkayitlari.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 58);
            this.button1.TabIndex = 42;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 893);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btn_ikaz_lambasi);
            this.Controls.Add(this.lbl_bilgi);
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
            this.tab_talepgiris.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_defterler)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
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
            this.tab_hizlitalep.ResumeLayout(false);
            this.tab_hizlitalep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridSunucuTalepleri)).EndInit();
            this.tab_defterbasim.ResumeLayout(false);
            this.groupBox39.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_talep_defterler_baski)).EndInit();
            this.groupBox38.ResumeLayout(false);
            this.groupBox37.ResumeLayout(false);
            this.groupBox37.PerformLayout();
            this.groupBox35.ResumeLayout(false);
            this.groupBox35.PerformLayout();
            this.groupBox36.ResumeLayout(false);
            this.groupBox36.PerformLayout();
            this.groupBox34.ResumeLayout(false);
            this.groupBox34.PerformLayout();
            this.tab_muhasebe.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muhasebe_odemeler)).EndInit();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muhasebe_borclanmalar)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.tab_digerislemler.ResumeLayout(false);
            this.tab_digerislemler.PerformLayout();
            this.groupBox41.ResumeLayout(false);
            this.groupBox41.PerformLayout();
            this.groupBox40.ResumeLayout(false);
            this.groupBox40.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tab_alt_arama.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.groupBox21.PerformLayout();
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox28.ResumeLayout(false);
            this.groupBox30.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.groupBox29.ResumeLayout(false);
            this.groupBox29.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.groupBox32.ResumeLayout(false);
            this.groupBox32.PerformLayout();
            this.groupBox31.ResumeLayout(false);
            this.groupBox31.PerformLayout();
            this.groupBox27.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alt_aramavelisteleme)).EndInit();
            this.tab_alt_loglar.ResumeLayout(false);
            this.tab_alt_loglar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_yili;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_planbasim;
        private System.Windows.Forms.TabPage tab_defterbasim;
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
        private System.Windows.Forms.TabPage tab_talepgiris;
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
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_talep_sosyalkulupikinciogretmen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_talep_sosyalkulupadi;
        private System.Windows.Forms.Label lbl_talep_sosyalkulupbasimtarihi;
        private System.Windows.Forms.Label lbl_talep_sosyalkuluptaleptatihi;
        private System.Windows.Forms.CheckBox cb_talep_pdf;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.LinkLabel linklbl_kurumkodundanbul;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.LinkLabel linklbl_talep_defterekle;
        private System.Windows.Forms.DataGridView dgv_talep_defterler;
        private System.Windows.Forms.ComboBox cb_talep_defter;
        private System.Windows.Forms.TabPage tab_hizlitalep;
        private System.Windows.Forms.Button btn_taleplerial_sunucudan;
        private System.Windows.Forms.DataGridView datagridSunucuTalepleri;
        private System.Windows.Forms.TextBox tb_bilgi_bayikodu;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView dgv_talep_nobetyerleri;
        private System.Windows.Forms.Label lbl_bekleyin;
        private System.Windows.Forms.TabPage tab_digerislemler;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_1;
        private System.Windows.Forms.LinkLabel linklbl_sablon_nobetyeri_sablonukaydet;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_yeni_sablonadi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linklbl_talep_nobetyeri_sil;
        private System.Windows.Forms.Button btn_taleplerial_excelden;
        private System.Windows.Forms.Button btn_varsayilanlariguncelle;
        private System.Windows.Forms.ComboBox cb_bilgi_ilcesi;
        private System.Windows.Forms.TextBox tb_bilgi_musterino;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cb_bilgi_musterinokilitli;
        private System.Windows.Forms.LinkLabel linklbl_musteri_no_ogrt_bilgisi_getir;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.LinkLabel linklbl_logo_gozat;
        private System.Windows.Forms.TextBox tb_bilgi_logo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbl_bilgi;
        private System.Windows.Forms.TabPage tab_muhasebe;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.LinkLabel linklbl_talep_kulup_sil;
        private System.Windows.Forms.LinkLabel linklbl_talep_kulup;
        private System.Windows.Forms.LinkLabel linklbl_zumre_otomatikgetir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cb_talep_nobetyerisablon;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.LinkLabel linklbl_talep_nobetyeri_ekle;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_11;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_10;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_9;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_8;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tb_sablon_nobetyeri_12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tb_ogrencilistesi_multiline;
        private System.Windows.Forms.LinkLabel linklbl_ogrencilistesikaydet;
        private System.Windows.Forms.Button btn_bilgi_ogrencilistesi;
        private System.Windows.Forms.Label lbl_ogrencilistesikaydedildi;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox tb_muhasebe_toplam_bakiye;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tb_muhasebe_toplam_odeme;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tb_muhasebe_toplam_borc;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.DataGridView dgv_muhasebe_odemeler;
        private System.Windows.Forms.DataGridView dgv_muhasebe_borclanmalar;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.TextBox tb_muhasebe_odemeal_aciklama;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tb_muhasebe_odemeal_odeme_tarihi;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tb_muhasebe_odemeal_odenen_miktar;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.LinkLabel linklbl_muhasebe_odemeal_odeme_kaydet;
        private System.Windows.Forms.ComboBox cb_muhasebe_odemeal_odeme_turu;
        private System.Windows.Forms.Button btn_muhasebe_miktar_uyari_bilgi;
        private System.Windows.Forms.Button btn_ikaz_lambasi;
        private System.Windows.Forms.TextBox tb_hesapozeti_toplambakiye;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tb_hesapozeti_toplamodeme;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tb_hesapozeti_toplamborc;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_alt_arama;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DataGridView dgv_alt_aramavelisteleme;
        private System.Windows.Forms.TabPage tab_alt_loglar;
        private System.Windows.Forms.TextBox tb_logkayitlari;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.CheckBox cb_sil_bilgidisinda_hersey;
        private System.Windows.Forms.CheckBox cb_sil_odemeler;
        private System.Windows.Forms.CheckBox cb_sil_cdpdf;
        private System.Windows.Forms.CheckBox cb_sil_kuluptalebi;
        private System.Windows.Forms.CheckBox cb_sil_ogrencilistesi;
        private System.Windows.Forms.CheckBox cb_sil_zumreler;
        private System.Windows.Forms.CheckBox cb_sil_defterler;
        private System.Windows.Forms.CheckBox cb_sil_serbestetkinlikler;
        private System.Windows.Forms.CheckBox cb_sil_gunlukplanlar;
        private System.Windows.Forms.CheckBox cb_sil_yillikplanlar;
        private System.Windows.Forms.CheckBox cb_sil_hersey;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Button bt_sil_seciliveriler;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox tb_sil_sifre;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.LinkLabel lnklbl_ara_ekurunler;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.RadioButton rb_ara_okumadefteri;
        private System.Windows.Forms.RadioButton rb_ara_sosyalkulup;
        private System.Windows.Forms.RadioButton rb_ara_pdf;
        private System.Windows.Forms.RadioButton rb_ara_cd;
        private System.Windows.Forms.LinkLabel lnklbl_ara_plan;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox26;
        private System.Windows.Forms.ComboBox cb_yil_ara;
        private System.Windows.Forms.RadioButton rb_ara_durum_basilmamis;
        private System.Windows.Forms.RadioButton rb_ara_durum_basilmis;
        private System.Windows.Forms.RadioButton rb_ara_durum_tumu;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.RadioButton rb_ara_ekurun_durum_basilmamis;
        private System.Windows.Forms.RadioButton rb_ara_ekurun_durum_basilmis;
        private System.Windows.Forms.RadioButton rb_ara_ekurun_durum_tumu;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.RadioButton rb_ara_plangunluk;
        private System.Windows.Forms.RadioButton rb_ara_planyillik;
        private System.Windows.Forms.RadioButton rb_ara_plantumu;
        private System.Windows.Forms.Button btn_defter_talepleriniHizliAl;
        private System.Windows.Forms.GroupBox groupBox28;
        private System.Windows.Forms.ComboBox cb_ara_defterturu;
        private System.Windows.Forms.GroupBox groupBox30;
        private System.Windows.Forms.ComboBox cb_yil_ara_defter;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox29;
        private System.Windows.Forms.RadioButton rb_ara_defter_durum_basilmamis;
        private System.Windows.Forms.RadioButton rb_ara_defter_durum_basilmis;
        private System.Windows.Forms.RadioButton rb_ara_defter_durum_tumu;
        private System.Windows.Forms.Label lbl_ara_bulunankayit_sayisi;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.CheckBox cb_defter_mukerrerkayit_izin_ver;
        private System.Windows.Forms.Button bt_mukerrerkayit_izni_cb_bilgi;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox27;
        private System.Windows.Forms.ComboBox cb_yil_ara_bilgileregore;
        private System.Windows.Forms.GroupBox groupBox31;
        private System.Windows.Forms.GroupBox groupBox32;
        private System.Windows.Forms.TextBox tb_yil_ara_musteriadi;
        private System.Windows.Forms.LinkLabel lnklbl_ara_bilgilerle_listele;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.TextBox tb_yil_ara_bilgileregore_bayiadi;
        private System.Windows.Forms.TextBox tb_yil_ara_bilgileregore_okul;
        private System.Windows.Forms.TextBox tb_yil_ara_bilgileregore_ilce;
        private System.Windows.Forms.TextBox tb_yil_ara_bilgileregore_il;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ProgressBar pb_defterhizlikayit;
        private System.Windows.Forms.GroupBox groupBox34;
        private System.Windows.Forms.RadioButton rb_defter_bas_listedesecilikayitlaricinislemyap;
        private System.Windows.Forms.RadioButton rb_defter_bas_ekrandakikayiticinislemyap;
        private System.Windows.Forms.Button bt_defterbas_rb_secenekleri_bilgi;
        private System.Windows.Forms.GroupBox groupBox35;
        private System.Windows.Forms.RadioButton rb_defterbas_secenek_kapakvedefter;
        private System.Windows.Forms.RadioButton rb_defterbas_secenek_defter;
        private System.Windows.Forms.RadioButton rb_defterbas_secenek_kapak;
        private System.Windows.Forms.GroupBox groupBox36;
        private System.Windows.Forms.RadioButton rb_defterbas_tektoplu_toplu;
        private System.Windows.Forms.RadioButton rb_defterbas_tektoplu_tek;
        private System.Windows.Forms.Button bt_bilgi_defterbaskisecenek_1;
        private System.Windows.Forms.Button bt_bilgi_defterbaskisecenek_2_teklitoplu;
        private System.Windows.Forms.GroupBox groupBox37;
        private System.Windows.Forms.Button bt_bilgi_defterbas_sonislem;
        private System.Windows.Forms.RadioButton rb_defterbas_sonislem_yaziciyagonder;
        private System.Windows.Forms.RadioButton rb_defterbas_sonislem_pdftut;
        private System.Windows.Forms.Button bt_defterbas_baskiyabasla;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button bt_varsayilan_kayit_konumu_pdf_degistir;
        private System.Windows.Forms.TextBox tb_varsayilan_kayit_konumu_pdf;
        private System.Windows.Forms.GroupBox groupBox38;
        private System.Windows.Forms.ComboBox cb_baski_basilacak_defterturu;
        private System.Windows.Forms.GroupBox groupBox39;
        private System.Windows.Forms.DataGridView dgv_talep_defterler_baski;
        private System.Windows.Forms.GroupBox groupBox40;
        private System.Windows.Forms.TextBox tb_varsayilan_plankapakyolu;
        private System.Windows.Forms.Button bt_varsayilan_degistir_plankapakyolu;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tb_varsayilan_gunlukplanyolu;
        private System.Windows.Forms.Button bt_varsayilan_degistir_gunlukplanyolu;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox tb_varsayilan_yillikplanyolu;
        private System.Windows.Forms.Button bt_varsayilan_degistir_yillikplanyolu;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox tb_varsayilan_kayit_planyolu_pdf;
        private System.Windows.Forms.Button bt_varsayilan_degistir_basimsonu_planpdfyolu;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.GroupBox groupBox41;
        private System.Windows.Forms.TextBox tb_varsayilan_defterkapakyolu;
        private System.Windows.Forms.Button bt_varsayilan_degistir_defterkapakyolu;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox tb_varsayilan_defteryolu;
        private System.Windows.Forms.Button bt_varsayilan_degistir_defteryolu;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button button1;
    }
}

