namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.kullaniciSifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnKayıt = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SifreGoster = new System.Windows.Forms.CheckBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.kullainiciAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.kullaniciSifre);
            this.guna2Panel1.Controls.Add(this.btnKayıt);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.SifreGoster);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Controls.Add(this.kullainiciAd);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(58, 34);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 9, 9);
            this.guna2Panel1.Size = new System.Drawing.Size(403, 486);
            this.guna2Panel1.TabIndex = 13;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // kullaniciSifre
            // 
            this.kullaniciSifre.Animated = true;
            this.kullaniciSifre.AutoRoundedCorners = true;
            this.kullaniciSifre.BorderColor = System.Drawing.Color.Gray;
            this.kullaniciSifre.BorderRadius = 25;
            this.kullaniciSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciSifre.DefaultText = "";
            this.kullaniciSifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kullaniciSifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kullaniciSifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciSifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullaniciSifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciSifre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kullaniciSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullaniciSifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullaniciSifre.Location = new System.Drawing.Point(50, 273);
            this.kullaniciSifre.Name = "kullaniciSifre";
            this.kullaniciSifre.PasswordChar = '\0';
            this.kullaniciSifre.PlaceholderText = "Şifre";
            this.kullaniciSifre.SelectedText = "";
            this.kullaniciSifre.Size = new System.Drawing.Size(303, 53);
            this.kullaniciSifre.TabIndex = 14;
            this.kullaniciSifre.TextChanged += new System.EventHandler(this.kullaniciSifre_TextChanged);
            // 
            // btnKayıt
            // 
            this.btnKayıt.Animated = true;
            this.btnKayıt.AutoRoundedCorners = true;
            this.btnKayıt.BorderRadius = 21;
            this.btnKayıt.FillColor = System.Drawing.Color.Gray;
            this.btnKayıt.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKayıt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKayıt.ForeColor = System.Drawing.Color.White;
            this.btnKayıt.Location = new System.Drawing.Point(235, 365);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(118, 45);
            this.btnKayıt.TabIndex = 7;
            this.btnKayıt.Text = "Kayıt Ol";
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMSA SOFT İNSAN KAYNAKLARI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SifreGoster
            // 
            this.SifreGoster.AutoSize = true;
            this.SifreGoster.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreGoster.ForeColor = System.Drawing.SystemColors.Control;
            this.SifreGoster.Location = new System.Drawing.Point(66, 338);
            this.SifreGoster.Name = "SifreGoster";
            this.SifreGoster.Size = new System.Drawing.Size(104, 21);
            this.SifreGoster.TabIndex = 9;
            this.SifreGoster.Text = "Şifreyi göster";
            this.SifreGoster.UseVisualStyleBackColor = true;
            this.SifreGoster.CheckedChanged += new System.EventHandler(this.SifreGoster_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderRadius = 21;
            this.btnLogin.FillColor = System.Drawing.Color.Gray;
            this.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(66, 365);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 45);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // kullainiciAd
            // 
            this.kullainiciAd.Animated = true;
            this.kullainiciAd.AutoRoundedCorners = true;
            this.kullainiciAd.BorderColor = System.Drawing.Color.Gray;
            this.kullainiciAd.BorderRadius = 25;
            this.kullainiciAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullainiciAd.DefaultText = "";
            this.kullainiciAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kullainiciAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kullainiciAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullainiciAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kullainiciAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullainiciAd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kullainiciAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kullainiciAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kullainiciAd.Location = new System.Drawing.Point(50, 214);
            this.kullainiciAd.Name = "kullainiciAd";
            this.kullainiciAd.PasswordChar = '\0';
            this.kullainiciAd.PlaceholderText = "Kullanıcı Adı";
            this.kullainiciAd.SelectedText = "";
            this.kullainiciAd.Size = new System.Drawing.Size(303, 53);
            this.kullainiciAd.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::İnsan_Kaynakları_Otomasyonu_Sistemi.Properties.Resources.Ekran_Alıntısı;
            this.pictureBox1.Location = new System.Drawing.Point(66, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(483, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox1.TabIndex = 14;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(514, 561);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Login_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox kullainiciAd;
        private Guna.UI2.WinForms.Guna2GradientButton btnKayıt;
        private System.Windows.Forms.CheckBox SifreGoster;
        private Guna.UI2.WinForms.Guna2TextBox kullaniciSifre;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}

