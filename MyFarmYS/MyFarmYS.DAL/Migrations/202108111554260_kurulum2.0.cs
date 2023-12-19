namespace MyFarmYS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum20 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asilama",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AsiAdi = c.String(),
                        YapilisAmaci = c.String(),
                        UygulamaSekli = c.String(),
                        UygulamaTarih = c.DateTime(),
                        UygulananDoz = c.Short(nullable: false),
                        PersonelID = c.Int(),
                        HayvanID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hayvan", t => t.HayvanID)
                .Index(t => t.HayvanID);
            
            CreateTable(
                "dbo.Hayvan",
                c => new
                    {
                        HayvanID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        KupeNo = c.String(),
                        Fotograf = c.String(),
                        Grup = c.String(),
                        Cinsiyet = c.String(),
                        DogumTarih = c.DateTime(),
                        Yas = c.Double(nullable: false),
                        DogumAgirlik = c.Short(nullable: false),
                        DogumTipi = c.String(),
                        DogumSekli = c.String(),
                        CanliAgirlik = c.Short(nullable: false),
                        LaktSayisi = c.Short(nullable: false),
                        OrtLakSuresi = c.Short(nullable: false),
                        OrtGunSutVerimi = c.Short(nullable: false),
                        OrtLaktSutVerimi = c.Short(nullable: false),
                        VerimGrup = c.String(),
                        DamizliktaKullTarih = c.DateTime(),
                        DamizlikYasi = c.Short(nullable: false),
                        DamizlikAgirlik = c.Short(nullable: false),
                        TopYavruSayisi = c.Short(nullable: false),
                        UremePerformansi = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.HayvanID);
            
            CreateTable(
                "dbo.Dogum",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KacinciDogum = c.Short(nullable: false),
                        KuruyaAlmaTarih = c.DateTime(),
                        KurudaKalmaSuresi = c.Short(nullable: false),
                        DogurmaTarih = c.DateTime(),
                        DogumSekli = c.String(),
                        DogumTipi = c.String(),
                        YavruCinsiyet = c.String(),
                        DogumAgirlik = c.Short(nullable: false),
                        CanliDogumMu = c.Boolean(nullable: false),
                        HayvanID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hayvan", t => t.HayvanID)
                .Index(t => t.HayvanID);
            
            CreateTable(
                "dbo.Laktasyon",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Durum = c.Boolean(nullable: false),
                        LaktSira = c.Short(nullable: false),
                        LaktBasTarih = c.DateTime(),
                        LaktBitTarih = c.DateTime(),
                        LaktSuresi = c.Short(nullable: false),
                        GunOrtSutVer = c.Short(nullable: false),
                        LakSutVer = c.Short(nullable: false),
                        SutYagOran = c.Double(nullable: false),
                        HayvanID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hayvan", t => t.HayvanID)
                .Index(t => t.HayvanID);
            
            CreateTable(
                "dbo.Saglik",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(),
                        HastalikAdi = c.String(),
                        Belirtiler = c.String(),
                        UygulananTedavi = c.String(),
                        KullanilanIlaclar = c.String(),
                        Durum = c.String(),
                        PersonelID = c.Int(),
                        HayvanID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hayvan", t => t.HayvanID)
                .Index(t => t.HayvanID);
            
            CreateTable(
                "dbo.Ureme",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SonDogurmaTarih = c.DateTime(),
                        SonKizginlikTarih = c.DateTime(),
                        SonTohumlanmaTarih = c.DateTime(),
                        BogaID = c.Int(),
                        PersonelID = c.Int(),
                        TohumlamaSayi = c.Short(nullable: false),
                        GebelikKontrolYapildiMi = c.Boolean(nullable: false),
                        GebelikKontrolSonuc = c.Boolean(nullable: false),
                        TahminDogurmaTarih = c.DateTime(),
                        ServisPeriyod = c.Short(nullable: false),
                        HayvanID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Hayvan", t => t.HayvanID)
                .Index(t => t.HayvanID);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        KayitTarihi = c.DateTime(),
                        Gorevi = c.String(),
                        Yetkisi = c.String(),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Cinsiyet = c.String(),
                        DogumTarih = c.DateTime(),
                        MedeniDurum = c.Boolean(nullable: false),
                        Fotograf = c.String(),
                        Gorev = c.String(),
                        BaslamaTarih = c.DateTime(),
                        KıdemYili = c.Double(nullable: false),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PersonelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ureme", "HayvanID", "dbo.Hayvan");
            DropForeignKey("dbo.Saglik", "HayvanID", "dbo.Hayvan");
            DropForeignKey("dbo.Laktasyon", "HayvanID", "dbo.Hayvan");
            DropForeignKey("dbo.Dogum", "HayvanID", "dbo.Hayvan");
            DropForeignKey("dbo.Asilama", "HayvanID", "dbo.Hayvan");
            DropIndex("dbo.Ureme", new[] { "HayvanID" });
            DropIndex("dbo.Saglik", new[] { "HayvanID" });
            DropIndex("dbo.Laktasyon", new[] { "HayvanID" });
            DropIndex("dbo.Dogum", new[] { "HayvanID" });
            DropIndex("dbo.Asilama", new[] { "HayvanID" });
            DropTable("dbo.Personel");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Ureme");
            DropTable("dbo.Saglik");
            DropTable("dbo.Laktasyon");
            DropTable("dbo.Dogum");
            DropTable("dbo.Hayvan");
            DropTable("dbo.Asilama");
        }
    }
}
