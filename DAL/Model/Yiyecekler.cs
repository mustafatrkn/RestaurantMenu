using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Yiyecekler
    {   
        [Key]
        public int YiyecekID { get; set; }
        public int YiyecekAdi {get;set;}
        public double YiyecekFiyat { get; set;}
        public virtual Masa masa { get; set; }
        public virtual Lokantalar lokanta {get;set;}
    }
}