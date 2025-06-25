namespace Güzellik_salonu
{
    partial class Urunler
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
            btngeri = new Button();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            txttür = new TextBox();
            lblütürü = new Label();
            txtufiyat = new TextBox();
            txtuad = new TextBox();
            lblufiyat = new Label();
            lbluad = new Label();
            txtstok = new TextBox();
            stkdurumu = new Label();
            txtara = new TextBox();
            lblara = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(345, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 687);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürünler Listesi";
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
            dataGridView1.Size = new Size(802, 658);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.White;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(133, 617);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(94, 45);
            btngeri.TabIndex = 31;
            btngeri.Text = "Geri Dön";
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.White;
            btnsil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnsil.Location = new Point(245, 550);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 45);
            btnsil.TabIndex = 30;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btndüzenle
            // 
            btndüzenle.BackColor = Color.White;
            btndüzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btndüzenle.Location = new Point(133, 550);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(94, 45);
            btndüzenle.TabIndex = 29;
            btndüzenle.Text = "Düzenle";
            btndüzenle.UseVisualStyleBackColor = false;
            btndüzenle.Click += btndüzenle_Click;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.White;
            btnekle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnekle.Location = new Point(22, 550);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(94, 45);
            btnekle.TabIndex = 28;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // txttür
            // 
            txttür.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txttür.Location = new Point(60, 252);
            txttür.Name = "txttür";
            txttür.Size = new Size(245, 30);
            txttür.TabIndex = 27;
            // 
            // lblütürü
            // 
            lblütürü.AutoSize = true;
            lblütürü.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblütürü.Location = new Point(118, 208);
            lblütürü.Name = "lblütürü";
            lblütürü.Size = new Size(129, 25);
            lblütürü.TabIndex = 26;
            lblütürü.Text = "Ürünün Türü";
            // 
            // txtufiyat
            // 
            txtufiyat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtufiyat.Location = new Point(60, 156);
            txtufiyat.Name = "txtufiyat";
            txtufiyat.Size = new Size(245, 30);
            txtufiyat.TabIndex = 25;
            // 
            // txtuad
            // 
            txtuad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtuad.Location = new Point(60, 66);
            txtuad.Name = "txtuad";
            txtuad.Size = new Size(245, 30);
            txtuad.TabIndex = 24;
            // 
            // lblufiyat
            // 
            lblufiyat.AutoSize = true;
            lblufiyat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblufiyat.Location = new Point(127, 116);
            lblufiyat.Name = "lblufiyat";
            lblufiyat.Size = new Size(110, 25);
            lblufiyat.TabIndex = 23;
            lblufiyat.Text = "Ürün Fiyatı";
            // 
            // lbluad
            // 
            lbluad.AutoSize = true;
            lbluad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbluad.Location = new Point(116, 26);
            lbluad.Name = "lbluad";
            lbluad.Size = new Size(133, 25);
            lbluad.TabIndex = 22;
            lbluad.Text = "Ürün Markası";
            // 
            // txtstok
            // 
            txtstok.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtstok.Location = new Point(60, 348);
            txtstok.Name = "txtstok";
            txtstok.Size = new Size(245, 30);
            txtstok.TabIndex = 33;
            // 
            // stkdurumu
            // 
            stkdurumu.AutoSize = true;
            stkdurumu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            stkdurumu.Location = new Point(116, 304);
            stkdurumu.Name = "stkdurumu";
            stkdurumu.Size = new Size(133, 25);
            stkdurumu.TabIndex = 32;
            stkdurumu.Text = "Stok Durumu";
            // 
            // txtara
            // 
            txtara.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtara.Location = new Point(60, 438);
            txtara.Name = "txtara";
            txtara.Size = new Size(245, 30);
            txtara.TabIndex = 35;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblara.Location = new Point(135, 394);
            lblara.Name = "lblara";
            lblara.Size = new Size(94, 25);
            lblara.TabIndex = 34;
            lblara.Text = "Ürün Ara";
            // 
            // Urunler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1156, 687);
            Controls.Add(txtara);
            Controls.Add(lblara);
            Controls.Add(txtstok);
            Controls.Add(stkdurumu);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(txttür);
            Controls.Add(lblütürü);
            Controls.Add(txtufiyat);
            Controls.Add(txtuad);
            Controls.Add(lblufiyat);
            Controls.Add(lbluad);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Urunler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Urunler";
            Load += Urunler_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btngeri;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
        private TextBox txttür;
        private Label lblütürü;
        private TextBox txtufiyat;
        private TextBox txtuad;
        private Label lblufiyat;
        private Label lbluad;
        private TextBox txtstok;
        private Label stkdurumu;
        private TextBox txtara;
        private Label lblara;
    }
}