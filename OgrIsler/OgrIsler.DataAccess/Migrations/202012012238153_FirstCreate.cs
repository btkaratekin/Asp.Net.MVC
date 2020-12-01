namespace OgrIsler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCreate : DbMigration
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
                        Pkodu = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.OgrNo)
                .ForeignKey("dbo.OgrProgram", t => t.Pkodu, cascadeDelete: true)
                .ForeignKey("dbo.OgrBilgi", t => t.OgrNo)
                .Index(t => t.OgrNo)
                .Index(t => t.Pkodu);
            
            CreateTable(
                "dbo.OgrProgram",
                c => new
                    {
                        Pkodu = c.String(nullable: false, maxLength: 3),
                        Padi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Pkodu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrOkul", "OgrNo", "dbo.OgrBilgi");
            DropForeignKey("dbo.OgrOkul", "Pkodu", "dbo.OgrProgram");
            DropIndex("dbo.OgrOkul", new[] { "Pkodu" });
            DropIndex("dbo.OgrOkul", new[] { "OgrNo" });
            DropTable("dbo.OgrProgram");
            DropTable("dbo.OgrOkul");
            DropTable("dbo.OgrBilgi");
        }
    }
}
