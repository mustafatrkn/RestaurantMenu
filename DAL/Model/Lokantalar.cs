using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Lokantalar
    {   
        [Key]
        public int LokantalarID { get; set; }
        public string LokantaAdi { get; set; }
        public string LokantaAdresi { get; set; }
        public string Tanitim {get;set;}
        public int MasaSayiyi { get; set; }


        //Bağlantılar
        //Bir lokantanın birden çok menüsü olacak
        public virtual ICollection<SogukIcecek> SogukIcecekler {get;set;}
        public virtual ICollection<SicakIcecekler> SicakİcecekLer { get; set; }
        public virtual ICollection<Tatlilar>Tatlilar{get;set;}
        public virtual ICollection<Yiyecekler>Yiyecekler{ get; set;}
        public virtual ICollection<Menuler> Menuler {get;set;}
        public virtual Kullanici Kullanici { get; set;}
        public virtual List<Masa> Masalar { get;set;}
       
    }
}