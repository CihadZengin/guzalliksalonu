namespace Güzellik_salonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblkullaniciadi = new Label();
            txtkullaniciadi = new TextBox();
            txtsifre = new TextBox();
            lblsifre = new Label();
            btngiris = new Button();
            chcsifre = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblyazi = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblkullaniciadi
            // 
            lblkullaniciadi.AutoSize = true;
            lblkullaniciadi.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            lblkullaniciadi.Location = new Point(61, 156);
            lblkullaniciadi.Name = "lblkullaniciadi";
            lblkullaniciadi.Size = new Size(161, 31);
            lblkullaniciadi.TabIndex = 0;
            lblkullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtkullaniciadi.Location = new Point(267, 162);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(202, 27);
            txtkullaniciadi.TabIndex = 1;
            // 
            // txtsifre
            // 
            txtsifre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtsifre.Location = new Point(267, 290);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(202, 27);
            txtsifre.TabIndex = 3;
            txtsifre.KeyDown += txtsifre_KeyDown;
            // 
            // lblsifre
            // 
            lblsifre.AutoSize = true;
            lblsifre.Font = new Font("Arial Narrow", 16F, FontStyle.Bold);
            lblsifre.Location = new Point(153, 284);
            lblsifre.Name = "lblsifre";
            lblsifre.Size = new Size(76, 31);
            lblsifre.TabIndex = 2;
            lblsifre.Text = "Şifre :";
            // 
            // btngiris
            // 
            btngiris.BackColor = Color.White;
            btngiris.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btngiris.Location = new Point(403, 385);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(94, 39);
            btngiris.TabIndex = 4;
            btngiris.Text = "Giriş Yap";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // chcsifre
            // 
            chcsifre.AutoSize = true;
            chcsifre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chcsifre.Location = new Point(315, 337);
            chcsifre.Name = "chcsifre";
            chcsifre.Size = new Size(154, 29);
            chcsifre.TabIndex = 7;
            chcsifre.Text = "Şifreyi Göster";
            chcsifre.UseVisualStyleBackColor = true;
            chcsifre.CheckedChanged += chcsifre_CheckedChanged;
            // 
            // lblyazi
            // 
            lblyazi.AutoSize = true;
            lblyazi.Font = new Font("Azonix", 18F, FontStyle.Bold);
            lblyazi.Location = new Point(19, 22);
            lblyazi.Name = "lblyazi";
            lblyazi.Size = new Size(492, 30);
            lblyazi.TabIndex = 0;
            lblyazi.Text = "AFİTAP Güzellik Merkezi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 19F, FontStyle.Bold);
            label1.Location = new Point(178, 63);
            label1.Name = "label1";
            label1.Size = new Size(175, 37);
            label1.TabIndex = 1;
            label1.Text = "Hoş Geldiniz";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(chcsifre);
            panel1.Controls.Add(lblyazi);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtkullaniciadi);
            panel1.Controls.Add(lblsifre);
            panel1.Controls.Add(btngiris);
            panel1.Controls.Add(txtsifre);
            panel1.Controls.Add(lblkullaniciadi);
            panel1.Location = new Point(342, 244);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 439);
            panel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1237, 821);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblkullaniciadi;
        private TextBox txtkullaniciadi;
        private TextBox txtsifre;
        private Label lblsifre;
        private Button btngiris;
        private CheckBox chcsifre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblyazi;
        private Label label1;
        private Panel panel1;
    }
}
