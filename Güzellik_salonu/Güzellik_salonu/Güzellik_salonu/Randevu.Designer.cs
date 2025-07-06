namespace Güzellik_salonu
{
    partial class Randevu
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
            dataGridView1 = new DataGridView();
            grpliste = new GroupBox();
            btnmusteri = new Button();
            btnislem = new Button();
            btnyetkili = new Button();
            btnrandevu = new Button();
            lblmesaj = new Label();
            txtara = new TextBox();
            btnkapat = new Button();
            btngeri = new Button();
            btnurunler = new Button();
            btnurunsat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpliste.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(873, 658);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // grpliste
            // 
            grpliste.Controls.Add(dataGridView1);
            grpliste.Dock = DockStyle.Right;
            grpliste.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpliste.Location = new Point(274, 0);
            grpliste.Name = "grpliste";
            grpliste.Size = new Size(882, 687);
            grpliste.TabIndex = 1;
            grpliste.TabStop = false;
            grpliste.Text = "Randevu Listesi";
            // 
            // btnmusteri
            // 
            btnmusteri.BackColor = Color.White;
            btnmusteri.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            btnmusteri.Location = new Point(12, 44);
            btnmusteri.Name = "btnmusteri";
            btnmusteri.Size = new Size(247, 59);
            btnmusteri.TabIndex = 2;
            btnmusteri.Text = "Yeni Müşteri Ekle\\Sil\\Düzenle";
            btnmusteri.UseVisualStyleBackColor = false;
            btnmusteri.Click += btnmusteri_Click;
            // 
            // btnislem
            // 
            btnislem.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            btnislem.Location = new Point(12, 119);
            btnislem.Name = "btnislem";
            btnislem.Size = new Size(247, 59);
            btnislem.TabIndex = 3;
            btnislem.Text = "  Yeni İşlem    Ekle\\Sil\\Düzenle";
            btnislem.UseVisualStyleBackColor = true;
            btnislem.Click += btnislem_Click;
            // 
            // btnyetkili
            // 
            btnyetkili.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            btnyetkili.Location = new Point(12, 273);
            btnyetkili.Name = "btnyetkili";
            btnyetkili.Size = new Size(247, 60);
            btnyetkili.TabIndex = 4;
            btnyetkili.Text = " Yeni Yetkili  Ekle\\Sil\\Düzenle";
            btnyetkili.UseVisualStyleBackColor = true;
            btnyetkili.Click += btnyetkili_Click;
            // 
            // btnrandevu
            // 
            btnrandevu.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            btnrandevu.Location = new Point(12, 197);
            btnrandevu.Name = "btnrandevu";
            btnrandevu.Size = new Size(247, 60);
            btnrandevu.TabIndex = 5;
            btnrandevu.Text = " Yeni Randevu  Ekle\\Sil\\Düzenle";
            btnrandevu.UseVisualStyleBackColor = true;
            btnrandevu.Click += btnrandevu_Click;
            // 
            // lblmesaj
            // 
            lblmesaj.AutoSize = true;
            lblmesaj.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblmesaj.Location = new Point(72, 505);
            lblmesaj.Name = "lblmesaj";
            lblmesaj.Size = new Size(126, 25);
            lblmesaj.TabIndex = 6;
            lblmesaj.Text = "Randevu Ara";
            // 
            // txtara
            // 
            txtara.Location = new Point(14, 546);
            txtara.Name = "txtara";
            txtara.Size = new Size(247, 27);
            txtara.TabIndex = 7;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // btnkapat
            // 
            btnkapat.BackColor = Color.White;
            btnkapat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnkapat.Location = new Point(145, 603);
            btnkapat.Name = "btnkapat";
            btnkapat.Size = new Size(116, 67);
            btnkapat.TabIndex = 8;
            btnkapat.Text = "Uygulamayı Kapat";
            btnkapat.UseVisualStyleBackColor = false;
            btnkapat.Click += btnkapat_Click;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.White;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(14, 603);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(116, 67);
            btngeri.TabIndex = 9;
            btngeri.Text = "Önceki Ekrana Dön";
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // btnurunler
            // 
            btnurunler.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            btnurunler.Location = new Point(12, 352);
            btnurunler.Name = "btnurunler";
            btnurunler.Size = new Size(247, 58);
            btnurunler.TabIndex = 10;
            btnurunler.Text = "    Yeni Ürün      Ekle\\Sil\\Düzenle";
            btnurunler.UseVisualStyleBackColor = true;
            btnurunler.Click += btnurunler_Click;
            // 
            // btnurunsat
            // 
            btnurunsat.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold);
            btnurunsat.Location = new Point(14, 429);
            btnurunsat.Name = "btnurunsat";
            btnurunsat.Size = new Size(247, 58);
            btnurunsat.TabIndex = 11;
            btnurunsat.Text = "Ürün Satışı ";
            btnurunsat.UseVisualStyleBackColor = true;
            btnurunsat.Click += btnurunsat_Click;
            // 
            // Randevu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1156, 687);
            Controls.Add(btnurunsat);
            Controls.Add(btnurunler);
            Controls.Add(btngeri);
            Controls.Add(btnkapat);
            Controls.Add(txtara);
            Controls.Add(lblmesaj);
            Controls.Add(btnrandevu);
            Controls.Add(btnyetkili);
            Controls.Add(btnislem);
            Controls.Add(btnmusteri);
            Controls.Add(grpliste);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Randevu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu";
            Load += Randevu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpliste.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grpliste;
        private Button btnmusteri;
        private Button btnislem;
        private Button btnyetkili;
        private Button btnrandevu;
        private Label lblmesaj;
        private TextBox txtara;
        private Button btnkapat;
        private Button btngeri;
        private Button btnurunler;
        private Button btnurunsat;
    }
}