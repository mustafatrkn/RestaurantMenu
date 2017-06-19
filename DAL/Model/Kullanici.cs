using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciIsim { set; get; }
        public string KullaniciSoyAdi { set; get; }
        public string KullaniciTelNo { set; get; }
        public string KullaniciMail { set; get; }
        public string KullaniciSifre { set; get;}

    }
}