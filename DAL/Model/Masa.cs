using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Masa
    {
        public int MasaID {get;set;}
        public string  MasaAdi{get;set;}
        public double ToplamFiyat{get;set;}
        public virtual List<SogukIcecek> SogukIcecekler { get; set; }
        public virtual List<SicakIcecekler> SicakİcecekLer { get; set; }
        public virtual List<Tatlilar> Tatlilar { get; set; }
        public virtual List<Yiyecekler> Yiyecekler { get; set; }
        public virtual List<Menuler> Menuler {get;set;}

        public virtual Lokantalar lokanta { get; set; }


    }
}