using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class SicakIcecekler
    {
        [Key]
        public int SicakIcecekID {get;set;}
        public string SicakIcecek { get; set; }
        public double SicakIcecekFiyat { get; set; }
        public virtual Masa masa { get; set; }
        public virtual Lokantalar lokanta { get; set; }

    }
}