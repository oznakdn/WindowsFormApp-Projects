namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class guncelleme10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Aracs", "GarantiDurumu", c => c.Boolean());
            AlterColumn("dbo.Aracs", "Durum", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Aracs", "Durum", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Aracs", "GarantiDurumu", c => c.Boolean(nullable: false));
        }
    }
}
