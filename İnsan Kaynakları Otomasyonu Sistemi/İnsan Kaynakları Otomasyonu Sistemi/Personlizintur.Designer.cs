namespace İnsan_Kaynakları_Otomasyonu_Sistemi
{
    partial class Personelizintur
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtizin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.izinTurIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izinturBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izinturleri = new İnsan_Kaynakları_Otomasyonu_Sistemi.izinturleri();
            this.izinİD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.izinturTableAdapter = new İnsan_Kaynakları_Otomasyonu_Sistemi.izinturleriTableAdapters.izinturTableAdapter();
            this.btnEkle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSil = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGuncelle = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCikis = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinturBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinturleri)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(11, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "İzin Adı:";
            // 
            // txtizin
            // 
            this.txtizin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtizin.Location = new System.Drawing.Point(93, 187);
            this.txtizin.Name = "txtizin";
            this.txtizin.Size = new System.Drawing.Size(135, 21);
            this.txtizin.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.izinTurIDDataGridViewTextBoxColumn,
            this.izinTuruDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.izinturBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(275, 150);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // izinTurIDDataGridViewTextBoxColumn
            // 
            this.izinTurIDDataGridViewTextBoxColumn.DataPropertyName = "izinTurID";
            this.izinTurIDDataGridViewTextBoxColumn.HeaderText = "İzin İd";
            this.izinTurIDDataGridViewTextBoxColumn.Name = "izinTurIDDataGridViewTextBoxColumn";
            this.izinTurIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // izinTuruDataGridViewTextBoxColumn
            // 
            this.izinTuruDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.izinTuruDataGridViewTextBoxColumn.DataPropertyName = "izinTuru";
            this.izinTuruDataGridViewTextBoxColumn.HeaderText = "İzin Türü";
            this.izinTuruDataGridViewTextBoxColumn.Name = "izinTuruDataGridViewTextBoxColumn";
            // 
            // izinturBindingSource
            // 
            this.izinturBindingSource.DataMember = "izintur";
            this.izinturBindingSource.DataSource = this.izinturleri;
            // 
            // izinturleri
            // 
            this.izinturleri.DataSetName = "izinturleri";
            this.izinturleri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // izinİD
            // 
            this.izinİD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.izinİD.Location = new System.Drawing.Point(93, 160);
            this.izinİD.Name = "izinİD";
            this.izinİD.ReadOnly = true;
            this.izinİD.Size = new System.Drawing.Size(135, 21);
            this.izinİD.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "İzin ID:";
            // 
            // izinturTableAdapter
            // 
            this.izinturTableAdapter.ClearBeforeFill = true;
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
            this.btnEkle.Location = new System.Drawing.Point(15, 225);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 45);
            this.btnEkle.TabIndex = 30;
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
            this.btnSil.Location = new System.Drawing.Point(15, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 45);
            this.btnSil.TabIndex = 29;
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
            this.btnGuncelle.Location = new System.Drawing.Point(131, 224);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 45);
            this.btnGuncelle.TabIndex = 28;
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
            this.btnCikis.Location = new System.Drawing.Point(131, 275);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(110, 45);
            this.btnCikis.TabIndex = 27;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Personelizintur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(272, 369);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izinİD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtizin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Personelizintur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İzin Türleri";
            this.Load += new System.EventHandler(this.Departmanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinturBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izinturleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtizin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox izinİD;
        private System.Windows.Forms.Label label1;
        private izinturleri izinturleri;
        private System.Windows.Forms.BindingSource izinturBindingSource;
        private izinturleriTableAdapters.izinturTableAdapter izinturTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinTurIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izinTuruDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2GradientButton btnEkle;
        private Guna.UI2.WinForms.Guna2GradientButton btnSil;
        private Guna.UI2.WinForms.Guna2GradientButton btnGuncelle;
        private Guna.UI2.WinForms.Guna2GradientButton btnCikis;
    }
}