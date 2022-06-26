namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    partial class PersonelZam
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPersoneller = new System.Windows.Forms.ComboBox();
            this.radioFiyat = new System.Windows.Forms.RadioButton();
            this.radioYuzde = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnOnay = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCikis = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.combosoyad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(73, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Yüzde(%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Personeller:";
            // 
            // comboPersoneller
            // 
            this.comboPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPersoneller.FormattingEnabled = true;
            this.comboPersoneller.Items.AddRange(new object[] {
            "Tüm Personeller"});
            this.comboPersoneller.Location = new System.Drawing.Point(139, 86);
            this.comboPersoneller.Name = "comboPersoneller";
            this.comboPersoneller.Size = new System.Drawing.Size(119, 23);
            this.comboPersoneller.TabIndex = 16;
            this.comboPersoneller.Text = " ";
            this.comboPersoneller.SelectedIndexChanged += new System.EventHandler(this.comboPersoneller_SelectedIndexChanged);
            // 
            // radioFiyat
            // 
            this.radioFiyat.AutoSize = true;
            this.radioFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioFiyat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioFiyat.Location = new System.Drawing.Point(274, 157);
            this.radioFiyat.Name = "radioFiyat";
            this.radioFiyat.Size = new System.Drawing.Size(87, 19);
            this.radioFiyat.TabIndex = 10;
            this.radioFiyat.TabStop = true;
            this.radioFiyat.Text = "Fiyata Göre";
            this.radioFiyat.UseVisualStyleBackColor = true;
            this.radioFiyat.CheckedChanged += new System.EventHandler(this.radioFiyat_CheckedChanged_1);
            // 
            // radioYuzde
            // 
            this.radioYuzde.AutoSize = true;
            this.radioYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioYuzde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioYuzde.Location = new System.Drawing.Point(274, 124);
            this.radioYuzde.Name = "radioYuzde";
            this.radioYuzde.Size = new System.Drawing.Size(101, 19);
            this.radioYuzde.TabIndex = 9;
            this.radioYuzde.TabStop = true;
            this.radioYuzde.Text = "Yüzdeye Göre";
            this.radioYuzde.UseVisualStyleBackColor = true;
            this.radioYuzde.CheckedChanged += new System.EventHandler(this.radioYuzde_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(138, 124);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(76, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fiyat(TL):";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(139, 157);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(119, 21);
            this.txtFiyat.TabIndex = 12;
            // 
            // btnOnay
            // 
            this.btnOnay.Animated = true;
            this.btnOnay.AutoRoundedCorners = true;
            this.btnOnay.BorderRadius = 21;
            this.btnOnay.CustomImages.Image = global::İnsan_Kaynakları_Otomasyonu_Sistemi.Properties.Resources.add__1_;
            this.btnOnay.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOnay.FillColor = System.Drawing.Color.DarkGray;
            this.btnOnay.FillColor2 = System.Drawing.Color.Silver;
            this.btnOnay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOnay.ForeColor = System.Drawing.Color.White;
            this.btnOnay.Location = new System.Drawing.Point(59, 193);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(110, 45);
            this.btnOnay.TabIndex = 28;
            this.btnOnay.Text = "Ekle";
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Animated = true;
            this.btnCikis.AutoRoundedCorners = true;
            this.btnCikis.BorderRadius = 21;
            this.btnCikis.CustomImages.Image = global::İnsan_Kaynakları_Otomasyonu_Sistemi.Properties.Resources.exit1;
            this.btnCikis.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCikis.FillColor = System.Drawing.Color.DarkGray;
            this.btnCikis.FillColor2 = System.Drawing.Color.Silver;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(181, 193);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(110, 45);
            this.btnCikis.TabIndex = 27;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(362, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "1006";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // combosoyad
            // 
            this.combosoyad.Enabled = false;
            this.combosoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combosoyad.FormattingEnabled = true;
            this.combosoyad.Location = new System.Drawing.Point(262, 86);
            this.combosoyad.Name = "combosoyad";
            this.combosoyad.Size = new System.Drawing.Size(99, 23);
            this.combosoyad.TabIndex = 33;
            this.combosoyad.SelectedIndexChanged += new System.EventHandler(this.combosoyad_SelectedIndexChanged);
            // 
            // PersonelZam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(440, 273);
            this.Controls.Add(this.combosoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPersoneller);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.radioFiyat);
            this.Controls.Add(this.radioYuzde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelZam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelZam";
            this.Load += new System.EventHandler(this.PersonelZam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPersoneller;
        private System.Windows.Forms.RadioButton radioFiyat;
        private System.Windows.Forms.RadioButton radioYuzde;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private Guna.UI2.WinForms.Guna2GradientButton btnOnay;
        private Guna.UI2.WinForms.Guna2GradientButton btnCikis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combosoyad;
    }
}