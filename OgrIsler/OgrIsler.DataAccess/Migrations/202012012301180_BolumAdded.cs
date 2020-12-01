namespace OgrIsler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BolumAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OgrBolum",
                c => new
                    {
                        Bkodu = c.String(nullable: false, maxLength: 3),
                        Badi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Bkodu);
            
            AddColumn("dbo.OgrProgram", "Bkodu", c => c.String(nullable: false, maxLength: 3));
            CreateIndex("dbo.OgrProgram", "Bkodu");
            AddForeignKey("dbo.OgrProgram", "Bkodu", "dbo.OgrBolum", "Bkodu", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrProgram", "Bkodu", "dbo.OgrBolum");
            DropIndex("dbo.OgrProgram", new[] { "Bkodu" });
            DropColumn("dbo.OgrProgram", "Bkodu");
            DropTable("dbo.OgrBolum");
        }
    }
}
