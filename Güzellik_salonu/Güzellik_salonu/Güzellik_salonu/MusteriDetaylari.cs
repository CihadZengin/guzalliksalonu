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
    public partial class MusteriDetaylari : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;");
        private int musteriIDsi;
        private string MusteriAdi;
        private int secilenBorcID = 0; // dtgBorcDetaylari'nda seçilen borcun ID'sini tutacak
        private int secilenRandevuID = 0; // dtgBorcDetaylari'nda seçilen randevunun ID'sini tutacak
        private int MusteriID = 0;
        public MusteriDetaylari(string musteriAdi)
        {
            InitializeComponent();
            MusteriAdi = musteriAdi;
        }


        private void MusteriDetaylari_Load(object sender, EventArgs e)
        {
            // Hastanın müşteriID'sini almak için yeni bir sorgu
            string getHastaIdQuery = "SELECT MusteriID FROM Musteri_tbl WHERE MusteriAdi = @MusteriAdi";

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;"))
            {
                conn.Open();

                // müterinin ıd'sini al
                using (SqlCommand cmd = new SqlCommand(getHastaIdQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@MusteriAdi", MusteriAdi);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        musteriIDsi = Convert.ToInt32(result);

                    }
                    else
                    {
                        MessageBox.Show("Hata: Musteri ID bulunamadı.");
                        this.Close();
                        return;
                    }
                }

                // Randevuları getir (dataGridView1) - Sadece ilgili sütunları çek
                string query = "select Tarih,Saatler as Saat,RandevuID,MusteriAdi,MusteriSoyadi,MusteriCinsiyeti as cinsiyet,TelefonNumarasi,İslemAdi as islem , İslemFiyati from Randevu_tbl\r\ninner join Musteri_tbl on MusteriID=RmID\r\ninner join İslemler_tbl on İslemlerID=RiID\r\ninner join Tarih_tbl on TarihID=RtID\r\ninner join Saat_tbl on SaatID=RsID\r\n WHERE MusteriAdi = @madi order by Tarih,Saat\r\n";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@madi", MusteriAdi);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);// tabloya gidiyor verileri buluyor
                    dataGridView1.DataSource = dt; // bu arkadaş ise bulunan verileri tabloya getirir uyg çalştr sov yap
                }

            }

        }
        private void BorcuVeritabaninaKaydet()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;"))
            {
                conn.Open();

                if (musteriIDsi == 0)
                {
                    MessageBox.Show("Müşteri ID'si belirlenmeden borç kaydedilemez. Lütfen önce formu yükleyin.");
                    return;
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["RandevuID"].Value != null && row.Cells["İslemFiyati"].Value != null)
                    {
                        int currentRandevuID;
                        decimal currentIslemFiyati;

                        if (int.TryParse(row.Cells["RandevuID"].Value.ToString(), out currentRandevuID) &&
                            decimal.TryParse(row.Cells["İslemFiyati"].Value.ToString(), out currentIslemFiyati))
                        {
                            using (SqlTransaction transaction = conn.BeginTransaction())
                            {
                                try // hata yoksa kayıt ekler veya düzenler 
                                {
                                    string checkQuery = "SELECT COUNT(*) FROM BorcTbl WHERE MID = @mid AND RID = @RandevuID";
                                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction))
                                    {
                                        checkCmd.Parameters.AddWithValue("@mid", musteriIDsi);
                                        checkCmd.Parameters.AddWithValue("@RandevuID", currentRandevuID);
                                        int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                                        if (existingCount > 0)
                                        {
                                            // Borç kaydını güncelle
                                            // Burada odenendiodenmedi sütununu güncellemiyoruz, çünkü ödeme işlemi bu kaydın yapıldığı anda değil,
                                            // sonradan bir eylemle gerçekleşecek. Varsayılan olarak ödenmedi kabul edilebilir (0/false).
                                            string updateQuery = "UPDATE BorcTbl SET ToplamTutar = @ToplamTutar WHERE MID = @mid AND RID = @RandevuID";
                                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                                            {
                                                updateCmd.Parameters.AddWithValue("@mid", musteriIDsi);
                                                updateCmd.Parameters.AddWithValue("@RandevuID", currentRandevuID);
                                                updateCmd.Parameters.AddWithValue("@ToplamTutar", currentIslemFiyati);
                                                updateCmd.ExecuteNonQuery();

                                            }
                                        }
                                        else
                                        {
                                            // Yeni borç kaydı ekle
                                            // odenendiodenmedi varsayılan olarak 0 (False/Ödenmedi) olarak ayarlanır.
                                            string insertQuery = "INSERT INTO BorcTbl (MID, RID, ToplamTutar, odendiodenmedi) VALUES (@mid, @RandevuID, @ToplamTutar, 0)";
                                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                                            {
                                                insertCmd.Parameters.AddWithValue("@mid", musteriIDsi);
                                                insertCmd.Parameters.AddWithValue("@RandevuID", currentRandevuID);
                                                insertCmd.Parameters.AddWithValue("@ToplamTutar", currentIslemFiyati);
                                                insertCmd.ExecuteNonQuery();
                                            }
                                        }
                                    }
                                    transaction.Commit();
                                }
                                catch (Exception ex) // hata var ise Borç bilgileri kaydedilirken hata oluştu: der ve sql hatasını bize yazar 
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Borç bilgileri kaydedilirken hata oluştu: " + ex.Message);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Uyarı: Randevu ID veya İşlem Fiyatı hatalı formatta. RandevuID: {row.Cells["RandevuID"].Value}, IslemFiyati: {row.Cells["IslemFiyati"].Value}");
                        }
                    }
                }
                MessageBox.Show("Borç bilgileri başarıyla kaydedildi/güncellendi.");
            }
        }

        private void btnBorcuKaydet_Click(object sender, EventArgs e)
        {
            BorcuVeritabaninaKaydet();
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

        private void btnOdemeİslemleri_Click(object sender, EventArgs e)
        {
            // `musteri ıd si` ve `musteri adı` form seviyesinde tanımlı olmalı ve RandevuDetayForm'a aktarılmış olmalı.
            if (musteriIDsi == 0 || string.IsNullOrEmpty(MusteriAdi)) //normalde müşteri ı yetiyor ama uyg hata veriyor
            {
                MessageBox.Show("Hasta bilgileri alınamadı. Ödeme işlemleri açılamıyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // OdemeForm'u musterinin adı ve ID'si ile aç
            Odeme odemeForm = new Odeme(MusteriAdi, musteriIDsi);
            odemeForm.ShowDialog(); // Modsal aç, bu form kapanmadan diğerine geçilemez
        }
    }

}

