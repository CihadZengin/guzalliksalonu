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
    public partial class Müsteri_ekleme : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adptara;
        int ID = 0;
        public Müsteri_ekleme()
        {
            InitializeComponent();
        }

        private void Müsteri_ekleme_Load(object sender, EventArgs e)
        {
            VerileriTazele();
        }
        public void VerileriTazele()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Musteri_tbl", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void temizle()
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            mtxttel.Clear();
        }
        private void veriara()
        {
            con.Open();
            string ara = txtara.Text.Trim();
            DataTable dtara = new DataTable();
            adptara = new SqlDataAdapter("select * from Musteri_tbl where Musteriadi like '%" + ara + "%' or MusteriSoyadi like'%" + ara + "%'  or TelefonNumarasi like'%" + ara + "%'", con);
            adptara.Fill(dtara);
            dataGridView1.DataSource = dtara;
            con.Close();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            veriara();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Randevu Ekranına Dönüş Yapmak İstiyor Musunuz?", "Önceki Ekrana Dön", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Randevu rndvu = new Randevu();
                rndvu.Show();
                this.Close();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtadi.Text != "" && txtsoyadi.Text != "" && mtxttel.Text != "")
            {
                string cinsiyet = "";
                if (radioe.Checked == true)
                {
                    cinsiyet = "erkek";
                }
                else if (radiok.Checked == true)
                {
                    cinsiyet = "kadın";
                }
                cmd = new SqlCommand("insert into Musteri_tbl(MusteriAdi,MusteriSoyadi,MusteriCinsiyeti,TelefonNumarasi) values(@adi,@soyadi,@cinsiyet,@TelefonNumarasi)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@adi", txtadi.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtsoyadi.Text);
                cmd.Parameters.AddWithValue("@TelefonNumarasi", mtxttel.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.ExecuteNonQuery();
                VerileriTazele();
                //MessageBox.Show("Müşteri Başarılı Bir Şekilde Eklendi");
                temizle();
                con.Close();
            }
            else MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (txtadi.Text != "" && txtsoyadi.Text != "" && mtxttel.Text != "")
            {
                string cinsiyet = "";
                if (radioe.Checked == true)
                {
                    cinsiyet = "erkek";
                }
                else if (radiok.Checked == true)
                {
                    cinsiyet = "kadın";
                }
                cmd = new SqlCommand("update Musteri_tbl set MusteriAdi=@adi,MusteriSoyadi=@soyadi,TelefonNumarasi=@TelefonNumarasi,MusteriCinsiyeti=@cinsiyet where MusteriID=@ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@adi", txtadi.Text);
                cmd.Parameters.AddWithValue("@soyadi", txtsoyadi.Text);
                cmd.Parameters.AddWithValue("@TelefonNumarasi", mtxttel.Text);
                cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                cmd.ExecuteNonQuery();
                VerileriTazele();
                //MessageBox.Show("Müşteri Bilgileri Başarılı Bir Şekilde Güncellendi");
                temizle();
                con.Close();
            }
            else MessageBox.Show("Lütfen Tüm Alanları Doldurunuz");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Musteri_tbl where MusteriID=@ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                VerileriTazele();
                temizle();
                MessageBox.Show("Secili Kayıt Başarıyla Silindi");
            }
            else MessageBox.Show("Lütfen Bir Kayıt Seçiniz");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtxttel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
