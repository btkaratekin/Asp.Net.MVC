namespace OgrIsler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OgrBilgi",
                c => new
                {
                    OgrNo = c.String(nullable: false, maxLength: 9),
                    Adi = c.String(nullable: false, maxLength: 15),
                    Soyadi = c.String(nullable: false, maxLength: 20),
                    Cinsiyet = c.Boolean(nullable: false),
                    Dtarih = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.OgrNo);
            
            CreateTable(
                "dbo.OgrOkul",
                c => new
                    {
                        OgrNo = c.String(nullable: false, maxLength: 9),
                        Sinif = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.OgrNo)
                .ForeignKey("dbo.OgrBilgi", t => t.OgrNo)
                .Index(t => t.OgrNo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrOkul", "OgrNo", "dbo.OgrBilgi");
            DropIndex("dbo.OgrOkul", new[] { "OgrNo" });
            DropTable("dbo.OgrOkul");
            DropTable("dbo.OgrBilgi");
        }
    }
}
