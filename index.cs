using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BMT110PROJE
{
    public partial class index : Form
    {
        public static string baglantiString = "Server=ANKETUYG.mssql.somee.com;Database=ANKETUYG;User Id=mhmtefe2_SQLLogin_1;Password=qmrge3azue;"; //SQL bağlantısı
        public index()
        {
            InitializeComponent();
        }

        private void index_Load(object sender, EventArgs e)
        {
            AnketleriYukle(); //Anketlerin güncel halini yükler
        }

        private void IndexKaydol_Click(object sender, EventArgs e)
        {
            KaydolmaEkrani kaydolmaEkrani = new KaydolmaEkrani();
            kaydolmaEkrani.ShowDialog();
        }

        private void IndexGirisYap_Click(object sender, EventArgs e)
        {
            girisMenu girisMenu = new girisMenu();
            girisMenu.ShowDialog();

            

            if (girisMenu.isloggedin)
            {
                labelUsername.Text = girisMenu.username; //Giriş yapınca kullanıcının ismini ekrana yazdırır
                labelemail.Text = girisMenu.eposta;

                girisYapButon.Visible = false;
                kaydolButon.Visible = false;
                AnketEkle.Visible = true; //Giriş yapınca "Giriş Yap" ve "Kaydol" butonlarını kaldırıp "Anket Ekle" butonunu aktif eder
                cikisYap.Visible = true;
            }
        }

        private void IndexAnketEkle_Click(object sender, EventArgs e)
        {
            AnketEkle anketEkle = new AnketEkle();
            anketEkle.Show();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            AnketleriYukle(); //Anketlerin güncel halini yükler
        }

        private void cikisYap_Click(object sender, EventArgs e)
        {
            labelUsername.Text = "-";
            labelemail.Text = "-";
            girisMenu.isloggedin = false;
            AnketEkle.Visible = false;
            cikisYap.Visible = false;
            girisYapButon.Visible = true;
            kaydolButon.Visible = true;
            

        }

        private void AnketleriYukle()
        {
            flowLayoutPanelSorular.Controls.Clear();

            

            using (SqlConnection baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("SELECT AnketID, Soru FROM AnketSorulari ORDER BY AnketID ASC", baglanti); //Soruları getiren sorgu
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int anketId = reader.GetInt32(0); //Veri tabanındaki tablonun 1. satırını okur (Id bilgisi)
                    string soru = reader.GetString(1); //Veri tabanındaki tablonun 2. satırını okur (Anketlerin isimleri)

                    Button soruButon = new Button(); //Yeni butonlar oluşturup özelliklerini ayarlıyoruz
                    soruButon.Text = soru;
                    soruButon.Tag = anketId;
                    soruButon.Width = flowLayoutPanelSorular.Width - 17;
                    soruButon.Height = 70;
                    soruButon.Margin = new Padding(0);
                    soruButon.BackColor = Color.AliceBlue;
                    soruButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    soruButon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    soruButon.Cursor = System.Windows.Forms.Cursors.Hand;

                    soruButon.Click += SoruButon_Click; //Butona tıklanınca metodu çalıştırır

                    flowLayoutPanelSorular.Controls.Add(soruButon); //Butonları flowlayoutpanel'e ekler
                    flowLayoutPanelSorular.Controls.SetChildIndex(soruButon, 0); //Eklenen butonu 0. sıraya (en başa) koyar
                }

                reader.Close();
            }
        }

        private void SoruButon_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int anketId = (int)btn.Tag; //Butona tıklayınca o butona ait soruyu getirir

            AnketOy Oy_Verme_Ekrani = new AnketOy(anketId);
            Oy_Verme_Ekrani.Show();
        }

        private void Hakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Muhammed, Aydın, Efe ,Yusuf");
        }
    }
}
