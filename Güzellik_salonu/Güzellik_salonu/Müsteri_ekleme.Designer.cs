namespace Güzellik_salonu
{
    partial class Müsteri_ekleme
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
            lblad = new Label();
            lblsoyad = new Label();
            lbltelno = new Label();
            txtadi = new TextBox();
            txtsoyadi = new TextBox();
            grpcinsiyet = new GroupBox();
            radioe = new RadioButton();
            radiok = new RadioButton();
            mtxttel = new MaskedTextBox();
            btnekle = new Button();
            btndüzenle = new Button();
            btnsil = new Button();
            btngeri = new Button();
            lblara = new Label();
            txtara = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpcinsiyet.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(377, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(799, 702);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteriler";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(793, 673);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblad.Location = new Point(116, 35);
            lblad.Name = "lblad";
            lblad.Size = new Size(120, 25);
            lblad.TabIndex = 1;
            lblad.Text = "Müşteri Adı ";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblsoyad.Location = new Point(101, 122);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(150, 25);
            lblsoyad.TabIndex = 2;
            lblsoyad.Text = "Müşteri Soyadı ";
            // 
            // lbltelno
            // 
            lbltelno.AutoSize = true;
            lbltelno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbltelno.Location = new Point(54, 216);
            lbltelno.Name = "lbltelno";
            lbltelno.Size = new Size(245, 25);
            lbltelno.TabIndex = 3;
            lbltelno.Text = "Müşteri Telefon Numarası ";
            // 
            // txtadi
            // 
            txtadi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtadi.Location = new Point(54, 75);
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(245, 30);
            txtadi.TabIndex = 5;
            // 
            // txtsoyadi
            // 
            txtsoyadi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtsoyadi.Location = new Point(54, 165);
            txtsoyadi.Name = "txtsoyadi";
            txtsoyadi.Size = new Size(245, 30);
            txtsoyadi.TabIndex = 6;
            // 
            // grpcinsiyet
            // 
            grpcinsiyet.Controls.Add(radioe);
            grpcinsiyet.Controls.Add(radiok);
            grpcinsiyet.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpcinsiyet.Location = new Point(54, 315);
            grpcinsiyet.Name = "grpcinsiyet";
            grpcinsiyet.Size = new Size(184, 137);
            grpcinsiyet.TabIndex = 8;
            grpcinsiyet.TabStop = false;
            grpcinsiyet.Text = "Müşteri Cinsiyeti";
            // 
            // radioe
            // 
            radioe.AutoSize = true;
            radioe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioe.Location = new Point(17, 94);
            radioe.Name = "radioe";
            radioe.Size = new Size(76, 27);
            radioe.TabIndex = 10;
            radioe.TabStop = true;
            radioe.Text = "Erkek";
            radioe.UseVisualStyleBackColor = true;
            // 
            // radiok
            // 
            radiok.AutoSize = true;
            radiok.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radiok.Location = new Point(17, 43);
            radiok.Name = "radiok";
            radiok.Size = new Size(77, 27);
            radiok.TabIndex = 9;
            radiok.TabStop = true;
            radiok.Text = "Kadın";
            radiok.UseVisualStyleBackColor = true;
            // 
            // mtxttel
            // 
            mtxttel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            mtxttel.Location = new Point(54, 259);
            mtxttel.Mask = "(999) 000-0000";
            mtxttel.Name = "mtxttel";
            mtxttel.Size = new Size(245, 30);
            mtxttel.TabIndex = 9;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.White;
            btnekle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnekle.Location = new Point(33, 560);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(94, 45);
            btnekle.TabIndex = 10;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // btndüzenle
            // 
            btndüzenle.BackColor = Color.White;
            btndüzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btndüzenle.Location = new Point(144, 560);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(94, 45);
            btndüzenle.TabIndex = 11;
            btndüzenle.Text = "Düzenle";
            btndüzenle.UseVisualStyleBackColor = false;
            btndüzenle.Click += btndüzenle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.White;
            btnsil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnsil.Location = new Point(256, 560);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 45);
            btnsil.TabIndex = 12;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.White;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(144, 627);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(94, 45);
            btngeri.TabIndex = 13;
            btngeri.Text = "Geri Dön";
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblara.Location = new Point(118, 464);
            lblara.Name = "lblara";
            lblara.Size = new Size(116, 25);
            lblara.TabIndex = 14;
            lblara.Text = "Müşteri Ara";
            // 
            // txtara
            // 
            txtara.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtara.Location = new Point(54, 504);
            txtara.Name = "txtara";
            txtara.Size = new Size(245, 30);
            txtara.TabIndex = 15;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // Müsteri_ekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1176, 702);
            Controls.Add(txtara);
            Controls.Add(lblara);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(mtxttel);
            Controls.Add(grpcinsiyet);
            Controls.Add(txtsoyadi);
            Controls.Add(txtadi);
            Controls.Add(lbltelno);
            Controls.Add(lblsoyad);
            Controls.Add(lblad);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Müsteri_ekleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müsteri_ekleme\\silme\\düzenleme";
            Load += Müsteri_ekleme_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpcinsiyet.ResumeLayout(false);
            grpcinsiyet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lblad;
        private Label lblsoyad;
        private Label lbltelno;
        private TextBox txtadi;
        private TextBox txtsoyadi;
        private GroupBox grpcinsiyet;
        private RadioButton radioe;
        private RadioButton radiok;
        private MaskedTextBox mtxttel;
        private Button btnekle;
        private Button btndüzenle;
        private Button btnsil;
        private Button btngeri;
        private Label lblara;
        private TextBox txtara;
    }
}