namespace Güzellik_salonu
{
    partial class urunsat
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
            lbluad = new Label();
            txtuad = new TextBox();
            txtufiyat = new TextBox();
            lblufiyat = new Label();
            txtutur = new TextBox();
            lblutur = new Label();
            txtustok = new TextBox();
            lblustok = new Label();
            groupBox2 = new GroupBox();
            txtmiktar = new TextBox();
            label1 = new Label();
            button1 = new Button();
            btngeri = new Button();
            txttoplamfiyat = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(513, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 689);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÜrünListesi";
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
            dataGridView1.Size = new Size(656, 660);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // lbluad
            // 
            lbluad.AutoSize = true;
            lbluad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbluad.Location = new Point(56, 51);
            lbluad.Name = "lbluad";
            lbluad.Size = new Size(92, 23);
            lbluad.TabIndex = 1;
            lbluad.Text = "Ürün Adı :";
            // 
            // txtuad
            // 
            txtuad.Location = new Point(154, 51);
            txtuad.Name = "txtuad";
            txtuad.ReadOnly = true;
            txtuad.Size = new Size(222, 30);
            txtuad.TabIndex = 2;
            // 
            // txtufiyat
            // 
            txtufiyat.Location = new Point(154, 115);
            txtufiyat.Name = "txtufiyat";
            txtufiyat.ReadOnly = true;
            txtufiyat.Size = new Size(222, 30);
            txtufiyat.TabIndex = 4;
            // 
            // lblufiyat
            // 
            lblufiyat.AutoSize = true;
            lblufiyat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblufiyat.Location = new Point(40, 115);
            lblufiyat.Name = "lblufiyat";
            lblufiyat.Size = new Size(108, 23);
            lblufiyat.TabIndex = 3;
            lblufiyat.Text = "Ürün Fiyatı :";
            // 
            // txtutur
            // 
            txtutur.Location = new Point(154, 189);
            txtutur.Name = "txtutur";
            txtutur.ReadOnly = true;
            txtutur.Size = new Size(222, 30);
            txtutur.TabIndex = 6;
            // 
            // lblutur
            // 
            lblutur.AutoSize = true;
            lblutur.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblutur.Location = new Point(48, 189);
            lblutur.Name = "lblutur";
            lblutur.Size = new Size(100, 23);
            lblutur.TabIndex = 5;
            lblutur.Text = "Ürün Türü :";
            // 
            // txtustok
            // 
            txtustok.Location = new Point(154, 263);
            txtustok.Name = "txtustok";
            txtustok.ReadOnly = true;
            txtustok.Size = new Size(222, 30);
            txtustok.TabIndex = 8;
            // 
            // lblustok
            // 
            lblustok.AutoSize = true;
            lblustok.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblustok.Location = new Point(36, 263);
            lblustok.Name = "lblustok";
            lblustok.Size = new Size(112, 23);
            lblustok.TabIndex = 7;
            lblustok.Text = "Ürün Stoğu :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtuad);
            groupBox2.Controls.Add(txtustok);
            groupBox2.Controls.Add(lbluad);
            groupBox2.Controls.Add(lblustok);
            groupBox2.Controls.Add(lblufiyat);
            groupBox2.Controls.Add(txtutur);
            groupBox2.Controls.Add(txtufiyat);
            groupBox2.Controls.Add(lblutur);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(455, 343);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Bilgileri";
            // 
            // txtmiktar
            // 
            txtmiktar.Location = new Point(166, 409);
            txtmiktar.Name = "txtmiktar";
            txtmiktar.Size = new Size(73, 27);
            txtmiktar.TabIndex = 11;
            txtmiktar.TextChanged += txtmiktar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(37, 410);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 10;
            label1.Text = "Adet Miktarı :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(285, 534);
            button1.Name = "button1";
            button1.Size = new Size(103, 44);
            button1.TabIndex = 12;
            button1.Text = "Satış Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.White;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(12, 632);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(94, 45);
            btngeri.TabIndex = 26;
            btngeri.Text = "Geri Dön";
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // txttoplamfiyat
            // 
            txttoplamfiyat.Location = new Point(166, 487);
            txttoplamfiyat.Name = "txttoplamfiyat";
            txttoplamfiyat.ReadOnly = true;
            txttoplamfiyat.Size = new Size(222, 27);
            txttoplamfiyat.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(37, 488);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 27;
            label2.Text = "Toplam Fiyat :";
            // 
            // urunsat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1178, 689);
            Controls.Add(txttoplamfiyat);
            Controls.Add(label2);
            Controls.Add(btngeri);
            Controls.Add(button1);
            Controls.Add(txtmiktar);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "urunsat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "urunsat";
            Load += urunsat_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Label lbluad;
        private TextBox txtuad;
        private TextBox txtufiyat;
        private Label lblufiyat;
        private TextBox txtutur;
        private Label lblutur;
        private TextBox txtustok;
        private Label lblustok;
        private GroupBox groupBox2;
        private TextBox txtmiktar;
        private Label label1;
        private Button button1;
        private Button btngeri;
        private TextBox txttoplamfiyat;
        private Label label2;
    }
}