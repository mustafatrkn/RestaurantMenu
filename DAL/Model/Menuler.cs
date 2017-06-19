using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Menuler
    {   [Key]
        public int MenuID { get; set; }
        public string MenuAdi { get; set; }
        public string MenuIcerik { get; set; }
        public double MenuFiyat { get; set; }

        public virtual Masa masa { get; set; }
        public virtual Lokantalar lokanta {get;set;}


    }
}