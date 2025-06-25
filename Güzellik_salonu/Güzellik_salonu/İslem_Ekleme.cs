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
    public partial class İslem_Ekleme : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;"); // veri tabanı bağlantı yolu ve con adında sql connection oluşturma
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adptara;
        int ID = 0;
        public İslem_Ekleme()
        {
            InitializeComponent();
        }

        private void İslem_Ekleme_Load(object sender, EventArgs e)
        {
            VerileriTazele();
        }
        public void VerileriTazele()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from İslemler_tbl", con);// işlemler tablosundaki veriler
            adapt.Fill(dt);//verileri datatabel'a doldurma
            dataGridView1.DataSource = dt;//dgv'i dt (veri kaynağı) ile eşledim
        }

        private void btngeri_Click(object sender, EventArgs e) // önceki ekrana randevu ekranına dön
        {
            var result = MessageBox.Show("Randevu Ekranına Dönülüyor", "Randevu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Randevu frmr = new Randevu();
                this.Close();
                frmr.Show();

            }
        }
        private void temizle()
        {
            txtislemad.Clear();
            txtislemfiyat.Clear();
        }
        private void veriara()
        {
            con.Open();
            string ara = txtara.Text.Trim(); // boşlukları algılamaz
            DataTable dtara = new DataTable();
            adptara = new SqlDataAdapter("select * from İslemler_tbl where İslemAdi like '%" + ara + "%'", con);
            adptara.Fill(dtara);
            dataGridView1.DataSource = dtara;
            con.Close();
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            veriara();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtislemad.Text != "" && txtislemfiyat.Text != "")
            {
                cmd = new SqlCommand("insert into İslemler_tbl(İslemAdi,İslemFiyati) values(@islemad,@islemfiyat)", con);//texboxa girilen değerler işlem tablosuna ekleniyor
                con.Open();
                cmd.Parameters.AddWithValue("@islemad", txtislemad.Text);
                cmd.Parameters.AddWithValue("@islemfiyat", txtislemfiyat.Text);
                cmd.ExecuteNonQuery();
                VerileriTazele();
                //MessageBox.Show("İşlem Başarılı Bir Şekilde Eklendi");
                temizle();
                con.Close();

            }
            else MessageBox.Show("Lütfen verileri eksiksiz giriniz");
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (txtislemad.Text != "" && txtislemfiyat.Text != "")
            {
                cmd = new SqlCommand("update İslemler_tbl set İslemAdi=@islemad,İslemFiyati=@islemfiyat where İslemlerID=@ID", con); //işlemler tablosundaki verileri textboxtaki verilerle değiştime
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@islemad", txtislemad.Text);
                cmd.Parameters.AddWithValue("@islemfiyat", txtislemfiyat.Text);
                cmd.ExecuteNonQuery();
                VerileriTazele();
                //MessageBox.Show("İşlem Başarılı Bir Şekilde Eklendi");
                temizle();
                con.Close();

            }
            else MessageBox.Show("Lütfen verileri eksiksiz giriniz");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
                if (ID != 0)
                {
                    cmd = new SqlCommand("delete İslemler_tbl where İslemlerID=@ID", con);//datagridview'den seçilen kaydı silme ıd ye göre silme yapıyoruz 
                    con.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    VerileriTazele();
                    temizle();
                    MessageBox.Show("seçili kayıt silindi");
                }
                else MessageBox.Show("lütfen kayıt seçiniz");
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());//datagridview'den seçilen kaydı texboxa getirme
            txtislemad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtislemfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
