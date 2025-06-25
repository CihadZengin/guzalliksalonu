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
    public partial class Admin_ekle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adptara;
        int ID = 0;
        public Admin_ekle()
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
            adapt = new SqlDataAdapter("select * from Login_tbl", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Admin_ekle_Load(object sender, EventArgs e)
        {
            VerileriTazele();
        }
        private void temizle()
        {
            txtkullanıciadi.Clear();
            txtsifre.Clear();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Login_tbl(KullaniciAdi,sifre) values(@Kullaniciadi,@Sifre)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Kullaniciadi", txtkullanıciadi.Text);
            cmd.Parameters.AddWithValue("@Sifre", txtsifre.Text);
            cmd.ExecuteNonQuery();
            VerileriTazele();
            //MessageBox.Show("İşlem Başarılı Bir Şekilde Eklendi");
            temizle();
            con.Close();
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (txtkullanıciadi.Text != "" && txtsifre.Text != "")
            {
                cmd = new SqlCommand("update Login_tbl set KullaniciAdi=@kullaniciadi,sifre=@sifre where LoginID=@ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@kullaniciadi", txtkullanıciadi.Text);
                cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);
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
                cmd = new SqlCommand("delete Login_tbl where LoginID=@ID", con);
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
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtkullanıciadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
