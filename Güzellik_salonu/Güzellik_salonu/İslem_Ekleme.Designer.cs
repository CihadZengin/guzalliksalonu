namespace Güzellik_salonu
{
    partial class İslem_Ekleme
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
            grpislem = new GroupBox();
            dataGridView1 = new DataGridView();
            txtislemfiyat = new TextBox();
            txtislemad = new TextBox();
            lblislemfiyat = new Label();
            lblislemad = new Label();
            txtara = new TextBox();
            lblara = new Label();
            btngeri = new Button();
            btnsil = new Button();
            btndüzenle = new Button();
            btnekle = new Button();
            grpislem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpislem
            // 
            grpislem.Controls.Add(dataGridView1);
            grpislem.Dock = DockStyle.Right;
            grpislem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpislem.Location = new Point(363, 0);
            grpislem.Name = "grpislem";
            grpislem.Size = new Size(793, 687);
            grpislem.TabIndex = 0;
            grpislem.TabStop = false;
            grpislem.Text = "İşlem Adı Ve Fiyatı";
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
            dataGridView1.Size = new Size(784, 658);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // txtislemfiyat
            // 
            txtislemfiyat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtislemfiyat.Location = new Point(54, 167);
            txtislemfiyat.Name = "txtislemfiyat";
            txtislemfiyat.Size = new Size(245, 30);
            txtislemfiyat.TabIndex = 10;
            // 
            // txtislemad
            // 
            txtislemad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtislemad.Location = new Point(54, 77);
            txtislemad.Name = "txtislemad";
            txtislemad.Size = new Size(245, 30);
            txtislemad.TabIndex = 9;
            // 
            // lblislemfiyat
            // 
            lblislemfiyat.AutoSize = true;
            lblislemfiyat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblislemfiyat.Location = new Point(113, 127);
            lblislemfiyat.Name = "lblislemfiyat";
            lblislemfiyat.Size = new Size(127, 25);
            lblislemfiyat.TabIndex = 8;
            lblislemfiyat.Text = "İşlemin Fiyatı";
            // 
            // lblislemad
            // 
            lblislemad.AutoSize = true;
            lblislemad.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblislemad.Location = new Point(130, 37);
            lblislemad.Name = "lblislemad";
            lblislemad.Size = new Size(93, 25);
            lblislemad.TabIndex = 7;
            lblislemad.Text = "İşlem Adı";
            // 
            // txtara
            // 
            txtara.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtara.Location = new Point(54, 604);
            txtara.Name = "txtara";
            txtara.Size = new Size(245, 30);
            txtara.TabIndex = 17;
            txtara.TextChanged += txtara_TextChanged;
            // 
            // lblara
            // 
            lblara.AutoSize = true;
            lblara.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblara.Location = new Point(129, 560);
            lblara.Name = "lblara";
            lblara.Size = new Size(94, 25);
            lblara.TabIndex = 16;
            lblara.Text = "İşlem Ara";
            // 
            // btngeri
            // 
            btngeri.BackColor = Color.White;
            btngeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btngeri.Location = new Point(127, 380);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(94, 45);
            btngeri.TabIndex = 21;
            btngeri.Text = "Geri Dön";
            btngeri.UseVisualStyleBackColor = false;
            btngeri.Click += btngeri_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = Color.White;
            btnsil.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnsil.Location = new Point(239, 313);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(94, 45);
            btnsil.TabIndex = 20;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btndüzenle
            // 
            btndüzenle.BackColor = Color.White;
            btndüzenle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btndüzenle.Location = new Point(127, 313);
            btndüzenle.Name = "btndüzenle";
            btndüzenle.Size = new Size(94, 45);
            btndüzenle.TabIndex = 19;
            btndüzenle.Text = "Düzenle";
            btndüzenle.UseVisualStyleBackColor = false;
            btndüzenle.Click += btndüzenle_Click;
            // 
            // btnekle
            // 
            btnekle.BackColor = Color.White;
            btnekle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnekle.Location = new Point(16, 313);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(94, 45);
            btnekle.TabIndex = 18;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = false;
            btnekle.Click += btnekle_Click;
            // 
            // İslem_Ekleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1156, 687);
            Controls.Add(btngeri);
            Controls.Add(btnsil);
            Controls.Add(btndüzenle);
            Controls.Add(btnekle);
            Controls.Add(txtara);
            Controls.Add(lblara);
            Controls.Add(txtislemfiyat);
            Controls.Add(txtislemad);
            Controls.Add(lblislemfiyat);
            Controls.Add(lblislemad);
            Controls.Add(grpislem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "İslem_Ekleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İslem_Ekleme";
            Load += İslem_Ekleme_Load;
            grpislem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpislem;
        private DataGridView dataGridView1;
        private TextBox txtislemfiyat;
        private TextBox txtislemad;
        private Label lblislemfiyat;
        private Label lblislemad;
        private TextBox txtara;
        private Label lblara;
        private Button btngeri;
        private Button btnsil;
        private Button btndüzenle;
        private Button btnekle;
    }
}