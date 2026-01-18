using BMT110PROJE.ANKETUYGDataSetTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMT110PROJE
{
    public partial class girisMenu : Form
    {
        public static bool isloggedin = false; //Giriş yapılıp yapılmadığını tutan değişken
        public string username; //Başka formda da kullanılacağı için bu değişken public
        public static int kullaniciid;
        public static string eposta;
        public girisMenu()
        {
            InitializeComponent();
        }

        

        private void GirisYap_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            SqlConnection baglanti = new SqlConnection(index.baglantiString);
            baglanti.Open();

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblkullanıcı WHERE kullanıcı_adı = @Username AND şifre = @Password", baglanti); //Girilen verilerin veri tabanında olup olmadığını kontrol eder
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password); //Veri tabanındaki parametrelere girilen verilerin değerlerini yerleştirir

            int result = (int)command.ExecuteScalar(); //ExecuteScalar,eşleşen veri sayısını verir; eğer eşleşen veri varsa "result" sıfırdan büyük olur

            if (result > 0)  // Kullanıcı adı ve şifre doğruysa giriş yapar ve giriş yapma formunu kapanır
            {
                SqlCommand kullanıcıidsinialmakomutu = new SqlCommand("SELECT ID FROM tblkullanıcı WHERE kullanıcı_adı = @Username ", baglanti);
                kullanıcıidsinialmakomutu.Parameters.AddWithValue("@Username", username);
                kullaniciid = (int)kullanıcıidsinialmakomutu.ExecuteScalar();
                isloggedin = true;
                SqlCommand epostaalmakomutu = new SqlCommand("SELECT e_posta FROM tblkullanıcı WHERE kullanıcı_adı = @Username ", baglanti);
                epostaalmakomutu.Parameters.AddWithValue("@Username", username);
                eposta = epostaalmakomutu.ExecuteScalar().ToString();
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                username = "-";
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baglanti.Close();
        }

        // Bundan sonraki yazılan kodlar Enter tuşuna basınca sonraki adıma geçmemizi sağlar

        private void entera_tıklama_textBoxUsername(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxPassword.Select();
            }
        }

        private void entera_tıklama_textBoxPassword(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                GirisYap.PerformClick();
            }
        }
    }
}
