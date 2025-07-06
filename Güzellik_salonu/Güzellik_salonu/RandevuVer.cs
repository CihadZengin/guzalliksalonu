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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Güzellik_salonu
{
    public partial class RandevuVer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;");//connection string
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataAdapter adptara;
        public RandevuVer()
        {
            InitializeComponent();
        }
        private void verileritazele()
        {
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Tarih,Saatler as Saat,MusteriAdi,MusteriSoyadi,MusteriCinsiyeti as cinsiyet,TelefonNumarasi,İslemAdi as islem , İslemFiyati from Randevu_tbl\r\ninner join Musteri_tbl on MusteriID=RmID\r\ninner join İslemler_tbl on İslemlerID=RiID\r\ninner join Tarih_tbl on TarihID=RtID\r\ninner join Saat_tbl on SaatID=RsID\r\norder by Tarih,Saat\r\n", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void RandevuVer_Load(object sender, EventArgs e)
        {
            verileritazele();
            fillcombobaxmusteri();// müşteri tablosundaki kişilerin adlarını combobax ın içine listeliyoruz
            FillislemComboBox();// işlem tablosundaki işlemlerin adlarını combobax ın içine listeliyoruz
            FillHourComboBox();// işlem tablosundaki işlemlerin adlarını combobax ın içine listeliyoruz
            date.Format = DateTimePickerFormat.Custom; // Özel format
            date.CustomFormat = "dd-MM-yyyy"; // Gün-ay-yıl
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Anasayfa Ekranına Dönüş Yapmak İstiyor Musunuz?", "Önceki Ekrana Dön", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Randevu rndvu = new Randevu();
                rndvu.Show();
                this.Close();
            }
        }
        private void fillcombobaxmusteri() // müşteri tablosundaki kişilerin adlarını combobax ın içine listeliyoruz
        {
            string connectionString = "Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MusteriAdi FROM Musteri_tbl";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) //yeniliyoruz
                    {
                        txtmadi.Items.Add(reader["MusteriAdi"].ToString());
                    }
                    con.Close();
                }
            }
        }
        private void FillislemComboBox()// işlem tablosundaki işlemlerin adlarını combobax ın içine ekliyoruz
        {
            string connectionString = "Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT İslemAdi FROM İslemler_tbl";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtiadi.Items.Add(reader["İslemAdi"].ToString());
                    }
                }
            }
        }
        private void FillHourComboBox()// saatler tablosundaki saatleri  combobax ın içine listeliyoruz
        {
            string connectionString = "Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SaatID, Saatler FROM Saat_tbl"; // Tüm saatleri çekiyoruz

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txtsaat.Items.Add(reader["Saatler"].ToString()); // Saat değerlerini ComboBox'a ekle
                    }
                }
            }
        }
        private void GetCustomerInfomusteri(string madi)//müşterinin adını seçtikten sonra geri kalan bilgilerini textbox un içine yazdırıyoruz
        {
            string connectionString = "Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MusteriSoyadi, MusteriCinsiyeti,TelefonNumarasi FROM Musteri_tbl WHERE MusteriAdi  = @madi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@madi", madi);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txtmsoyadi.Text = reader["MusteriSoyadi"].ToString();
                        txtmcinsiyet.Text = reader["MusteriCinsiyeti"].ToString();
                        txtmtel.Text = reader["TelefonNumarasi"].ToString();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bilgi bulunamadı!");
                    }
                }
            }
        }
        private void GetTreatmentDetails(string treatmentName)// işlemin adını seçtikten sonra fiyatını textbox a çekmek için kullanıyoruz 
        {
            string connectionString = "Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT İslemFiyati  FROM İslemler_tbl WHERE İslemAdi = @İslemAdi";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@İslemAdi", treatmentName);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {

                        txtifiyat.Text = reader["İslemFiyati"].ToString();
                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("İslem bilgisi bulunamadı!");
                    }
                }
            }
        }
        private void SaveDate(DateTime selectedDate) // tarih kontrolu yapıyoruz tarih varsa  alıyor tarih yoksa yeni tarihi tabloya ekleyor
        {
            string formattedDate = selectedDate.ToString("dd-MM-yyyy");
            string connectionString = "Data Source=.;Initial Catalog=Güzellik_Salonu;Integrated security=true;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tarihi kontrol et
                string checkQuery = "SELECT TarihID FROM tarih_tbl WHERE Tarih = @Tarih";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Tarih", formattedDate);

                    object result = checkCommand.ExecuteScalar(); // Tarih kontrolü yap
                    if (result != null)
                    {
                        // Tarih varsa işlem yapılmaz, otomatik devam eder
                        return;
                    }
                }

                // Yeni tarihi ekle
                string insertQuery = "INSERT INTO tarih_tbl (Tarih) VALUES (@Tarih)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Tarih", formattedDate);
                    insertCommand.ExecuteNonQuery(); // Yeni tarih kaydedilir
                }
            }

        }

        private void txtmadi_SelectedIndexChanged(object sender, EventArgs e)// boş mu dolumu diye bakar değeri kontrol eder ve seçer
        {
            if (txtmadi.SelectedItem == null)
                return;

            string selectedmadi = txtmadi.SelectedItem.ToString();
            GetCustomerInfomusteri(selectedmadi);
        }

        private void txtiadi_SelectedIndexChanged(object sender, EventArgs e)// boş mu dolumu diye bakar değeri kontrol eder ve seçer
        {
            if (txtiadi.SelectedItem == null)
                return;

            string selectedTreatment = txtiadi.SelectedItem.ToString();// boş mu dolumu diye bakar değeri kontrol eder ve seçer
            GetTreatmentDetails(selectedTreatment);
        }

        private void txtsaat_SelectedIndexChanged(object sender, EventArgs e)// boş mu dolumu diye bakar değeri kontrol eder ve seçer
        {
            if (txtsaat.SelectedItem == null)
                return;

            string selectedHour = txtsaat.SelectedItem.ToString();
            // Gerekirse burada işlem yapılabilir
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)// boş mu dolumu diye bakar değeri kontrol eder ve seçer
        {
            if (date == null)
                return;

            DateTime selectedDate = date.Value.Date; // Seçilen tarihi al
            SaveDate(selectedDate); // Tarihi kontrol et ve gerekirse kaydet
        }
        private int GetMusteriID(string madi)// müşterinin adına göre ıd sini alıyor
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT MusteriID FROM Musteri_tbl WHERE MusteriAdi = @ad", connection);
                cmd.Parameters.AddWithValue("@ad", madi);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    id = Convert.ToInt32(result);
            }
            return id;
        }
        private int GetTedaviID(string tedaviAdi) // tedavinin adına göre ıd sini alıyor
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT İslemlerID FROM İslemler_tbl WHERE İslemAdi = @ad", connection);
                cmd.Parameters.AddWithValue("@ad", tedaviAdi);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    id = Convert.ToInt32(result);
            }
            return id;
        }
        private int GetSaatID(string saat)// saatin ıd sini alıyor
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT SaatID FROM Saat_tbl WHERE Saatler = @saat", connection);
                cmd.Parameters.AddWithValue("@saat", saat);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    id = Convert.ToInt32(result);
            }
            return id;
        }
        private int GetTarihID(DateTime tarih) // tarihin ıd sini alıyor
        {
            int id = -1;
            string formattedDate = tarih.ToString("dd-MM-yyyy");
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TarihID FROM Tarih_tbl WHERE Tarih = @tarih", connection);
                cmd.Parameters.AddWithValue("@tarih", formattedDate);
                var result = cmd.ExecuteScalar();
                if (result != null)
                    id = Convert.ToInt32(result);
            }
            return id;
        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            int musteriID = GetMusteriID(txtmadi.Text);// müşterinin adına göre ıd sini alıyor
            int islemID = GetTedaviID(txtiadi.Text);// tedavinin adına göre ıd sini alıyor
            int saatID = GetSaatID(txtsaat.Text);// saatin ıd sini alıyor
            int tarihID = GetTarihID(date.Value);// tarihin ıd sini alıyor

            if (musteriID == -1 || islemID == -1 || saatID == -1 || saatID == -1)// değerler dolu mu boş mu kontrol ediyor dolu ise devam ediyor boş ise devam etmiyor
            {
                MessageBox.Show("Eksik veya hatalı bilgi var!");
                return;
            }
            if (RandevuVarMi(islemID, saatID, tarihID))//işlemde aynı saat tarih var mı kontrol ediyor yok ise devam ediyor var ise hata veriyor
            {
                MessageBox.Show("Bu saatte zaten randevusu var! Lütfen başka bir saat seçin.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Randevu_tbl (RmID, RiID, RtID, RsID) VALUES (@mid, @iid, @tid, @sid)", connection);
                cmd.Parameters.AddWithValue("@mid", musteriID);
                cmd.Parameters.AddWithValue("@iid", islemID);
                cmd.Parameters.AddWithValue("@tid", tarihID);
                cmd.Parameters.AddWithValue("@sid", saatID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Randevu başarıyla eklendi!");
            }
            Temizle();
            verileritazele(); // DataGridView güncellensin
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) //verileri texbox a aktarır 
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtmadi.Text = row.Cells["MusteriAdi"].Value.ToString();
                txtmsoyadi.Text = row.Cells["MusteriSoyadi"].Value.ToString();
                txtmcinsiyet.Text = row.Cells["cinsiyet"].Value.ToString();
                txtmtel.Text = row.Cells["TelefonNumarasi"].Value.ToString();
                txtiadi.Text = row.Cells["islem"].Value.ToString();
                txtifiyat.Text = row.Cells["İslemFiyati"].Value.ToString();
                txtsaat.Text = row.Cells["Saat"].Value.ToString();


                // Tarih düzgün formatta uyarlanamıyorsa
                DateTime parsedDate;
                if (DateTime.TryParse(row.Cells["Tarih"].Value.ToString(), out parsedDate))
                {
                    date.Value = parsedDate;
                }
            }
        }

        private void btndüzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek bir randevu seçin.");
                return;
            }
            int musteriID = GetMusteriID(txtmadi.Text);// buralar yukarısı ile aynı
            int islemID = GetTedaviID(txtiadi.Text);
            int saatID = GetSaatID(txtsaat.Text);
            int tarihID = GetTarihID(date.Value);
            if (musteriID == -1 || islemID == -1 || saatID == -1 || saatID == -1)
            {
                MessageBox.Show("Eksik veya hatalı bilgi var!");
                return;
            }
            if (RandevuVarMi(islemID, saatID, tarihID))
            {
                MessageBox.Show("Bu saatte zaten randevusu var! Lütfen başka bir saat seçin.");
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // datagrid den seçilen veriler
            string selectedmadi = selectedRow.Cells["MusteriAdi"].Value.ToString();
            string selectsaat = selectedRow.Cells["Saat"].Value.ToString();
            string selectedtarih = selectedRow.Cells["Tarih"].Value.ToString();

            int eskiMusteriID = GetMusteriID(selectedmadi);//burada ise eski saat ve tarihi alıyoruz düzenleme yapıoruz
            int eskisaatID = GetSaatID(selectsaat);
            int eskitarihID = GetTarihID(Convert.ToDateTime(selectedtarih));

            int randevuID = -1;
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                SqlCommand getIdCmd = new SqlCommand("SELECT RandevuID FROM Randevu_tbl WHERE RmID = @mid AND RsID = @sid AND RtID = @taid", connection);// burada eski olan veriyi tutuyoruz
                getIdCmd.Parameters.AddWithValue("@mid", eskiMusteriID);
                getIdCmd.Parameters.AddWithValue("@sid", eskisaatID);
                getIdCmd.Parameters.AddWithValue("@taid", eskitarihID);
                var result = getIdCmd.ExecuteScalar();
                if (result != null)
                {
                    randevuID = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Randevu ID bulunamadı.");
                    return;
                }

                // Güncelleme işlemi
                SqlCommand updateCmd = new SqlCommand("UPDATE Randevu_tbl SET RmID=@mid, RiID=@iid, RsID=@sid, RtID=@taid  WHERE RandevuID=@rid", connection);// burada ise tüm verileri eskisi yerine yazdırıyoruz 
                updateCmd.Parameters.AddWithValue("@mid", musteriID);
                updateCmd.Parameters.AddWithValue("@iid", islemID);
                updateCmd.Parameters.AddWithValue("@sid", saatID);
                updateCmd.Parameters.AddWithValue("@taid", tarihID);
                updateCmd.Parameters.AddWithValue("@rid", randevuID);

                updateCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Randevu başarıyla güncellendi!");
            Temizle();
            verileritazele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)// randevu ıd yi seçyoruz
            {
                MessageBox.Show("Lütfen güncellenecek bir randevu seçin.");
                return;
            }
            var confirm = MessageBox.Show("Seçilen randevuyu silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;
           
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // burada seçtiimiz kayıdın verilerini tutuyoruz 
            string selectedmadi = selectedRow.Cells["MusteriAdi"].Value.ToString();
            string selectsaat = selectedRow.Cells["Saat"].Value.ToString();
            string selectedtarih = selectedRow.Cells["Tarih"].Value.ToString();

            int MusteriID = GetMusteriID(selectedmadi);
            int saatID = GetSaatID(selectsaat);
            int tarihID = GetTarihID(Convert.ToDateTime(selectedtarih));

            int randevuID = -1; // seçilen kayıt var ise
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                SqlCommand getIdCmd = new SqlCommand("SELECT RandevuID FROM Randevu_tbl WHERE RmID=@mid AND RsID=@sid AND RtID=@taid", connection);// burada verileri sql e sorgulatıyoruz
                getIdCmd.Parameters.AddWithValue("@mid", MusteriID);
                getIdCmd.Parameters.AddWithValue("@sid", saatID);
                getIdCmd.Parameters.AddWithValue("@taid", tarihID);
                var result = getIdCmd.ExecuteScalar();
                if (result != null)
                {
                    randevuID = Convert.ToInt32(result);
                }
                else
                {
                    MessageBox.Show("Randevu bulunamadı.");
                    return;
                }

                // Silme işlemi
                SqlCommand deleteCmd = new SqlCommand("DELETE FROM Randevu_tbl WHERE RandevuID=@rid", connection);
                deleteCmd.Parameters.AddWithValue("@rid", randevuID);
                deleteCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Randevu başarıyla silindi!");
            Temizle();
            verileritazele();
        }
        private void Temizle()
        {
            // Eventleri geçici olarak kaldır
            txtmadi.SelectedIndexChanged -= txtmadi_SelectedIndexChanged;
            txtiadi.SelectedIndexChanged -= txtiadi_SelectedIndexChanged;

            txtmadi.SelectedIndex = -1;
            txtmsoyadi.Clear();
            txtmtel.Clear();
            txtmcinsiyet.Clear();

            txtiadi.SelectedIndex = -1;
            txtifiyat.Clear();

            txtsaat.SelectedIndex = -1;

            date.Value = DateTime.Now;

            // Eventleri geri bağla
            txtmadi.SelectedIndexChanged += txtmadi_SelectedIndexChanged;
            txtiadi.SelectedIndexChanged += txtiadi_SelectedIndexChanged;
        }
        private bool RandevuVarMi(int islemID, int saatID, int tarihID)
        {
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open(); // burada sorgulamayı yapıyoruz işlemde saat ve tarih aynı var ise kayıt eklemez randevu var hatası alır 
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Randevu_tbl WHERE RiID=@rid AND RsID=@sid AND RtID=@taid", connection))
                {
                    cmd.Parameters.AddWithValue("@rid", islemID);
                    cmd.Parameters.AddWithValue("@sid", saatID);
                    cmd.Parameters.AddWithValue("@taid", tarihID);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0; // Eğer kayıt varsa true döner
                }
            }
        }

    }

}
