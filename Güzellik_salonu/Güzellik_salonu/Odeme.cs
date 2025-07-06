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
    public partial class Odeme : Form
    {
        // SQL Bağlantı nesnesi
        private SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;");
        SqlDataAdapter adapt;

        // Mevcut müşterinin ID'sini ve adını tutacak değişkenler
        private int musteriIDsi;
        private string MusteriAdi;
        public Odeme()
        {
            InitializeComponent();
        }
        public Odeme(string Musteriadi, int MusteriID)
        {
            InitializeComponent();
            MusteriAdi = Musteriadi; // Parametreden gelen adı'yi form değişkenine ata
            musteriIDsi = MusteriID; // Parametreden gelen ID'yi form değişkenine ata
            this.Load += Odeme_Load; // Formun Load olayını burada bağla
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;"))
                {
                    string BorcQuery = "select BorcID, MusteriAdi, toplamtutar,odendiodenmedi as [Ödeme Durumu] from BorcTbl\r\ninner join Musteri_tbl on MusteriID = MID WHERE MusteriAdi = @madi";
                    using (SqlCommand cmd = new SqlCommand(BorcQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@madi", MusteriAdi); // BURADA musteriadi'yi kullan!

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dtborc = new DataTable();
                        da.Fill(dtborc);// data gridden veri getirir veriyi bulur
                        dataGridView1.DataSource = dtborc;// gelen verileri datagridin içine doldurur
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Borç detayları yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void verileritazele()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;"))
                {
                    string BorcQuery = "select BorcID, MusteriAdi, toplamtutar,odendiodenmedi as [Ödeme Durumu] from BorcTbl\r\ninner join Musteri_tbl on MusteriID = MID WHERE MusteriAdi = @madi";
                    using (SqlCommand cmd = new SqlCommand(BorcQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@madi", MusteriAdi); // BURADA musteriadi'yi kullan!

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dtborc = new DataTable();
                        da.Fill(dtborc);// data gridden veri getirir veriyi bulur
                        dataGridView1.DataSource = dtborc;// gelen verileri datagridin içine doldurur
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Borç detayları yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnode_Click(object sender, EventArgs e)
        {
            // 1. DataGridView'de bir satır seçili mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 2. Seçili satırdan BorcID'yi al
                // dtgBorclar.SelectedRows[0] -> seçili olan ilk satırı döndürür (MultiSelect=false olduğu için zaten tek satır olacak)
                // .Cells["BorcID"].Value -> seçili satırdaki "BorcID" isimli sütunun değerini alır
                // Convert.ToInt32() -> alınan değeri integer'a çevirir
                int selectedBorcID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BorcID"].Value);

                // 3. Kullanıcıya ödeme onayı sor
                DialogResult dialogResult = MessageBox.Show("Seçili borcu ödemek istediğinizden emin misiniz?", "Borç Ödeme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes) // Eğer kullanıcı "Evet" derse
                {
                    try
                    {
                        // 4. Veritabanı bağlantısını kullanarak UPDATE sorgusu oluştur
                        // odenendiodenmedi sütununu 1 (True) olarak ayarla
                        string updateQuery = "UPDATE BorcTbl SET odendiodenmedi = 1 WHERE BorcID = @borcID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                        {
                            // 5. Parametre olarak seçilen BorcID'yi ekle
                            cmd.Parameters.AddWithValue("@borcID", selectedBorcID);

                            con.Open(); // Veritabanı bağlantısını aç
                            int rowsAffected = cmd.ExecuteNonQuery(); // SQL sorgusunu çalıştır (kaç satır etkilendiğini döndürür)
                            con.Close(); // Veritabanı bağlantısını kapat

                            // 6. İşlem sonucunu kontrol et ve kullanıcıya bilgi ver
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Borç başarıyla ödendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                verileritazele(); // Borç ödendikten sonra DataGridView'i yenile
                                                       // Bu, ödenen borcun listeden kaybolmasını sağlar.
                            }
                            else
                            {
                                MessageBox.Show("Borç ödenirken bir sorun oluştu veya borç bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // 7. Hata durumunda kullanıcıya bilgi ver
                        MessageBox.Show("Borç ödenirken veritabanı hatası oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Her durumda bağlantıyı kapatmaya çalış
                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }
                    }
                }
            }
            else
            {
                // Eğer hiçbir satır seçili değilse kullanıcıya uyarı ver
                MessageBox.Show("Lütfen ödemek istediğiniz borcu listeden seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    

