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
        public string TanitimAdresi {get;set;}
        public int MasaSayiyi { get; set; }
    }
}