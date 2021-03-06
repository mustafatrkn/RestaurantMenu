﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Model
{
    public class SogukIcecek
    {
        [Key]
        public int SogukIcecekID {get;set;}
        public string SogukIcecekAdi {get;set;}
        public double SogukIcecekFiyat { get; set;}

        public virtual Masa masa { get; set; }
        public virtual Lokantalar lokanta { get; set; }
    }
}