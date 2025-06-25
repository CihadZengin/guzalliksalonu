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
    public partial class Urunler : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;"); // veri tabanı bağlantı yolu ve con adında sql connection oluşturma
        SqlCommand cmd;//sorguları çalıştırmak için kullandığımız kod 
        SqlDataAdapter adapt;
        SqlDataAdapter adptara;
        int ID = 0; // ıd yi belirtmek için kullanılır
        public Urunler()
        {
            InitializeComponent();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Randevu Ekranına Dönülüyor", "Randevu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Randevu frmr = new Randevu();
                this.Close();
                frmr.Show();

            }
        }
        public void VerileriTazele()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Urunlar_tbl", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            // buradaki kod verileri tazelemek için sürekli döngü yapar
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            VerileriTazele();
            // hocam sayfa açıldığı zaman tablomdaki verilerin gelmesi ve güncellenmesi için
        }
        private void temizle()
        {
            txtuad.Clear();
            txtufiyat.Clear();
            txttür.Clear();
            txtstok.Clear();
            // veri ekleme silme ve güncelleme sonunda textbox ların içindeki yazılar silinir
        }
        private void veriara()
        {
            con.Open();
            string ara = txtara.Text.Trim();// boşlukları görmezden gelir
            DataTable dtara = new DataTable();
            adptara = new SqlDataAdapter("select * from Urunlar_tbl where UrunAdi like '%" + ara + "%' or UrununTuru like '%" + ara + "%'", con);// urunun adına veya urununturune göre arama yapar içinde geçen kelimlere göre listeler
            adptara.Fill(dtara);// databaseye gider verileri alır gelir
            dataGridView1.DataSource = dtara;// verileri buraya yazar -datagridwiev1-
            con.Close();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            veriara();// textbox un içinde yazılanı ara 
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtuad.Text != "" && txtufiyat.Text != "" && txttür.Text != "" && txtstok.Text != "")// Text box ların içi boş olamaz
            {
                cmd = new SqlCommand("insert into Urunlar_tbl(UrunAdi , UrununFiyati , UrununTuru , StokAdedi) values (@uad , @ufiyat , @utur , @sadedi)", con);// kaydetmek için kullanılan sql sorgusu
                con.Open();
                cmd.Parameters.AddWithValue("@uad", txtuad.Text);//txtuad a girilen kelimler @uad dır bunu tabloya ekleme parametresi
                cmd.Parameters.AddWithValue("@ufiyat", txtufiyat.Text);
                cmd.Parameters.AddWithValue("@utur", txttür.Text);
                cmd.Parameters.AddWithValue("@sadedi", txtstok.Text);
                cmd.ExecuteNonQuery(); // bu değerleri tabloya kaydet
                VerileriTazele();
                //MessageBox.Show("Ürün Başarılı Bir Şekilde Eklendi");
                temizle();
                con.Close();
            }
            else MessageBox.Show("Lütfen Bilgileri Eksiksiz Bir Biçimde Doldurunuz");
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (txtuad.Text != "" && txtufiyat.Text != "" && txttür.Text != "" && txtstok.Text != "")
            {
                cmd = new SqlCommand("update Urunlar_tbl set UrunAdi=@uad , UrununFiyati=@ufiyat,UrununTuru=@utur,StokAdedi=@sadedi where UrunID=@ID", con);// düzenlemek için kullanılan sql sorgusu
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);// seçilen ürünün yani satırın ıd sini tutmak için kullanılır ve ıd ye göre düzenleme yapılır
                cmd.Parameters.AddWithValue("@uad", txtuad.Text);
                cmd.Parameters.AddWithValue("@ufiyat", txtufiyat.Text);
                cmd.Parameters.AddWithValue("@utur", txttür.Text);
                cmd.Parameters.AddWithValue("@sadedi", txtstok.Text);
                cmd.ExecuteNonQuery();
                VerileriTazele();
                //MessageBox.Show("Ürün Başarılı Bir Şekilde güncellendi");
                temizle();
                con.Close();
            }
            else MessageBox.Show("Lütfen Bilgileri Eksiksiz Bir Biçimde Doldurunuz");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (ID != 0)// kayıt seçilmiş ise
            {
                cmd = new SqlCommand("delete Urunlar_tbl where UrunID=@ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);// seçilen satırdaki veriyi sil
                cmd.ExecuteNonQuery();
                VerileriTazele();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi");
                temizle();
                con.Close();
            }
            else MessageBox.Show("Lütfen Bir Kayıt Seçiniz");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()); 
            txtuad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();// datagridwiev de seçilen satırdaki kolondaki değerleri textboxlara götür
            txtufiyat.Text = dataGridView1.Rows[e.RowIndex ].Cells[2].Value.ToString();
            txttür.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtstok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
