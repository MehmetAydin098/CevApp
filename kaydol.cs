using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMT110PROJE
{
    public partial class KaydolmaEkrani : Form
    {
        string kullanıcıAdı;
        string şifre;
        public static string eposta;


        public KaydolmaEkrani()
        {
            InitializeComponent();
        }

        private void kaydolButon_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(index.baglantiString);
            baglanti.Open();

            SqlDataAdapter yenidataadaptör = new SqlDataAdapter();

            if (textBoxPassword.Text == textBoxPassword2.Text)
            {
                kullanıcıAdı = textBoxUsername.Text;
                şifre = textBoxPassword.Text;
                eposta = textBoxEmail.Text;

                if (string.IsNullOrWhiteSpace(kullanıcıAdı) || string.IsNullOrWhiteSpace(şifre) || string.IsNullOrWhiteSpace(eposta)) //Girilen verinin boş olup olmadığını kontrol eder
                {
                    MessageBox.Show("Boş alan bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand kullanıcıEkleme = new SqlCommand("insert into tblkullanıcı (kullanıcı_adı,şifre,e_posta,admin) values (@kullanıcıadı,@sifre,@eposta,0)", baglanti); //Textbox'lara girilen verileri SQL tablosuna aktarır

                kullanıcıEkleme.Parameters.AddWithValue("@kullanıcıadı", kullanıcıAdı);
                kullanıcıEkleme.Parameters.AddWithValue("@sifre", şifre);
                kullanıcıEkleme.Parameters.AddWithValue("@eposta", eposta); //Veri tabanındaki parametrelere girilen verilerin değerlerini yerleştirir

                kullanıcıEkleme.ExecuteNonQuery(); //Insert komutunu çalıştırır              
                MessageBox.Show("Kayıt başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayıt oluşturulamadı, Şifreler uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bundan sonraki yazılan kodlar Enter tuşuna basınca sonraki adıma geçmemizi sağlar
        private void enteraTıklamaTextBoxUsername(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxPassword.Select();
            }
        }

        private void enteraTıklamaTextBoxPassword(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxPassword2.Select();
            }
        }

        private void enteraTıklamaTextBoxPassword2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxEmail.Select();
            }
        }

        private void enteraTıklamaTextBoxEmail(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                kaydolButon.PerformClick();
            }
        }


    }
}
