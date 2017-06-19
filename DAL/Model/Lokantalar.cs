using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Lokantalar
    {
        public int LokantaID { get; set; }
        public string LokantaAdi { get; set; }
        public string LokantaAdresi { get; set; }
        public string Tanitim {get;set;}
        public int MasaSayiyi { get; set; }


        //Bağlantılar
        //Bir lokantanın birden çok menüsü olacak
        public virtual List<SogukIcecek> SogukIcecekler {get;set;}
        public virtual List<SicakIcecekler> SicakİcecekLer { get; set; }
        public virtual List<Tatlilar>Tatlilar{get;set;}
        public virtual List<Yiyecekler>Yiyecekler{ get; set;}
        public virtual List<Menuler> Menuler {get;set;}
        public virtual Kullanici Kullanici { get; set;}
        public virtual List<Masa> Masalar { get;set;}
        public virtual İstatistik istatistik { get; set; }


    }
}