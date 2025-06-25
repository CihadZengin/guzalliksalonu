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
    public partial class urunsat : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;"); // veri tabanı bağlantı yolu ve con adında sql connection oluşturma
        SqlCommand cmd;//sorguları çalıştırmak için kullandığımız kod 
        SqlDataAdapter adapt;
        SqlDataAdapter adptara;
        int ID = 0; // ıd yi belirtmek için kullanılır
        public urunsat()
        {
            InitializeComponent();
        }

        private void urunsat_Load(object sender, EventArgs e)
        {
            VerileriTazele();
        }
        public void VerileriTazele()
        {
            DataTable dt = new DataTable(); 
            adapt = new SqlDataAdapter("select * from Urunlar_tbl", con);
            adapt.Fill(dt);// tablodan alıp geliyor
            dataGridView1.DataSource = dt;// artı tabloyu datagride yazar
            // buradaki kod verileri tazelemek için sürekli döngü yapar
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtuad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();// datagridwiev de seçilen satırdaki kolondaki değerleri textboxlara götür
            txtufiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtutur.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtustok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtmiktar_TextChanged(object sender, EventArgs e)//adete göre fiyat çıkarır 
        {
            if (int.TryParse(txtmiktar.Text, out int adet) && decimal.TryParse(txtufiyat.Text, out decimal fiyat))
            {
                txttoplamfiyat.Text = (adet * fiyat).ToString("0.##"); // İsteğe bağlı formatlama
            }
            else
            {
                txttoplamfiyat.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID != 0 && int.TryParse(txtmiktar.Text, out int adetMiktari) && int.TryParse(txtustok.Text, out int mevcutStok))
            {
                if (adetMiktari <= mevcutStok)// mevcut stoğun üstünde satış yapılamaz 
                {
                    int yeniStok = mevcutStok - adetMiktari;

                    con.Open();
                    cmd = new SqlCommand("UPDATE Urunlar_tbl SET StokAdedi = @yeniStok WHERE UrunID = @id", con);
                    cmd.Parameters.AddWithValue("@yeniStok", yeniStok);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Satış işlemi başarılı, stok güncellendi.");
                    VerileriTazele();

                    // Temizle
                    txtmiktar.Clear();
                    txttoplamfiyat.Clear();
                    txtuad.Clear();
                    txtufiyat.Clear();
                    txtutur.Clear();
                    txtustok.Clear();
                    ID = 0;
                }
                else
                {
                    MessageBox.Show("Yetersiz stok! Mevcut stok: " + mevcutStok);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir ürün ve adet girin.");
            }
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
    }
}
