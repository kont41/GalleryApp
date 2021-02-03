
namespace GalleryApp
{
    partial class AracKontrolE
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
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtUretimYili = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCekis = new System.Windows.Forms.TextBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCekis = new System.Windows.Forms.Label();
            this.lblUretimYili = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnAracGuncelle = new System.Windows.Forms.Button();
            this.btnAracAra = new System.Windows.Forms.Button();
            this.txtAracId = new System.Windows.Forms.TextBox();
            this.lblAracAra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(124, 251);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 0;
            // 
            // txtUretimYili
            // 
            this.txtUretimYili.Location = new System.Drawing.Point(124, 214);
            this.txtUretimYili.Name = "txtUretimYili";
            this.txtUretimYili.Size = new System.Drawing.Size(100, 22);
            this.txtUretimYili.TabIndex = 1;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(124, 96);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 2;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(124, 139);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 3;
            // 
            // txtCekis
            // 
            this.txtCekis.Location = new System.Drawing.Point(124, 178);
            this.txtCekis.Name = "txtCekis";
            this.txtCekis.Size = new System.Drawing.Size(100, 22);
            this.txtCekis.TabIndex = 4;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(50, 96);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 5;
            this.lblMarka.Text = "Marka";
            this.lblMarka.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(50, 139);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // lblCekis
            // 
            this.lblCekis.AutoSize = true;
            this.lblCekis.Location = new System.Drawing.Point(50, 178);
            this.lblCekis.Name = "lblCekis";
            this.lblCekis.Size = new System.Drawing.Size(42, 17);
            this.lblCekis.TabIndex = 7;
            this.lblCekis.Text = "Çekiş";
            // 
            // lblUretimYili
            // 
            this.lblUretimYili.AutoSize = true;
            this.lblUretimYili.Location = new System.Drawing.Point(50, 214);
            this.lblUretimYili.Name = "lblUretimYili";
            this.lblUretimYili.Size = new System.Drawing.Size(71, 17);
            this.lblUretimYili.TabIndex = 8;
            this.lblUretimYili.Text = "Üretim Yılı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(50, 254);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(38, 17);
            this.lblFiyat.TabIndex = 9;
            this.lblFiyat.Text = "Fiyat";
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(124, 295);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(100, 47);
            this.btnAracEkle.TabIndex = 11;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(621, 214);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(97, 57);
            this.btnAracSil.TabIndex = 12;
            this.btnAracSil.Text = "Araç Sil";
            this.btnAracSil.UseVisualStyleBackColor = true;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.Location = new System.Drawing.Point(621, 295);
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(97, 55);
            this.btnAracGuncelle.TabIndex = 13;
            this.btnAracGuncelle.Text = "Araç Güncelle";
            this.btnAracGuncelle.UseVisualStyleBackColor = true;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // btnAracAra
            // 
            this.btnAracAra.Location = new System.Drawing.Point(621, 137);
            this.btnAracAra.Name = "btnAracAra";
            this.btnAracAra.Size = new System.Drawing.Size(97, 55);
            this.btnAracAra.TabIndex = 14;
            this.btnAracAra.Text = "Araç Ara";
            this.btnAracAra.UseVisualStyleBackColor = true;
            this.btnAracAra.Click += new System.EventHandler(this.btnAracAra_Click);
            // 
            // txtAracId
            // 
            this.txtAracId.Enabled = false;
            this.txtAracId.Location = new System.Drawing.Point(621, 103);
            this.txtAracId.Name = "txtAracId";
            this.txtAracId.Size = new System.Drawing.Size(97, 22);
            this.txtAracId.TabIndex = 15;
            // 
            // lblAracAra
            // 
            this.lblAracAra.AutoSize = true;
            this.lblAracAra.Location = new System.Drawing.Point(561, 103);
            this.lblAracAra.Name = "lblAracAra";
            this.lblAracAra.Size = new System.Drawing.Size(54, 17);
            this.lblAracAra.TabIndex = 16;
            this.lblAracAra.Text = "Araç ID";
            // 
            // AracKontrolE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAracAra);
            this.Controls.Add(this.txtAracId);
            this.Controls.Add(this.btnAracAra);
            this.Controls.Add(this.btnAracGuncelle);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblUretimYili);
            this.Controls.Add(this.lblCekis);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.txtCekis);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtUretimYili);
            this.Controls.Add(this.txtFiyat);
            this.Name = "AracKontrolE";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtFiyat;
        public System.Windows.Forms.TextBox txtUretimYili;
        public System.Windows.Forms.TextBox txtMarka;
        public System.Windows.Forms.TextBox txtModel;
        public System.Windows.Forms.TextBox txtCekis;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCekis;
        private System.Windows.Forms.Label lblUretimYili;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnAracGuncelle;
        private System.Windows.Forms.Button btnAracAra;
        public System.Windows.Forms.TextBox txtAracId;
        private System.Windows.Forms.Label lblAracAra;
    }
}

