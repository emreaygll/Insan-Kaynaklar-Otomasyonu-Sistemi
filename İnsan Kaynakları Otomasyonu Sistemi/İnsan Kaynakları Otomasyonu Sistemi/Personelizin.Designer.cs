namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    partial class Personelizin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personelizin));
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.comboizinTuru = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.izinler = new İnsan_Kaynakları_Otomasyonu_Sistemi.izinler();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.comboPersonelAdsoyad = new System.Windows.Forms.ComboBox();
            this.btnEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSil = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCikis = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnizinTurleri = new Guna.UI2.WinForms.Guna2GradientButton();
            this.izinTableAdapter = new İnsan_Kaynakları_Otomasyonu_Sistemi.izinlerTableAdapters.izinTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinler)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(354, 420);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(197, 21);
            this.dateTimeBitis.TabIndex = 25;
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(354, 390);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(197, 21);
            this.dateTimeBaslangic.TabIndex = 24;
            // 
            // comboizinTuru
            // 
            this.comboizinTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboizinTuru.FormattingEnabled = true;
            this.comboizinTuru.Location = new System.Drawing.Point(354, 362);
            this.comboizinTuru.Name = "comboizinTuru";
            this.comboizinTuru.Size = new System.Drawing.Size(197, 23);
            this.comboizinTuru.TabIndex = 23;
            this.comboizinTuru.SelectedIndexChanged += new System.EventHandler(this.comboizinTuru_SelectedIndexChanged);
            this.comboizinTuru.Click += new System.EventHandler(this.comboizinTuru_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(291, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "İzin Bitiş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Adı Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(264, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "İzin Başlangıç:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(597, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(281, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "İzin Türleri:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(661, 362);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(180, 68);
            this.txtAciklama.TabIndex = 13;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1486503744-backspace-clean-clear-delete-remove-erase_81258.png");
            this.ımageList1.Images.SetKeyName(1, "off_downnearexit_apagado_abajo_6017.png");
            this.ımageList1.Images.SetKeyName(2, "system_software_update_22485.png");
            this.ımageList1.Images.SetKeyName(3, "1486504830-delete-dustbin-empty-recycle-recycling-remove-trash_81361.png");
            this.ımageList1.Images.SetKeyName(4, "add_12966 (1).png");
            this.ımageList1.Images.SetKeyName(5, "calendar_office_day_1474.png");
            this.ımageList1.Images.SetKeyName(6, "organizer_calendar_clock_pencil_10047.png");
            this.ımageList1.Images.SetKeyName(7, "add_12966.png");
            this.ımageList1.Images.SetKeyName(8, "increase_25373.png");
            this.ımageList1.Images.SetKeyName(9, "list_992.png");
            this.ımageList1.Images.SetKeyName(10, "Menu_icon_icon-icons.com_71858.png");
            this.ımageList1.Images.SetKeyName(11, "business_application_addmale_useradd_insert_add_user_client_2312.png");
            this.ımageList1.Images.SetKeyName(12, "businessapplication_binarytree_tree_negocio_2316.png");
            this.ımageList1.Images.SetKeyName(13, "Variation-80_icon-icons.com_57243.png");
            this.ımageList1.Images.SetKeyName(14, "logo_orange_ccleaner_clean_icon_134365.png");
            this.ımageList1.Images.SetKeyName(15, "1486503744-backspace-clean-clear-delete-remove-erase_81258.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1027, 334);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Hareket İd";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ad Soyad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "izintur";
            this.dataGridViewTextBoxColumn2.HeaderText = "İzin Türü";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "izinbas";
            this.dataGridViewTextBoxColumn3.HeaderText = "İzin Başlangıç";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "izinbit";
            this.dataGridViewTextBoxColumn4.HeaderText = "İzin Bitiş";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "açıklama";
            this.dataGridViewTextBoxColumn5.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "izin";
            this.bindingSource1.DataSource = this.izinler;
            // 
            // izinler
            // 
            this.izinler.DataSetName = "izinler";
            this.izinler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hareket İd:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(91, 397);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(140, 21);
            this.txtid.TabIndex = 26;
            // 
            // comboPersonelAdsoyad
            // 
            this.comboPersonelAdsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPersonelAdsoyad.FormattingEnabled = true;
            this.comboPersonelAdsoyad.Location = new System.Drawing.Point(91, 360);
            this.comboPersonelAdsoyad.Name = "comboPersonelAdsoyad";
            this.comboPersonelAdsoyad.Size = new System.Drawing.Size(140, 23);
            this.comboPersonelAdsoyad.TabIndex = 37;
            // 
            // btnEkle
            // 
            this.btnEkle.Animated = true;
            this.btnEkle.AutoRoundedCorners = true;
            this.btnEkle.BorderRadius = 21;
            this.btnEkle.CustomImages.Image = global::İnsan_Kaynakları_Otomasyonu_Sistemi.Properties.Resources.add__1_;
            this.btnEkle.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEkle.FillColor = System.Drawing.Color.DarkGray;
            this.btnEkle.FillColor2 = System.Drawing.Color.Silver;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(393, 476);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 45);
            this.btnEkle.TabIndex = 41;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Animated = true;
            this.btnSil.AutoRoundedCorners = true;
            this.btnSil.BorderRadius = 21;
            this.btnSil.CustomImages.Image = global::İnsan_Kaynakları_Otomasyonu_Sistemi.Properties.Resources.remove;
            this.btnSil.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSil.FillColor = System.Drawing.Color.DarkGray;
            this.btnSil.FillColor2 = System.Drawing.Color.Silver;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(623, 477);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 45);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Animated = true;
            this.btnGuncelle.AutoRoundedCorners = true;
            this.btnGuncelle.BorderRadius = 21;
            this.btnGuncelle.CustomImages.Image = global::İnsan_Kaynakları_Otomasyonu_Sistemi.Properties.Resources.refresh__1_;
            this.btnGuncelle.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGuncelle.FillColor = System.Drawing.Color.DarkGray;
            this.btnGuncelle.FillColor2 = System.Drawing.Color.Silver;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(509, 475);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 45);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.btnCikis.Location = new System.Drawing.Point(739, 476);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(110, 45);
            this.btnCikis.TabIndex = 38;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnizinTurleri
            // 
            this.btnizinTurleri.Animated = true;
            this.btnizinTurleri.AutoRoundedCorners = true;
            this.btnizinTurleri.BorderRadius = 21;
            this.btnizinTurleri.CustomImages.Image = global::İnsan_Kaynakları_Otomasyonu_Sistemi.Properties.Resources.holidays__2_2;
            this.btnizinTurleri.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnizinTurleri.FillColor = System.Drawing.Color.DarkGray;
            this.btnizinTurleri.FillColor2 = System.Drawing.Color.Silver;
            this.btnizinTurleri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnizinTurleri.ForeColor = System.Drawing.Color.White;
            this.btnizinTurleri.Location = new System.Drawing.Point(259, 475);
            this.btnizinTurleri.Name = "btnizinTurleri";
            this.btnizinTurleri.Size = new System.Drawing.Size(128, 45);
            this.btnizinTurleri.TabIndex = 42;
            this.btnizinTurleri.Text = "İzin Turleri";
            this.btnizinTurleri.Click += new System.EventHandler(this.btnizinTurleri_Click);
            // 
            // izinTableAdapter
            // 
            this.izinTableAdapter.ClearBeforeFill = true;
            // 
            // Personelizin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1027, 585);
            this.Controls.Add(this.btnizinTurleri);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.comboPersonelAdsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.comboizinTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Personelizin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personelizin";
            this.Load += new System.EventHandler(this.Personelizin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource izinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinbasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinbitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn açıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox comboPersonelAdsoyad;
        private Guna.UI2.WinForms.Guna2GradientButton btnEkle;
        private Guna.UI2.WinForms.Guna2GradientButton btnSil;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuncelle;
        private Guna.UI2.WinForms.Guna2GradientButton btnCikis;
        private Guna.UI2.WinForms.Guna2GradientButton btnizinTurleri;
        private izinler izinler;
        private System.Windows.Forms.BindingSource bindingSource1;
        private izinlerTableAdapters.izinTableAdapter izinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.ComboBox comboizinTuru;
    }
}