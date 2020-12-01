namespace OgrIsler.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProgramAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OgrProgram",
                c => new
                    {
                        pkodu = c.String(nullable: false, maxLength: 3),
                        padi = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.pkodu);
            
            AddColumn("dbo.OgrOkul", "ogrProgram_pkodu", c => c.String(nullable: false, maxLength: 3));
            CreateIndex("dbo.OgrOkul", "ogrProgram_pkodu");
            AddForeignKey("dbo.OgrOkul", "ogrProgram_pkodu", "dbo.OgrProgram", "pkodu", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrOkul", "ogrProgram_pkodu", "dbo.OgrProgram");
            DropIndex("dbo.OgrOkul", new[] { "ogrProgram_pkodu" });
            DropColumn("dbo.OgrOkul", "ogrProgram_pkodu");
            DropTable("dbo.OgrProgram");
        }
    }
}
