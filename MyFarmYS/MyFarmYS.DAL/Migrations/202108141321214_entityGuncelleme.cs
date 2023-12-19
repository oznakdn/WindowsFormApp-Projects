namespace MyFarmYS.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entityGuncelleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Asilama", "UygulananDoz", c => c.Short());
            AlterColumn("dbo.Hayvan", "Yas", c => c.Double());
            AlterColumn("dbo.Hayvan", "DogumAgirlik", c => c.Short());
            AlterColumn("dbo.Hayvan", "CanliAgirlik", c => c.Short());
            AlterColumn("dbo.Hayvan", "LaktSayisi", c => c.Short());
            AlterColumn("dbo.Hayvan", "OrtLakSuresi", c => c.Short());
            AlterColumn("dbo.Hayvan", "OrtGunSutVerimi", c => c.Short());
            AlterColumn("dbo.Hayvan", "OrtLaktSutVerimi", c => c.Short());
            AlterColumn("dbo.Hayvan", "DamizlikYasi", c => c.Short());
            AlterColumn("dbo.Hayvan", "DamizlikAgirlik", c => c.Short());
            AlterColumn("dbo.Hayvan", "TopYavruSayisi", c => c.Short());
            AlterColumn("dbo.Hayvan", "UremePerformansi", c => c.Short());
            AlterColumn("dbo.Dogum", "KacinciDogum", c => c.Short());
            AlterColumn("dbo.Dogum", "KurudaKalmaSuresi", c => c.Short());
            AlterColumn("dbo.Dogum", "DogumAgirlik", c => c.Short());
            AlterColumn("dbo.Dogum", "CanliDogumMu", c => c.Boolean());
            AlterColumn("dbo.Laktasyon", "Durum", c => c.Boolean());
            AlterColumn("dbo.Personel", "MedeniDurum", c => c.Boolean());
            AlterColumn("dbo.Personel", "KıdemYili", c => c.Double());
            AlterColumn("dbo.Personel", "Maas", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personel", "Maas", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Personel", "KıdemYili", c => c.Double(nullable: false));
            AlterColumn("dbo.Personel", "MedeniDurum", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Laktasyon", "Durum", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Dogum", "CanliDogumMu", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Dogum", "DogumAgirlik", c => c.Short(nullable: false));
            AlterColumn("dbo.Dogum", "KurudaKalmaSuresi", c => c.Short(nullable: false));
            AlterColumn("dbo.Dogum", "KacinciDogum", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "UremePerformansi", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "TopYavruSayisi", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "DamizlikAgirlik", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "DamizlikYasi", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "OrtLaktSutVerimi", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "OrtGunSutVerimi", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "OrtLakSuresi", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "LaktSayisi", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "CanliAgirlik", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "DogumAgirlik", c => c.Short(nullable: false));
            AlterColumn("dbo.Hayvan", "Yas", c => c.Double(nullable: false));
            AlterColumn("dbo.Asilama", "UygulananDoz", c => c.Short(nullable: false));
        }
    }
}
