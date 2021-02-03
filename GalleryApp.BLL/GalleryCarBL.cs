using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessL;
using GalleryApp.Models;

namespace GalleryApp.BLL
{
    public class GalleryCarBL
    {
        public bool CarAdd(Car cr)
        {
            try
            {
                if (cr == null)
                {
                    throw new NullReferenceException("Araç bilgisi boş geldi.");
                }

                SqlParameter[] p = {
                    new SqlParameter("@CarId", cr.AracId),
                    new SqlParameter("@AracMarka", cr.AracMarka),
                    new SqlParameter("@AracModel", cr.AracModel),
                    new SqlParameter("@AracCekis", cr.AracCekis),
                    new SqlParameter("@UretimYili", cr.UretimYili),
                    new SqlParameter("@Fiyati", cr.Fiyati) };
               Yardim hlp = new Yardim();

                return hlp.ExecuteNonQuery("Insert into tblCars values (@AracMarka,@AracModel,@AracCekis,@UretimYili,@Fiyati)", p) > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

