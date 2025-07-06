using System.Data;
using System.Data.SqlClient;

namespace Güzellik_salonu
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public Form1()
        {
            InitializeComponent();
            txtsifre.PasswordChar = '*'; // uygulama açıldığında şifreyi gizli başlat
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Kapanıyor", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) // uygulamayı kapat
            {
                Application.Exit();
            }
        }
        private void giris()
        {
            string kullanici = txtkullaniciadi.Text;
            string sifre = txtsifre.Text;
            con.Open();
            DataTable dt = new DataTable(kullanici);
            adapt = new SqlDataAdapter("select * from Login_tbl where Kullaniciadi = '" + kullanici + "'and Sifre = '" + sifre + "'", con);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0) // kullanıcı adı şifre doğru ise giriş yap
            {
                MessageBox.Show("Güzellik Şans Değildir Giriş Başarılı");
                Randevu frm2 = new Randevu();
                //this.Hide();
                frm2.ShowDialog();
            }
            else MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış Lütfen Tekrar Deneyiniz"); // yoksa giriş yapma hata ver
            Sil();
            con.Close();
        }
        private void Sil()
        {
            txtkullaniciadi.Clear();
            txtsifre.Clear();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void txtsifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // entere basınca giriş yap 
            {
                giris();
            }
        }

        private void chcsifre_CheckedChanged(object sender, EventArgs e)
        {
            if (chcsifre.Checked) // şifreyi görünür yap
            {
                txtsifre.PasswordChar = '\0';
            }
            else
                txtsifre.PasswordChar = '*'; // şifreyi gizle
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
