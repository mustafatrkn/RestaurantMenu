using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class Tatlilar
    {
        [Key]
        public int TatliID { get; set; }
        public string TatliAdi { get; set; }
        public double TatliFiyat { get; set; }
        public virtual Masa masa { get; set; }
        public virtual Lokantalar lokanta { get; set; }
    }
}