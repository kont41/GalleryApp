using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryApp
{
    public partial class AracArama : Form
    {
        public int aracid = 0;
        SqlConnection cn = null;
        
        public AracArama()
        {
            InitializeComponent();
        }

        private void btnAraEkran_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=.\; Integrated Security=true; Initial Catalog=GalleryDB"))
            {
                using (SqlCommand cmd = new SqlCommand("Select AracId,AracMarka,AracModel,AracCekis,UretimYili,Fiyati from tblCars where AracId=@AracId", cn))
                {
                    SqlParameter[] p = { new SqlParameter("@AracId", txtAraEkran.Text.Trim()) };
                    cmd.Parameters.AddRange(p);
                    if (cn != null && cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        AracKontrolE ake = (AracKontrolE)Application.OpenForms["AracKontrolE"];
                        ake.txtMarka.Text = dr["AracMarka"].ToString();
                        ake.txtModel.Text = dr["AracModel"].ToString();
                        ake.txtCekis.Text = dr["AracCekis"].ToString();
                        ake.txtUretimYili.Text = dr["UretimYili"].ToString();
                        ake.txtFiyat.Text = dr["Fiyati"].ToString();
                        ake.aracid = Convert.ToInt32(dr["AracId"]);
                        ake.txtAracId.Text = dr["AracId"].ToString();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Araç bulunamadı.");
                    }
                    dr.Close();
                }
            }
        }
    }
}
    
