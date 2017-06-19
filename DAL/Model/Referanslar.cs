using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Referanslar
    {
        [Key]
        public int ReferansID { get; set; }
        public string ResferansAdi { get; set; }
        public string ReferansTanitimi { get; set; }
        public string ReferansResim {get;set;}
    }
}