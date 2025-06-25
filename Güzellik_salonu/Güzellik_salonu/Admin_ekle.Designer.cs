namespace Güzellik_salonu
{
    partial class Admin_ekle
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
            Yetkililer = new GroupBox();
            dataGridView1 = new DataGridView();
            txtsifre = new TextBox();
            txtkullanıciadi = new TextBox();
            lblsifre = new Label();
            lblkullaniciadi = new Label();
            btngeri = new Button();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            Yetkililer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Yetkililer
            // 
            Yetkililer.Controls.Add(dataGridView1);
            Yetkililer.Dock = DockStyle.Right;
            Yetkililer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Yetkililer.Location = new Point(369, 0);
            Yetkililer.Name = "Yetkililer";
            Yetkililer.Size = new Size(787, 687);
            Yetkililer.TabIndex = 0;
            Yetkililer.TabStop = false;
            Yetkililer.Text = "Yetkililer";
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
            dataGridView1.Size = new Size(778, 658);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtsifre.Location = new Point(66, 156);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(245, 30);
            txtsifre.TabIndex = 14;
            // 
            // txtkullanıciadi
            // 
            txtkullanıciadi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtkullanıciadi.Location = new Point(66, 66);
            txtkullanıciadi.Name = "txtkullanıciadi";
            txtkullanıciadi.Size = new Size(245, 30);
            txtkullanıciadi.TabIndex = 13;
            // 
            // lblsifre
            // 
            lblsifre.AutoSize = true;
            lblsifre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblsifre.Location = new Point(162, 116);
            lblsifre.Name = "lblsifre";
            lblsifre.Size = new Size(53, 25);
            lblsifre.TabIndex = 12;
            lblsifre.Text = "Şifre";
            // 
            // lblkullaniciadi
            // 
            lblkullaniciadi.AutoSize = true;
            lblkullaniciadi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblkullaniciadi.Location = new Point(127, 26);
            lblkullaniciadi.Name = "lblkullaniciadi";
            lblkullaniciadi.Size = new Size(122, 25);
            lblkullaniciadi.TabIndex = 11;
            lblkullaniciadi.Text = "Kullanıcı Adı";
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.White;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(138, 542);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(94, 45);
            btngeri.TabIndex = 25;
            btngeri.Text = "Geri Dön";
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.White;
            btnsil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnsil.Location = new Point(250, 475);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 45);
            btnsil.TabIndex = 24;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btndüzenle
            // 
            btndüzenle.BackColor = Color.White;
            btndüzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btndüzenle.Location = new Point(138, 475);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(94, 45);
            btndüzenle.TabIndex = 23;
            btndüzenle.Text = "Düzenle";
            btndüzenle.UseVisualStyleBackColor = false;
            btndüzenle.Click += btndüzenle_Click;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.White;
            btnekle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnekle.Location = new Point(27, 475);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(94, 45);
            btnekle.TabIndex = 22;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // Admin_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1156, 687);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(txtsifre);
            Controls.Add(txtkullanıciadi);
            Controls.Add(lblsifre);
            Controls.Add(lblkullaniciadi);
            Controls.Add(Yetkililer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_ekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_ekle";
            Load += Admin_ekle_Load;
            Yetkililer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Yetkililer;
        private DataGridView dataGridView1;
        private TextBox txtsifre;
        private TextBox txtkullanıciadi;
        private Label lblsifre;
        private Label lblkullaniciadi;
        private Button btngeri;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
    }
}