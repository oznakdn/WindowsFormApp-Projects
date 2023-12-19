namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kurulum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Birims",
                c => new
                    {
                        BirimID = c.Int(nullable: false, identity: true),
                        BirimAdi = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.BirimID);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                        Email = c.String(),
                        Tarih = c.DateTime(),
                        AktifMi = c.Boolean(),
                        BirimId = c.Int(),
                    })
                .PrimaryKey(t => t.PersonelID)
                .ForeignKey("dbo.Birims", t => t.BirimId)
                .Index(t => t.BirimId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "BirimId", "dbo.Birims");
            DropIndex("dbo.Personels", new[] { "BirimId" });
            DropTable("dbo.Personels");
            DropTable("dbo.Birims");
        }
    }
}
