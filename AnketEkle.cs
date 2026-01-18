using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMT110PROJE
{
    public partial class AnketEkle : Form
    {
        public AnketEkle()
        {
            InitializeComponent();
        }

        

        private void SecenegiKaydetButonu(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrWhiteSpace(textBoxSecenek.Text)) //Textbox boş değilse butona basınca listbox'a veri ekler
                {
                    listBoxSecenek.Items.Add(textBoxSecenek.Text);
                    textBoxSecenek.Clear();
                }
                else
                {
                    MessageBox.Show("Boş seçenek eklenemez!");
                }
            
        }

        private void anketKaydetButon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSoru.Text))
            
            {
                string soru = textBoxSoru.Text;

                using (SqlConnection conn = new SqlConnection(index.baglantiString)) //Using, blok tamamlanınca bağlantıyı kapatır ve temizler.
                {
                    conn.Open();

                    string insertSoru = "INSERT INTO AnketSorulari(Soru) OUTPUT INSERTED.AnketID VALUES (@soru)"; //Yeni soru ekler ve sorunun AnketID değerini döndürür.
                    SqlCommand cmdSoru = new SqlCommand(insertSoru, conn);

                    cmdSoru.Parameters.AddWithValue("@soru", soru); ///Veri tabanındaki parametrelere girilen verilerin değerlerini yerleştirir

                    int soruID = (int)cmdSoru.ExecuteScalar(); //Döndürülen AnketID değerini soruID değişkenine atar

                    foreach (var item in listBoxSecenek.Items)
                    {
                        string insertSecenek = "INSERT INTO AnketSecenekleri(SoruID, Secenek) VALUES (@soruID, @secenek)"; //Seçenekleri veri tabanına ekler
                        SqlCommand cmdSecenek = new SqlCommand(insertSecenek, conn);

                        cmdSecenek.Parameters.AddWithValue("@soruID", soruID);
                        cmdSecenek.Parameters.AddWithValue("@secenek", item.ToString()); ///Veri tabanındaki parametrelere girilen verilerin değerlerini yerleştirir

                        cmdSecenek.ExecuteNonQuery(); //Insert komutunu çalıştırır
                    }

                    MessageBox.Show("Anket başarıyla kaydedildi!");
                    this.Close();
                }
            } 
            else
            {
                MessageBox.Show("Boş soru eklenemez!");
            }
        }

        private void enterabasma_soru(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxSecenek.Select();
            }
        }

        private void enterabasma_secenek(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                secenekEkleButon.PerformClick();
            }
        }
    }
}
