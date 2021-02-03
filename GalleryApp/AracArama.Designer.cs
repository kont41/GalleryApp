
namespace GalleryApp
{
    partial class AracArama
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
            this.lblAramaEkran = new System.Windows.Forms.Label();
            this.lblYaziEkran = new System.Windows.Forms.Label();
            this.txtAraEkran = new System.Windows.Forms.TextBox();
            this.btnAraEkran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAramaEkran
            // 
            this.lblAramaEkran.AutoSize = true;
            this.lblAramaEkran.Location = new System.Drawing.Point(280, 170);
            this.lblAramaEkran.Name = "lblAramaEkran";
            this.lblAramaEkran.Size = new System.Drawing.Size(54, 17);
            this.lblAramaEkran.TabIndex = 0;
            this.lblAramaEkran.Text = "Araç ID";
            // 
            // lblYaziEkran
            // 
            this.lblYaziEkran.AutoSize = true;
            this.lblYaziEkran.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaziEkran.Location = new System.Drawing.Point(262, 24);
            this.lblYaziEkran.Name = "lblYaziEkran";
            this.lblYaziEkran.Size = new System.Drawing.Size(302, 46);
            this.lblYaziEkran.TabIndex = 1;
            this.lblYaziEkran.Text = "Araç Arama Ekranı";
            // 
            // txtAraEkran
            // 
            this.txtAraEkran.Location = new System.Drawing.Point(360, 170);
            this.txtAraEkran.Name = "txtAraEkran";
            this.txtAraEkran.Size = new System.Drawing.Size(102, 22);
            this.txtAraEkran.TabIndex = 2;
            // 
            // btnAraEkran
            // 
            this.btnAraEkran.Location = new System.Drawing.Point(360, 216);
            this.btnAraEkran.Name = "btnAraEkran";
            this.btnAraEkran.Size = new System.Drawing.Size(102, 32);
            this.btnAraEkran.TabIndex = 3;
            this.btnAraEkran.Text = "Ara";
            this.btnAraEkran.UseVisualStyleBackColor = true;
            this.btnAraEkran.Click += new System.EventHandler(this.btnAraEkran_Click);
            // 
            // AracArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAraEkran);
            this.Controls.Add(this.txtAraEkran);
            this.Controls.Add(this.lblYaziEkran);
            this.Controls.Add(this.lblAramaEkran);
            this.Name = "AracArama";
            this.Text = "AracArama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAramaEkran;
        private System.Windows.Forms.Label lblYaziEkran;
        private System.Windows.Forms.TextBox txtAraEkran;
        private System.Windows.Forms.Button btnAraEkran;
    }
}