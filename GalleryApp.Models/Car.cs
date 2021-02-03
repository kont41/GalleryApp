using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp.Models
{
    public class Car
    {
        public Car()
        {

        }

        public Car(string aracmarka, string aracmodel, string araccekis, string uretimyili, string fiyati)
        {
            AracMarka = aracmarka;
            AracModel = aracmodel;
            AracCekis = araccekis;
            UretimYili = uretimyili;
            Fiyati = fiyati;
        }
        public Car(int aracid, string aracmarka, string aracmodel, string araccekis, string uretimyili, string fiyati)
        {
            AracId = aracid;
            AracMarka = aracmarka;
            AracModel = aracmodel;
            AracCekis = araccekis;
            UretimYili = uretimyili;
            Fiyati = fiyati;
        }


        public int AracId { get; set; }
        public string AracMarka { get; set; }
        public string AracModel { get; set; }
        public string AracCekis { get; set; }
        public string UretimYili { get; set; }
        public string Fiyati { get; set; }



    }
}

