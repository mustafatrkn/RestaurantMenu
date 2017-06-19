using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class İstatistik
    {
        public int İstatistikID { get; set; }
        public int GunlukHasilat { get; set; }
        public int AylikHasilat { get; set; }

        public int YillikHasilat{ get; set;}

        public int GenelHasilat{ get; set;}

        public string EnCokTercihEdilenSogukİcecek { get; set; }
        public string EnCokTercihEdilenSicakİcecek { get; set; }
        public string EnCokTercihEdilenTatli{ get; set; }
        public string EnCokTercihEdilenYiyecek{ get; set; }
        public string EnCokTercihEdilenMenu{ get; set; }

        public virtual Lokantalar lokanta { get; set; }


    }
}