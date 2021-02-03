using GalleryApp.BLL;
using GalleryApp.Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DataAccessL;
namespace GalleryApp
{
    public partial class AracKontrolE : Form
    {
        public int aracid = 0;
        SqlConnection cn = null;
        
        public AracKontrolE()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAracAra_Click(object sender, EventArgs e)
        {
            AracArama aA = new AracArama();
            aA.ShowDialog();
        }

        private void btnAracSil_Click(object sender, EventArgs e)
        {
            if (aracid == 0)
            {
                MessageBox.Show("Önce aracı seç!");

            }
            else
            {
                DialogResult cvp = MessageBox.Show("Aracı Siliyorsunuz.Emin misiniz?", "Kayıt Silme Onayı", MessageBoxButtons.YesNo);
                if (cvp == DialogResult.Yes)
                {
                    using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from tblCars where AracId=@AracId", cn))
                        {
                            SqlParameter[] p = {
                            new SqlParameter("@AracId", aracid) };

                            cmd.Parameters.AddRange(p); // Dizinin içerisindeki tüm elemanları ekler.
                            if (cn != null && cn.State != ConnectionState.Open)
                            {
                                cn.Open();
                            }
                            int sonuc = cmd.ExecuteNonQuery();
                            MessageBox.Show(sonuc > 0 ? "İşlem başarılı." : "İşlem başarısız!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt silme işlemi iptal edildi.");
                }


            }
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Update tblCars set AracMarka=@AracMarka,AracModel=@AracModel,AracCekis=@AracCekis,UretimYili=@UretimYili,Fiyati=@Fiyati from tblCars where AracId=@aracid", cn))
                {
                    SqlParameter[] p = {
                        new SqlParameter("@AracMarka", txtMarka.Text.Trim()),
                        new SqlParameter("@AracModel", txtModel.Text.Trim()),
                        new SqlParameter("@AracCekis", txtCekis.Text.Trim()),
                        new SqlParameter("@UretimYili", txtUretimYili.Text.Trim()),
                        new SqlParameter("@Fiyati", txtFiyat.Text.Trim()),
                        new SqlParameter("@aracid", aracid)

                        };

                    cmd.Parameters.AddRange(p);

                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    int sonuc = cmd.ExecuteNonQuery();

                    MessageBox.Show(sonuc > 0 ? " Araç Güncelleme İşlemi Başarılı." : "Araç Güncelleme İşlemi Başarısız!");
                }
            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            try
            {
                GalleryCarBL bbl = new GalleryCarBL();
                bool sonuc = bbl.CarAdd(new Car(txtMarka.Text.Trim(), txtModel.Text.Trim(), txtCekis.Text.Trim(), txtUretimYili.Text.Trim(), txtFiyat.Text.Trim()));
                if (sonuc)
                {
                    MessageBox.Show("Araç Ekleme Başarılı!");
                }
                else
                {
                    MessageBox.Show("Araç Ekleme Başarısız.Lütfen Tekrar Deneyiniz.!");
                }
            }
            catch (SqlException x)
            {
                switch (x.Number)
                {
                    case 2627:
                        MessageBox.Show("Böyle bir araç mevcut.");
                        break;
                    case 1225:
                        MessageBox.Show("Veritabanına Bağlanılamadı. ");
                        break;
                    default:
                        break;
                }
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Sistem Hatası!");
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!");
            }
        }
    }
}
