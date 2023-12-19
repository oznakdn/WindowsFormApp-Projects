namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aracs",
                c => new
                    {
                        AracID = c.Int(nullable: false, identity: true),
                        MarkaId = c.Int(),
                        SeriId = c.Int(),
                        ModelAd = c.String(),
                        Yil = c.String(),
                        Renk = c.String(),
                        Yakit = c.String(),
                        LpgDurum = c.Boolean(),
                        Vites = c.String(),
                        KasaTipi = c.String(),
                        Fotograf = c.String(),
                        Kilometre = c.Double(),
                        MotorGucu = c.Double(),
                        MotorHacmi = c.Double(),
                        Cekis = c.String(),
                        GarantiDurumu = c.Boolean(nullable: false),
                        GelisTarih = c.DateTime(),
                        Durum = c.Boolean(nullable: false),
                        Aciklama = c.String(),
                        AlisFiyati = c.Double(),
                        SatisFiyati = c.Double(),
                    })
                .PrimaryKey(t => t.AracID);
            
            CreateTable(
                "dbo.Gelir_Gider",
                c => new
                    {
                        KayitID = c.Int(nullable: false, identity: true),
                        Baslangi = c.DateTime(),
                        Bitis = c.DateTime(),
                        PersonelGiderleri = c.Double(),
                        AracAlimBedelleri = c.Double(),
                        BankaOdemeleri = c.Double(),
                        Elektrik = c.Double(),
                        Su = c.Double(),
                        Dogalgaz = c.Double(),
                        Telefon = c.Double(),
                        Internet = c.Double(),
                        ToplamGider = c.Double(),
                        AracSatisGelirleri = c.Double(),
                        DigerGelirler = c.Double(),
                        Kar_Zarar = c.Double(),
                        Kar_ZararDurum = c.Boolean(),
                    })
                .PrimaryKey(t => t.KayitID);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Yetki = c.String(),
                        KayitTarih = c.DateTime(nullable: false),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Markas",
                c => new
                    {
                        MarkaID = c.Int(nullable: false, identity: true),
                        MarkaAd = c.String(),
                        MarkaLogo = c.String(),
                    })
                .PrimaryKey(t => t.MarkaID);
            
            CreateTable(
                "dbo.Seris",
                c => new
                    {
                        SeriID = c.Int(nullable: false, identity: true),
                        SeriAd = c.String(),
                        MarkaId = c.Int(),
                    })
                .PrimaryKey(t => t.SeriID)
                .ForeignKey("dbo.Markas", t => t.MarkaId)
                .Index(t => t.MarkaId);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAdSoyad = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        SatisID = c.Int(nullable: false, identity: true),
                        AracId = c.Int(),
                        MusteriId = c.Int(),
                        MusteriAdSoyad = c.String(),
                        SatisTarih = c.DateTime(),
                        Kapora = c.Boolean(),
                        KaporaTarih = c.DateTime(),
                        KaporaTutar = c.Double(nullable: false),
                        SatisTutar = c.Double(nullable: false),
                        KalanTutar = c.Double(nullable: false),
                        OdemeTipi = c.String(),
                        PersonelId = c.Int(),
                    })
                .PrimaryKey(t => t.SatisID);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Gorev = c.String(),
                        Fotograf = c.String(),
                        Cinsiyet = c.String(),
                        MedeniDurum = c.Boolean(),
                        GirisTarih = c.DateTime(),
                        CalismaYili = c.Short(nullable: false),
                        Maas = c.Double(),
                        DigerOdemeler = c.Double(),
                        ToplamOdeme = c.Double(),
                    })
                .PrimaryKey(t => t.PersonelID);
            
            CreateTable(
                "dbo.SatisMusteris",
                c => new
                    {
                        Satis_SatisID = c.Int(nullable: false),
                        Musteri_MusteriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Satis_SatisID, t.Musteri_MusteriID })
                .ForeignKey("dbo.Satis", t => t.Satis_SatisID, cascadeDelete: true)
                .ForeignKey("dbo.Musteris", t => t.Musteri_MusteriID, cascadeDelete: true)
                .Index(t => t.Satis_SatisID)
                .Index(t => t.Musteri_MusteriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SatisMusteris", "Musteri_MusteriID", "dbo.Musteris");
            DropForeignKey("dbo.SatisMusteris", "Satis_SatisID", "dbo.Satis");
            DropForeignKey("dbo.Seris", "MarkaId", "dbo.Markas");
            DropIndex("dbo.SatisMusteris", new[] { "Musteri_MusteriID" });
            DropIndex("dbo.SatisMusteris", new[] { "Satis_SatisID" });
            DropIndex("dbo.Seris", new[] { "MarkaId" });
            DropTable("dbo.SatisMusteris");
            DropTable("dbo.Personels");
            DropTable("dbo.Satis");
            DropTable("dbo.Musteris");
            DropTable("dbo.Seris");
            DropTable("dbo.Markas");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Gelir_Gider");
            DropTable("dbo.Aracs");
        }
    }
}
