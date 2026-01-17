using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMT110PROJE
{
    public partial class AnketOy : Form
    {

        public static int seceneklerid = 0;
        public int seceneksıralama;

        public AnketOy(int anketId)
        {
            InitializeComponent();
            labelSoru.Tag = anketId;
        }

        private void AnketOy_Load(object sender, EventArgs e)
        {
            SecenekleriYukle();

            

            SqlConnection baglanti = new SqlConnection(index.baglantiString);
            baglanti.Open();

            SqlCommand girilensoruyubul = new SqlCommand("SELECT Soru FROM AnketSorulari WHERE AnketID = @id", baglanti);
            girilensoruyubul.Parameters.AddWithValue("@id", labelSoru.Tag);

            string soru = girilensoruyubul.ExecuteScalar().ToString();

            labelSoru.Text = soru;

            baglanti.Close();
        }

        public void SecenekleriYukle()
        {
            flowLayoutPanelSecenekler.Controls.Clear();
            
            SqlConnection baglanti = new SqlConnection(index.baglantiString);
            baglanti.Open();

            string siralamasecenekler;
            switch (seceneksıralama)
            {
                case 1: siralamasecenekler = "SELECT * FROM AnketSecenekleri WHERE SoruID = @Soruid ORDER BY ID DESC"; break; //Kullanıcının ekleme sırasına göre sıralama
                case 2: siralamasecenekler = "SELECT * FROM AnketSecenekleri WHERE SoruID = @Soruid ORDER BY secenek DESC"; break; //Alfabetik sıralama
                default: siralamasecenekler = "SELECT * FROM AnketSecenekleri WHERE SoruID = @Soruid ORDER BY ID DESC"; break; //Varsayılan(kullanıcının ekleme sırası) sıralama
            }

            SqlCommand cmdSecenek = new SqlCommand(siralamasecenekler, baglanti);
            cmdSecenek.Parameters.AddWithValue("@Soruid", labelSoru.Tag.ToString());

            SqlDataReader readerSecenek = cmdSecenek.ExecuteReader();
            while (readerSecenek.Read())
            {
                int ID = readerSecenek.GetInt32(0);
                int SoruID = readerSecenek.GetInt32(1);
                string cevaplar = readerSecenek.GetString(2);

                RadioButton Secenek = new RadioButton();
                Secenek.Text = cevaplar;
                Secenek.Tag = ID;
                Secenek.Width = 200;
                Secenek.Height = 30;
                Secenek.Margin = new Padding(0);
                Secenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Secenek.CheckedChanged += new System.EventHandler(Secenek_CheckedChanged);

                flowLayoutPanelSecenekler.Controls.Add(Secenek);
                flowLayoutPanelSecenekler.Controls.SetChildIndex(Secenek, 0);
            }
            readerSecenek.Close();

            List<int> secenekIDListesi = new List<int>();
            secenekIDListesi.Clear();

            string siralamaYuzdelik;
            switch (seceneksıralama)
            {
                case 1: siralamaYuzdelik = "SELECT * FROM AnketSecenekleri WHERE SoruID = @Soruid ORDER BY ID DESC"; break;
                case 2: siralamaYuzdelik = "SELECT * FROM AnketSecenekleri WHERE SoruID = @Soruid ORDER BY secenek DESC"; break;
                default: siralamaYuzdelik = "SELECT * FROM AnketSecenekleri WHERE SoruID = @Soruid ORDER BY ID DESC"; break;
            }

            SqlCommand cmdYuzdelik = new SqlCommand(siralamaYuzdelik, baglanti);
            cmdYuzdelik.Parameters.AddWithValue("@Soruid", labelSoru.Tag.ToString());
            SqlDataReader readerYuzdelik = cmdYuzdelik.ExecuteReader();

            while (readerYuzdelik.Read())
            {
                int ID = readerYuzdelik.GetInt32(0);
                secenekIDListesi.Add(ID);
            }
            readerYuzdelik.Close(); // <-- reader kapandıktan sonra ExecuteScalar yapılabilir

            flowLayoutPanelYuzde.Controls.Clear();

            foreach (int ID in secenekIDListesi)
            {
                SqlCommand cmdSecilenOy = new SqlCommand("SELECT COUNT(*) FROM Oylar WHERE SecenekID = @Secenek", baglanti);
                cmdSecilenOy.Parameters.AddWithValue("@Secenek", ID);

                SqlCommand cmdToplamOy = new SqlCommand("SELECT COUNT(*) FROM Oylar WHERE SoruID = @Soru", baglanti);
                cmdToplamOy.Parameters.AddWithValue("@Soru", labelSoru.Tag.ToString());

                int secilenOy = (int)cmdSecilenOy.ExecuteScalar();
                int toplamOy = (int)cmdToplamOy.ExecuteScalar();

                int yuzdelik;
                if (toplamOy > 0)
                {
                    yuzdelik = 100 * secilenOy / toplamOy;
                }
                else
                {
                    yuzdelik = 0;
                }

                ProgressBar Yuzde = new ProgressBar();
                Yuzde.Value = Math.Min(100, yuzdelik);
                Yuzde.Width = 100;
                Yuzde.Height = 30;
                Yuzde.Margin = new Padding(0);

                System.Windows.Forms.Label YuzdeLabel = new System.Windows.Forms.Label();
                YuzdeLabel.Text = "%" + yuzdelik;
                YuzdeLabel.Width = 100;
                YuzdeLabel.Height = 30;
                YuzdeLabel.Margin = new Padding(0);
                YuzdeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                System.Windows.Forms.Label sayilabel = new System.Windows.Forms.Label();
                sayilabel.Text = secilenOy + " kişi";
                sayilabel.Width = 100;
                sayilabel.Height = 30;
                sayilabel.Margin = new Padding(0);
                sayilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                toplamOylabel.Text = toplamOy.ToString();


                flowLayoutPanelYuzde.Controls.Add(sayilabel);
                flowLayoutPanelYuzde.Controls.SetChildIndex(sayilabel, 0);

                flowLayoutPanelYuzde.Controls.Add(YuzdeLabel);
                flowLayoutPanelYuzde.Controls.SetChildIndex(YuzdeLabel, 0);

                flowLayoutPanelYuzde.Controls.Add(Yuzde);
                flowLayoutPanelYuzde.Controls.SetChildIndex(Yuzde, 0);

            }

            baglanti.Close();
        }

        private void OyVer_Click(object sender, EventArgs e)
        {
            if (girisMenu.isloggedin)
            {
                if (seceneklerid == 0)
                {
                    MessageBox.Show("LÜTFEN BİR SEÇENEK SEÇİN");
                }
                else
                {
                    SqlConnection baglanti = new SqlConnection(index.baglantiString);
                    baglanti.Open();

                    SqlCommand kullaniciOyKontrol = new SqlCommand("SELECT COUNT(*) FROM Oylar WHERE KullanıcıID = @KullaniciID AND SoruID = @SoruID", baglanti);
                    kullaniciOyKontrol.Parameters.AddWithValue("@KullaniciID", girisMenu.kullaniciid);
                    kullaniciOyKontrol.Parameters.AddWithValue("@SoruID", labelSoru.Tag);

                    if ((int)kullaniciOyKontrol.ExecuteScalar() == 0)
                    {
                        SqlCommand oyVerme = new SqlCommand("INSERT INTO Oylar(KullanıcıID,SoruID,SecenekID) VALUES (@KullaniciID,@SoruID,@SecenekID)", baglanti);

                        oyVerme.Parameters.AddWithValue("@KullaniciID", girisMenu.kullaniciid);
                        oyVerme.Parameters.AddWithValue("@SoruID", labelSoru.Tag);
                        oyVerme.Parameters.AddWithValue("@SecenekID", seceneklerid);
                        oyVerme.ExecuteNonQuery();
                        oyKaydedildi.Text = "Seçiminiz Başarıyla Kaydedildi";
                        oyKaydedildi.Visible = true;
                        seceneklerid = 0;

                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Daha Önce Bu Soruya Oy Vermişsiniz.");

                        baglanti.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce giriş yapınız.");
            }

            SecenekleriYukle();
        }

        private void Secenek_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            seceneklerid = (int)btn.Tag;
        }

        private void radioButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            seceneksıralama = 1;
            SecenekleriYukle();
        }

        private void radioButtonAlfabetik_CheckedChanged(object sender, EventArgs e)
        {
            seceneksıralama = 2;
            SecenekleriYukle();
        }

    }
}
