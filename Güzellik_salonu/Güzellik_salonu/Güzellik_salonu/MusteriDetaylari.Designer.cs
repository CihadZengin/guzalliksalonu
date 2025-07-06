namespace Güzellik_salonu
{
    partial class MusteriDetaylari
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
            btnBorcuKaydet = new Button();
            btnOdemeİslemleri = new Button();
            btngeri = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(314, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(868, 747);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri Detayları";
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
            dataGridView1.Size = new Size(859, 718);
            dataGridView1.TabIndex = 0;
            // 
            // btnBorcuKaydet
            // 
            btnBorcuKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBorcuKaydet.Location = new Point(12, 183);
            btnBorcuKaydet.Name = "btnBorcuKaydet";
            btnBorcuKaydet.Size = new Size(296, 68);
            btnBorcuKaydet.TabIndex = 2;
            btnBorcuKaydet.Text = "Müşteri Randevuya Geldi";
            btnBorcuKaydet.UseVisualStyleBackColor = true;
            btnBorcuKaydet.Click += btnBorcuKaydet_Click;
            // 
            // btnOdemeİslemleri
            // 
            btnOdemeİslemleri.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOdemeİslemleri.Location = new Point(12, 351);
            btnOdemeİslemleri.Name = "btnOdemeİslemleri";
            btnOdemeİslemleri.Size = new Size(296, 68);
            btnOdemeİslemleri.TabIndex = 3;
            btnOdemeİslemleri.Text = "Ödeme Ekranına Geçiş";
            btnOdemeİslemleri.UseVisualStyleBackColor = true;
            btnOdemeİslemleri.Click += btnOdemeİslemleri_Click;
            // 
            // btngeri
            // 
            btngeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btngeri.Location = new Point(95, 698);
            btngeri.Name = "btngeri";
            btngeri.Size = new Size(94, 37);
            btngeri.TabIndex = 4;
            btngeri.Text = "Geri";
            btngeri.UseVisualStyleBackColor = true;
            btngeri.Click += btngeri_Click;
            // 
            // MusteriDetaylari
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(1182, 747);
            Controls.Add(btngeri);
            Controls.Add(btnOdemeİslemleri);
            Controls.Add(btnBorcuKaydet);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusteriDetaylari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusteriDetaylari";
            Load += MusteriDetaylari_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnBorcuKaydet;
        private Button btnOdemeİslemleri;
        private Button btngeri;
    }
}