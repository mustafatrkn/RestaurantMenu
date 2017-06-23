namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Duyurular",
                c => new
                    {
                        DuyuruID = c.Int(nullable: false, identity: true),
                        DuyuruBaslik = c.String(),
                        Duyuruİcerik = c.String(),
                        DuyuruResim = c.String(),
                    })
                .PrimaryKey(t => t.DuyuruID);
            
            CreateTable(
                "dbo.Istatistik",
                c => new
                    {
                        İstatistikID = c.Int(nullable: false, identity: true),
                        GunlukHasilat = c.Int(nullable: false),
                        AylikHasilat = c.Int(nullable: false),
                        YillikHasilat = c.Int(nullable: false),
                        GenelHasilat = c.Int(nullable: false),
                        EnCokTercihEdilenSogukİcecek = c.String(),
                        EnCokTercihEdilenSicakİcecek = c.String(),
                        EnCokTercihEdilenTatli = c.String(),
                        EnCokTercihEdilenYiyecek = c.String(),
                        EnCokTercihEdilenMenu = c.String(),
                        lokanta_LokantalarID = c.Int(),
                    })
                .PrimaryKey(t => t.İstatistikID)
                .ForeignKey("dbo.Lokantalar", t => t.lokanta_LokantalarID)
                .Index(t => t.lokanta_LokantalarID);
            
            CreateTable(
                "dbo.Lokantalar",
                c => new
                    {
                        LokantalarID = c.Int(nullable: false, identity: true),
                        LokantaAdi = c.String(),
                        LokantaAdresi = c.String(),
                        Tanitim = c.String(),
                        MasaSayiyi = c.Int(nullable: false),
                        Kullanici_KullaniciID = c.Int(),
                    })
                .PrimaryKey(t => t.LokantalarID)
                .ForeignKey("dbo.Kullanici", t => t.Kullanici_KullaniciID)
                .Index(t => t.Kullanici_KullaniciID);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        KullaniciIsim = c.String(),
                        KullaniciSoyAdi = c.String(),
                        KullaniciTelNo = c.String(),
                        KullaniciMail = c.String(),
                        KullaniciSifre = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Masa",
                c => new
                    {
                        MasaID = c.Int(nullable: false, identity: true),
                        MasaAdi = c.String(),
                        ToplamFiyat = c.Double(nullable: false),
                        lokanta_LokantalarID = c.Int(),
                    })
                .PrimaryKey(t => t.MasaID)
                .ForeignKey("dbo.Lokantalar", t => t.lokanta_LokantalarID)
                .Index(t => t.lokanta_LokantalarID);
            
            CreateTable(
                "dbo.Menuler",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        MenuAdi = c.String(),
                        MenuIcerik = c.String(),
                        MenuFiyat = c.Double(nullable: false),
                        lokanta_LokantalarID = c.Int(),
                        masa_MasaID = c.Int(),
                    })
                .PrimaryKey(t => t.MenuID)
                .ForeignKey("dbo.Lokantalar", t => t.lokanta_LokantalarID)
                .ForeignKey("dbo.Masa", t => t.masa_MasaID)
                .Index(t => t.lokanta_LokantalarID)
                .Index(t => t.masa_MasaID);
            
            CreateTable(
                "dbo.SicakIcecekler",
                c => new
                    {
                        SicakIcecekID = c.Int(nullable: false, identity: true),
                        SicakIcecek = c.String(),
                        SicakIcecekFiyat = c.Double(nullable: false),
                        lokanta_LokantalarID = c.Int(),
                        masa_MasaID = c.Int(),
                    })
                .PrimaryKey(t => t.SicakIcecekID)
                .ForeignKey("dbo.Lokantalar", t => t.lokanta_LokantalarID)
                .ForeignKey("dbo.Masa", t => t.masa_MasaID)
                .Index(t => t.lokanta_LokantalarID)
                .Index(t => t.masa_MasaID);
            
            CreateTable(
                "dbo.SogukIcecek",
                c => new
                    {
                        SogukIcecekID = c.Int(nullable: false, identity: true),
                        SogukIcecekAdi = c.String(),
                        SogukIcecekFiyat = c.Double(nullable: false),
                        lokanta_LokantalarID = c.Int(),
                        masa_MasaID = c.Int(),
                    })
                .PrimaryKey(t => t.SogukIcecekID)
                .ForeignKey("dbo.Lokantalar", t => t.lokanta_LokantalarID)
                .ForeignKey("dbo.Masa", t => t.masa_MasaID)
                .Index(t => t.lokanta_LokantalarID)
                .Index(t => t.masa_MasaID);
            
            CreateTable(
                "dbo.Tatlilar",
                c => new
                    {
                        TatliID = c.Int(nullable: false, identity: true),
                        TatliAdi = c.String(),
                        TatliFiyat = c.Double(nullable: false),
                        lokanta_LokantalarID = c.Int(),
                        masa_MasaID = c.Int(),
                    })
                .PrimaryKey(t => t.TatliID)
                .ForeignKey("dbo.Lokantalar", t => t.lokanta_LokantalarID)
                .ForeignKey("dbo.Masa", t => t.masa_MasaID)
                .Index(t => t.lokanta_LokantalarID)
                .Index(t => t.masa_MasaID);
            
            CreateTable(
                "dbo.Yiyecekler",
                c => new
                    {
                        YiyecekID = c.Int(nullable: false, identity: true),
                        YiyecekAdi = c.Int(nullable: false),
                        YiyecekFiyat = c.Double(nullable: false),
                        lokanta_LokantalarID = c.Int(),
                        masa_MasaID = c.Int(),
                    })
                .PrimaryKey(t => t.YiyecekID)
                .ForeignKey("dbo.Lokantalar", t => t.lokanta_LokantalarID)
                .ForeignKey("dbo.Masa", t => t.masa_MasaID)
                .Index(t => t.lokanta_LokantalarID)
                .Index(t => t.masa_MasaID);
            
            CreateTable(
                "dbo.Referanslar",
                c => new
                    {
                        ReferansID = c.Int(nullable: false, identity: true),
                        ResferansAdi = c.String(),
                        ReferansTanitimi = c.String(),
                        ReferansResim = c.String(),
                    })
                .PrimaryKey(t => t.ReferansID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Istatistik", "lokanta_LokantalarID", "dbo.Lokantalar");
            DropForeignKey("dbo.Yiyecekler", "masa_MasaID", "dbo.Masa");
            DropForeignKey("dbo.Yiyecekler", "lokanta_LokantalarID", "dbo.Lokantalar");
            DropForeignKey("dbo.Tatlilar", "masa_MasaID", "dbo.Masa");
            DropForeignKey("dbo.Tatlilar", "lokanta_LokantalarID", "dbo.Lokantalar");
            DropForeignKey("dbo.SogukIcecek", "masa_MasaID", "dbo.Masa");
            DropForeignKey("dbo.SogukIcecek", "lokanta_LokantalarID", "dbo.Lokantalar");
            DropForeignKey("dbo.SicakIcecekler", "masa_MasaID", "dbo.Masa");
            DropForeignKey("dbo.SicakIcecekler", "lokanta_LokantalarID", "dbo.Lokantalar");
            DropForeignKey("dbo.Menuler", "masa_MasaID", "dbo.Masa");
            DropForeignKey("dbo.Menuler", "lokanta_LokantalarID", "dbo.Lokantalar");
            DropForeignKey("dbo.Masa", "lokanta_LokantalarID", "dbo.Lokantalar");
            DropForeignKey("dbo.Lokantalar", "Kullanici_KullaniciID", "dbo.Kullanici");
            DropIndex("dbo.Yiyecekler", new[] { "masa_MasaID" });
            DropIndex("dbo.Yiyecekler", new[] { "lokanta_LokantalarID" });
            DropIndex("dbo.Tatlilar", new[] { "masa_MasaID" });
            DropIndex("dbo.Tatlilar", new[] { "lokanta_LokantalarID" });
            DropIndex("dbo.SogukIcecek", new[] { "masa_MasaID" });
            DropIndex("dbo.SogukIcecek", new[] { "lokanta_LokantalarID" });
            DropIndex("dbo.SicakIcecekler", new[] { "masa_MasaID" });
            DropIndex("dbo.SicakIcecekler", new[] { "lokanta_LokantalarID" });
            DropIndex("dbo.Menuler", new[] { "masa_MasaID" });
            DropIndex("dbo.Menuler", new[] { "lokanta_LokantalarID" });
            DropIndex("dbo.Masa", new[] { "lokanta_LokantalarID" });
            DropIndex("dbo.Lokantalar", new[] { "Kullanici_KullaniciID" });
            DropIndex("dbo.Istatistik", new[] { "lokanta_LokantalarID" });
            DropTable("dbo.Referanslar");
            DropTable("dbo.Yiyecekler");
            DropTable("dbo.Tatlilar");
            DropTable("dbo.SogukIcecek");
            DropTable("dbo.SicakIcecekler");
            DropTable("dbo.Menuler");
            DropTable("dbo.Masa");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Lokantalar");
            DropTable("dbo.Istatistik");
            DropTable("dbo.Duyurular");
        }
    }
}
