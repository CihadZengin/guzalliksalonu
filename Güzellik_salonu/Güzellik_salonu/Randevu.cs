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

namespace Güzellik_salonu
{
    public partial class Randevu : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adptara;
        public Randevu()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamayı kapatmak istiyor musunuz?", "Kapanıyor", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Giriş Ekranına Dönüş Yapmak İstiyor Musunuz?", "Önceki Ekrana Dön", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Close();
            }
        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Tarih,Saatler as Saat,MusteriAdi,MusteriSoyadi,MusteriCinsiyeti as cinsiyet,TelefonNumarasi,İslemAdi as islem from Randevu_tbl\r\ninner join Musteri_tbl on MusteriID=RmID\r\ninner join İslemler_tbl on İslemlerID=RiID\r\ninner join Tarih_tbl on TarihID=RtID\r\ninner join Saat_tbl on SaatID=RsID\r\norder by Tarih,Saat\r\n", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            araislemi();
        }

        private void araislemi()
        {
            con.Open();
            string ara = txtara.Text.Trim();
            DataTable dtara = new DataTable();
            adptara = new SqlDataAdapter("select Tarih,Saatler as Saat,MusteriAdi,MusteriSoyadi,MusteriCinsiyeti as cinsiyet,TelefonNumarasi,İslemAdi as islem from Randevu_tbl\r\ninner join Musteri_tbl on MusteriID=RmID\r\ninner join İslemler_tbl on İslemlerID=RiID inner join Tarih_tbl on TarihID=RtID\r\ninner join Saat_tbl on SaatID=RsID \r\n where MusteriAdi like '%" + ara + "%' or MusteriSoyadi like '%" + ara + "%' or TelefonNumarasi like '%" + ara + "%'\r\norder by Tarih,Saat", con);
            adptara.Fill(dtara);
            dataGridView1.DataSource = dtara;
            con.Close();
        }

        private void btnmusteri_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Müşteri Ekleme Ekranına Geçiliyor", "Müsteri Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Müsteri_ekleme frmmekle = new Müsteri_ekleme();
                //this.Close();
                frmmekle.Show();

            }
        }

        private void btnislem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("İşlem Ekleme Ekranına Geçiliyor", "İşlem Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                İslem_Ekleme isleme = new İslem_Ekleme();
                //this.Close();
                isleme.Show();

            }
        }

        private void btnyetkili_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Admin Ekranına Giriş Yapılıyor Lütfen Tüm Kullanıcıları Silmeyiniz Ekleme Yaparken Dikkatli Olmanızı Önemle Rica Ederiz", "Admin Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Admin_ekle Admin = new Admin_ekle();
                //this.Close();
                Admin.Show();

            }
        }

        private void btnurunler_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ürünler Ekranına Giriş Yapılıyor ", "Ürün Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Urunler urn = new Urunler();
                //this.Close();
                urn.Show();

            }
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ürünler Ekranına Giriş Yapılıyor ", "Ürün Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                RandevuVer rv = new RandevuVer();
                //this.Close();
                rv.Show();

            }
        }

        private void btnurunsat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ürünler Ekranına Giriş Yapılıyor ", "Ürün Ekleme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                urunsat usat = new urunsat();
                //this.Close();
                usat.Show();

            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satıra tıklandığından emin ol
            {
                string Musteriadi = dataGridView1.Rows[e.RowIndex].Cells["MusteriAdi"].Value.ToString(); // müşteri adi'yi al

                // Yeni formu aç ve müşteri adi'yi gönder
                MusteriDetaylari mForm = new MusteriDetaylari(Musteriadi);// müşterinin adını diğer forma gönder
                //this.Close();
                mForm.Show();
            }
        }
    }
}
