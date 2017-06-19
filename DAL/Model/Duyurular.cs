using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Duyurular
    {   [Key]
        public int DuyuruID { get; set; }
        public string DuyuruBaslik { get; set; }
        public string Duyuruİcerik {get;set;}
    }
}