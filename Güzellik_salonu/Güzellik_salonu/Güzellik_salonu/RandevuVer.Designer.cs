namespace Güzellik_salonu
{
    partial class RandevuVer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            txtmadi = new ComboBox();
            txtmtel = new TextBox();
            lbltelno = new Label();
            txtmcinsiyet = new TextBox();
            lblcinsiyet = new Label();
            txtmsoyadi = new TextBox();
            lblsoyad = new Label();
            lblad = new Label();
            groupBox3 = new GroupBox();
            txtsaat = new ComboBox();
            txtiadi = new ComboBox();
            date = new DateTimePicker();
            label2 = new Label();
            txtifiyat = new TextBox();
            label1 = new Label();
            lblifiyat = new Label();
            lbliad = new Label();
            btnkayit = new Button();
            btndüzenle = new Button();
            btnsil = new Button();
            btngeri = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 421);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1200, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Randevu Detayları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1194, 341);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtmadi);
            groupBox2.Controls.Add(txtmtel);
            groupBox2.Controls.Add(lbltelno);
            groupBox2.Controls.Add(txtmcinsiyet);
            groupBox2.Controls.Add(lblcinsiyet);
            groupBox2.Controls.Add(txtmsoyadi);
            groupBox2.Controls.Add(lblsoyad);
            groupBox2.Controls.Add(lblad);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 278);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Müşteri Bilgileri";
            // 
            // txtmadi
            // 
            txtmadi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtmadi.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtmadi.FormattingEnabled = true;
            txtmadi.Location = new Point(183, 38);
            txtmadi.Name = "txtmadi";
            txtmadi.Size = new Size(225, 31);
            txtmadi.TabIndex = 8;
            txtmadi.SelectedIndexChanged += txtmadi_SelectedIndexChanged;
            // 
            // txtmtel
            // 
            txtmtel.Location = new Point(183, 189);
            txtmtel.Name = "txtmtel";
            txtmtel.ReadOnly = true;
            txtmtel.Size = new Size(225, 30);
            txtmtel.TabIndex = 7;
            // 
            // lbltelno
            // 
            lbltelno.AutoSize = true;
            lbltelno.Location = new Point(7, 192);
            lbltelno.Name = "lbltelno";
            lbltelno.Size = new Size(159, 23);
            lbltelno.TabIndex = 6;
            lbltelno.Text = "Telefon Numarası :";
            // 
            // txtmcinsiyet
            // 
            txtmcinsiyet.Location = new Point(183, 141);
            txtmcinsiyet.Name = "txtmcinsiyet";
            txtmcinsiyet.ReadOnly = true;
            txtmcinsiyet.Size = new Size(225, 30);
            txtmcinsiyet.TabIndex = 5;
            // 
            // lblcinsiyet
            // 
            lblcinsiyet.AutoSize = true;
            lblcinsiyet.Location = new Point(12, 144);
            lblcinsiyet.Name = "lblcinsiyet";
            lblcinsiyet.Size = new Size(154, 23);
            lblcinsiyet.TabIndex = 4;
            lblcinsiyet.Text = "Müşteri Cinsiyeti :";
            // 
            // txtmsoyadi
            // 
            txtmsoyadi.Location = new Point(183, 89);
            txtmsoyadi.Name = "txtmsoyadi";
            txtmsoyadi.ReadOnly = true;
            txtmsoyadi.Size = new Size(225, 30);
            txtmsoyadi.TabIndex = 3;
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(26, 92);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(140, 23);
            lblsoyad.TabIndex = 2;
            lblsoyad.Text = "Müşteri Soyadı :";
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(52, 41);
            lblad.Name = "lblad";
            lblad.Size = new Size(114, 23);
            lblad.TabIndex = 0;
            lblad.Text = "Müşteri Adı :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtsaat);
            groupBox3.Controls.Add(txtiadi);
            groupBox3.Controls.Add(date);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(txtifiyat);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(lblifiyat);
            groupBox3.Controls.Add(lbliad);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox3.Location = new Point(709, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(466, 278);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Bilgileri";
            // 
            // txtsaat
            // 
            txtsaat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtsaat.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtsaat.FormattingEnabled = true;
            txtsaat.Location = new Point(219, 188);
            txtsaat.Name = "txtsaat";
            txtsaat.Size = new Size(103, 31);
            txtsaat.TabIndex = 11;
            txtsaat.SelectedIndexChanged += txtsaat_SelectedIndexChanged;
            // 
            // txtiadi
            // 
            txtiadi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtiadi.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtiadi.FormattingEnabled = true;
            txtiadi.Location = new Point(219, 38);
            txtiadi.Name = "txtiadi";
            txtiadi.Size = new Size(225, 31);
            txtiadi.TabIndex = 10;
            txtiadi.SelectedIndexChanged += txtiadi_SelectedIndexChanged;
            // 
            // date
            // 
            date.Location = new Point(219, 144);
            date.Name = "date";
            date.Size = new Size(225, 30);
            date.TabIndex = 9;
            date.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 189);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 7;
            label2.Text = "İşlem Saati :";
            // 
            // txtifiyat
            // 
            txtifiyat.Location = new Point(219, 92);
            txtifiyat.Name = "txtifiyat";
            txtifiyat.ReadOnly = true;
            txtifiyat.Size = new Size(225, 30);
            txtifiyat.TabIndex = 5;
            txtifiyat.TextChanged += txtifiyat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 148);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 6;
            label1.Text = "İşlem Tarihi :";
            // 
            // lblifiyat
            // 
            lblifiyat.AutoSize = true;
            lblifiyat.Location = new Point(82, 99);
            lblifiyat.Name = "lblifiyat";
            lblifiyat.Size = new Size(111, 23);
            lblifiyat.TabIndex = 4;
            lblifiyat.Text = "İşlem Fiyatı :";
            // 
            // lbliad
            // 
            lbliad.AutoSize = true;
            lbliad.Location = new Point(98, 44);
            lbliad.Name = "lbliad";
            lbliad.Size = new Size(95, 23);
            lbliad.TabIndex = 2;
            lbliad.Text = "İşlem Adı :";
            // 
            // btnkayit
            // 
            btnkayit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnkayit.Location = new Point(709, 335);
            btnkayit.Name = "btnkayit";
            btnkayit.Size = new Size(90, 43);
            btnkayit.TabIndex = 3;
            btnkayit.Text = "Kaydet";
            btnkayit.UseVisualStyleBackColor = true;
            btnkayit.Click += btnkayit_Click;
            // 
            // btndüzenle
            // 
            btndüzenle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btndüzenle.Location = new Point(899, 335);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(90, 43);
            btndüzenle.TabIndex = 4;
            btndüzenle.Text = "Düzenle";
            btndüzenle.UseVisualStyleBackColor = true;
            btndüzenle.Click += btndüzenle_Click;
            // 
            // btnsil
            // 
            btnsil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsil.Location = new Point(1085, 335);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(90, 43);
            btnsil.TabIndex = 5;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btngeri
            // 
            btngeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btngeri.Location = new Point(24, 335);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(90, 43);
            btngeri.TabIndex = 6;
            btngeri.Text = "Geri Dön";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // RandevuVer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1200, 794);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnkayit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RandevuVer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandevuVer";
            Load += RandevuVer_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtmtel;
        private Label lbltelno;
        private TextBox txtmcinsiyet;
        private Label lblcinsiyet;
        private TextBox txtmsoyadi;
        private Label lblsoyad;
        private Label lblad;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Label lblifiyat;
        private Label lbliad;
        private DataGridView dataGridView1;
        private DateTimePicker date;
        private Button btnkayit;
        private Button btndüzenle;
        private Button btnsil;
        private Button btngeri;
        private TextBox txtifiyat;
        private ComboBox txtmadi;
        private ComboBox txtiadi;
        private ComboBox txtsaat;
    }
}