using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DAL.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL.DbCont
{
    public class LokantaContext:DbContext
    {
        public LokantaContext()
        {
            Database.Connection.ConnectionString = "server=.;database=LokantaUygulama;Trusted_Connection=true";
        }

        public DbSet<Duyurular> Duyurular {get;set;}
        public DbSet<Istatistik> Istatistik {get;set;}
        public DbSet<Kullanici> Kullanici {get;set;}
       public DbSet<Lokantalar> Lokantalar {get;set;}
       public DbSet<Masa> Masa {get;set;}
       public DbSet<Menuler> Menuler { get; set; }
        public DbSet<Referanslar> Referanslar { get; set;}
        public DbSet<SicakIcecekler> SicakIcecekler {get;set;}
        public DbSet<SogukIcecek> SogukIcecekler {get;set;}
        public DbSet<Tatlilar> Tatlilar {get;set;}
        public DbSet<Yiyecekler> Yiyecekler {get;set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}