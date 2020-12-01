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
                        Dkodu = c.Int(nullable: false),
                        Pkodu = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.OgrNo)
                .ForeignKey("dbo.OgrDanisman", t => t.Dkodu, cascadeDelete: true)
                .ForeignKey("dbo.OgrProgram", t => t.Pkodu, cascadeDelete: true)
                .ForeignKey("dbo.OgrBilgi", t => t.OgrNo)
                .Index(t => t.OgrNo)
                .Index(t => t.Dkodu)
                .Index(t => t.Pkodu);
            
            CreateTable(
                "dbo.OgrDanisman",
                c => new
                    {
                        Dkodu = c.Int(nullable: false, identity: true),
                        Dadi = c.String(nullable: false, maxLength: 15),
                        Dsoyadi = c.String(nullable: false, maxLength: 20),
                        Bkodu = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.Dkodu)
                .ForeignKey("dbo.OgrBolum", t => t.Bkodu, cascadeDelete: true)
                .Index(t => t.Bkodu);
            
            CreateTable(
                "dbo.OgrBolum",
                c => new
                    {
                        Bkodu = c.String(nullable: false, maxLength: 3),
                        Badi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Bkodu);
            
            CreateTable(
                "dbo.OgrProgram",
                c => new
                    {
                        Pkodu = c.String(nullable: false, maxLength: 3),
                        Padi = c.String(nullable: false),
                        Bkodu = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => t.Pkodu)
                .ForeignKey("dbo.OgrBolum", t => t.Bkodu, cascadeDelete: false)
                .Index(t => t.Bkodu);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrOkul", "OgrNo", "dbo.OgrBilgi");
            DropForeignKey("dbo.OgrOkul", "Pkodu", "dbo.OgrProgram");
            DropForeignKey("dbo.OgrOkul", "Dkodu", "dbo.OgrDanisman");
            DropForeignKey("dbo.OgrDanisman", "Bkodu", "dbo.OgrBolum");
            DropForeignKey("dbo.OgrProgram", "Bkodu", "dbo.OgrBolum");
            DropIndex("dbo.OgrProgram", new[] { "Bkodu" });
            DropIndex("dbo.OgrDanisman", new[] { "Bkodu" });
            DropIndex("dbo.OgrOkul", new[] { "Pkodu" });
            DropIndex("dbo.OgrOkul", new[] { "Dkodu" });
            DropIndex("dbo.OgrOkul", new[] { "OgrNo" });
            DropTable("dbo.OgrProgram");
            DropTable("dbo.OgrBolum");
            DropTable("dbo.OgrDanisman");
            DropTable("dbo.OgrOkul");
            DropTable("dbo.OgrBilgi");
        }
    }
}
